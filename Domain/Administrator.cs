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
    public class Administrator : IDomainObject
    {
        public int AdministratorID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [Browsable(false)]
        public string TableName => "Administrator";
        public string criteria;
        [Browsable(false)]
        public string InsertValues => $"{AdministratorID},'{Ime}','{Prezime}','{Username}','{Password}'";
        [Browsable(false)]
        public string Criteria => $"{criteria}";
        [Browsable(false)]
        public string Join => "";
        [Browsable(false)]
        public string Alias => "a";
        [Browsable(false)]
        public string SelectValues => "*";
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
        public IDomainObject ReadRow(SqlDataReader reader)
        {
            Administrator administrator= new Administrator();
            administrator.AdministratorID = (int)reader[0];
            administrator.Ime = (string)reader[1];
            administrator.Prezime = (string)reader[2];
            administrator.Username= (string)reader[3];
            administrator.Password = (string)reader[4];
            return administrator;
        }
    }
}
