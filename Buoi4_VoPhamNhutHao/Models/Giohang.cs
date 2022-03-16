using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Buoi4_VoPhamNhutHao.Models;

namespace Buoi4_VoPhamNhutHao.Models
{
    public class Giohang
    {
        DataClasses1DataContext data = new DataClasses1DataContext();
        public int masach { get; set; }

        [Display(Name = "Ten sach")]
        public string tensach { get; set; }

        [Display(Name = "Anh bia")]
        public string hinh { get; set; }

        [Display(Name = "Gia ban")]
        public double giaban { get; set; }

        [Display(Name = "So luong")]
        public int soluong { get; set; }

        [Display(Name = "Thanh tien")]
        public double thanhtien
        {
            get { return soluong * giaban; }
        }
        public Giohang(int id)
        {
            masach = id;
            Sach sach = data.Saches.Single(n => n.masach == masach);
            tensach = sach.tensach;
            hinh = sach.hinh;
            giaban = double.Parse(sach.giaban.ToString());
            soluong = 1;
        }
    }
}