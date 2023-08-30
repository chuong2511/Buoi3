using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi3
{
    class SinhVien
    {
        int MaSV;

        public int MASV
        {
            get { return MaSV; }
            set { MaSV = value; }
        }
        string Hoten;

        public string HoTen
        {
            get { return Hoten; }
            set { Hoten = value; }
        }
        double diemLT, diemTH;

        public double DiemTH
        {
            get { return diemTH; }
            set { diemTH = value; }
        }

        public double DiemLT
        {
            get { return diemLT; }
            set { diemLT = value; }
        }

        public SinhVien()
        { 
        }

        public SinhVien(int MaSV, string HoTen, double diemLT, double diemTH)
        {
            this.MaSV = MaSV;
            this.HoTen = HoTen;
            this.diemLT = diemLT;
            this.diemTH = diemTH;
        }

        public double diemTB()
        {
            return ((diemLT + diemTH)/2);
        }
    }
}
