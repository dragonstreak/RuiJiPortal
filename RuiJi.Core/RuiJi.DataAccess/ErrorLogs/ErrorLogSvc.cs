using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.ErrorLogs.Data;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ErrorLogs
{
    public class ErrorLogSvc : RuiJi.DataAccess.ErrorLogs.IErrorLogSvc
    {
        private IErrorLogMgr _mgr;

        internal ErrorLogSvc(IErrorLogMgr mgr)
        {
            _mgr = mgr;
        }

        public int Add(Exception ex)
        {
            int? innerErrorId = null;
            if (ex.InnerException != null)
            {
                innerErrorId = Add(ex.InnerException);
            }

            ErrorLog log = new ErrorLog();
            log.ErrorMessage = ex.Message;
            log.StackTrace = ex.StackTrace;
            log.ExceptionType = ex.GetType().Name;
            log.InsertDate = DateTime.Now;
            log.InnerErrorId = innerErrorId;
            
            return Add(log);
        }

        public int Add(ErrorLog error)
        {
           return  _mgr.Add(error);
        }

        public ErrorLog Load(int errorId)
        {
            return _mgr.Load(errorId);
        }
    }
}
