#pragma checksum "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a9dce07460550ffb3e61b7242977b8d0f8c390f"
// <auto-generated/>
#pragma warning disable 1591
namespace biblioteca.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\_Imports.razor"
using biblioteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Modulos_facturas")]
    public partial class Modulos_facturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "class", "table");
            __builder.AddMarkupContent(2, @"<thead><tr><th scope=""col"">#</th>
      <th scope=""col"">Libro</th>
      <th scope=""col"">Nombre</th>
      <th scope=""col"">Apellido</th>
      <th scope=""col"">Telefono</th>
      <th scope=""col"">Precio</th>
      <th scope=""col"">Fecha de Renta</th>
      <th scope=""col"">Fecha de retorno</th></tr></thead>
  ");
            __builder.OpenElement(3, "tbody");
#nullable restore
#line 18 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
     foreach(var item in Getfacturas()){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "tr");
            __builder.OpenElement(5, "th");
            __builder.AddAttribute(6, "scope", "row");
            __builder.AddContent(7, 
#nullable restore
#line 21 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.IdFactura

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n      ");
            __builder.OpenElement(9, "th");
            __builder.AddAttribute(10, "scope", "row");
            __builder.AddContent(11, 
#nullable restore
#line 22 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.IdLibro

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n      ");
            __builder.OpenElement(13, "th");
            __builder.AddAttribute(14, "scope", "row");
            __builder.AddContent(15, 
#nullable restore
#line 23 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.NombreCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n      ");
            __builder.OpenElement(17, "th");
            __builder.AddAttribute(18, "scope", "row");
            __builder.AddContent(19, 
#nullable restore
#line 24 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.ApellidoCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n      ");
            __builder.OpenElement(21, "th");
            __builder.AddAttribute(22, "scope", "row");
            __builder.AddContent(23, 
#nullable restore
#line 25 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.TelefonoCliente

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n      ");
            __builder.OpenElement(25, "th");
            __builder.AddAttribute(26, "scope", "row");
            __builder.AddContent(27, 
#nullable restore
#line 26 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.Precio

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n      ");
            __builder.OpenElement(29, "th");
            __builder.AddAttribute(30, "scope", "row");
            __builder.AddContent(31, 
#nullable restore
#line 27 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.FechaRenta

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n      ");
            __builder.OpenElement(33, "th");
            __builder.AddAttribute(34, "scope", "row");
            __builder.AddContent(35, 
#nullable restore
#line 28 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                       item.FechaRetorno

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n      \r\n        ");
            __builder.OpenElement(37, "th");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "class", "btn btn-warning");
            __builder.AddAttribute(40, "href", "/EditarFactura/" + (
#nullable restore
#line 31 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                                                               item.IdFactura

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "th");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddAttribute(46, "href", "/EliminarFactura/" + (
#nullable restore
#line 32 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
                                                                item.IdFactura

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(47, "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n");
            __builder.AddMarkupContent(49, "<a class=\"btn btn-primary\" href=\"/RegistrarFacturas\">Registrar</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\raphiel burdier\Desktop\ProyectoBiblioteca\biblioteca\Pages\Modulos_facturas.razor"
       
List<Facturas> Getfacturas(){
    btnnoysoy5udemk46n23Context db = new btnnoysoy5udemk46n23Context();
    return db.Facturas.ToList();
}




#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
