using API_NOMINAS.Entidades.Estructura;

namespace API_NOMINAS.Interfaces.IEstructura
{
    public interface IDepartamento
    {
        Task<List<Departamento>> GetAll();
        Task<IEnumerable<Departamento>> GetByName(string name);
        Task<IEnumerable<Departamento>> GetById(int id);
        Task<Departamento> CreateDepartament(Departamento departamento);
        Task<Departamento> EditDepartament(int id, Departamento departamento);
        Task<Departamento> DeleteDepartament(int id);
    }
}
