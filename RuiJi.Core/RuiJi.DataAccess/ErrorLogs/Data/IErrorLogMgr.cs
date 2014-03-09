using System;
namespace RuiJi.DataAccess.ErrorLogs.Data
{
    interface IErrorLogMgr
    {
        int Add(RuiJi.DataAccess.Models.ErrorLog error);
        RuiJi.DataAccess.Models.ErrorLog Load(int errorId);
    }
}
