using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public interface IRepositorioDT
    {
        public DirectorTecnico AddDT(DirectorTecnico directorTecnico);
        public DirectorTecnico GetDT(int idDirectorTecnico);
        public IEnumerable<DirectorTecnico> GetAllDTs();
    }
}