using System.ComponentModel.DataAnnotations;

namespace ASP.NETCoreIdentityCustom.Models
{
    public class Courses
    {
        [Key]
        public int IdCourse { get; set; }

        public string Nom { get; set; }

    }
}
