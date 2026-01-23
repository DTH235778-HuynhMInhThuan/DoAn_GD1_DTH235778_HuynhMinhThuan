using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTro.Data
{
    public class DienNuoc
    {

        [Key]
        public int MaDN { get; set; }

        public int MaPhong { get; set; }

        public int ChiSoDienCu { get; set; }
        public int ChiSoDienMoi { get; set; }

        public int ChiSoNuocCu { get; set; }
        public int ChiSoNuocMoi { get; set; }

        public Phong Phong { get; set; }
    }
}
