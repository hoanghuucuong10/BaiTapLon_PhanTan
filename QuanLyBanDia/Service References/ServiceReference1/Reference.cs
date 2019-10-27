﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyBanDia.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        Entities.eNhanVien Login(string tenTK, string pw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        System.Threading.Tasks.Task<Entities.eNhanVien> LoginAsync(string tenTK, string pw);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllNhanVien", ReplyAction="http://tempuri.org/IService1/GetAllNhanVienResponse")]
        Entities.eNhanVien[] GetAllNhanVien(string id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllNhanVien", ReplyAction="http://tempuri.org/IService1/GetAllNhanVienResponse")]
        System.Threading.Tasks.Task<Entities.eNhanVien[]> GetAllNhanVienAsync(string id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNhanVienByID", ReplyAction="http://tempuri.org/IService1/GetNhanVienByIDResponse")]
        Entities.eNhanVien GetNhanVienByID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetNhanVienByID", ReplyAction="http://tempuri.org/IService1/GetNhanVienByIDResponse")]
        System.Threading.Tasks.Task<Entities.eNhanVien> GetNhanVienByIDAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditNhanVien", ReplyAction="http://tempuri.org/IService1/EditNhanVienResponse")]
        bool EditNhanVien(Entities.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditNhanVien", ReplyAction="http://tempuri.org/IService1/EditNhanVienResponse")]
        System.Threading.Tasks.Task<bool> EditNhanVienAsync(Entities.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNhanVien", ReplyAction="http://tempuri.org/IService1/AddNhanVienResponse")]
        bool AddNhanVien(Entities.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddNhanVien", ReplyAction="http://tempuri.org/IService1/AddNhanVienResponse")]
        System.Threading.Tasks.Task<bool> AddNhanVienAsync(Entities.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteNhanVien", ReplyAction="http://tempuri.org/IService1/DeleteNhanVienResponse")]
        bool DeleteNhanVien(Entities.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteNhanVien", ReplyAction="http://tempuri.org/IService1/DeleteNhanVienResponse")]
        System.Threading.Tasks.Task<bool> DeleteNhanVienAsync(Entities.eNhanVien nv);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDia", ReplyAction="http://tempuri.org/IService1/GetAllDiaResponse")]
        Entities.eDia[] GetAllDia(string id, string name, string theLoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDia", ReplyAction="http://tempuri.org/IService1/GetAllDiaResponse")]
        System.Threading.Tasks.Task<Entities.eDia[]> GetAllDiaAsync(string id, string name, string theLoai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDiaTheLoai", ReplyAction="http://tempuri.org/IService1/GetAllDiaTheLoaiResponse")]
        Entities.eDia[] GetAllDiaTheLoai(string theloai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllDiaTheLoai", ReplyAction="http://tempuri.org/IService1/GetAllDiaTheLoaiResponse")]
        System.Threading.Tasks.Task<Entities.eDia[]> GetAllDiaTheLoaiAsync(string theloai);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDiaByID", ReplyAction="http://tempuri.org/IService1/GetDiaByIDResponse")]
        Entities.eDia GetDiaByID(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDiaByID", ReplyAction="http://tempuri.org/IService1/GetDiaByIDResponse")]
        System.Threading.Tasks.Task<Entities.eDia> GetDiaByIDAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditDia", ReplyAction="http://tempuri.org/IService1/EditDiaResponse")]
        bool EditDia(Entities.eDia dia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditDia", ReplyAction="http://tempuri.org/IService1/EditDiaResponse")]
        System.Threading.Tasks.Task<bool> EditDiaAsync(Entities.eDia dia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddDia", ReplyAction="http://tempuri.org/IService1/AddDiaResponse")]
        bool AddDia(Entities.eDia dia);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddDia", ReplyAction="http://tempuri.org/IService1/AddDiaResponse")]
        System.Threading.Tasks.Task<bool> AddDiaAsync(Entities.eDia dia);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : QuanLyBanDia.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<QuanLyBanDia.ServiceReference1.IService1>, QuanLyBanDia.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public Entities.eNhanVien Login(string tenTK, string pw) {
            return base.Channel.Login(tenTK, pw);
        }
        
        public System.Threading.Tasks.Task<Entities.eNhanVien> LoginAsync(string tenTK, string pw) {
            return base.Channel.LoginAsync(tenTK, pw);
        }
        
        public Entities.eNhanVien[] GetAllNhanVien(string id, string name) {
            return base.Channel.GetAllNhanVien(id, name);
        }
        
        public System.Threading.Tasks.Task<Entities.eNhanVien[]> GetAllNhanVienAsync(string id, string name) {
            return base.Channel.GetAllNhanVienAsync(id, name);
        }
        
        public Entities.eNhanVien GetNhanVienByID(string id) {
            return base.Channel.GetNhanVienByID(id);
        }
        
        public System.Threading.Tasks.Task<Entities.eNhanVien> GetNhanVienByIDAsync(string id) {
            return base.Channel.GetNhanVienByIDAsync(id);
        }
        
        public bool EditNhanVien(Entities.eNhanVien nv) {
            return base.Channel.EditNhanVien(nv);
        }
        
        public System.Threading.Tasks.Task<bool> EditNhanVienAsync(Entities.eNhanVien nv) {
            return base.Channel.EditNhanVienAsync(nv);
        }
        
        public bool AddNhanVien(Entities.eNhanVien nv) {
            return base.Channel.AddNhanVien(nv);
        }
        
        public System.Threading.Tasks.Task<bool> AddNhanVienAsync(Entities.eNhanVien nv) {
            return base.Channel.AddNhanVienAsync(nv);
        }
        
        public bool DeleteNhanVien(Entities.eNhanVien nv) {
            return base.Channel.DeleteNhanVien(nv);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteNhanVienAsync(Entities.eNhanVien nv) {
            return base.Channel.DeleteNhanVienAsync(nv);
        }
        
        public Entities.eDia[] GetAllDia(string id, string name, string theLoai) {
            return base.Channel.GetAllDia(id, name, theLoai);
        }
        
        public System.Threading.Tasks.Task<Entities.eDia[]> GetAllDiaAsync(string id, string name, string theLoai) {
            return base.Channel.GetAllDiaAsync(id, name, theLoai);
        }
        
        public Entities.eDia[] GetAllDiaTheLoai(string theloai) {
            return base.Channel.GetAllDiaTheLoai(theloai);
        }
        
        public System.Threading.Tasks.Task<Entities.eDia[]> GetAllDiaTheLoaiAsync(string theloai) {
            return base.Channel.GetAllDiaTheLoaiAsync(theloai);
        }
        
        public Entities.eDia GetDiaByID(string id) {
            return base.Channel.GetDiaByID(id);
        }
        
        public System.Threading.Tasks.Task<Entities.eDia> GetDiaByIDAsync(string id) {
            return base.Channel.GetDiaByIDAsync(id);
        }
        
        public bool EditDia(Entities.eDia dia) {
            return base.Channel.EditDia(dia);
        }
        
        public System.Threading.Tasks.Task<bool> EditDiaAsync(Entities.eDia dia) {
            return base.Channel.EditDiaAsync(dia);
        }
        
        public bool AddDia(Entities.eDia dia) {
            return base.Channel.AddDia(dia);
        }
        
        public System.Threading.Tasks.Task<bool> AddDiaAsync(Entities.eDia dia) {
            return base.Channel.AddDiaAsync(dia);
        }
    }
}
