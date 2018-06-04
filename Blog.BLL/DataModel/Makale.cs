using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.DataModel
{
    [Table("Makaleler")]
    public class Makale : EntityBase
    {
        public Makale()
        {

        }
        [Required(ErrorMessage = "Lütfen makale başlığını giriniz!")]
        [StringLength(100, ErrorMessage = "Başlık {0} karakterden uzun olmamalıdır!")]
        public string Baslik { get; set; }
        [DataType(DataType.Html)]
        public string Icerik { get; set; }
        [StringLength(150)]
        public string Resim { get; set; }
        public int? UyeID { get; set; }
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }
        [Required]
        [DefaultValue(1)]
        public bool Aktif { get; set; }

        //Relations
        public virtual IList<Etiket> Etiketler { get; set; }
        public virtual IList<Yorum> Yorumlar { get; set; }
        public virtual Uye Uye { get; set; }
    }
}
