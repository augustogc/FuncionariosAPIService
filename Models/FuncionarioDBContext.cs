using MySql.Data.EntityFramework;
using System.Data.Entity;

namespace FuncionariosAPIService.Models
{
    //[DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class FuncionarioDBContext : DbContext
    {
        public FuncionarioDBContext() : base("name=FuncionarioDBContext")
        { }
        public virtual DbSet<Funcionario> Funcionarios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
    }
}