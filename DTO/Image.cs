using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    internal class Image
    {
        public int ImageID { get; set; }
        public byte[] ImageData { get; set; }

        public Image(int imageID, byte[] imageData)
        {
            ImageID = imageID;
            ImageData = imageData;
        }

        public Image()
        {
        }
        public Image(DataRow row)
        {
            ImageID = (int)row["ImageID"];
            if (row["ImageData"] != DBNull.Value)
            {
                ImageData = row.Field<byte[]>("ImageData");
            }
            else
            {
                ImageData = null; // Đảm bảo rằng ImageData sẽ là null nếu cột ImageData là NULL
            }
        }
    }
}
