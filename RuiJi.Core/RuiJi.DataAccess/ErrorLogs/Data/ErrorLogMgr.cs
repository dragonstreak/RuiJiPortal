using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RuiJi.DataAccess.Models;

namespace RuiJi.DataAccess.ErrorLogs.Data
{
    internal class ErrorLogMgr : RuiJi.DataAccess.ErrorLogs.Data.IErrorLogMgr
    {
        public int Add(ErrorLog error)
        {
            using (var db = new RuijiPortalContext())
            {
                db.ErrorLogs.Add(error);
                db.SaveChanges();
                return error.ErrorId;
            }
        }

        public ErrorLog Load(int errorId)
        {
            using (var db = new RuijiPortalContext())
            {
                return db.ErrorLogs.Find(errorId);
            }
        }
    }
}
