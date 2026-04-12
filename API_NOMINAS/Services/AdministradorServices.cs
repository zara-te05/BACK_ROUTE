using API_NOMINAS.Connections;
using API_NOMINAS.Entidades.Estructura;
using API_NOMINAS.Interfaces.IEstructura;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Crypto.Generators;
using BCrypt.Net;

namespace API_NOMINAS.Services
{
    public class AdministradorServices : IAdministrador
    {
        private readonly AppDbContext _context;

        public AdministradorServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Administrador> CreateAdministrator(Administrador administrador)
        {
            administrador.Password = BCrypt.Net.BCrypt.HashPassword(administrador.Password);

            await _context.Administrador.AddAsync(administrador);
            await _context.SaveChangesAsync();

            return administrador;
        }

        public async Task<Administrador> DeleteAdministrador(int id)
        {
            var administradorDelete = await _context.Administrador.FindAsync(id);

            if (administradorDelete == null) throw new ArgumentException("ID invalido");

            _context.Administrador.Remove(administradorDelete);
            await _context.SaveChangesAsync();

            return administradorDelete;
        }

        public async Task<Administrador> EditAdministrator(int id, Administrador administrador)
        {
            var updateAdministrador = await _context.Administrador.FindAsync(id);

            if (updateAdministrador == null) throw new ArgumentException("Administrador invalido");

            updateAdministrador.Name = administrador.Name;
            updateAdministrador.Usermane = administrador.Usermane;
            updateAdministrador.Password = administrador.Password;

            await _context.SaveChangesAsync();

            return updateAdministrador;
        }

        public async Task<List<Administrador>> GetAll()
        {
            return await _context.Administrador.ToListAsync();
        }

        public async Task<Administrador> Login(string user, string password)
        {
            var admin = await _context.Administrador.FirstOrDefaultAsync(
                    a => a.Usermane == user
                );
            
            if (admin == null) throw new ArgumentException("El usuario no existe");

            bool isValid = BCrypt.Net.BCrypt.Verify(password, admin.Password);

            if (!isValid) throw new Exception("Clave Incorrecta");

            return admin;

        }
    }
}
