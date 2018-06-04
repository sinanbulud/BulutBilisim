using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.DataModel
{
    [Table("Yorumlar")]
    public class Yorum : EntityBase
    {

        [Required(ErrorMessage = "Lütfen yorum giriniz!")]
        public string Icerik { get; set; }
        public int? UyeID { get; set; }
        public int MakaleID { get; set; }
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Relations
        public virtual Uye Uye { get; set; }
        public virtual Makale Makale { get; set; }

    }
    }

