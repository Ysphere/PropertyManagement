using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace PropertyManagement.Models
{
    public class Property
    {
        [Key]
        public int Id { get; set; }
        public Address Address { get; set; }

        [Required]
        public PropertyType PropertyType { get; set; }
        public string Image { get; set; }

        public DateTime? BoughtDate { get; set; }
    }

    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Number { get; set; }

        public string Street { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        [AllowNull]
        public string? PostalCode { get; set; }

        public Country Country { get; set; }

    }

    public enum Country
    {
        US = 0,
        Canada = 1,
        China = 2,
    }

    public enum PropertyType
    {
        House = 0,
        Condo = 1,
        OfficeBuilding = 2,
        WareHouse = 3,
    }
}
