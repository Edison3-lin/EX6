using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace EX6.Models
{
    public class Pega
    {
      [DisplayName("頁面：")]
      [Required]
      public int Page{ get; set; }
      
      [DisplayName("姓名：")]
      public string WORK_NAME{ get; set; }

      [DisplayName("部門：")]
      [Required]
      public string BU_ID{ get; set; }

      [DisplayName("性別：")]
      [Required]
      public string Gender{ get; set; }
    }
}