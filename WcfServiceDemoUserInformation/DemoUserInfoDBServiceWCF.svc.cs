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

        public bool delete( string password)
        {

            try
            {
                using (DB_ModelDemo_DBSmartAspEntities dbdel = new DB_ModelDemo_DBSmartAspEntities())
                {
                    UserInformation usrinfo1;
                    usrinfo1 = (from i in dbdel.UserInformations where i.UserPassword == password select i).FirstOrDefault();
                    if (usrinfo1 != null)
                    {
                        usrinfo1.UserPassword = password;
                        dbdel.UserInformations.Remove(usrinfo1);
                        dbdel.SaveChanges();
                        usrinfo1 = null;
                        usrinfo1 = null;
                        return true;
                    }
                    else
                    {
                        usrinfo1 = null;
                        return false;
                    }

                }
            }
            catch
            {
                return false;
            }
        }

        public bool Edit(string name, string password)
        {
            try
            {
                using (DB_ModelDemo_DBSmartAspEntities dbedt = new DB_ModelDemo_DBSmartAspEntities())
                {
                    UserInformation usrinfo1;
                    usrinfo1 = (from i in dbedt.UserInformations where i.UserPassword == password select i).FirstOrDefault();
                    if (usrinfo1 != null)
                    {
                        usrinfo1.UserName = name;                   
                        dbedt.SaveChanges();
                        usrinfo1 = null;
                        usrinfo1 = null;
                        return true;
                    }
                    else
                    {
                        usrinfo1 = null;
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
        }

        public UserInformation find(string password)
        {
            return dbDemo.UserInformations.Single(p => p.UserPassword == password);
        }

        public List<UserInformation> findAll()
        {
            return dbDemo.UserInformations.ToList();
        }

        public bool insert(string name, string password)
        {
            try
            {
                using (DB_ModelDemo_DBSmartAspEntities dbinsrt = new DB_ModelDemo_DBSmartAspEntities())
                {
                    UserInformation usrinfoinset = new UserInformation();
                    var ExistUserinsrt =(from i in dbinsrt.UserInformations where i.UserPassword == password select i).FirstOrDefault();
                    if (ExistUserinsrt == null)
                    {
                        usrinfoinset.UserName = name;
                        usrinfoinset.UserPassword = password;
                        dbinsrt.UserInformations.Add(usrinfoinset);
                        dbinsrt.SaveChanges();
                        usrinfoinset = null;
                        ExistUserinsrt = null;
                        return true;
                    }
                    else
                    {
                        usrinfoinset = null;
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }

        }
    }
}
