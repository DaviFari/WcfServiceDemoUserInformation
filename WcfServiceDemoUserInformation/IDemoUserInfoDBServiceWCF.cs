﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDemoUserInformation
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IDemoUserInfoDBServiceWCF" in both code and config file together.
    [ServiceContract]
    public interface IDemoUserInfoDBServiceWCF
    {
        [OperationContract]
        UserInformation find(string password);
        [OperationContract]
        List<UserInformation> findAll();
        [OperationContract]
        bool insert(string name, string password);
        [OperationContract]
        bool delete(string password);
        [OperationContract]
        bool Edit(string name, string password);

    }
}
