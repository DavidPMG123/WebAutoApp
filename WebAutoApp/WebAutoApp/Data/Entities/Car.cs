using System.ComponentModel.DataAnnotations;

namespace WebAutoApp.Data.Entities
{
    public class Car
    {
        public Car()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        
        public int Id { get; set; }

        [Required]
        [MaxLength(10)]
        public string RegNumber { get; set; } = null!;

        [Required]
       
        public string Brand { get; set; } = null!;

        [Required]
        public string Picture { get; set; } = null!;


        [MaxLength(30)]
        public string Color { get; set; }

        [Required]
        public decimal Price { get; set; }

        public ICollection<Purchase> Purchases { get; set; }

    }
}
