using System;
using System.Collections.Generic;
using System.Text;

namespace ITServiceModel
{
    public class SystemMessage
    {
        public static string NO_INPUT_VALUE = "0";
        public static int NO_VALUE = 0;
        public static string NO_INPUT_TEXT = "ไม่ระบุ";

        public class Configuration
        {
            //public static string LDAP_PATH = ConfigurationSettings.AppSettings["LDAPPath"];
        }

        public static class Message
        {
            public static class Error
            {
                public static readonly string INVALID_LOGIN = "Username & Password invalid.";
                public static readonly string PLEASE_INPUT_INSPECT_REASON = "โปรดระบุ เหตุผลที่ไม่ผ่าน";
                public static readonly string PLEASE_INPUT_PAYMENT_TERM = "โปรดระบุ term การชำระเงิน";
                public static readonly string PLEASE_SELECT_REASON_STATUS = "โปรดระบุ สถานะ Approve";
            }
            public static class Information
            {
                public static readonly string SUCCESS = "success";
                public static readonly string VALID_LOGIN = "Login Success.";
                public static readonly string SAVE_SUCCESS = "Save Success.";
            }
        }

        public class InspectStatus
        {
            public static readonly string WAIT_TXT = "รอตรวจสอบข้อมูล";
            public static readonly string PASS_TXT = "ข้อมูลถูกต้อง";
            public static readonly string NOT_PASS_TXT = "ข้อมูลส่งกลับแก้ไข";
            public static readonly string NOT_CANCEL_TXT = "ยกเลิก";
            public static readonly string PASS = "1";
            public static readonly string NOT_PASS = "0";
            public static readonly string NOT_CANCEL = "9";
        }
        public class VerifyStatus
        {
            public static readonly string WAIT_TXT = "รอตรวจสอบคุณสมบัติ";
            public static readonly string PASS_TXT = "ผ่านเกณฑ์";
            public static readonly string NOT_PASS_TXT = "ไม่ผ่านเกณฑ์";
            public static readonly string NOT_CANCEL_TXT = "ยกเลิก";
            public static readonly string PASS = "1";
            public static readonly string NOT_PASS = "0";
            public static readonly string NOT_CANCEL = "9";
        }
        public class ExtType
        {
            public static readonly int REGISTER_TYPE = 1;
            public static readonly int PAYMENT_TERM = 10;
            public static readonly int VERIFY_REASON = 11;
            public static readonly int Grade_Type = 12;
            public static readonly int Grade = 13;
            public static readonly int Grade_Status = 14;
            public static readonly int Estimate_Status = 15;
            public static readonly int Skill = 9;
            public static readonly int Reason_N = 21;
            public static readonly int Reason_Y = 20;
        }
        public class Ext
        {
            public static readonly int THAI = 1;
            public static readonly int ENGLISH = 2;
            public static readonly int PERSON = 3;
        }

    }
}
