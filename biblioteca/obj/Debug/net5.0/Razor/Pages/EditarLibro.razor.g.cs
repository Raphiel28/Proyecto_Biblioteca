#pragma checksum "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bc9218aef1c65f2c5c2f2f496dc724a398f603f"
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
#line 1 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\_Imports.razor"
using biblioteca.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
using biblioteca.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarLibro")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarLibro/{id:int}")]
    public partial class EditarLibro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "<h4>Editar</h4>\r\n  ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                    libro

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "mb-3");
                __builder2.AddMarkupContent(8, "<label for=\"NLibro\" class=\"form-label\">Nombre del libro</label>\r\n  ");
                __builder2.OpenElement(9, "input");
                __builder2.AddAttribute(10, "type", "text");
                __builder2.AddAttribute(11, "id", "NLibro");
                __builder2.AddAttribute(12, "required");
                __builder2.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                           libro.NombreLibro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => libro.NombreLibro = __value, libro.NombreLibro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(15, "\r\n\r\n");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "mb-3");
                __builder2.AddMarkupContent(18, "<label for=\"GLibro\" class=\"form-label\">Genero del Libro</label>\r\n  ");
                __builder2.OpenElement(19, "input");
                __builder2.AddAttribute(20, "type", "text");
                __builder2.AddAttribute(21, "id", "GLibro");
                __builder2.AddAttribute(22, "required");
                __builder2.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                           libro.GeneroLibro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => libro.GeneroLibro = __value, libro.GeneroLibro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n\r\n    ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "mb-3");
                __builder2.AddMarkupContent(28, "<label for=\"PLibro\" class=\"form-label\">Precio</label>\r\n  ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "text");
                __builder2.AddAttribute(31, "id", "PLibro");
                __builder2.AddAttribute(32, "required");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                           libro.Precio

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => libro.Precio = __value, libro.Precio));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "mb-3");
                __builder2.AddMarkupContent(38, "<label for=\"CDisponibles\" class=\"form-label\">Copias Disponibles</label>\r\n  ");
                __builder2.OpenElement(39, "input");
                __builder2.AddAttribute(40, "type", "text");
                __builder2.AddAttribute(41, "id", "CDisponibles");
                __builder2.AddAttribute(42, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                                    libro.CopiasDisponibles

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => libro.CopiasDisponibles = __value, libro.CopiasDisponibles));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "mb-3");
                __builder2.AddMarkupContent(47, "<label for=\"VLibros\" class=\"form-label\">Ventas</label>\r\n  ");
                __builder2.OpenElement(48, "input");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "id", "VLibros");
                __builder2.AddAttribute(51, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                               libro.Ventas

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => libro.Ventas = __value, libro.Ventas));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "mb-3");
                __builder2.AddMarkupContent(56, "<label for=\"EditorialLibro\" class=\"form-label\">Editorial</label>\r\n  ");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "type", "text");
                __builder2.AddAttribute(59, "id", "EditorialLibro");
                __builder2.AddAttribute(60, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                                      libro.EditorialLibro

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => libro.EditorialLibro = __value, libro.EditorialLibro));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n");
            __builder.OpenElement(63, "h6");
#nullable restore
#line 40 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
__builder.AddContent(64, result);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "submit");
            __builder.AddAttribute(68, "class", "btn btn-primary");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
                                                           Editar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "value", "Guardar");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
            __builder.AddMarkupContent(72, "<a class=\"btn btn-danger\" href=\"/Modulos_libros\">Cancelar</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\HP\Desktop\Proyecto_Biblioteca\biblioteca\Pages\EditarLibro.razor"
      
    [Parameter]
    public int id {get; set;}
    Libros libro = new Libros();
    btnnoysoy5udemk46n23Context db = new btnnoysoy5udemk46n23Context();
    string result="";
    int idL = 0;

    protected override void OnInitialized(){
     
      
       libro = db.Libros.Where(x=> x.IdLibro == id).First();
       idL = libro.IdLibro;
       
    }

    async Task Editar()
    {
        btnnoysoy5udemk46n23Context bd = new btnnoysoy5udemk46n23Context();
       

        await db.SaveChangesAsync();
        result = "Editado con exito!";
        NavigationManager.NavigateTo("/Modulos_libros");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
