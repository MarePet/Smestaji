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
    public class Client : IDomainObject
    {
        [Browsable(false)]
        public int KlijentID { get; set; }
        [DisplayName("Ime")]
        public string ImeKlijenta { get; set; }
        [DisplayName("Prezime")]
        public string PrezimeKlijenta { get; set; }
        [DisplayName("E-mail")]
        public string Email { get; set; }
        public string Telefon { get; set; }
        [Browsable(false)]
        public string TableName => "Klijent";
        public string criteria;
        [Browsable(false)]
        public string InsertValues => $"{KlijentID},'{ImeKlijenta}','{PrezimeKlijenta}','{Email}','{Telefon}'";

        [Browsable(false)]
        public string Criteria => $"{criteria}";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Alias => "k";

        public string SelectValues => "*";
        public override string ToString()
        {
            return ImeKlijenta + " " + PrezimeKlijenta; 
        }
       
        public IDomainObject ReadRow(SqlDataReader reader)
        {
            Client client = new Client();
            client.KlijentID = (int)reader[0];
            client.ImeKlijenta = (string)reader[1];
            client.PrezimeKlijenta = (string)reader[2];
            client.Email = (string)reader[3];
            client.Telefon = (string)reader[4];
            return client;
        }
    }
}
