using Microsoft.EntityFrameworkCore;
using Torneo.App.Dominio;
namespace Torneo.App.Persistencia
{
    public class RepositorioDT : IRepositorioDT
    {
        private readonly DataContext _dataContext = new DataContext();

        public DirectorTecnico AddDT(DirectorTecnico directorTecnico)
        {
            var dtInsertado = _dataContext.DirectoresTecnicos.Add(directorTecnico);
            _dataContext.SaveChanges();
            return dtInsertado.Entity;
        }

        public DirectorTecnico GetDT(int idDirectorTecnico)
        {
            var DTEncontrado = _dataContext.DirectoresTecnicos.Find(idDirectorTecnico);
            return DTEncontrado;
        }


        public IEnumerable<DirectorTecnico> GetAllDTs()
        {
            return _dataContext.DirectoresTecnicos;
        }

    }
}