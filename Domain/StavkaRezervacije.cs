using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class StavkaRezervacije : IDomainObject
    {
        [Browsable(false)]
        public int RezervacijaID { get; set; }
        public int RBStavke { get; set; }
        public Usluga UslugaID { get; set; }
        [Browsable(false)]
        public string TableName => "StavkaRezervacije";
        [Browsable(false)]
        public string InsertValues => $"{RezervacijaID},{RBStavke}, {UslugaID.UslugaID}";
        [Browsable(false)]
        public string Criteria => $"WHERE sr.RezervacijaID={RezervacijaID}" + criteria;
        [Browsable(false)]
        public string Join => "JOIN Usluga u ON (u.UslugaID = sr.UslugaID)";
        [Browsable(false)]
        public string Alias => "sr";
        [Browsable(false)]
        public string SelectValues => $"RezervacijaID,RBStavke,u.UslugaID,NazivUsluge,Opis,CenaUslugePoDanu";
        public string criteria;
        public IDomainObject ReadRow(SqlDataReader reader)
        {
            StavkaRezervacije stavkaRezervacije = new StavkaRezervacije()
            {
                RezervacijaID = (int)reader[0],
                RBStavke= (int)reader[1],
                UslugaID = new Usluga()
                {
                    UslugaID = (int)reader[2],
                    NazivUsluge = (string)reader[3],
                    Opis = (string)reader[4],
                    CenaUslugePoDanu = (decimal)reader[5],
                }
            };
            return stavkaRezervacije;
        }
    }
}
