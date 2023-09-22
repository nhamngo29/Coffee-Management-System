using System.Data;

namespace DTO
{
    public class Account
    {
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public int TypeID { get; set; }

        public Account(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;
        }

        public Account(string userName, string displayName, int typeID, string password = null)
        {
            this.UserName = userName;
            this.DisplayName = displayName;
            this.TypeID = typeID;
            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.UserName = row["UserName"].ToString();
            this.DisplayName = row["DisplayName"].ToString();
            this.TypeID = (int)row["TypeID"];
            this.Password = row["Password"].ToString();
        }
    }
}