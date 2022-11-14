using System.ComponentModel.DataAnnotations;
namespace ASP.NETCoreIdentityCustom.Models
{
    public class Teacher
    {

        [Key]
        public int Id { get; set; }

        public string Nom { get; set; }


        public string Prenom { get; set; }


    }
}
