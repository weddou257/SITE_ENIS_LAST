using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreIdentityCustom.Models
{
    public class reclamation
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }

        [Required]
        public string adresse { get; set; }

        public string text { get; set; }
    }
}
