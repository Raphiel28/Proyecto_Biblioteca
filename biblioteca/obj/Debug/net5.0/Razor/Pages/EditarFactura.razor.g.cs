#pragma checksum "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66ef19e4069998f51ad51f11022a8df53c803b7e"
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
#line 12 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using biblioteca.Data.AdminUsuarios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarFactura")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarFactura/{id:int}")]
    public partial class EditarFactura : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<h4>Editar</h4>\r\n\r\n  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                    factura

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "mb-3");
                __builder2.AddMarkupContent(8, "<label for=\"Idlibro\" class=\"form-label\">Id del libro</label>\r\n  ");
                __builder2.OpenElement(9, "select");
                __builder2.AddAttribute(10, "class", "form-select");
                __builder2.AddAttribute(11, "aria-label", "Default select example");
                __builder2.AddAttribute(12, "id", "Idlibro");
                __builder2.AddAttribute(13, "required");
                __builder2.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                                                                         idL

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => idL = __value, idL));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(16, "option");
                __builder2.AddAttribute(17, "value", "0");
                __builder2.AddContent(18, "Open this select menu");
                __builder2.CloseElement();
#nullable restore
#line 14 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
     foreach (var item in Getlibros())
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "option");
                __builder2.AddAttribute(20, "value", 
#nullable restore
#line 16 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                      item.IdLibro

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(21, 
#nullable restore
#line 16 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                     item.NombreLibro

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 17 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "mb-3");
                __builder2.AddMarkupContent(25, "<label for=\"Ncliente\" class=\"form-label\">Nombre del cliente</label>\r\n  ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "text");
                __builder2.AddAttribute(28, "id", "Ncliente");
                __builder2.AddAttribute(29, "required");
                __builder2.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                             factura.NombreCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => factura.NombreCliente = __value, factura.NombreCliente));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n\r\n");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "mb-3");
                __builder2.AddMarkupContent(35, "<label for=\"Acliente\" class=\"form-label\">Apellido del cliente</label>\r\n  ");
                __builder2.OpenElement(36, "input");
                __builder2.AddAttribute(37, "type", "text");
                __builder2.AddAttribute(38, "id", "Acliente");
                __builder2.AddAttribute(39, "required");
                __builder2.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                             factura.ApellidoCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => factura.ApellidoCliente = __value, factura.ApellidoCliente));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "mb-3");
                __builder2.AddMarkupContent(45, "<label for=\"Tcliente\" class=\"form-label\">Telefono del cliente</label>\r\n  ");
                __builder2.OpenElement(46, "input");
                __builder2.AddAttribute(47, "type", "text");
                __builder2.AddAttribute(48, "id", "Tcliente");
                __builder2.AddAttribute(49, "required");
                __builder2.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 35 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                             factura.TelefonoCliente

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => factura.TelefonoCliente = __value, factura.TelefonoCliente));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "mb-3");
                __builder2.AddMarkupContent(55, "<label for=\"F_inicial\" class=\"form-label\">Dia de la renta</label>\r\n  ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "date");
                __builder2.AddAttribute(58, "id", "F_inicial");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                                 factura.FechaRenta

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => factura.FechaRenta = __value, factura.FechaRenta, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n    ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "mb-3");
                __builder2.AddMarkupContent(64, "<label for=\"F_final\" class=\"form-label\">Dia del retorno</label>\r\n  ");
                __builder2.OpenElement(65, "input");
                __builder2.AddAttribute(66, "type", "date");
                __builder2.AddAttribute(67, "id", "F_final");
                __builder2.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                               factura.FechaRetorno

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => factura.FechaRetorno = __value, factura.FechaRetorno, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
            __builder.OpenElement(71, "h6");
            __builder.AddContent(72, 
#nullable restore
#line 51 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
     result

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n  ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "submit");
            __builder.AddAttribute(76, "class", "btn btn-primary");
            __builder.AddAttribute(77, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
                                                             Editar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "value", "Registrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n  ");
            __builder.AddMarkupContent(80, "<a class=\"btn btn-danger\" href=\"/Modulos_facturas\">Cancelar</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "C:\Users\HP 5540\Desktop\Introduccion a la Ingenieria de Software\Biblioteca\Proyecto_Biblioteca\biblioteca\Pages\EditarFactura.razor"
        
    [Parameter]
    public int id {get; set;}
    Facturas factura = new Facturas();
    btnnoysoy5udemk46n23Context db = new btnnoysoy5udemk46n23Context();
    string result="";
    int idL = 0;
    

       protected override void OnInitialized(){
     
      
       factura = db.Facturas.Where(x=> x.IdFactura == id).First();
       idL = factura.IdLibro;
       
    }

    List<Libros> Getlibros(){
        btnnoysoy5udemk46n23Context bd = new btnnoysoy5udemk46n23Context();
        return bd.Libros.ToList();
    }

 async Task Editar(){
     btnnoysoy5udemk46n23Context bd = new btnnoysoy5udemk46n23Context();

    if(factura.NombreCliente == null || factura.ApellidoCliente == null || factura.TelefonoCliente == null || id == 0)
    {
      return;
    }
    
    factura.IdLibro = idL;
    
    var fact1 = bd.Facturas.Where(x=> x.IdFactura == id).First();

    if(factura.FechaRenta != fact1.FechaRenta || factura.FechaRetorno != fact1.FechaRetorno){

        

      var facturas_libros = bd.Facturas.Where(x=>x.IdLibro == factura.IdLibro && x.IdFactura != id).ToList();
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
