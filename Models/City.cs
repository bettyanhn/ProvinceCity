using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProvinceCity.Models
{
    public class City
    {
        [Key]
        [Display(Name = "City Id")]
        public int CityId { get; set; }

        [Display(Name = "City Name")]
        public string? CityName { get; set; }
        public int Population { get; set; }

        public string? ProvinceCode { get; set; }
        
        [ForeignKey("ProvinceCode")]
        public Province? Province { get; set; }
    }
}