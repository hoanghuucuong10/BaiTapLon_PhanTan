using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eTheLoai
    {
        [DataMember]
        public int maTheLoai { get; set; }
        [DataMember]
        public string tenTheLoai { get; set; }
    }
}
