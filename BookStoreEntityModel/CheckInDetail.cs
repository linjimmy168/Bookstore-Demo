//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreEntityModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class CheckInDetail
    {
        public int CheckInRecordID { get; set; }
        public int EmployeeID { get; set; }
        public int Emp_AttendacyID { get; set; }
        public Nullable<int> Absence_ID { get; set; }
        public string CheckInLocation { get; set; }
        public Nullable<System.DateTime> CheckInDateTime { get; set; }
        public string CheclInLatitude { get; set; }
        public string CheckLongitude { get; set; }
        public string Dis_Between_Previous { get; set; }
        public string Note { get; set; }
        public Nullable<bool> In_Out { get; set; }
    
        public virtual Absence_Type Absence_Type { get; set; }
        public virtual Emp_AttendancyType Emp_AttendancyType { get; set; }
        public virtual Emp_Information Emp_Information { get; set; }
    }
}
