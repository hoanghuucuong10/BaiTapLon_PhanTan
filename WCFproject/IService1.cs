using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
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
        List<eDia> GetAllDia(string id, string name);
        [OperationContract]
        List<eDia> GetAllDiaTheLoai(int theloai);
        [OperationContract]
        eDia GetDiaByID(int id);
        [OperationContract]
        List<eDia> SearchDia(string id, string ten, string theLoai);
        [OperationContract]
        bool EditDia(eDia dia);
        [OperationContract]
        bool AddDia(eDia dia);

        [OperationContract]
        List<eTheLoai> GetAllTheLoai();


        [OperationContract]
        bool AddHoaDon(eHoaDon x, List<eChiTietHoaDon> lst);
        [OperationContract]
        List<eHoaDon> GetAllHoaDon();
        [OperationContract]
        List<eChiTietHoaDon> GetAllChiTietHoaDon();
    }

    
}
