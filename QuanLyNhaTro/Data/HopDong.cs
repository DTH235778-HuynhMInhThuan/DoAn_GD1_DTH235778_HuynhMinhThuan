using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.Data
{
    public class HopDong
    {
        [Key]
        public int MaHopDong { get; set; }

        public int MaSV { get; set; }
        public int MaPhong { get; set; }

        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public SinhVien SinhVien { get; set; }
        public Phong Phong { get; set; }
    }
}
