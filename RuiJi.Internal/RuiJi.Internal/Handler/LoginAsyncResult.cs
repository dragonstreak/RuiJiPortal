using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Web;
using RuiJi.Internal.Web.Security;

namespace RuiJi.Internal.Handler
{
    internal class LoginAsyncResult : IAsyncResult
    {
        
        public LoginAsyncResult(HttpContext context, object asyncState, AsyncCallback callBack)
        {
            Context = context;
            _asyncState = asyncState;
            _callBack = callBack;
        }

        private object _asyncState;
        public object AsyncState { get { return _asyncState; } }

        private AsyncCallback _callBack;
        public AsyncCallback CallBack { get { return _callBack; } }

        public WaitHandle AsyncWaitHandle { get { return null; } }
        //
        // Summary:
        //     Gets a value that indicates whether the asynchronous operation completed
        //     synchronously.
        //
        // Returns:
        //     true if the asynchronous operation completed synchronously; otherwise, false.
        private bool _completedSynchronously;
        public bool CompletedSynchronously 
        {
            get
            {
                return _completedSynchronously;
            }
        }
        //
        // Summary:
        //     Gets a value that indicates whether the asynchronous operation has completed.
        //
        // Returns:
        //     true if the operation is complete; otherwise, false.
        private bool _isCompleted;
        public bool IsCompleted 
        {
            get
            {
                return _isCompleted;
            }
        }

        public void SetCompletedSynchronously()
        {
            this._isCompleted = true;
            this._completedSynchronously = true;
        }

        public HttpContext Context { get; private set; }

        public LoginData LoginData { get; set; }

        /// <summary>
        /// Whether the user was successfully authenticated
        /// </summary>
        /// <remarks></remarks>
        public bool IsAuthenticated;

        /// <summary>
        /// Whether the authentication has expired
        /// </summary>
        /// <remarks></remarks>
        public bool IsExpired;

        /// <summary>
        /// The target path (success or error)
        /// </summary>
        /// <remarks></remarks>
        public string Target;

        /// <summary>
        /// Flag to indicate not to redirect to the target
        /// </summary>
        public bool NoRedirect;

        public string ErrorMessage;
    }
}
