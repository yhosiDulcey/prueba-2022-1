using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioEstadio
    {
        public Estadio AddEstadio(Estadio estadio, int idMunicipio);
        public IEnumerable<Estadio> GetAllEstadios();

    }
}