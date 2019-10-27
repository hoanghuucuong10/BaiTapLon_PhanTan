using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class eDia
    {
        public int maDia { get; set; }
        public string tenDia { get; set; }
        public int maTheLoai { get; set; }
        public string tenTheLoai { get; set; }
        public int soLuong { get; set; }
        public double donGia { get; set; }
        public byte[] HinhAnh { get; set; }
        public eTheLoai theLoai { get; set; }
    }
}
