using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using biblioteca.Models;

namespace biblioteca.Data.AdminUsuarios
{
    interface IRegistrosUsuarios
    {
        Task<bool> InsertUser(Usuarios usuarios);
        Task<bool> UpdateUser(Usuarios usuarios);
        Task<bool> SaveUser(Usuarios usuarios);
    }
}
