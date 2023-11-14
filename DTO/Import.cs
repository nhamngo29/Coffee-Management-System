using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class Import
    {
        public int ID { get; set; }
        public DateTime ImportDate  { get; set; }
        public int IdStaff { get; set; }
        public string IdSupplier { get; set; }
        public string Note {  get; set; }

        public Import(int iD, DateTime importDate, int idStaff, string supplier, string note)
        {
            ID = iD;
            ImportDate = importDate;
            IdStaff = idStaff;
            IdSupplier = supplier;
            Note = note;
        }

        public Import(DateTime importDate, int idStaff, string idSupplier, string note)
        {
            ImportDate = importDate;
            IdStaff = idStaff;
            IdSupplier = idSupplier;
            Note = note;
        }

        public Import()
        {
        }

        public Import(DataRow row)
        {
            ID = (int)row["ID"];
            ImportDate = (DateTime)row["ImportDate"];
            IdStaff = (int)row["IdStaff"];
            IdSupplier = (string)row["IdSupplier"];
            Note = (string)row["Note"];
        }
    }
}
