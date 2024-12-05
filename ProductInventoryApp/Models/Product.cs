using System.ComponentModel.DataAnnotations;

namespace ProductInventoryApp.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string Producator { get; set; }

        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Prețul trebuie să fie mai mare decât 0.")]
        public decimal  Pret { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Prețul trebuie să fie mai mare decât 0..")]
        public int CantitateaStoc { get; set; }
    }
}
