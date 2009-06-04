using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DiaDiemMaiTangDto
    {
        private string _MaDiaDiemMaiTang;
        private string _TenDiaDiemMaiTang;
        public string MaDiaDiemMaiTang
        {
            get { return _MaDiaDiemMaiTang; }
            set { _MaDiaDiemMaiTang = value; }
        }
        public string TenDiaDiemMaiTang
        {
            get { return _TenDiaDiemMaiTang; }
            set { _TenDiaDiemMaiTang = value; }
        }
    }
}
