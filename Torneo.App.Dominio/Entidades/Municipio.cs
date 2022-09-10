using System.ComponentModel.DataAnnotations;

namespace Torneo.App.Dominio
{
    public class Municipio
    {
        public int Id { get; set; }
       
        [Display(Name = "Nombre del municipio")]
        public string Nombre { get; set; }
    }
}