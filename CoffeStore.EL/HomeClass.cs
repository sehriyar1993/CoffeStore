using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeStore.EL
{
    public class HomeClass
    {
        [Key]

        public int Id { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string YTVideo1 { get; set; }
        public string YTVideo2 { get; set; }
        public bool Status { get; set; }
        public string BannerTitle { get; set; }
        public string BannerDescription { get; set; }
        public string BannerAbout { get; set; }
        public string BannerTitle2 { get; set; }
        public string BannerDescription2 { get; set; }
        public string BannerAbout2 { get; set; }
        public string BannerTitle3 { get; set; }
        public string BannerDescription3 { get; set; }
        public string BannerAbout4 { get; set; }
        public string BannerTitle4 { get; set; }
        public string BannerDescription4 { get; set; }
        public string BannerAbout3 { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string About { get; set; }
        public string Title2 { get; set; }
        public string Description2 { get; set; }
        public string About2 { get; set; }

    }
}
