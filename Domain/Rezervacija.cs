using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace Domain
{
    [Serializable]
    public class Rezervacija : IDomainObject
    {
        public string criteria;

        [Browsable(false)]
        public int RezervacijaID { get; set; }
        public DateTime DatumPocetka { get; set; }
        public DateTime DatumKraja { get; set; }
        public int BrojDana { get; set; }
        public decimal UkupnaCena { get; set; }
        public TipRezervacije TipRezervacije { get; set; }
        public Client Klijent { get; set; }
        public Administrator Administrator { get; set; }
        [Browsable(false)]
        public List<StavkaRezervacije> StavkeRezervacije { get; set; }
        [Browsable(false)]
        public string TableName => "Rezervacija";
        [Browsable(false)]
        public string InsertValues => $"{RezervacijaID},'{DatumPocetka.Date.ToString("yyyy-MM-dd")}','{DatumKraja.Date.ToString("yyyy-MM-dd")}',{BrojDana},'{UkupnaCena.ToString("##.##")}',{TipRezervacije.TipRezervacijeID},{Klijent.KlijentID},{Administrator.AdministratorID}";
        [Browsable(false)]
        public string Criteria => criteria;
        [Browsable(false)]
        public string Join => "JOIN Administrator a ON (a.AdministratorID = r.AdministratorID)\r\nJOIN TipRezervacije tr ON (r.TipRezervacijeID = tr.TipRezervacijeID)\r\nJOIN Klijent k ON (r.KlijentID = k.KlijentID)";
        [Browsable(false)]
        public string Alias => "r";
        [Browsable(false)]
        public string SelectValues => $"r.RezervacijaID,k.ImeKlijenta,k.PrezimeKlijenta,DatumPocetka,DatumKraja,BrojDana, UkupnaCena, tr.NazivTipaRezervacije, a.Ime,a.Prezime";

        public IDomainObject ReadRow(SqlDataReader reader)
        {
            Rezervacija rezervacija = new Rezervacija()
            {
                RezervacijaID = (int)reader[0],
                Klijent = new Client()
                {
                    ImeKlijenta = (string)reader[1],
                    PrezimeKlijenta = (string)reader[2]
                },
                DatumPocetka = (DateTime)reader[3],
                DatumKraja = (DateTime)reader[4],
                BrojDana = (int)reader[5],
                UkupnaCena = (decimal)reader[6],
                TipRezervacije = new TipRezervacije()
                {
                    NazivTipaRezervacije = (string)reader[7],
                },
                Administrator = new Administrator()
                {
                    Ime = (string)reader[8],
                    Prezime = (string)reader[9]
                }
            };
            return rezervacija;
        }
    }
}
