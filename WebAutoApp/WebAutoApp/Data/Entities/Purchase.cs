using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAutoApp.Data.Entities
{
    public class Purchase
    {
        public int Id { get; set; }

        [ForeignKey("Car")]
        public int CarId { get; set; }
        public Car Car { get; set; } = null!;

        [ForeignKey("Client")]
        public int ClientId { get; set; }  
        public Client Client { get; set; } = null!;

        [Required]
        public DateTime PurchaseDate { get; set; }
    }
}
