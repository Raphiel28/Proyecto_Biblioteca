// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace biblioteca.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\_Imports.razor"
using biblioteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\Shared\MainLayout.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\Shared\MainLayout.razor"
using biblioteca.Data.AdminUsuarios;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\alane\OneDrive\Documentos\Clases Semestre 7\Ingenieria de Software\Proyecto Final\Proyecto_Biblioteca-main\Proyecto_Biblioteca-main\biblioteca\Shared\MainLayout.razor"
       Usuario user = new Usuario();
    private void CerrarSesion()
    {
        Usuario.correo = null;
        Usuario.contrasena = null;
        Usuario.id = 0;
        Usuario.admin = false;
        NavigationManager.NavigateTo("/");
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRegistrosUsuarios registrosusuarios { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
