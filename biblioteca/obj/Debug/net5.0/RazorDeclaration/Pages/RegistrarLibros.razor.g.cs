// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace biblioteca.Pages
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
#line 2 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\RegistrarLibros.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\RegistrarLibros.razor"
using biblioteca.Data.AdminUsuarios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrarLibros")]
    public partial class RegistrarLibros : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\RegistrarLibros.razor"
      
    Libros libro = new Libros();
    string result="";

protected async Task Registrar(){
    btnnoysoy5udemk46n23Context db = new btnnoysoy5udemk46n23Context();
    
    db.Libros.Add(libro);
    await db.SaveChangesAsync();
    result = "Libro registrado correctamente!!!";
    NavigationManager.NavigateTo("/Modulos_libros");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
