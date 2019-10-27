using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
namespace WCF
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        eNhanVien Login(string tenTK, string pw);
        [OperationContract]
        List<eNhanVien> GetAllNhanVien(string id, string name);
        [OperationContract]
        eNhanVien GetNhanVienByID(string id);
        [OperationContract]
        bool EditNhanVien(eNhanVien nv);
        [OperationContract]
        bool AddNhanVien(eNhanVien nv);
        [OperationContract]
        bool DeleteNhanVien(eNhanVien nv);



        [OperationContract]
        List<eDia> GetAllDia(string id, string name, string theLoai);
        [OperationContract]
        List<eDia> GetAllDiaTheLoai(string theloai);
        [OperationContract]
        eDia GetDiaByID(string id);
        [OperationContract]
        bool EditDia(eDia dia);
        [OperationContract]
        bool AddDia(eDia dia);



    }

}
