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
        public string NameImportPorduct { get; set; }

        public Import(int iD, DateTime importDate, int idStaff, string supplier, string note,string nameImportPorduct)
        {
            ID = iD;
            ImportDate = importDate;
            IdStaff = idStaff;
            IdSupplier = supplier;
            Note = note;
            NameImportPorduct=nameImportPorduct;
        }

        public Import(DateTime importDate, int idStaff, string idSupplier, string note, string nameImportPorduct)
        {
            ImportDate = importDate;
            IdStaff = idStaff;
            IdSupplier = idSupplier;
            Note = note;
            NameImportPorduct= nameImportPorduct;
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
            NameImportPorduct = (string)row["NameImportPorduct"];
        }
    }
}
