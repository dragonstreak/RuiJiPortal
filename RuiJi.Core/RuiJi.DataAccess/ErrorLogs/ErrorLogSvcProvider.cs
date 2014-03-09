using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ErrorLogs.Data;

namespace RuiJi.DataAccess.ErrorLogs
{
     [ServiceProviderBinding]
    internal class ErrorLogSvcProvider : ServiceProviderBase<IErrorLogSvc>
    {
         protected override IErrorLogSvc GetServiceCore()
        {
            var dataMgr = CreateErrorLogMgr();
            return new ErrorLogSvc(
                dataMgr);
        }

         IErrorLogMgr CreateErrorLogMgr()
        {
            return new ErrorLogMgr();
        }
    }
}
