using ClothShop.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClothShop.BLL;
using System.Data.Entity;

namespace ClothShop.DAL
{
    internal class DAL_ClothShop
    {
        private QLShopCloth db = new QLShopCloth();
        public dynamic GetAllNV(string txt = "")
        {
            return (from p in db.NhanViens
                    where p.MaNV != "admin" && (p.MaNV.Contains(txt) || p.TenNV.Contains(txt) || p.DiaChi.Contains(txt) || p.ChucVu.Contains(txt) || p.SDT.Contains(txt))
                    let Gioitinh = (p.GioiTinh == true) ? "Nam" : "Nữ"
                    select new
                    {
                        p.MaNV,
                        p.TenNV,
                        p.ChucVu,
                        Gioitinh,
                        p.DiaChi,
                        p.SDT
                    }).ToList();
        }
        public dynamic GetAllNCC(string txt = "")
        {
            return db.NhaCungCaps.Where(p => p.MaNCC != "NCC0000000" && (p.MaNCC.Contains(txt) || p.TenNCC.Contains(txt) || p.DiaChi.Contains(txt) || p.SDT.Contains(txt) || p.Mail.Contains(txt)))
                                 .Select(p => new
                                 {
                                     p.MaNCC,
                                     p.TenNCC,
                                     p.DiaChi,
                                     p.SDT,
                                     p.Mail
                                 }).ToList();
        }

        public dynamic GetAllKH(string txt = "")
        {
            return (from p in db.KhachHangs
                    where p.MaKH != "KH00000000" && (p.MaKH.Contains(txt) || p.TenKH.Contains(txt) || p.SDT.Contains(txt) || p.DiaChi.Contains(txt))
                    let Gioitinh = (p.GioiTinh == true) ? "Nam" : "Nữ"
                    select new
                    {
                        p.MaKH,
                        p.TenKH,
                        Gioitinh,
                        p.DiaChi,
                        p.SDT
                    }).ToList();
        }

        public dynamic GetAllSP(string txt = "")
        {
            return (from p in db.SanPhams
                    where p.MaSP != "SP00000000" && (p.MaSP.Contains(txt) || p.TenSP.Contains(txt) || p.NhomSP.TenNhomSP.Contains(txt))
                    let SoLuong =
                    (
                        from q in db.CTSanPhams
                        where q.MaSP == p.MaSP
                        select (int?)q.SoLuong
                    ).Sum() ?? 0
                    select new
                    {
                        p.MaSP,
                        p.TenSP,
                        p.NhomSP.TenNhomSP,
                        p.GiaBan,
                        p.KhuyenMai,
                        SoLuong
                    }).ToList();
        }

        public dynamic GetAllNK(string txt = "")
        {
            return db.NhapKhos.Where(p => p.MaNK != "NK00000000" && p.MaNK.Contains(txt) || p.MaNCC.Contains(txt)
                                     || p.NhaCungCap.TenNCC.Contains(txt) || p.NguoiTao.TenNV.Contains(txt) || p.ID_NguoiTao.Contains(txt))
                              .Select(p => new
                              {
                                  p.MaNK,
                                  p.NhaCungCap.TenNCC,
                                  p.NguoiTao.TenNV,
                                  p.NgayTao
                              }).ToList();
        }

        public dynamic GetAllSPView(string txt = "")
        {
            return db.SanPhams.Where(p => p.MaSP != "SP00000000" && (p.MaSP.Contains(txt) || p.TenSP.Contains(txt) || p.NhomSP.TenNhomSP.Contains(txt)))
                              .Select(p => new
                              {
                                  p.MaSP,
                                  p.TenSP
                              }).ToList();
        }

        public dynamic GetAllKM(string txt = "")
        {
            return (from p in db.KhuyenMais
                    where p.MaKM.Contains(txt) || p.TenKM.Contains(txt) || p.MoTa.Contains(txt)
                    let NgayBatDau = p.NgayApDung
                    let NgayKetThuc = DbFunctions.AddDays(p.NgayApDung, p.HanSuDung - 1)
                    select new
                    {
                        p.MaKM,
                        p.TenKM,
                        p.MoTa,
                        p.GiaTri,
                        NgayBatDau,
                        NgayKetThuc
                    }).ToList();
        }

        public dynamic GetAllHD(string txt = "")
        {
            return (from p in db.HoaDons
                    where p.MaHD != "HD00000000" && (p.MaHD.Contains(txt) || p.KhachHang.TenKH.Contains(txt) ||
                                                     p.NguoiTao.TenNV.Contains(txt) || p.MaKM.Contains(txt) || p.KhuyenMai.TenKM.Contains(txt))
                    let SoLuong =
                    (
                        from q in db.CTHoaDons
                        where q.MaHD == p.MaHD
                        select (int?)q.SoLuong
                    ).Sum() ?? 0
                    let TongTien =
                    (from q in db.CTHoaDons
                     where q.MaHD == p.MaHD
                     select (int?)q.SoLuong * (q.GiaBan * (1 - q.KhuyenMai)) // Khuyen mai theo sanpham
                    ).Sum() ?? 0
                    let KM = (p.GiaTriKM * 100).ToString() + "%"
                    let ThanhTien = TongTien * (1 - p.GiaTriKM) // khuyen mai theo chuong trinh
                    select new { p.MaHD, p.KhachHang.TenKH, p.NguoiTao.TenNV, p.NgayTao, p.KhuyenMai.TenKM, KM, SoLuong, TongTien, ThanhTien }
                    ).ToList();
        }

        public dynamic GetNVByMaNV(string MaNV)
        {
            NhanVien s = db.NhanViens.Find(MaNV);
            return s;
        }
        public KhachHang GetKHByMaKH(string MaKH)
        {
            KhachHang kh = db.KhachHangs.Find(MaKH);
            return kh;
        }

        public KhuyenMai GetKMByMaKM(string MaKM)
        {
            KhuyenMai km = db.KhuyenMais.Find(MaKM);
            return km;
        }

        public string GetKHBySDT(string SDT)
        {
            foreach (var i in (db.KhachHangs.Where(p => p.SDT == SDT)).Select(p => p).ToList())
            {
                return i.MaKH;
            }
            return null;
        }
        public dynamic GetNKByMaNK(string MaNK)
        {
            NhapKho s = db.NhapKhos.Find(MaNK);
            return s;
        }

        public string GetNCCBySDT(string SDT)
        {
            foreach (var i in (db.NhaCungCaps.Where(p => p.SDT == SDT)).Select(p => p).ToList())
            {
                return i.MaNCC;
            }
            return null;
        }

        public string GetRandom()
        {
            Random rd = new Random();
            string rand = "";
            rand = rd.Next(0, 99999999).ToString();
            for (int i = 0; i < (8 - rand.Length); i++)
                rand = "0" + rand;
            return rand;
        }

        public CTSanPham GetCTSPByMaCTSP(string MaCTSP)
        {
            CTSanPham s = db.CTSanPhams.Find(MaCTSP);
            return s;
        }

        public SanPham GetSPByMaSP(string MaSP)
        {
            SanPham s = db.SanPhams.Find(MaSP);
            return s;
        }

        public CTNhapKho GetCTNKByMaCTNK(string MaCTNK)
        {
            CTNhapKho s = db.CTNhapKhos.Find(MaCTNK);
            return s;
        }

        public NhaCungCap GetNCCByMaNCC(string MaNCC)
        {
            NhaCungCap s = db.NhaCungCaps.Find(MaNCC);
            return s;
        }
        public HoaDon GetHDByMaHD(string MaHD)
        {
            HoaDon temp = db.HoaDons.Find(MaHD);
            return temp;
        }
        public CTHoaDon GetCTHDByMaCTHD(string MaCTHD)
        {
            CTHoaDon temp = db.CTHoaDons.Find(MaCTHD);
            return temp;
        }

        public dynamic GetCTSPByMaSP(string MaSP, string size, string mausac)
        {
            if (size == "All" && mausac == "All")
            {
                return (from p in db.CTSanPhams
                        where p.MaSP == MaSP
                        let SoLuongNhap =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.SoLuong
                        ).Sum() ?? 0
                        let GiaNhapTB =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.GiaNhap * q.SoLuong
                        ).Sum() / SoLuongNhap ?? 0
                        select new { p.MaCTSP, p.Size, p.MauSac, p.SoLuong, GiaNhapTB }).ToList();
            }
            else if (size == "All" && mausac != "All")
            {
                return (from p in db.CTSanPhams
                        where p.MaSP == MaSP && p.MauSac == mausac
                        let SoLuongNhap =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.SoLuong
                        ).Sum() ?? 0
                        let GiaNhapTB =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.GiaNhap * q.SoLuong
                        ).Sum() / SoLuongNhap ?? 0
                        select new { p.MaCTSP, p.Size, p.MauSac, p.SoLuong, GiaNhapTB }).ToList();
            }
            else if (size != "All" && mausac == "All")
            {
                return (from p in db.CTSanPhams
                        where p.MaSP == MaSP && p.Size == size
                        let SoLuongNhap =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.SoLuong
                        ).Sum() ?? 0
                        let GiaNhapTB =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.GiaNhap * q.SoLuong
                        ).Sum() / SoLuongNhap ?? 0
                        select new { p.MaCTSP, p.Size, p.MauSac, p.SoLuong, GiaNhapTB }).ToList();
            }
            else
            {
                return (from p in db.CTSanPhams
                        where p.MaSP == MaSP && p.Size == size && p.MauSac == mausac
                        let SoLuongNhap =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.SoLuong
                        ).Sum() ?? 0
                        let GiaNhapTB =
                        (
                            from q in db.CTNhapKhos
                            where q.MaCTSP == p.MaCTSP
                            select (int?)q.GiaNhap * q.SoLuong
                        ).Sum() / SoLuongNhap ?? 0
                        select new { p.MaCTSP, p.Size, p.MauSac, p.SoLuong, GiaNhapTB }).ToList();
            }
        }

        public dynamic GetCTNKByMaNK(string MaNK)
        {
            return db.CTNhapKhos.Where(p => p.MaNK == MaNK).Select(p => new
            {
                p.MaCTNK,
                p.CTSanPham.SanPham.TenSP,
                p.CTSanPham.Size,
                p.CTSanPham.MauSac,
                p.GiaNhap,
                p.SoLuong
            }).ToList();
        }

        public dynamic GetCTHDByMaHD(string MaHD)
        {
            return (from p in db.CTHoaDons
                    where p.MaHD == MaHD
                    select new
                    {
                        p.MaCTHD,
                        p.CTSanPham.SanPham.TenSP,
                        p.CTSanPham.Size,
                        p.CTSanPham.MauSac,
                        p.GiaBan,
                        p.SoLuong,
                        p.KhuyenMai,
                        ThanhTien = p.SoLuong * (p.GiaBan * (1 - p.KhuyenMai))
                    }).ToList();
        }

        public dynamic GetAllCTNK()
        {
            return db.CTNhapKhos.Select(p => p).ToList();
        }

        public dynamic GetAllCTHD()
        {
            return db.CTHoaDons.Select(p => p).ToList();
        }

        public List<string> GetCBBSizeByMaSP(string MaSP)
        {
            List<string> size = new List<string>();
            foreach (var i in db.CTSanPhams)
            {
                if (i.MaSP == MaSP)
                {
                    bool check = false;
                    foreach (string j in size)
                    {
                        if (j == i.Size) check = true;
                    }
                    if (check == false) size.Add(i.Size);
                }
            }
            return size;
        }

        public List<string> GetCBBMauByMaSP(string MaSP)
        {
            List<string> mau = new List<string>();
            foreach (var i in db.CTSanPhams)
            {
                if (i.MaSP == MaSP)
                {
                    bool check = false;
                    foreach (string j in mau)
                    {
                        if (j == i.MauSac) check = true;
                    }
                    if (check == false) mau.Add(i.MauSac);
                }
            }
            return mau;
        }

        public NhomSP GetNhomSPByID(int ID_NhomSP)
        {
            NhomSP s = db.NhomSPs.Find(ID_NhomSP);
            return s;
        }

        public NhomSP GetNhomSPByName(string name)
        {
            foreach (NhomSP i in db.NhomSPs)
            {
                if (i.TenNhomSP == name) return i;
            }
            return null;
        }

        public dynamic GetSPTonKho(int thoiGian, double tiLe)
        {
            return (from p in db.SanPhams
                    let TGTonKho =
                    (
                        from q in db.CTNhapKhos
                        where q.CTSanPham.MaSP == p.MaSP
                        select (int?)DbFunctions.DiffDays(q.NhapKho.NgayTao, DateTime.Now)
                    ).Min() ?? 0
                    let SLBan =
                    (
                        from q in db.CTHoaDons
                        where q.CTSanPham.MaSP == p.MaSP && DbFunctions.DiffDays(q.HoaDon.NgayTao, DateTime.Now) <= TGTonKho
                        select (int?)q.SoLuong
                    ).Sum() ?? 0
                    let SLNhap =
                    (
                        from q in db.CTNhapKhos
                        where q.CTSanPham.MaSP == p.MaSP
                        select (int?)q.SoLuong
                    ).Sum() ?? 0
                    let SLBanKyTruoc =
                    (
                        from q in db.CTHoaDons
                        where q.CTSanPham.MaSP == p.MaSP && DbFunctions.DiffDays(q.HoaDon.NgayTao, DateTime.Now) > TGTonKho
                        select (int?)q.SoLuong
                    ).Sum() ?? 0
                    let TiLeBan = Math.Round((double)SLBan / (SLNhap - SLBanKyTruoc) * 100, 2)
                    where TGTonKho > thoiGian && TiLeBan < tiLe
                    select new { p.MaSP, p.TenSP, p.KhuyenMai, TGTonKho, TiLeBan }).ToList();
        }

        public bool CheckLogin(string MaNV, string MK)
        {
            NhanVien s = GetNVByMaNV(MaNV);
            return s != null && s.MatKhau == MK;
        }

        public int CheckChucVu(string MaNV)
        {
            if (GetNVByMaNV(MaNV) != null)
            {
                if (GetNVByMaNV(MaNV).ChucVu == "Admin") return 0;
                else if (GetNVByMaNV(MaNV).ChucVu == "Thu Ngân") return 1;
                else if (GetNVByMaNV(MaNV).ChucVu == "Bán Hàng") return 2;
                else if (GetNVByMaNV(MaNV).ChucVu == "Nhập Kho") return 3;
                else return -1;
            }
            else return -1;
        }

        public List<CBBNhomSP> GetAllNhomSP()
        {
            List<CBBNhomSP> data = new List<CBBNhomSP>();
            foreach (NhomSP i in db.NhomSPs)
            {
                data.Add(new CBBNhomSP
                {
                    Value = i.ID_NhomSP,
                    Text = i.TenNhomSP
                });
            }
            return data;
        }
        public void AddCTSP(string MaSP, string size, string mausac)
        {
            Random rd = new Random();
            string rand;
            do
            {
                rand = "";
                rand = rd.Next(0, 99999999).ToString();
                for (int i = 0; i < (8 - rand.Length); i++)
                    rand = "0" + rand;
                rand = "CS" + rand;
            }
            while (BLL_ClothShop.Instance.GetCTSPByMaCTSP(rand) != null);
            CTSanPham s = new CTSanPham
            {
                MaCTSP = "AO" + rand.Substring(2),
                Size = size,
                MauSac = mausac,
                MaSP = MaSP,
                SoLuong = 0
            };
            AddUpdateCTSP(s);
        }
        public void AddUpdateCTSP(CTSanPham s)
        {
            CTSanPham x = db.CTSanPhams.Find(s.MaCTSP);
            if (x == null)
            {
                db.CTSanPhams.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.MaSP = s.MaSP;
                x.Size = s.Size;
                x.MauSac = s.MauSac;
                x.SoLuong = s.SoLuong;
                db.SaveChanges();
            };
        }

        public void AddNhomSP(NhomSP s)
        {
            NhomSP x = db.NhomSPs.Find(s.ID_NhomSP);
            if (x == null)
            {
                NhomSP c = new NhomSP
                {
                    ID_NhomSP = 0,
                    TenNhomSP = s.TenNhomSP
                };
                db.NhomSPs.Add(c);
                db.SaveChanges();
            }
            else
            {
                x.TenNhomSP = s.TenNhomSP;
                db.SaveChanges();
            }
        }

        public void AddUpdateSP(SanPham s)
        {
            SanPham x = db.SanPhams.Find(s.MaSP);
            if (x == null)
            {
                db.SanPhams.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.TenSP = s.TenSP;
                x.ID_NhomSP = s.ID_NhomSP;
                x.GiaBan = s.GiaBan;
                x.KhuyenMai = s.KhuyenMai;
                db.SaveChanges();
            }
        }

        public void AddUpdateKM(KhuyenMai km)
        {
            KhuyenMai k = db.KhuyenMais.Find(km.MaKM);
            if (k == null)
            {
                db.KhuyenMais.Add(km);
                db.SaveChanges();
            }
            else
            {
                k.TenKM = km.TenKM;
                k.GiaTri = km.GiaTri;
                k.HanSuDung = km.HanSuDung;
                k.MoTa = km.MoTa;
                db.SaveChanges();
            }
        }

        public void AddUpdateNV(NhanVien s)
        {
            NhanVien x = db.NhanViens.Find(s.MaNV);
            if (x == null)
            {
                db.NhanViens.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.TenNV = s.TenNV;
                x.ChucVu = s.ChucVu;
                x.SDT = s.SDT;
                x.DiaChi = s.DiaChi;
                x.GioiTinh = s.GioiTinh;
                x.MatKhau = s.MatKhau;
                db.SaveChanges();
            }
        }

        public void AddUpdateNK(NhapKho s)
        {
            NhapKho x = db.NhapKhos.Find(s.MaNK);
            if (x == null)
            {
                db.NhapKhos.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.MaNCC = s.MaNCC;
                x.ID_NguoiTao = s.ID_NguoiTao;
                x.ID_NguoiSua = s.ID_NguoiSua;
                x.NgayTao = s.NgayTao;
                x.NgaySua = s.NgaySua;
                db.SaveChanges();
            }
        }

        public void AddUpdateCTNK(CTNhapKho s)
        {
            CTNhapKho x = db.CTNhapKhos.Find(s.MaCTNK);
            if (x == null)
            {
                db.CTNhapKhos.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.MaCTSP = s.MaCTSP;
                x.SoLuong = s.SoLuong;
                x.GiaNhap = s.GiaNhap;
                x.MaNK = s.MaNK;
                db.SaveChanges();
            }
        }
        public void AddUpdateKH(KhachHang kh)
        {
            KhachHang temp = db.KhachHangs.Find(kh.MaKH);
            if (temp == null)
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }
            else
            {
                temp.TenKH = kh.TenKH;
                temp.NgaySinh = kh.NgaySinh;
                temp.GioiTinh = kh.GioiTinh;
                temp.DiaChi = kh.DiaChi;
                temp.SDT = kh.SDT;
                db.SaveChanges();
            }
        }

        public void AddUpdateHD(HoaDon s)
        {
            HoaDon x = db.HoaDons.Find(s.MaHD);
            if (x == null)
            {
                db.HoaDons.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.MaKM = s.MaKM;
                x.GiaTriKM = s.GiaTriKM;
                x.MaKH = s.MaKH;
                x.ID_NguoiTao = s.ID_NguoiTao;
                x.ID_NguoiSua = s.ID_NguoiSua;
                x.NgaySua = s.NgaySua;
                x.NgayTao = s.NgayTao;
            }
        }

        public void AddUpdateNCC(NhaCungCap ncc)
        {
            NhaCungCap temp = db.NhaCungCaps.Find(ncc.MaNCC);
            if (temp == null)
            {
                db.NhaCungCaps.Add(ncc);
                db.SaveChanges();
            }
            else
            {
                temp.TenNCC = ncc.TenNCC;
                temp.DiaChi = ncc.DiaChi;
                temp.SDT = ncc.SDT;
                temp.Mail = ncc.Mail;
                db.SaveChanges();
            }
        }

        public void AddUpdateCTHD(CTHoaDon s)
        {
            CTHoaDon x = db.CTHoaDons.Find(s.MaCTHD);
            if (x == null)
            {
                db.CTHoaDons.Add(s);
                db.SaveChanges();
            }
            else
            {
                x.MaCTSP = s.MaCTSP;
                x.SoLuong = s.SoLuong;
                x.GiaBan = s.GiaBan;
                x.MaHD = s.MaHD;
                db.SaveChanges();
            }
        }

        public void CopySP(string MaSP)
        {
            foreach (var i in GetCTSPByMaSP(MaSP, "All", "All"))
            {
                CTSanPham s = db.CTSanPhams.Find(i.MaCTSP);
                db.CTSanPhams.Add(new CTSanPham
                {
                    MaCTSP = "AO" + s.MaCTSP.Substring(2),
                    MaSP = "SP00000000",
                    Size = s.Size,
                    MauSac = s.MauSac,
                    SoLuong = s.SoLuong,
                });
                db.SaveChanges();
            }
        }

        public void PasteSP(string MaSP)
        {
            foreach (var i in GetCTSPByMaSP(MaSP, "All", "All"))
            {
                CTSanPham s = db.CTSanPhams.Find(i.MaCTSP);
                if (db.CTSanPhams.Find("AO" + s.MaCTSP.Substring(2)) == null)
                {
                    db.CTSanPhams.Remove(s);
                }
                db.SaveChanges();
            }
            foreach (var i in GetCTSPByMaSP("SP00000000", "All", "All"))
            {
                CTSanPham s = db.CTSanPhams.Find(i.MaCTSP);
                CTSanPham x = db.CTSanPhams.Find("CS" + i.MaCTSP.Substring(2));
                if (x == null)
                {
                    x = new CTSanPham
                    {
                        MaCTSP = "CS" + i.MaCTSP.Substring(2),
                        MaSP = MaSP,
                        Size = s.Size,
                        SoLuong = 0,
                        MauSac = s.MauSac,
                    };
                    db.CTSanPhams.Add(x);
                }
                else
                {
                    x.Size = s.Size;
                    x.MauSac = s.MauSac;
                }
                db.CTSanPhams.Remove(s);
                db.SaveChanges();
            }
        }

        public void CopyNK(string MaNK)
        {
            foreach (var i in GetCTNKByMaNK(MaNK))
            {
                CTNhapKho s = db.CTNhapKhos.Find(i.MaCTNK);
                db.CTNhapKhos.Add(new CTNhapKho
                {
                    MaCTNK = "AO" + s.MaCTNK.Substring(2),
                    MaCTSP = s.MaCTSP,
                    GiaNhap = s.GiaNhap,
                    MaNK = "NK00000000",
                    SoLuong = s.SoLuong
                });
                db.SaveChanges();
            }
        }

        public void PasteNK(string MaNK)
        {
            foreach (var i in GetCTNKByMaNK(MaNK))
            {
                CTNhapKho s = db.CTNhapKhos.Find(i.MaCTNK);
                if (db.CTNhapKhos.Find("AO" + s.MaCTNK.Substring(2)) == null)
                {
                    CTSanPham p = db.CTSanPhams.Find(s.MaCTSP);
                    p.SoLuong -= s.SoLuong;
                    db.CTNhapKhos.Remove(s);
                    db.SaveChanges();
                }
            }
            foreach (var i in GetCTNKByMaNK("NK00000000"))
            {
                CTNhapKho s = db.CTNhapKhos.Find(i.MaCTNK);
                CTNhapKho x = db.CTNhapKhos.Find("CN" + i.MaCTNK.Substring(2));
                CTSanPham p = db.CTSanPhams.Find(s.MaCTSP);
                p.SoLuong += s.SoLuong;
                db.SaveChanges();
                if (x == null)
                {
                    x = new CTNhapKho
                    {
                        MaCTNK = "CN" + i.MaCTNK.Substring(2),
                        MaCTSP = s.MaCTSP,
                        MaNK = MaNK,
                        SoLuong = s.SoLuong,
                        GiaNhap = s.GiaNhap,
                    };
                    db.CTNhapKhos.Add(x);
                }
                else
                {
                    p = db.CTSanPhams.Find(s.MaCTSP);
                    p.SoLuong -= x.SoLuong;
                    db.SaveChanges();
                    x.MaCTSP = s.MaCTSP;
                    x.SoLuong = s.SoLuong;
                    x.GiaNhap = s.GiaNhap;
                }
                db.CTNhapKhos.Remove(s);
                db.SaveChanges();
            }
        }

        public void CopyHD(string MaHD)
        {
            foreach (var i in GetCTHDByMaHD(MaHD))
            {
                CTHoaDon temp = db.CTHoaDons.Find(i.MaCTHD);
                db.CTHoaDons.Add(new CTHoaDon
                {
                    MaCTHD = "AO" + temp.MaCTHD.Substring(2),
                    MaHD = "HD00000000",
                    MaCTSP = temp.MaCTSP,
                    GiaBan = temp.GiaBan,
                    SoLuong = temp.SoLuong,
                    KhuyenMai = temp.KhuyenMai
                });
                db.SaveChanges();
            }
        }

        public void PasteHD(string MaHD)
        {
            foreach (var i in GetCTHDByMaHD(MaHD))
            {
                CTHoaDon temp = db.CTHoaDons.Find(i.MaCTHD);
                if (db.CTHoaDons.Find("AO" + temp.MaCTHD.Substring(2)) == null)
                {
                    db.CTHoaDons.Remove(temp);
                }
                db.SaveChanges();
            }

            foreach (var i in GetCTHDByMaHD("HD00000000"))
            {
                CTHoaDon temp = db.CTHoaDons.Find(i.MaCTHD);
                CTHoaDon main = db.CTHoaDons.Find("CH" + i.MaCTHD.Substring(2));
                CTSanPham p = db.CTSanPhams.Find(temp.MaCTSP);
                p.SoLuong -= temp.SoLuong;
                db.SaveChanges();
                if (main == null)
                {
                    main = new CTHoaDon
                    {
                        MaCTHD = "CH" + i.MaCTHD.Substring(2),
                        MaCTSP = temp.MaCTSP,
                        MaHD = MaHD,
                        SoLuong = temp.SoLuong,
                        GiaBan = temp.GiaBan,
                        KhuyenMai = temp.KhuyenMai
                    };
                    db.CTHoaDons.Add(main);
                }
                else
                {
                    p = db.CTSanPhams.Find(temp.MaCTSP);
                    p.SoLuong += main.SoLuong;
                    db.SaveChanges();
                    main.MaCTSP = temp.MaCTSP;
                    main.SoLuong = temp.SoLuong;
                    main.GiaBan = temp.GiaBan;
                    main.KhuyenMai = temp.KhuyenMai;
                }
                db.CTHoaDons.Remove(temp);
                db.SaveChanges();
            }
        }
        public bool CheckDelSize(string MaSP, string Size) // Kiểm tra có thể xóa size
        {
            foreach (var i in GetCTSPByMaSP(MaSP, Size, "All"))
            {
                foreach (var j in GetAllCTHD())
                    if (j.MaCTSP == "CS" + i.MaCTSP.Substring(2)) return false; // check MaCTSP chưa đc sử dụng trong CTHD
                foreach (var j in GetAllCTNK())
                    if (j.MaCTSP == "CS" + i.MaCTSP.Substring(2)) return false; // check MaCTSP chưa đc sử dụng trong CTNK
            }
            return true;
        }
        public bool CheckDelMau(string MaSP, string Mau) // Kiểm tra có thể xóa màu
        {
            foreach (var i in GetCTSPByMaSP(MaSP, "All", Mau))
            {
                foreach (var j in GetAllCTHD()) // check MaCTSP chưa đc sử dụng trong CTHD
                    if (j.MaCTSP == "CS" + i.MaCTSP.Substring(2)) return false;
                foreach (var j in GetAllCTNK()) // check MaCTSP chưa đc sử dụng trong CTNK
                    if (j.MaCTSP == "CS" + i.MaCTSP.Substring(2)) return false;
            }
            return true;
        }
        public bool CheckDelSP(string MaSP) // Kiểm tra có thể xóa sản phẩm
        {
            foreach (var i in GetCTSPByMaSP(MaSP, "All", "All"))
            {
                foreach (var j in GetAllCTNK()) // check MaCTSP chưa đc sử dụng trong CTNK
                    if (j.MaCTSP == "CS" + i.MaCTSP.Substring(2)) return false;
            }
            return true;
        }

        public bool CheckDelKM(string MaKM) // Chỉ có thể xóa KhuyenMai khi chưa áp dụng trong bảng hóa đơn
        {
            foreach (HoaDon i in db.HoaDons)
            {
                if (i.MaKM == MaKM)
                {
                    return false; // MaKM đã được áp dụng => xóa thì sẽ liên quan đến thuộc tính khóa ngoại bảng HoaDon
                }
            }
            return true;
        }

        public bool CheckDelKH(string MaKH) // Chỉ có thể xóa KhachHang khi chưa áp dụng trong bảng hóa đơn
        {
            foreach (HoaDon i in db.HoaDons)
            {
                if (i.MaKH == MaKH)
                {
                    return false; // MaKH đã được áp dụng trong bảng HoaDon
                }
            }
            return true;
        }
        public bool CheckDelNCC(string MaNCC) // Chỉ có thể xóa NCC khi chưa áp dụng trong bảng nhập kho
        {
            foreach (NhapKho i in db.NhapKhos)
            {
                if (i.MaNCC == MaNCC)
                {
                    return false; // MaNCC đã được áp dụng trong bảng NhapKho
                }
            }
            return true;
        }

        public void DelNV(string MaNV)
        {
            NhanVien s = db.NhanViens.Find(MaNV);
            db.NhanViens.Remove(s);
            db.SaveChanges();
        }

        public void DelSP(string MaSP)
        {
            foreach (CTSanPham i in db.CTSanPhams)
            {
                if (i.MaSP == MaSP)
                {
                    db.CTSanPhams.Remove(i);
                }
            }
            db.SaveChanges();
            SanPham s = db.SanPhams.Find(MaSP);
            db.SanPhams.Remove(s);
            db.SaveChanges();
        }
        public void DelCTSP(string MaCTSP)
        {
            CTSanPham s = db.CTSanPhams.Find(MaCTSP);
            db.CTSanPhams.Remove(s);
            db.SaveChanges();
        }

        public void DelCTHD(string MaCTHD)
        {
            CTHoaDon s = db.CTHoaDons.Find(MaCTHD);
            db.CTHoaDons.Remove(s);
            db.SaveChanges();
        }

        public void DelKM(string MaKM)
        {
            KhuyenMai km = db.KhuyenMais.Find(MaKM);
            db.KhuyenMais.Remove(km);
            db.SaveChanges();
        }

        public void DelCTNK(string MaCTNK)
        {
            CTNhapKho s = db.CTNhapKhos.Find(MaCTNK);
            db.CTNhapKhos.Remove(s);
            db.SaveChanges();
        }

        public void DelNK(string MaNK)
        {
            foreach (CTNhapKho i in db.CTNhapKhos)
            {
                if (i.MaNK == MaNK)
                {
                    CTSanPham p = db.CTSanPhams.Find(i.MaCTSP);
                    p.SoLuong -= i.SoLuong;
                    db.CTNhapKhos.Remove(i);
                }
            }
            db.SaveChanges();
            NhapKho s = db.NhapKhos.Find(MaNK);
            db.NhapKhos.Remove(s);
            db.SaveChanges();
        }

        public void DelKH(string MaKH)
        {
            foreach (HoaDon i in db.HoaDons)
            {
                if (i.MaKH == MaKH)
                {
                    i.MaKH = "KH00000000";
                    db.SaveChanges();
                }
            }
            KhachHang kh = db.KhachHangs.Find(MaKH);
            db.KhachHangs.Remove(kh);
            db.SaveChanges();
        }

        public void DelNCC(string MaNCC)
        {
            foreach (NhapKho i in db.NhapKhos)
            {
                if (i.MaNCC == MaNCC)
                {
                    i.MaNCC = "NCC0000000";
                    db.SaveChanges();
                }
            }
            NhaCungCap ncc = db.NhaCungCaps.Find(MaNCC);
            db.NhaCungCaps.Remove(ncc);
            db.SaveChanges();
        }

        public void DelHD(string MaHD)
        {
            foreach (CTHoaDon i in db.CTHoaDons)
            {
                if (i.MaHD == MaHD)
                {
                    CTSanPham p = db.CTSanPhams.Find(i.MaCTSP);
                    p.SoLuong += i.SoLuong;
                    db.CTHoaDons.Remove(i);
                }
            }
            db.SaveChanges();
            HoaDon s = db.HoaDons.Find(MaHD);
            db.HoaDons.Remove(s);
            db.SaveChanges();
        }

        public int GetSoLuongNK(string MaNK)
        {
            int SoLuong = 0;
            foreach (var i in GetCTNKByMaNK(MaNK))
            {
                SoLuong += i.SoLuong;
            }
            return SoLuong;
        }

        public int GetTongNK(string MaNK)
        {
            int Tong = 0;
            foreach (var i in GetCTNKByMaNK(MaNK))
            {
                Tong += i.SoLuong * i.GiaNhap;
            }
            return Tong;
        }
        public int GetSoLuongHD(string MaHD)
        {
            int SoLuong = 0;
            foreach (var i in GetCTHDByMaHD(MaHD))
            {
                SoLuong += i.SoLuong;
            }
            return SoLuong;
        }
        public int GetTongHD(string MaHD)
        {
            int Tong = 0;
            foreach (var i in GetCTHDByMaHD(MaHD))
            {
                Tong += i.ThanhTien;
            }
            return Tong;
        }

        public int GetSLSPBan(DateTime batdau, DateTime ketthuc)
        {
            int Tong = 0;
            foreach (var i in GetAllHD())
            {
                if (i.NgayTao >= batdau && i.NgayTao <= ketthuc)
                {
                    Tong += i.SoLuong;
                }
            }
            return Tong;
        }

        public int GetSLHoaDon(DateTime batdau, DateTime ketthuc)
        {
            int Tong = 0;
            foreach (var i in GetAllHD())
            {
                if (i.NgayTao >= batdau && i.NgayTao <= ketthuc)
                {
                    Tong++;
                }
            }
            return Tong;
        }

        public int GetDoanhSo(DateTime batdau, DateTime ketthuc)
        {
            int Tong = 0;
            foreach (var i in GetAllHD())
            {
                if (i.NgayTao >= batdau && i.NgayTao <= ketthuc)
                {
                    Tong += i.ThanhTien;
                }
            }
            return Tong;
        }

        public double GetLoiNhuan(DateTime batdau, DateTime ketthuc)
        {
            double Tong = (double)GetDoanhSo(batdau, ketthuc);
            foreach (CTHoaDon i in db.CTHoaDons)
            {
                if (i.HoaDon.NgayTao >= batdau && i.HoaDon.NgayTao <= ketthuc)
                {
                    Tong -= i.SoLuong * GetCTSPByMaSP(i.CTSanPham.MaSP, i.CTSanPham.Size, i.CTSanPham.MauSac)[0].GiaNhapTB;
                }
            }
            return Tong;
        }

        public List<int> GetDS12m()
        {
            List<int> s = new List<int>();
            int monthNow = DateTime.Now.Month;
            for (int i = 11; i >= 0; i--)
            {
                DateTime startDay, endDay;
                if (monthNow <= i) startDay = new DateTime(DateTime.Now.Year - 1, monthNow + 12 - i, 1); // 2022/6/1
                else startDay = new DateTime(DateTime.Now.Year, monthNow - i, 1); // 
                if (monthNow <= i - 1) endDay = new DateTime(DateTime.Now.Year - 1, monthNow + 13 - i, 1).AddDays(-1); //2022/6/31
                else endDay = new DateTime(DateTime.Now.Year, monthNow - i + 1, 1).AddDays(-1);
                s.Add(GetDoanhSo(startDay, endDay));
            }
            return s;
        }

        public double[] GetDSTheoNhomSP()
        {
            double[] s = new double[db.NhomSPs.Count()];
            int sum = 0;
            foreach (CTHoaDon i in db.CTHoaDons)
            {
                s[i.CTSanPham.SanPham.ID_NhomSP - 1] += i.GiaBan * i.SoLuong;
                sum += (int)i.GiaBan * i.SoLuong;  // Tổng bán được của tất cả nhóm SP
            }
            for (int i = 0; i < db.NhomSPs.Count(); i++)
            {
                s[i] = s[i] * 100 / sum;
            }
            return s;
        }

        public dynamic GetTopDoanhSoSP(DateTime batdau, DateTime ketthuc)
        {
            return (from p in db.SanPhams
                    let DoanhSo =
                    (
                        from q in db.CTHoaDons
                        where q.HoaDon.NgayTao >= batdau && q.HoaDon.NgayTao <= ketthuc && q.CTSanPham.MaSP == p.MaSP
                        select (int?)q.GiaBan * q.SoLuong * (1 - q.KhuyenMai)
                    ).Sum() ?? 0
                    where DoanhSo != 0
                    orderby DoanhSo descending
                    select new { p.TenSP, DoanhSo }).Take(5).ToList();
        }

        public dynamic GetTopSoLuongSP(DateTime batdau, DateTime ketthuc)
        {
            return (from p in db.SanPhams
                    let SoLuong =
                    (
                        from q in db.CTHoaDons
                        where q.HoaDon.NgayTao >= batdau && q.HoaDon.NgayTao <= ketthuc && q.CTSanPham.MaSP == p.MaSP
                        select (int?)q.SoLuong
                    ).Sum() ?? 0
                    where SoLuong != 0
                    orderby SoLuong descending
                    select new { p.TenSP, SoLuong }).Take(5).ToList();
        }

        public dynamic GetTopKH(DateTime batdau, DateTime ketthuc)
        {
            return (from p in db.KhachHangs
                    let TongMua =
                    (
                        from q in db.HoaDons
                        where q.NgayTao >= batdau && q.NgayTao <= ketthuc && q.MaKH == p.MaKH
                        let TongTien =
                        (
                            from n in db.CTHoaDons
                            where n.MaHD == q.MaHD
                            select (int?)n.SoLuong * n.GiaBan * (1 - n.KhuyenMai)
                        ).Sum() ?? 0
                        let ThanhTien = TongTien * (1 - q.GiaTriKM)
                        select (int?)ThanhTien
                    ).Sum() ?? 0
                    where p.MaKH != "KH00000000" && TongMua != 0
                    orderby TongMua descending
                    select new { p.TenKH, TongMua }).Take(5).ToList();
        }

        public bool CheckDelNV(string MaNV)
        {
            NhanVien s = db.NhanViens.Find(MaNV);
            foreach (HoaDon i in db.HoaDons)
            {
                if (i.ID_NguoiSua == MaNV || i.ID_NguoiTao == MaNV)
                    return false;
            }
            foreach (NhapKho i in db.NhapKhos)
            {
                if (i.ID_NguoiSua == MaNV || i.ID_NguoiTao == MaNV)
                    return false;
            }
            return true;
        }
        public void ResetMKNV(string MaNV)
        {
            NhanVien s = db.NhanViens.Find(MaNV);
            if (s != null)
            {
                s.MatKhau = "123456";
                db.SaveChanges();
            }
        }
        public int CheckNum(string txt) // kiểm tra chuỗi nhập vào có phải số hợp lệ
                                        // -1: xâu rỗng
                                        //  0: xâu = 0
                                        //  1: xâu không hợp lệ
                                        //  2: xâu hợp lệ
        {
            if (txt == "" || txt == null) return -1;
            if (Convert.ToInt32(txt) == 0) return 0;
            foreach (char i in txt)
            {
                if ((i < '0') || (i > '9')) return 1;
            }
            return 2;
        }
    }
}
