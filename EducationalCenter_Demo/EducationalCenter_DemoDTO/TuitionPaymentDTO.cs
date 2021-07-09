using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalCenter_DemoDTO
{
    public class TuitionPaymentDTO
    {
        private string _NGAYLAPHOADON;
        private string _MAPHIEUDANGKYLOPHOC;
        private float _TONGTIEN;
        private string _MANV;

        public string NGAYLAPHOADON { get => _NGAYLAPHOADON; set => _NGAYLAPHOADON = value; }
        public string MAPHIEUDANGKYLOPHOC { get => _MAPHIEUDANGKYLOPHOC; set => _MAPHIEUDANGKYLOPHOC = value; }
        public float TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
        public string MANV { get => _MANV; set => _MANV = value; }
    }
}
