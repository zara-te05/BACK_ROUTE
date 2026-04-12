using API_NOMINAS.Entidades.Estructura;

namespace API_NOMINAS.Interfaces.IEstructura
{
    public interface IEmpleado
    {
        Task<IEnumerable<Empleado>> GetAll();
        Task<IEnumerable<Empleado>> GetById(int id);
        Task<IEnumerable<Empleado>> GetByName(string name);
        Task<Empleado> CreateEmpleado(Empleado empleado);
        Task<Empleado> UpdateEmpleado(int id, Empleado empleado);
        Task<Empleado> DeleteEmpleado(int id);
        Task<Empleado> UpdatePuesto(int empleado_id, int puesto_id);
    }
}
