using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WFCore.db
{
    public class DBMetadata
    {
        public const string COL_NAME_SEQ = "seq";
        public const string COL_NAME_STARTDATETIME = "startDateTime";
        public const string COL_NAME_ENDDATETIME = "endDateTime";
        public const string COL_NAME_STATUS = "status";
        public static string[] T_POWERMODE_COLUMNS_NAME = 
        {
            COL_NAME_SEQ,
            COL_NAME_STARTDATETIME,
            COL_NAME_ENDDATETIME,
            COL_NAME_STATUS,
        };
        public static string[] T_POWERMODE_COLUMNS_HEADER = 
        {
            "id",
            COL_NAME_STARTDATETIME,
            COL_NAME_ENDDATETIME,
            COL_NAME_STATUS,
        };


    }
}
