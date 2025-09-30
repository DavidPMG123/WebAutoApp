using System.ComponentModel.DataAnnotations;

namespace WebAutoApp.Data.Entities
{
    public class Client
    {
        public Client()
        {
            this.Purchases = new HashSet<Purchase>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(30)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(10)]
        public string Phone { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        public ICollection<Purchase> Purchases { get; set; }
    }
}
