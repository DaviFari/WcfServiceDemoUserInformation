﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="UserInformation", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceDemoUserInformation")]
    [System.SerializableAttribute()]
    public partial class UserInformation : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserPasswordField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserPassword {
            get {
                return this.UserPasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.UserPasswordField, value) != true)) {
                    this.UserPasswordField = value;
                    this.RaisePropertyChanged("UserPassword");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceDemoUser1.IDemoUserInfoDBServiceWCF")]
    public interface IDemoUserInfoDBServiceWCF {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/find", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/findResponse")]
        WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation find(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/find", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/findResponse")]
        System.Threading.Tasks.Task<WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation> findAsync(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/findAll", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/findAllResponse")]
        WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation[] findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/findAll", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/findAllResponse")]
        System.Threading.Tasks.Task<WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation[]> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/insert", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/insertResponse")]
        bool insert(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/insert", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/insertResponse")]
        System.Threading.Tasks.Task<bool> insertAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/delete", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/deleteResponse")]
        bool delete(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/delete", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/deleteResponse")]
        System.Threading.Tasks.Task<bool> deleteAsync(string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/Edit", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/EditResponse")]
        bool Edit(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDemoUserInfoDBServiceWCF/Edit", ReplyAction="http://tempuri.org/IDemoUserInfoDBServiceWCF/EditResponse")]
        System.Threading.Tasks.Task<bool> EditAsync(string name, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDemoUserInfoDBServiceWCFChannel : WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.IDemoUserInfoDBServiceWCF, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DemoUserInfoDBServiceWCFClient : System.ServiceModel.ClientBase<WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.IDemoUserInfoDBServiceWCF>, WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.IDemoUserInfoDBServiceWCF {
        
        public DemoUserInfoDBServiceWCFClient() {
        }
        
        public DemoUserInfoDBServiceWCFClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DemoUserInfoDBServiceWCFClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoUserInfoDBServiceWCFClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DemoUserInfoDBServiceWCFClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation find(string password) {
            return base.Channel.find(password);
        }
        
        public System.Threading.Tasks.Task<WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation> findAsync(string password) {
            return base.Channel.findAsync(password);
        }
        
        public WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation[] findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<WinFormWCFServiceDemoUserInfo.ServiceReferenceDemoUser1.UserInformation[]> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public bool insert(string name, string password) {
            return base.Channel.insert(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> insertAsync(string name, string password) {
            return base.Channel.insertAsync(name, password);
        }
        
        public bool delete(string password) {
            return base.Channel.delete(password);
        }
        
        public System.Threading.Tasks.Task<bool> deleteAsync(string password) {
            return base.Channel.deleteAsync(password);
        }
        
        public bool Edit(string name, string password) {
            return base.Channel.Edit(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> EditAsync(string name, string password) {
            return base.Channel.EditAsync(name, password);
        }
    }
}
