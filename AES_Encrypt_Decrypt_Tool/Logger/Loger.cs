using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Logger;

namespace Logger
{
    public class Loger
    {
        private static iLogger _transactionLog = null;
        private static iLogger _errorLog = null;
        private static iLogger _auditTrailLogger = null;
        private static iLogger _commonTransactionLog = null;
        private static iLogger _commonErrorLog = null;
        public static Dictionary<string, iLogger> LoggerPool = null;

        static Loger()
        {
            LoggerPool = new Dictionary<string, iLogger>();
        }

        static iLogger AudiTrailLogg
        {
            get
            {
                if (_auditTrailLogger == null)
                {
                    try
                    {
                        _auditTrailLogger = new FileLogger(AuditTrailLogFilePath.AuditTrailLogPath, "dd-MM-yyyy", "AuditTrailLog_", ".txt");
                    }
                    catch (Exception ex)
                    { }
                }
                return _auditTrailLogger;
            }
            set { _auditTrailLogger = value; }
        }

        public static void AuditTrailLog(object sender, string UserName, string ActivityPerformed)
        {
            AudiTrailLogg.WriteEntry(sender,
                                     string.Format("UserName : {0}" + Environment.NewLine +
                                     "Activity Performed : {1}" + Environment.NewLine +
                                     "Activity Date Time : {2}" + Environment.NewLine + "-------------------------------------------------------"
                                     , UserName, ActivityPerformed, DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss tt")));
        }

        static iLogger TransactionLog
        {
            get
            {
                if (_transactionLog == null)
                {
                    try
                    {
                        _transactionLog = new FileLogger(LogFilePath.TransactionLogPath, "dd-MM-yyyy", "TransactionLog_", ".txt");
                    }
                    catch (Exception ex)
                    {
                        Loger.WriteCommonErrorLog(null, ex);
                    }
                }
                return _transactionLog;
            }
            set { _transactionLog = value; }
        }

        static iLogger CommonTransactionLog
        {
            get
            {
                if (_commonTransactionLog == null)
                {
                    try
                    {
                        _commonTransactionLog = new FileLogger(LogFilePath.CommonTransactionLogPath, "dd-MM-yyyy", "TransactionLog_", ".txt");
                    }
                    catch (Exception ex)
                    {
                        Loger.WriteCommonErrorLog(null, ex);
                    }
                }
                return _commonTransactionLog;
            }
            set { _commonTransactionLog = value; }
        }

        static iLogger ErrorLog
        {
            get
            {
                if (_errorLog == null)
                {
                    try
                    {
                        _errorLog = new FileLogger(LogFilePath.ErrorLogPath, "dd-MM-yyyy", "ErrorLog_", ".txt");
                    }
                    catch (Exception ex)
                    {
                        Loger.WriteCommonErrorLog(null, ex);
                    }
                }
                return _errorLog;
            }
            set { _errorLog = value; }
        }

        static iLogger CommonErrorLog
        {
            get
            {
                if (_commonErrorLog == null)
                {
                    try
                    {
                        _commonErrorLog = new FileLogger(LogFilePath.CommonErrorLogPath, "dd-MM-yyyy", "ErrorLog_", ".txt");
                    }
                    catch (Exception ex)
                    {
                        Loger.WriteCommonErrorLog(null, ex);
                    }
                }
                return _commonErrorLog;
            }
            set { _commonErrorLog = value; }
        }

        public static void WriteTransLog(object sender, string message)
        {
            TransactionLog.WriteEntry(sender, message);
        }

        public static void WriteCommonTransLog(object sender, string message)
        {
            CommonTransactionLog.WriteEntry(sender, message);
        }

        public static void WriteErrorLog(object sender, Exception ex)
        {
            ErrorLog.WriteError(sender,
                                                "Source - : " + ex.Source.ToString() + Environment.NewLine +
                                                "StackTrace -  : " + ex.StackTrace.ToString() + Environment.NewLine +
                                                "Inner Exception -  : " + ex.InnerException.ToString() + Environment.NewLine +
                                                "Message - : " + ex.Message.ToString()
                                              );
        }

        public static void WriteCommonErrorLog(object sender, Exception ex)
        {
            CommonErrorLog.WriteError(sender,
                                                "Source - : " + ex.Source.ToString() + Environment.NewLine +
                                                "StackTrace -  : " + ex.StackTrace.ToString() + Environment.NewLine +
                                                 "Inner Exception -  : " + ex.InnerException.ToString() + Environment.NewLine +
                                                "Message - : " + ex.Message.ToString()
                                              );
        }

    }

    public class LogFilePath
    {
        public static readonly string RootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemLog");
        public static readonly string TransactionLogPath = Path.Combine(RootPath, "TransactionLog");
        public static readonly string CommonTransactionLogPath = Path.Combine(RootPath, "CommonTransactionLog");
        public static readonly string ErrorLogPath = Path.Combine(RootPath, "ErrorLog");
        public static readonly string CommonErrorLogPath = Path.Combine(RootPath, "CommonErrorLog");
    }

    public class AuditTrailLogFilePath
    {
        public static readonly string RootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SystemLog");
        public static readonly string AuditTrailLogPath = Path.Combine(RootPath, "AuditTrailLog");
    }
}
