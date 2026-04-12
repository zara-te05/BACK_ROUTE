using API_NOMINAS.Entidades.Estructura;

namespace API_NOMINAS.Interfaces.IEstructura
{
    public interface IPuesto
    {
        Task<IEnumerable<Puesto>> GetAll();
        Task<IEnumerable<Puesto>> GetById(int id);
        Task<IEnumerable<Puesto>> GetByName(string name);
        Task<Puesto> CreatePuesto(Puesto Puesto);
        Task<Puesto> UpdatePuesto(int id, Puesto Puesto);
        Task<Puesto> DeletePuesto(int id);
        Task<Puesto> EditSalary(int id, double salary);
    }
}
