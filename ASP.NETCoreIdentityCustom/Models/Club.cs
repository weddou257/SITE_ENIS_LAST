using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreIdentityCustom.Models
{
    public class Club
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string NomPresident { get; set; }

        [Required]
        public string activite { get; set; }
        public IList<Students> Students { get; set; }
    }
}
