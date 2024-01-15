using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project.Models
{
    public class Opinion
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(500)")]
        public string text { get; set; }

        [Required]
        public int rateNumber { get; set; }

        [Required]
        public int clubID { get; set; }

        public Opinion()
        {
        }

        public Opinion(int id, string text, int rateNumber, int clubId)
        {
            ID = id;
            this.text = text;
            this.rateNumber = rateNumber;
            clubID = clubId;
        }
    }
}
