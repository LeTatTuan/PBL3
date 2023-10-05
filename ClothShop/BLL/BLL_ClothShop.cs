using ClothShop.DAL;
using ClothShop.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.RegularExpressions;


namespace ClothShop.BLL
{
    internal class BLL_ClothShop
    {
        DAL_ClothShop dal = new DAL_ClothShop();
        private QLShopCloth db = new QLShopCloth();
        private static BLL_ClothShop _Instance;
        public static BLL_ClothShop Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ClothShop();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ClothShop()
        {

        }

        public dynamic GetAllNV(string txt = "")
        {
           return dal.GetAllNV(txt);
        }

        public dynamic GetAllNCC(string txt = "")
        {
            return dal.GetAllNCC(txt);
        }

        public dynamic GetAllKH(string txt = "")
        {
           return dal.GetAllKH(txt);
        }

        public dynamic GetAllSP(string txt = "")
        {
            return dal.GetAllSP(txt);
        }

        public dynamic GetAllNK(string txt = "")
        {
            return dal.GetAllNK(txt);
        }

        public dynamic GetAllSPView(string txt = "")
        {
            return dal.GetAllSPView(txt);
        }

        public dynamic GetAllKM(string txt = "")
        {
            return dal.GetAllKM(txt);
        }
        
        public dynamic GetAllHD(string txt = "")
        {
            return dal.GetAllHD(txt);
        }

        public dynamic GetNVByMaNV(string MaNV)
        {
            return dal.GetNVByMaNV(MaNV);
        }
        public KhachHang GetKHByMaKH(string MaKH)
        {
            return dal.GetKHByMaKH(MaKH);
        }

        public KhuyenMai GetKMByMaKM(string MaKM)
        {
            return dal.GetKMByMaKM(MaKM);
        }

        public string GetKHBySDT(string SDT)
        {
           return dal.GetKHBySDT(SDT);
        }
        public dynamic GetNKByMaNK(string MaNK)
        {
            return dal.GetNKByMaNK(MaNK);
        }

        public string GetNCCBySDT(string SDT)
        {
            return dal.GetNCCBySDT(SDT);
        }

        public string GetRandom()
        {
            return dal.GetRandom();
        }

        public CTSanPham GetCTSPByMaCTSP(string MaCTSP)
        {
            return dal.GetCTSPByMaCTSP(MaCTSP);
        }

        public SanPham GetSPByMaSP(string MaSP)
        {
            return dal.GetSPByMaSP(MaSP);
        }

        public CTNhapKho GetCTNKByMaCTNK(string MaCTNK)
        {
            return dal.GetCTNKByMaCTNK(MaCTNK);
        }

        public NhaCungCap GetNCCByMaNCC(string MaNCC)
        {
            return dal.GetNCCByMaNCC(MaNCC);
        }
        public HoaDon GetHDByMaHD(string MaHD)  
        {
            return dal.GetHDByMaHD(MaHD);
        }
        public CTHoaDon GetCTHDByMaCTHD(string MaCTHD)
        {
            return dal.GetCTHDByMaCTHD(MaCTHD);
        }

        public dynamic GetCTSPByMaSP(string MaSP, string size, string mausac)
        { 
            return dal.GetCTSPByMaSP(MaSP, size, mausac);
        }

        public dynamic GetCTNKByMaNK(string MaNK)
        {
            return dal.GetCTNKByMaNK(MaNK);
        }

        public dynamic GetCTHDByMaHD(string MaHD)
        {
            return dal.GetCTHDByMaHD(MaHD);
        }

        public dynamic GetAllCTNK()
        {
           return dal.GetAllCTNK(); 
        }

        public dynamic GetAllCTHD()
        {
            return dal.GetAllCTHD();
        }

        public List<string> GetCBBSizeByMaSP(string MaSP)
        {
            return dal.GetCBBSizeByMaSP(MaSP);
        }

        public List<string> GetCBBMauByMaSP(string MaSP)
        {
            return dal.GetCBBMauByMaSP(MaSP);
        }

        public NhomSP GetNhomSPByID(int ID_NhomSP)
        {
            return dal.GetNhomSPByID(ID_NhomSP);
        }

        public NhomSP GetNhomSPByName(string name)
        {
            return dal.GetNhomSPByName(name);
        }

        public dynamic GetSPTonKho(int thoiGian, double tiLe)
        {
            return dal.GetSPTonKho(thoiGian, tiLe);
        }

        public bool CheckLogin(string MaNV, string MK)
        {
            return dal.CheckLogin(MaNV, MK);
        }

        public int CheckChucVu(string MaNV)
        {
            return dal.CheckChucVu(MaNV);
        }

        public List<CBBNhomSP> GetAllNhomSP()
        {
            return dal.GetAllNhomSP();
        }
        public void AddCTSP(string MaSP, string size, string mausac)
        {
            dal.AddCTSP(MaSP, size, mausac);
        }
        public void AddUpdateCTSP(CTSanPham s)
        {
            dal.AddUpdateCTSP(s);
        }

        public void AddNhomSP(NhomSP s)
        {
            dal.AddNhomSP(s);
        }

        public void AddUpdateSP(SanPham s)
        {
            dal.AddUpdateSP(s);
        }

        public void AddUpdateKM(KhuyenMai km)
        {
            dal.AddUpdateKM(km);
        }

        public void AddUpdateNV(NhanVien s)
        {
            dal.AddUpdateNV(s);
        }

        public void AddUpdateNK(NhapKho s)
        {
            dal.AddUpdateNK(s);
        }

        public void AddUpdateCTNK(CTNhapKho s)
        {
            dal.AddUpdateCTNK(s);
        }
        public void AddUpdateKH(KhachHang kh)
        {
            dal.AddUpdateKH(kh);
        }

        public void AddUpdateHD(HoaDon s)
        {
            dal.AddUpdateHD(s);
        }

        public void AddUpdateNCC(NhaCungCap ncc)
        {
            dal.AddUpdateNCC(ncc);
        }

        public void AddUpdateCTHD(CTHoaDon s)
        {
            dal.AddUpdateCTHD(s);
        }

        public void CopySP(string MaSP)
        {
            dal.CopySP(MaSP);
        }

        public void PasteSP(string MaSP)
        {
            dal.PasteSP(MaSP);
        }

        public void CopyNK(string MaNK)
        {
            dal.CopyNK(MaNK);
        }

        public void PasteNK(string MaNK)
        {
            dal.PasteNK(MaNK);
        }

        public void CopyHD(string MaHD)
        {
            dal.CopyHD(MaHD);
        }
 
        public void PasteHD(string MaHD)
        {
            dal.PasteHD(MaHD);
        }
        public bool CheckDelSize(string MaSP, string Size) // Kiểm tra có thể xóa size
        {
            return dal.CheckDelSize(MaSP, Size);
        }
        public bool CheckDelMau(string MaSP, string Mau) // Kiểm tra có thể xóa màu
        {
            return dal.CheckDelMau(MaSP, Mau);  
        }
        public bool CheckDelSP(string MaSP) // Kiểm tra có thể xóa sản phẩm
        {
            return dal.CheckDelSP(MaSP);
        }

        public bool CheckDelKM(string MaKM) // Chỉ có thể xóa KhuyenMai khi chưa áp dụng trong bảng hóa đơn
        {
            return dal.CheckDelKM(MaKM);
        }

        public bool CheckDelKH(string MaKH) // Chỉ có thể xóa KhachHang khi chưa áp dụng trong bảng hóa đơn
        {
            return dal.CheckDelKH(MaKH);
        }
        public bool CheckDelNCC(string MaNCC) // Chỉ có thể xóa NCC khi chưa áp dụng trong bảng nhập kho
        {
            return dal.CheckDelNCC(MaNCC);
        }

        public void DelNV(string MaNV)
        {
            dal.CheckDelNV(MaNV);
        }

        public void DelSP(string MaSP)
        {
            dal.DelSP(MaSP);
        }
        public void DelCTSP(string MaCTSP)
        {
            dal.DelCTSP(MaCTSP);
        }

        public void DelCTHD(string MaCTHD)
        {
            dal.DelCTHD(MaCTHD);
        }

        public void DelKM(string MaKM)
        {
            dal.DelKM(MaKM);
        }

        public void DelCTNK(string MaCTNK)
        {
            dal.DelCTNK(MaCTNK);
        }

        public void DelNK(string MaNK)
        {
            dal.DelNK(MaNK);
        }

        public void DelKH(string MaKH)
        {
            dal.DelKH(MaKH);
        }

        public void DelNCC(string MaNCC)
        {
            dal.DelNCC(MaNCC);
        }

        public void DelHD(string MaHD)
        {
            dal.DelHD(MaHD);
        }

        public int GetSoLuongNK(string MaNK)
        {
            return dal.GetSoLuongNK(MaNK);
        }

        public int GetTongNK(string MaNK)
        {
            return dal.GetTongNK(MaNK);
        }
        public int GetSoLuongHD(string MaHD)
        {
            return dal.GetSoLuongHD(MaHD);
        }
        public int GetTongHD(string MaHD)
        {
            return dal.GetTongHD(MaHD);
        }

        public int GetSLSPBan(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetSLSPBan(batdau, ketthuc);
        }

        public int GetSLHoaDon(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetSLHoaDon(batdau, ketthuc);
        }

        public int GetDoanhSo(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetDoanhSo(batdau, ketthuc);
        }

        public double GetLoiNhuan(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetLoiNhuan(batdau, ketthuc);
        }

        public List<int> GetDS12m()
        {
            return dal.GetDS12m();
        }

        public double[] GetDSTheoNhomSP()
        {
            return dal.GetDSTheoNhomSP();
        }

        public dynamic GetTopDoanhSoSP(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetTopDoanhSoSP(batdau, ketthuc);
        }

        public dynamic GetTopSoLuongSP(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetTopSoLuongSP(batdau, ketthuc);
        }

        public dynamic GetTopKH(DateTime batdau, DateTime ketthuc)
        {
            return dal.GetTopKH(batdau, ketthuc);
        }

        public bool CheckDelNV(string MaNV)
        {
            return dal.CheckDelNV(MaNV);
        }

        public void ResetMKNV(string MaNV)
        {
            dal.ResetMKNV(MaNV);
        }


        public int CheckNum(string txt) 
        {
           return dal.CheckNum(txt);
        }
    }
}
