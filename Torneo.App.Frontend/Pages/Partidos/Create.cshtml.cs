using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Torneo.App.Dominio;
using Torneo.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Partidos
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipo;
        private readonly IRepositorioArbitro _repoArbitro;
        private readonly IRepositorioEstadio _repoEstadio;

        public CreateModel(IRepositorioPartido repoPartido, IRepositorioEquipo
repoEquipo, IRepositorioArbitro repoArbitro, IRepositorioEstadio repoEstadio)
        {
            _repoPartido = repoPartido;
            _repoEquipo = repoEquipo;
            _repoArbitro = repoArbitro;
            _repoEstadio = repoEstadio;
        }

        public Partido partido { get; set; }
        public IEnumerable<Equipo> equipos { get; set; }
        public IEnumerable<Arbitro> arbitros { get; set; }
        public IEnumerable<Estadio> estadios { get; set; }

        public void OnGet()
        {
            partido = new Partido();
            equipos = _repoEquipo.GetAllEquipos();
            arbitros = _repoArbitro.GetAllArbitros();
            estadios = _repoEstadio.GetAllEstadios();
        }
    }
}
