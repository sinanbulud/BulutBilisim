using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.DataModel
{
    [Table("Uyeler")]
        public  class Uye :EntityBase
    {
        public Uye()
        {

        }
        [Required(ErrorMessage = "Lütfen adınızı giriniz!")]
        [StringLength(30, ErrorMessage = "İsim {0} karakterden uzun olmamalıdır!")]
        public string Ad { get; set; }
        [Required(ErrorMessage = "Lütfen soyadınızı giriniz!")]
        [StringLength(30, ErrorMessage = "Soyisim {0} karakterden uzun olmamalıdır!")]
        public string Soyad { get; set; }
        [Required(ErrorMessage = "Lütfen email adresinizi giriniz!")]
        [EmailAddress(ErrorMessage = "Email formatına uygun giriniz!")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [StringLength(20)]
        public string Sifre { get; set; }
        [NotMapped]     //Property modelde kullanılabilir, ancak SQL'de kolon oluşturmaz.
        [DataType(DataType.Password)]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Sifre", ErrorMessage = "Şifreler aynı değil!")]
        public string SifreTekrar { get; set; }
        [Required]
        [DataType(DataType.DateTime, ErrorMessage = "Tarih formatına uygun giriniz!")]
        public DateTime Tarih { get; set; }

        //Relations
        public virtual IList<Yorum> Yorumlar { get; set; }
        public virtual IList<Makale> Makaleler { get; set; }






    }
}
