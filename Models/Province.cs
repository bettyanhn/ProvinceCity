using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvinceCity.Models
{
    public class Province
    {
        [Key]
        [Display(Name = "Province Code")]
        public string? ProvinceCode { get; set; }

        [Display(Name = "Province Name")]
        public string? ProvinceName { get; set; }

        public ICollection<City>? Cities { get; set; }
    }
}