using System;
using System.ComponentModel.DataAnnotations;
namespace Workshop1.Models
{
    public class Movie
    {
        [Display(Name="รหัส")]
        public int Id {get;set;}
        [Display(Name="ชื่อเรื่อง")]
        public string Title{get;set;}
        [Display(Name="รูปแบบ")]
        public string Genre{get;set;}
        [Display(Name="วันที่ฉาย")]
        [DisplayFormat(DataFormatString = "วันที่ {0:d MMMM yyyy}")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate {get;set;}

        [DisplayFormat(DataFormatString="{0:N2}")]
        [Display(Name="ราคา")]
           public decimal Price{get;set;}
    }
}