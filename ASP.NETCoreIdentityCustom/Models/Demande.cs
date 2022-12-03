using System.ComponentModel.DataAnnotations;
namespace ASP.NETCoreIdentityCustom.Models
{
    public class Demande
    {
          

        [Key]
        public int Id { get; set; }
        [Required]
        public string TypeDemande { get; set; }

        [Required]
        public string datedemande { get; set; }

     
    }
}

