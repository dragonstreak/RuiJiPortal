using System;
namespace RuiJi.DataAccess.ErrorLogs
{
    public interface IErrorLogSvc
    {
        int Add(RuiJi.DataAccess.Models.ErrorLog error);
        RuiJi.DataAccess.Models.ErrorLog Load(int errorId);
        int Add(Exception ex);
    }
}
