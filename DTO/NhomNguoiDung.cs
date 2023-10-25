using System.Data;
namespace DTO
{
    public class NhomNguoiDung
    {
        public int MaNhomNguoiDung {  get; set; }
        public int AccountTypeID {  get; set; }
        public string Name {  get; set; }

        public NhomNguoiDung(int maNhomNguoiDung, int accountTypeID, string name)
        {
            MaNhomNguoiDung = maNhomNguoiDung;
            AccountTypeID = accountTypeID;
            Name = name;
        }

        public NhomNguoiDung()
        {
        }
        public NhomNguoiDung(DataRow row)
        {
            MaNhomNguoiDung = (int)row["MaNhomNguoiDung"];
            AccountTypeID = (int)row["AccountTypeID"];
            Name = row["Name"].ToString();
        }
    }
}
