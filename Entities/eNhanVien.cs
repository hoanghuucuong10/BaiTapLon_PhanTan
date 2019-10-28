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
    public class eNhanVien
    {
        [DataMember]
        public int maNhanVien { get; set; }
        [DataMember]
        public string hoTen { get; set; }
        [DataMember]
        public string sDT { get; set; }
        [DataMember]
        public string mail { get; set; }
        [DataMember]
        public string tenTK { get; set; }
        [DataMember]
        public string matKhau { get; set; }
        [DataMember]
        public string loaiTK { get; set; }

    }
}
