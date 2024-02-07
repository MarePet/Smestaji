using System;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class TipRezervacije : IDomainObject
    {
        public int TipRezervacijeID { get; set; }
        public string NazivTipaRezervacije { get; set; }
        public decimal CenaPoDanu { get; set; }
        public string TableName => "TipRezervacije";

        public string InsertValues => $"{TipRezervacijeID},'{NazivTipaRezervacije}',{CenaPoDanu}";

        public string Criteria => "";

        public string Join => "";

        public string Alias => "tr";

        public string SelectValues => "*";
        public override string ToString()
        {
            return NazivTipaRezervacije + " " + CenaPoDanu;
        }

        public IDomainObject ReadRow(SqlDataReader reader)
        {
            TipRezervacije tipRezervacije = new TipRezervacije() {
                TipRezervacijeID = (int)reader[0],
                NazivTipaRezervacije = (string)reader[1],
                CenaPoDanu = (decimal)reader[2],
            };
            return tipRezervacije;
        }
    }
}