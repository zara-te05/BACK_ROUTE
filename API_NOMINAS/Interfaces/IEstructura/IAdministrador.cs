using API_NOMINAS.Entidades.Estructura;

namespace API_NOMINAS.Interfaces.IEstructura
{
    public interface IAdministrador
    {
        Task<List<Administrador>> GetAll();
        Task<Administrador> CreateAdministrator(Administrador administrador);
        Task<Administrador> EditAdministrator(int id, Administrador administrador);
        Task<Administrador> DeleteAdministrador(int id);
        Task<Administrador> Login(string user, string password);

    }
}
