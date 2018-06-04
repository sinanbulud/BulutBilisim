using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.BLL.DataModel
{
    [Table("Etiketler")]
   public class Etiket :EntityBase
    {

        [Required(ErrorMessage = "Lütfen etiket içeriği giriniz!")]
        [StringLength(30,ErrorMessage ="İçerik {0} karekterden uzun olmamalıdır !")]
        public String Içerik { get; set; }
        public virtual IList<Makale> Makaleler { get; set; }


    }
}
