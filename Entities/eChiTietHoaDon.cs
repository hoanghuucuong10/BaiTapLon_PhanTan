using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace Entities
{
    [DataContract]
    public class eChiTietHoaDon
    {
        [DataMember]
        public int maCTHD { get; set; }
        [DataMember]
        public int maHoaDon { get; set; }
        [DataMember]
        public int maDia { get; set; }
        [DataMember]
        public int tenDia { get; set; }
        [DataMember]
        public int soLuong { get; set; }
        [DataMember]
        public double thanhTien { get; set; }
    }
}
