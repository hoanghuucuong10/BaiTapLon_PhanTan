using DAL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;

namespace WCFproject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        BanDiaPhanTanEntities db = new BanDiaPhanTanEntities();

        public bool AddDia(eDia dia)
        {
            try
            {
                Dia t = new Dia();
                t.MaTheLoai = dia.maTheLoai;
                t.MaDia = dia.maDia;
                t.TenDia = dia.tenDia;
                t.DonGia = dia.donGia;
                t.SoLuong = dia.soLuong;
                t.HinhAnh = dia.HinhAnh;
                db.Dias.Add(t);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public bool EditDia(eDia dia)
        {
            try
            {
                Dia t = db.Dias.Where(x => x.MaDia == dia.maDia).FirstOrDefault();
                if (t != null)
                {
                    t.MaTheLoai = dia.maTheLoai;
                    t.TenDia = dia.tenDia;
                    t.DonGia = dia.donGia;
                    t.SoLuong = dia.soLuong;
                    t.HinhAnh = dia.HinhAnh;
                    db.SaveChanges();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public List<eDia> GetAllDia(string id, string name)
        {
            List<eDia> lst = db.Dias.Where(x => x.MaDia.ToString().Contains(id) && x.TenDia.Contains(name)).Select(t => new eDia
            {
                maDia = t.MaDia,
                tenDia = t.TenDia,
                tenTheLoai = t.TheLoai.TenTheLoai,
                maTheLoai = t.MaTheLoai.Value,
                soLuong = t.SoLuong.Value,
                donGia = t.DonGia.Value,
                HinhAnh = t.HinhAnh
            }).ToList();
            return lst;
        }
        public List<eDia> GetAllDiaTheLoai(int theloai)
        {
            List<eDia> lst = db.Dias.Where(x => x.MaTheLoai == theloai).Select(t => new eDia
            {
                maDia = t.MaDia,
                tenDia = t.TenDia,
                tenTheLoai = t.TheLoai.TenTheLoai,
                maTheLoai = t.MaTheLoai.Value,
                soLuong = t.SoLuong.Value,
                donGia = t.DonGia.Value,
                HinhAnh = t.HinhAnh

            }).ToList();
            return lst;
        }
        #region NhanVien
        public bool EditNhanVien(eNhanVien nv)
        {
            try
            {
                NhanVien t = db.NhanViens.Where(x => x.MaNhanVien == nv.maNhanVien).FirstOrDefault();
                if (t != null)
                {
                    t.MaNhanVien = nv.maNhanVien;
                    t.MatKhau = nv.matKhau;
                    t.SDT = nv.sDT;
                    t.TenTaiKhoan = nv.tenTK;
                    t.Mail = nv.mail;
                    t.HoTen = nv.hoTen;

                    db.SaveChanges();
                    return true;
                }
                else
                    return false;

            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool AddNhanVien(eNhanVien nv)
        {
            throw new NotImplementedException();
        }
        public bool DeleteNhanVien(eNhanVien nv)
        {
            throw new NotImplementedException();
        }
        public List<eNhanVien> GetAllNhanVien(string id, string name)
        {
            List<eNhanVien> lst = db.NhanViens.Where(x => x.MaNhanVien.ToString().Contains(id) && x.HoTen.Contains(name)).Select(t => new eNhanVien
            {
                maNhanVien = t.MaNhanVien,
                hoTen = t.HoTen,
                sDT = t.SDT,
                mail = t.Mail,
                tenTK = t.TenTaiKhoan,
                matKhau = t.MatKhau,
                loaiTK = t.ChucVu
            }).ToList();
            return lst;
        }
        public List<eDia> SearchDia(string id, string ten, string theLoai)
        {
            List<eDia> lst = db.Dias.Where(x => x.MaDia.ToString().Contains(id) && x.TenDia.Contains(ten) && x.TheLoai.TenTheLoai.Trim().Contains(theLoai)).Select(t => new eDia
            {
                maDia = t.MaDia,
                maTheLoai = t.MaTheLoai.Value,
                tenDia = t.TenDia,
                donGia = t.DonGia.Value,
                tenTheLoai = t.TheLoai.TenTheLoai,
                HinhAnh = t.HinhAnh,
                soLuong = t.SoLuong.Value

            }).ToList();
            return lst;
        }
        public eDia GetDiaByID(int id)
        {
            eDia lst = db.Dias.Where(x => x.MaDia == id).Select(t => new eDia
            {
                maDia = t.MaDia,
                maTheLoai = t.MaTheLoai.Value,
                tenDia = t.TenDia,
                donGia = t.DonGia.Value,
                tenTheLoai = t.TheLoai.TenTheLoai,
                HinhAnh = t.HinhAnh,
                soLuong = t.SoLuong.Value

            }).FirstOrDefault();
            return lst;
        }

        public eNhanVien GetNhanVienByID(string id)
        {
            eNhanVien lst = db.NhanViens.Where(x => x.MaNhanVien.ToString().Contains(id)).Select(t => new eNhanVien
            {
                maNhanVien = t.MaNhanVien,
                hoTen = t.HoTen,
                sDT = t.SDT,
                mail = t.Mail,
                tenTK = t.TenTaiKhoan,
                matKhau = t.MatKhau,
                loaiTK = t.ChucVu
            }).FirstOrDefault();
            return lst;
        }

        public eNhanVien Login(string tenTK, string pw)
        {
            NhanVien tk = db.NhanViens.Where(x => x.TenTaiKhoan.Trim() == tenTK).FirstOrDefault();
            if (tk != null)
            {
                if (tk.MatKhau.Trim() == pw)
                {
                    eNhanVien x = new eNhanVien();
                    x.maNhanVien = tk.MaNhanVien;
                    x.hoTen = tk.HoTen;
                    x.sDT = tk.SDT;
                    x.mail = tk.Mail;
                    x.loaiTK = tk.ChucVu;
                    x.tenTK = tk.TenTaiKhoan;
                    x.matKhau = tk.MatKhau;
                    return x;
                }
                else
                    return null;
            }
            else
                return null;
        }

        public List<eTheLoai> GetAllTheLoai()
        {
            List<eTheLoai> lst = db.TheLoais.Select(t => new eTheLoai
            {
                maTheLoai = t.MaTheLoai,
                tenTheLoai = t.TenTheLoai
            }).ToList();
            return lst;
        }




        #endregion


        public bool AddHoaDon(eHoaDon x, List<eChiTietHoaDon> lst)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    HoaDon hoaDon = new HoaDon();
                    hoaDon.MaHoaDon = x.maHoaDon;
                    hoaDon.MaNhanVien = x.maNhanVien;
                    hoaDon.LoaiHoaDon = x.loaiHoaDon;
                    hoaDon.MaNhanVien = x.maNhanVien;
                    hoaDon.NgayLapHoaDon = x.ngayLapHD;
                    hoaDon.TongTien = x.tongTien;
                    int idCTHD = 1;
                    if (db.ChiTietHoaDons.Any())
                    {
                        idCTHD = db.ChiTietHoaDons.Max(a => a.MaChiTietHD) + 1;
                    }
                    foreach (eChiTietHoaDon item in lst)
                    {
                        ChiTietHoaDon cthd = new ChiTietHoaDon();
                        cthd.MaDia = item.maDia;
                        cthd.MaChiTietHD = idCTHD;
                        cthd.MaHoaDon = hoaDon.MaHoaDon;
                        cthd.SoLuong = item.soLuong;
                        cthd.HoaDon = hoaDon;
                        cthd.ThanhTien = item.thanhTien;
                        db.ChiTietHoaDons.Add(cthd);
                        if (x.loaiHoaDon == "Bán")
                        {
                            var dia = db.Dias.FirstOrDefault(s => s.MaDia == cthd.MaDia);
                            dia.SoLuong -= cthd.SoLuong;
                            db.Entry(dia).State = System.Data.Entity.EntityState.Modified;
                        }
                        else
                        {
                            var dia = db.Dias.FirstOrDefault(s => s.MaDia == cthd.MaDia);
                            dia.SoLuong += cthd.SoLuong;
                            db.Entry(dia).State = System.Data.Entity.EntityState.Modified;
                        }
                        idCTHD++;
                    }
                    db.HoaDons.Add(hoaDon);
                    db.SaveChanges();
                    scope.Complete();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }

        public List<eHoaDon> GetAllHoaDon()
        {
            List<eHoaDon> lst = db.HoaDons.Select(t => new eHoaDon
            {
                loaiHoaDon = t.LoaiHoaDon,
                maHoaDon = t.MaHoaDon,
                maNhanVien = t.MaNhanVien.Value,
                ngayLapHD = t.NgayLapHoaDon.Value,
                tongTien = t.TongTien.Value
            }).ToList();
            return lst;
        }



        public List<eChiTietHoaDon> GetAllChiTietHoaDon()
        {
            List<eChiTietHoaDon> lst = db.ChiTietHoaDons.Select(t => new eChiTietHoaDon
            {
                maCTHD = t.MaChiTietHD,
                maHoaDon = t.MaHoaDon.Value,
                maDia = t.MaDia.Value,
                soLuong = t.SoLuong.Value,
                thanhTien = t.ThanhTien.Value
            }).ToList();
            return lst;
        }
    }
}
