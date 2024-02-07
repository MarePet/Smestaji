using Domain;
using System.Collections.Generic;
using System.Linq;

namespace SystemOperations
{
    public class LoginSystemOperation : SystemOperationBase
    {
        private Administrator administrator;
        public Administrator Result { get; private set; }
        public List<Administrator> Administrators { get; set; }

        public LoginSystemOperation(Administrator administrator)
        {
            this.administrator = administrator;
        }

        protected override void ExecuteOperation()
        {
            Administrators = repository.GetAll(new Administrator()).OfType<Administrator>().ToList();
            foreach (var admin in Administrators)
            {
                if (admin.Username == administrator.Username && admin.Password == administrator.Password)
                {
                    Result = admin;
                }
            }
        }
    }
}
