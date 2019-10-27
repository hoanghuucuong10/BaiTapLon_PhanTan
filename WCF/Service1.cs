﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using DAL;
namespace WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        BanDiaPhanTanEntities db = new BanDiaPhanTanEntities();

        public bool AddDia(eDia dia)
        {
            throw new NotImplementedException();
        }
        public bool DeleteNhanVien(eNhanVien nv)
        {
            throw new NotImplementedException();
        }
        public bool EditDia(eDia dia)
        {
            throw new NotImplementedException();
        }
        public List<eDia> GetAllDia(string id, string name, string theLoai)
        {
            List<eDia> lst = db.Dias.Where(x => x.MaDia.ToString().Contains(id) && x.TenDia.Contains(name)&&(x.TheLoai.TenTheLoai==theLoai || theLoai=="")).Select(t => new eDia
            {
                maDia = t.MaDia,
                tenDia = t.TenDia,
                tenTheLoai = t.TheLoai.TenTheLoai,
                maTheLoai = t.MaTheLoai.Value,
                soLuong = t.SoLuong.Value,
                donGia = t.DonGia.Value,
                HinhAnh = t.HinhAnh,
                theLoai = new eTheLoai { maTheLoai = t.MaTheLoai.Value, tenTheLoai = t.TheLoai.TenTheLoai }
            }).ToList();
            return lst;
        }
        public List<eDia> GetAllDiaTheLoai(string theloai)
        {
            List<eDia> lst = db.Dias.Where(x => x.TheLoai.ToString()==theloai).Select(t => new eDia
            {
                maDia=t.MaDia,
                tenDia=t.TenDia,
                tenTheLoai=t.TheLoai.TenTheLoai,
                maTheLoai=t.MaTheLoai.Value,
                soLuong=t.SoLuong.Value,
                donGia=t.DonGia.Value,
                HinhAnh=t.HinhAnh,
                theLoai= new eTheLoai { maTheLoai=t.MaTheLoai.Value,tenTheLoai=t.TheLoai.TenTheLoai}
                
            }).ToList();
            return lst;
        }
        #region NhanVien
        public bool EditNhanVien(eNhanVien nv)
        {
            throw new NotImplementedException();
        }
        public bool AddNhanVien(eNhanVien nv)
        {
            throw new NotImplementedException();
        }
        public List<eNhanVien> GetAllNhanVien(string id, string name)
        {
            List<eNhanVien> lst = db.NhanViens.Where(x => x.MaNhanVien.ToString().Contains(id)&&x.HoTen.Contains(name)).Select(t => new eNhanVien
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

        public eDia GetDiaByID(string id)
        {
            throw new NotImplementedException();
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

        public List<eDia> GetAllDia(string id, string name, string theLoai)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}