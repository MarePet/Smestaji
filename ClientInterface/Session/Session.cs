using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientInterface.Session
{
    public class Session
    {
        private static Session instance;
        public static Session Instance
        {
            get {if (instance == null)
                {
                    instance = new Session();
                }
                return instance; }
        }
        private Session() {
            Usluge = new BindingList<Usluga>();
        }

        public Administrator  CurrentAdmin { get; set; }
        public BindingList<Usluga>  Usluge { get; set; }
    }
}
