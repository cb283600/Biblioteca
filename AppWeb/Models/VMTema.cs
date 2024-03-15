using System.ComponentModel.DataAnnotations;

namespace AppWeb.Models
{
    public class VMTema
    {
        public int Id { get; set; }

        [StringLength(10, MinimumLength = 5, ErrorMessage = "Largo del nombre es 2-10")]
        public string? Nombre { get; set; }


        [StringLength(10, MinimumLength = 5, ErrorMessage = "Largo de descripción es 5-10")]
        public string? Descripcion { get; set; }
    }
}
