using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.Models;

namespace biblioteca.Data.AdminUsuarios
{
    public class RegistrosUsuarios : IRegistrosUsuarios
    {
        private readonly btnnoysoy5udemk46n23Context con;

        public RegistrosUsuarios(btnnoysoy5udemk46n23Context context)
        {
            con = context;
        }

        public async Task<bool> InsertUser(Usuarios usuarios)
        {
            con.Usuarios.Add(usuarios);

            return await con.SaveChangesAsync() > 0;
        }

        public async Task<bool> SaveUser(Usuarios usuarios)
        {
            if (usuarios.IdUsuario > 0)
                return await UpdateUser(usuarios);
            else
                return await InsertUser(usuarios);
        }


        public async Task<bool> UpdateUser(Usuarios usuarios)
        {
            con.Entry(usuarios).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return await con.SaveChangesAsync() > 0;
        }
    }
}
