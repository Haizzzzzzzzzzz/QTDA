using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiCuoiKyCNPM.DoiTuong
{
    internal class NhanVien
    {
        string ID_NV;
        string Ten_NV;
        DateTime Ngay_sinh_NV;
        string Gioi_tinh_NV;
        float Luong_NV;
        int CMND;
        string Dia_chi;
        int Phone;
        string ID_Ca_lam;
        string ID_Cham_cong;

        public string ID_NV1 { get => ID_NV; set => ID_NV=value; }
        public string Ten_NV1 { get => Ten_NV; set => Ten_NV=value; }

        public string Gioi_tinh_NV1 { get => Gioi_tinh_NV; set => Gioi_tinh_NV=value; }
        public float Luong_NV1 { get => Luong_NV; set => Luong_NV=value; }
        public int CMND1 { get => CMND; set => CMND=value; }
        public string Dia_chi1 { get => Dia_chi; set => Dia_chi=value; }
        public int Phone1 { get => Phone; set => Phone=value; }
        public string ID_Ca_lam1 { get => ID_Ca_lam; set => ID_Ca_lam=value; }
        public string ID_Cham_cong1 { get => ID_Cham_cong; set => ID_Cham_cong=value; }
        public DateTime Ngay_sinh_NV1 { get => Ngay_sinh_NV; set => Ngay_sinh_NV=value; }
    }
}
