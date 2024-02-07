using System;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Usluga : IDomainObject
    {
        [Browsable(false)]
        public int UslugaID { get; set; }
        [DisplayName("Naziv usluge")]
        public string NazivUsluge { get; set; }
        public string Opis { get; set; }
        [DisplayName("Cena usluge po danu")]
        public decimal CenaUslugePoDanu { get; set; }
        [Browsable(false)]
        public string TableName => "Usluga";
        [Browsable(false)]
        public string InsertValues => $"{UslugaID},'{NazivUsluge}','{Opis}',{CenaUslugePoDanu}";
        [Browsable(false)]
        public string Criteria =>"";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Alias => "u";
        [Browsable(false)]
        public string SelectValues => "*";
        public override string ToString()
        {
            return NazivUsluge;
        }
        
        public IDomainObject ReadRow(SqlDataReader reader)
        {
            Usluga u = new Usluga() { 
                UslugaID = (int)reader[0],
                NazivUsluge = (string)reader[1],
                Opis = (string)reader[2],
                CenaUslugePoDanu= (decimal)reader[3],
            };
            return u;
        }
    }
}