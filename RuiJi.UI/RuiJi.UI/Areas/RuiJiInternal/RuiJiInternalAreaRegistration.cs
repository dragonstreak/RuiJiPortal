using System.Web.Mvc;

namespace RuiJi.Internal
{
    public class RuiJiInternalAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "RuiJiInternal";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Internal_default",
                "RuiJiInternal/{controller}/{action}/{id}",
                new { Controller = "Login", action = "Index", id = UrlParameter.Optional }
                , new string[] { "RuiJi.Internal.Controllers" }
            );
        }
    }
}
