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
#line 2 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\RegistrarFacturas.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\RegistrarFacturas.razor"
using biblioteca.Data.AdminUsuarios;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RegistrarFacturas")]
    public partial class RegistrarFacturas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\RegistrarFacturas.razor"
        
      Facturas factura = new Facturas();
      string result="";
      int id = 0;
      protected override void OnInitialized()
      {
          factura.FechaRenta = DateTime.Now;
          factura.FechaRetorno = DateTime.Now;
      }

      List<Libros> Getlibros(){
          btnnoysoy5udemk46n23Context db = new btnnoysoy5udemk46n23Context();
          return db.Libros.ToList();
      }

      protected async Task Registrar(){
          btnnoysoy5udemk46n23Context db = new btnnoysoy5udemk46n23Context();

          if(factura.NombreCliente == null || factura.ApellidoCliente == null || factura.TelefonoCliente == null || id == 0){
              return;
          }

          factura.IdLibro = id;
          var facturas_libros = db.Facturas.Where(x=>x.IdLibro == factura.IdLibro).ToList();



          foreach(var item in facturas_libros){
              if(factura.FechaRenta == item.FechaRenta ||
              factura.FechaRetorno == item.FechaRetorno ||
              factura.FechaRenta >= item.FechaRenta && factura.FechaRenta <= item.FechaRetorno ||
              factura.FechaRetorno >= item.FechaRenta && factura.FechaRetorno <= item.FechaRetorno
              ){
                  result = "Libro ocupado en esta fecha";
                  return;
              }


          }

          var compare_f = DateTime.Compare(factura.FechaRenta, DateTime.Now);
          var compare_f2 = DateTime.Compare(factura.FechaRenta, factura.FechaRetorno);
          if(compare_f < 0 || compare_f2 > 0)
          {
              result = "Error en la fecha";
              return;
          }

          var libro = db.Libros.Where(x => x.IdLibro == factura.IdLibro).First();
          var costo = libro.Precio;
          var dias = factura.FechaRetorno.Subtract(factura.FechaRenta).TotalDays;
          var resultado = costo * dias;

          factura.Precio = resultado;

          libro.Ventas = libro.Ventas + 1;
          libro.CopiasDisponibles = libro.CopiasDisponibles - 1;

          db.Facturas.Add(factura);
          await db.SaveChangesAsync();
          NavigationManager.NavigateTo("/Modulos_facturas");

      }

  

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
