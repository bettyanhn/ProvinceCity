using Microsoft.EntityFrameworkCore;
using ProvinceCity.Models;

namespace ProvinceCity.Data
{
    public static class SeedData
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );
            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>() {
            new Province() {
                ProvinceCode="BC",
                ProvinceName="British Columbia",
            },
            new Province() {
                ProvinceCode="AB",
                ProvinceName="Alberta",
            },
            new Province() {
                ProvinceCode="ON",
                ProvinceName="Ontario",
            },
            new Province() {
                ProvinceCode="QC",
                ProvinceName="Quebec",
            },
        };
            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
            new City() {
                CityId = 1,
                CityName = "Vancouver",
                Population = 675218,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 2,
                CityName = "Victoria",
                Population = 344615,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 3,
                CityName = "Kelowna",
                Population = 142146,
                ProvinceCode = "BC"
            },
            new City() {
                CityId = 4,
                CityName = "Calgary",
                Population = 1239220,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 5,
                CityName = "Edmonton",
                Population = 972223,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 6,
                CityName = "Red Deer",
                Population = 100418,
                ProvinceCode = "AB"
            },
            new City() {
                CityId = 7,
                CityName = "Toronto",
                Population = 2930000,
                ProvinceCode = "ON"
            },
            new City() {
                CityId = 8,
                CityName = "Ottawa",
                Population = 934243,
                ProvinceCode = "ON"
            },
            new City() {
                CityId = 9,
                CityName = "Mississauga",
                Population = 721599,
                ProvinceCode = "ON"
            },
            new City() {
                CityId = 10,
                CityName = "Montreal",
                Population = 1704694,
                ProvinceCode = "QC"
            },
            new City() {
                CityId = 11,
                CityName = "Quebec City",
                Population = 531902,
                ProvinceCode = "QC"
            },
            new City() {
                CityId = 12,
                CityName = "Laval",
                Population = 422993,
                ProvinceCode = "QC"
            },
        };
            return cities;
        }
    }
}