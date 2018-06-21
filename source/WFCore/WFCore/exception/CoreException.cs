using System;

namespace WFCore.exception
{
    public class CoreException : Exception
    {
        private int errorCode;
        private string param;

        public const int ERROR_FILE_NOT_EXIST_1 = 0;
        private const string ERROR_FILE_NOT_EXIST_MSG = "{0} file not exist.";

        public const int FAILED_TO_GET_DB_CONNECTION_0 = 1;
        private const string FAILED_TO_GET_DB_CONNECTION_MSG = "failed to get db connection.";

        public const int FAILED_TO_EXECUTE_SQL_1 = 2;
        private const string FAILED_TO_EXECUTE_SQL_MSG = "failed to execute sql : {0}.";

        private static string[] messageBox = 
        {
            /*0*/ERROR_FILE_NOT_EXIST_MSG,
            /*1*/FAILED_TO_GET_DB_CONNECTION_MSG,
            /*2*/FAILED_TO_EXECUTE_SQL_MSG,
        };

        public CoreException(int errorCode, string param)
        {
            this.errorCode = errorCode;
            this.param = param;
        }


        public string getErrorMessage()
        {
            return messageBox[this.errorCode].Replace("{0}", this.param);
        }
    }
}
