using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Web;
using RuiJi.Internal.Web.Context;

namespace RuiJi.Internal.Web.Module
{
    public abstract class RuiJiContextModuleBase<TContext> : IHttpModule where TContext : class, IServerContext
    {
        protected RuiJiContextModuleBase()
        {
        }

        private void Application_BeginRequest(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            if (this.IsValidForRequest(application.Request))
            {
                ContextManager<TContext>.SetContext(this.LoadContext(application.Context), application.Context);
            }
        }

        private void Application_PreSendRequestHeaders(object sender, EventArgs e)
        {
            HttpApplication application = (HttpApplication)sender;
            if (this.IsValidForRequest(application.Request))
            {
                TContext context = ContextManager<TContext>.GetContext(application.Context);
                this.SaveContext(context, application.Context);
            }
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public virtual void Dispose()
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public virtual void Init(HttpApplication application)
        {
            application.BeginRequest += new EventHandler(this.Application_BeginRequest);
            application.PreSendRequestHeaders += new EventHandler(this.Application_PreSendRequestHeaders);
        }

        protected abstract bool IsValidForRequest(HttpRequest request);
        protected abstract TContext LoadContext(HttpContext context);
        protected abstract void SaveContext(TContext context, HttpContext httpContext);

    }
}
