using System;
using System.Web;
using System.Linq;
using Common;
using RuiJi.DataAccess;
using RuiJi.DataAccess.Models;
using RuiJi.DataAccess.User;
using RuiJi.Internal.Common;
using RuiJi.Internal.Context;
using RuiJi.Internal.Web.Security;

namespace RuiJi.Internal.Handler
{
    public class LoginHandler : IHttpAsyncHandler
    {

        // Summary:
        //     Initiates an asynchronous call to the HTTP handler.
        //
        // Parameters:
        //   context:
        //     An System.Web.HttpContext object that provides references to intrinsic server
        //     objects (for example, Request, Response, Session, and Server) used to service
        //     HTTP requests.
        //
        //   cb:
        //     The System.AsyncCallback to call when the asynchronous method call is complete.
        //     If cb is null, the delegate is not called.
        //
        //   extraData:
        //     Any extra data needed to process the request.
        //
        // Returns:
        //     An System.IAsyncResult that contains information about the status of the
        //     process.
        IAsyncResult IHttpAsyncHandler.BeginProcessRequest(HttpContext context, AsyncCallback cb, object extraData)
        {
            LoginAsyncResult result = new LoginAsyncResult(context, extraData, cb);
            return StartProcess(result);
        }
        //
        // Summary:
        //     Provides an asynchronous process End method when the process ends.
        //
        // Parameters:
        //   result:
        //     An System.IAsyncResult that contains information about the status of the
        //     process.
        void IHttpAsyncHandler.EndProcessRequest(IAsyncResult result)
        {
            LoginAsyncResult loginResult = result as LoginAsyncResult;
            EndProcess(loginResult);
        }

        #region IHttpHandler Members

        bool IHttpHandler.IsReusable
        {
            // Return false in case your Managed Handler cannot be reused for another request.
            // Usually this would be false in case you have some state information preserved per request.
            get { return true; }
        }

        void IHttpHandler.ProcessRequest(HttpContext context)
        {
            LoginAsyncResult result = new LoginAsyncResult(context, null, null);
            result = StartProcess(result);
            EndProcess(result);
        }

        #endregion

        private LoginAsyncResult StartProcess(LoginAsyncResult result)
        {
            HttpContext context = result.Context;
            var loginData = LoginDataBuilder.CreateLoginData(context);
            if (string.IsNullOrEmpty(loginData.UserName))
            {
                SetAuthenticateFailed(result, "UserName Missing!");
                return result;
            }
            if (string.IsNullOrEmpty(loginData.Password))
            {
                SetAuthenticateFailed(result, "Password Missing!");
                return result;
            }

            var encryptPW = RuiJiCryptoGraphy.Instance.CreateHash(loginData.Password);
            if (UserSvc.IsVaildUser(loginData.UserName, encryptPW))
            {
                result.IsAuthenticated = true;
                result.LoginData = loginData;
            }
            else
            {
                SetAuthenticateFailed(result, "UserName or Password error!");
            }

            result.SetCompletedSynchronously();
            //if (result.CallBack != null)
            //{
            //    result.CallBack(result);
            //}

            return result;
        }


        private void EndProcess(LoginAsyncResult result)
        {
            var httpContext = result.Context;
            if (result.IsAuthenticated)
            {                
                SystemUser user = UserSvc.LoadByName(result.LoginData.UserName);
                RuiJiContext ruijiContext = new RuiJiContext(user.UserId, user.UserName, user.Roles);

                RuiJiContext.Current = ruijiContext;
                httpContext.Response.Redirect("~/Article", false);
                httpContext.ApplicationInstance.CompleteRequest();
            }
            else
            {
                httpContext.Response.Redirect(string.Format("~/Login?loginErrorMsg={0}", result.ErrorMessage), false);
                httpContext.ApplicationInstance.CompleteRequest();
            }

        }

        private void SetAuthenticateFailed(LoginAsyncResult result, string errorMessage)
        {
            result.IsAuthenticated = false;
            result.ErrorMessage = errorMessage;
            result.SetCompletedSynchronously();                
        }

        private IUserSvc userSvc;
        private IUserSvc UserSvc
        {
            get
            {
                if (userSvc == null)
                {
                    userSvc = RuiJiPortalServiceLocator.Instance.GetSvc<IUserSvc>();
                }

                return userSvc;
            }
        }
    
    }
}
