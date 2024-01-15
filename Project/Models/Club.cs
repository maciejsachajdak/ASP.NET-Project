using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Club
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string city { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string street { get; set; }

        public Club()
        {
        }

        public Club(int id, string name, string city, string street)
        {
            ID = id;
            this.name = name;
            this.city = city;
            this.street = street;
        }

    }
}
