using RuiJi.DataAccess.SiteSettings.Data;

namespace RuiJi.DataAccess.SiteSettings
{
    [ServiceProviderBinding]
    internal class SiteSettingProvider : ServiceProviderBase<ISiteSettingSvc>
    {
        protected override ISiteSettingSvc GetServiceCore()
        {
            var mgr = CreateSiteSettingMgr();
            return new SiteSettingSvc(mgr);
        }

        ISiteSettingMgr CreateSiteSettingMgr()
        {
            var mgr = new SiteSettingMgr();
            return mgr;
        }
    }
}
