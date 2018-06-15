using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDemoUserInformation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "DemoUserInfoDBServiceWCF" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select DemoUserInfoDBServiceWCF.svc or DemoUserInfoDBServiceWCF.svc.cs at the Solution Explorer and start debugging.
    public class DemoUserInfoDBServiceWCF : IDemoUserInfoDBServiceWCF
    {
        DB_ModelDemo_DBSmartAspEntities dbDemo = new DB_ModelDemo_DBSmartAspEntities();
        public UserInformation find(string password)
        {
            return dbDemo.UserInformations.Single(p => p.UserPassword == password);
        }

        public List<UserInformation> findAll()
        {
            return dbDemo.UserInformations.ToList();
        }
    }
}
