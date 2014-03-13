using System.Web.Mvc;

namespace RuiJi.UI.Areas.MyTest
{
    public class MyTestAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "MyTest";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "MyTest_default",
                "MyTest/{controller}/{action}/{id}",
                new {Controller="First", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
