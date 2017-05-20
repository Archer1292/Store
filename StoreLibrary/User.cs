using System;
using System.Data;


namespace StoreLibrary
{
    public partial class User:BaseClass<User>
{
        #region связь с БД
        public string Login {
            get { return _row["Login"].ToString(); }
            set { _row["Login"] = value; }
        }
    public string Password {
            get { return _row["Password"].ToString(); }
            set { _row["PWORD"] = value; }
        }
    private Guid _employeeId
        {
            get { return (Guid)_row["Employee_id"]; }
            set { _row["Employee_id"] = value; }
        }
    public Access Access_rights {
            get { return (Access)_row["Access_rights"]; }
            set { _row["Access_rights"] = value; }
        }
        #endregion
        
        public User() : base() { }
        public User(DataRow dr) : base(dr) { }
        public Employee Employee {
            get {return Employee.GetByID(_employeeId); }
            set
            {
                
                if (Employee.GetByID(_employeeId)!=null) 
                    _employeeId = value.Id;
            }
        }
        public override string ToString() { return Login; }

        public override bool Equals(object obj) { return (obj is User && this == (User)obj); }

        public static bool operator ==(User u1, User u2)
        {
            if (System.Object.ReferenceEquals(u1, u2)) { return true; }
            if (((object)u1 == null) || ((object)u2 == null)) { return false; }
            return u1.Id == u2.Id;
        }

        public static bool operator !=(User u1, User u2) { return !(u1 == u2); }
        public enum Access { admin, stockman,manager }
    }
}
