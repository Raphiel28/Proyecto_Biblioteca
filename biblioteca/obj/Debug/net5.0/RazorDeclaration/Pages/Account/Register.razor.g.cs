// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace biblioteca.Pages.Account
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using biblioteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\Account\Register.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\Account\Register.razor"
using biblioteca.Data.AdminUsuarios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Account/Register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\Account\Register.razor"
        public Usuarios usuarios = new Usuarios();
            public String Nombre { get; set; }
            public String Apellido { get; set; }
            public String Correo { get; set; }
            public String Telefono { get; set; }
            public String Password { get; set; }
            public bool Admin { get; set; }

            public string EstadoUsuario { get; set; } = "";


            protected async Task SaveRegistro()
            {
                Correo = usuarios.CorreoUsuario;
                Nombre = usuarios.NombreUsuario;
                Apellido = usuarios.ApellidoUsuario;
                Telefono = usuarios.TelefonoUsuario;
                Password = usuarios.Contrasena;
                Admin = false;

                if (Correo.Length > 0 && Nombre.Length > 0 && Apellido.Length > 0 && Telefono.Length > 0 && Password.Length > 0)
                {
                    await registrosusuarios.InsertUser(usuarios);

                    EstadoUsuario = "Cuenta Registrada Exitosamente";
                    usuarios.NombreUsuario = "";
                    usuarios.Contrasena = "";
                    usuarios.ApellidoUsuario = "";
                    usuarios.CorreoUsuario = "";


                    NavigationManager.NavigateTo("/Account/Login");
                }
                else
                {
                    EstadoUsuario = "Campos Vacios. Debe de llenar los campos que faltan antes de registrar la cuenta.";
                }

            } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRegistrosUsuarios registrosusuarios { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
