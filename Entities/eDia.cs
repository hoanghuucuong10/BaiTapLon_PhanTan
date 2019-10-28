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
    public class eDia
    {
        [DataMember]
        public int maDia { get; set; }
        [DataMember]
        public string tenDia { get; set; }
        [DataMember]
        public int maTheLoai { get; set; }
        [DataMember]
        public string tenTheLoai { get; set; }
        [DataMember]
        public int soLuong { get; set; }
        [DataMember]
        public double donGia { get; set; }
        [DataMember]
        public byte[] HinhAnh { get; set; }

    }
}
