using System.ComponentModel.DataAnnotations;

namespace AppWeb.Models
{
    public class VMPais
    {
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 2, ErrorMessage = "Largo del nombre es 2-10")]
        public string? Nombre { get; set; }


        [StringLength(10, MinimumLength = 5, ErrorMessage = "Largo de cantidad de habitantes es 5-10")]
        public string? CantHabitantes { get; set; }
    }
}
