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
    public class eHoaDon
    {
        [DataMember]
        public int maHoaDon { get; set; }
        [DataMember]
        public DateTime ngayLapHD { get; set; }
        [DataMember]
        public int maNhanVien { get; set; }
        [DataMember]
        public double tongTien { get; set; }
        [DataMember]
        public string loaiHoaDon { get; set; }
    }
}
