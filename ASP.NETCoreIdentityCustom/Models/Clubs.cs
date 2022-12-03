using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreIdentityCustom.Models
{
    public class Clubs
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string email { get; set; }

        [Required]
        public string specialite { get; set; }
        public string niveau { get; set; }
        [Required]
        public string nameclub { get; set; }
    }
}
