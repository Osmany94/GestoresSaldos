using PruebaTecnica.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Data.Entity;
using PruebaTecnica.Modelo.ViewModel;

namespace PruebaTecnica.Repositorio
{
    public class ServicioGestor
    {
        private readonly dbContext _db = new dbContext();
        public List<GestorSaldoViewModel> GetAsignacionSaldos()
        {

            var data = _db.Database.SqlQuery<GestorSaldoViewModel>(
            "EXEC sp_AddSaldoGestor").ToList();

            return data;
        }
    }
}
