#pragma checksum "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ee88813efaa042c95518b1d53426225f1ff49fc"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_8.Pages
{
    #line hidden
    using System;
    using System.Threading.Tasks;
#nullable restore
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Tarea_8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Tarea_8.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
using Tarea_8.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrar_vacuna")]
    public partial class Registrar_vacuna : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    #pa {\r\n        justify-content: center;\r\n    }\r\n</style>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h1 style=\"text-align: center; color: white; height: 65px\" class=\"mt-2 col-md-12 mb-1 pt-2\">Registrar vacuna</h1>\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "pa");
            __builder.AddAttribute(7, "class", "row ml-auto");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "style", "width: 20%; text-align: left;");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "Digite una cédula");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                                                   cedula

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => cedula = __value, cedula));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        <br>\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-dark mb-3 ml-2");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                         DatosPersona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Buscar Datos");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        <br> <br>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    <br>  <br>\r\n    <hr style=\"background-color: white\">\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\r\n");
#nullable restore
#line 28 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
 if (cedula != "")
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
     if (validar)
    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "container");
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "label");
            __builder.AddAttribute(28, "style", "font-size: 20px;");
            __builder.AddMarkupContent(29, "<strong>Nombre: </strong> ");
            __builder.AddContent(30, 
#nullable restore
#line 34 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                               nombre_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(32, "label");
            __builder.AddAttribute(33, "style", "font-size: 20px;");
            __builder.AddMarkupContent(34, "<strong>Apellido: </strong> ");
            __builder.AddContent(35, 
#nullable restore
#line 36 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                 apellido_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "style", "font-size: 20px;");
            __builder.AddMarkupContent(39, "<strong>Fecha de nacimiento: </strong> ");
            __builder.AddContent(40, 
#nullable restore
#line 38 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                            fecha_nacimiento_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(42, "label");
            __builder.AddAttribute(43, "style", "font-size: 20px;");
            __builder.AddMarkupContent(44, "<strong>Signo Zodiaco: </strong> ");
            __builder.AddContent(45, 
#nullable restore
#line 40 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                      signo_zodiaco_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "style", "font-size: 20px;");
            __builder.AddMarkupContent(49, "<strong>Telefono: </strong> ");
            __builder.AddContent(50, 
#nullable restore
#line 42 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                 telefono_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(52, "label");
            __builder.AddAttribute(53, "style", "font-size: 20px;");
            __builder.AddMarkupContent(54, "<strong>Id vacuna: </strong> ");
            __builder.AddContent(55, 
#nullable restore
#line 44 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                  idvacuna_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(57, "label");
            __builder.AddAttribute(58, "style", "font-size: 20px;");
            __builder.AddMarkupContent(59, "<strong>Id provincia: </strong> ");
            __builder.AddContent(60, 
#nullable restore
#line 46 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                     idprovincia_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(62, "label");
            __builder.AddAttribute(63, "style", "font-size: 20px;");
            __builder.AddMarkupContent(64, "<strong>Fecha dosis 1: </strong> ");
            __builder.AddContent(65, 
#nullable restore
#line 48 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                      primeradosis_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(67, "label");
            __builder.AddAttribute(68, "style", "font-size: 20px;");
            __builder.AddMarkupContent(69, "<strong>Latitud: </strong> ");
            __builder.AddContent(70, 
#nullable restore
#line 50 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                lat_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(72, "label");
            __builder.AddAttribute(73, "style", "font-size: 20px;");
            __builder.AddMarkupContent(74, "<strong>Longitud: </strong> ");
            __builder.AddContent(75, 
#nullable restore
#line 52 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                 lon_registrado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n    <br> <br>\r\n    ");
            __builder.AddMarkupContent(77, "<label style=\"font-size: 20px;\"><strong>Fecha de la segunda dosis</strong></label>\r\n    ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "style", "width: 50%;");
            __builder.AddAttribute(80, "type", "text");
            __builder.AddAttribute(81, "class", "form-control");
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                             segundadosis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => segundadosis = __value, segundadosis));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "btn btn-dark");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                           AplicarDosis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Aplicar segunda dosis");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n    <br>\r\n");
#nullable restore
#line 59 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
     if (mensaje == 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(90, "        ");
            __builder.AddMarkupContent(91, "<div class=\"alert alert-success\" role=\"alert\">Segunda dosis aplicada</div>\r\n");
#nullable restore
#line 62 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 64 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
    }

    else
    {

        

#line default
#line hidden
#nullable disable
            __builder.OpenElement(93, "div");
            __builder.AddAttribute(94, "class", "container");
            __builder.AddMarkupContent(95, "\r\n    ");
            __builder.OpenElement(96, "label");
            __builder.AddAttribute(97, "style", "font-size: 20px;");
            __builder.AddMarkupContent(98, "<strong>Nombre: </strong> ");
            __builder.AddContent(99, 
#nullable restore
#line 71 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                               nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(101, "label");
            __builder.AddAttribute(102, "style", "font-size: 20px;");
            __builder.AddMarkupContent(103, "<strong>Apellido: </strong> ");
            __builder.AddContent(104, 
#nullable restore
#line 73 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                 apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(106, "label");
            __builder.AddAttribute(107, "style", "font-size: 20px;");
            __builder.AddMarkupContent(108, "<strong>Fecha de nacimiento: </strong> ");
            __builder.AddContent(109, 
#nullable restore
#line 75 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                            fecha_nacimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(111, "label");
            __builder.AddAttribute(112, "style", "font-size: 20px;");
            __builder.AddMarkupContent(113, "<strong>Signo zodiaco:</strong> ");
            __builder.AddContent(114, 
#nullable restore
#line 77 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                     signo_zodiaco

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n    <br> <br>\r\n    ");
            __builder.OpenElement(116, "input");
            __builder.AddAttribute(117, "style", "width: 50%;");
            __builder.AddAttribute(118, "type", "text");
            __builder.AddAttribute(119, "class", "form-control");
            __builder.AddAttribute(120, "placeholder", "Digite un teléfono");
            __builder.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 79 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                             telefono

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => telefono = __value, telefono));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n    <br> <br>\r\n    ");
            __builder.AddMarkupContent(124, "<label style=\"font-size: 20px;\"><strong>Selecciona una vacuna</strong></label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(125);
            __builder.AddAttribute(126, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 82 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                     vacunas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(127, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(128, "\r\n        ");
                __Blazor.Tarea_8.Pages.Registrar_vacuna.TypeInference.CreateInputSelect_0(__builder2, 129, 130, "form-control", 131, "width: 50%;", 132, 
#nullable restore
#line 83 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                  idvacuna

#line default
#line hidden
#nullable disable
                , 133, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idvacuna = __value, idvacuna)), 134, () => idvacuna, 135, (__builder3) => {
                    __builder3.AddMarkupContent(136, "\r\n");
#nullable restore
#line 84 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
             foreach (var vacu in vacunas)
                    {


#line default
#line hidden
#nullable disable
                    __builder3.AddContent(137, "                ");
                    __builder3.OpenElement(138, "option");
                    __builder3.AddAttribute(139, "style", "color: black");
                    __builder3.AddAttribute(140, "value", 
#nullable restore
#line 87 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                     vacu.id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(141, 
#nullable restore
#line 87 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                               vacu.marca

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(142, "\r\n");
#nullable restore
#line 88 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(143, "        ");
                }
                );
                __builder2.AddMarkupContent(144, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(145, "\r\n    <br><br>\r\n    ");
            __builder.AddMarkupContent(146, "<label style=\"font-size: 20px;\"><strong>Selecciona una provincia</strong></label>\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(147);
            __builder.AddAttribute(148, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 93 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                     provincias

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(149, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(150, "\r\n        ");
                __Blazor.Tarea_8.Pages.Registrar_vacuna.TypeInference.CreateInputSelect_1(__builder2, 151, 152, "form-control", 153, "width: 50%;", 154, 
#nullable restore
#line 94 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                  idprovincia

#line default
#line hidden
#nullable disable
                , 155, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => idprovincia = __value, idprovincia)), 156, () => idprovincia, 157, (__builder3) => {
                    __builder3.AddMarkupContent(158, "\r\n");
#nullable restore
#line 95 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
             foreach (var pro in provincias)
                    {


#line default
#line hidden
#nullable disable
                    __builder3.AddContent(159, "                ");
                    __builder3.OpenElement(160, "option");
                    __builder3.AddAttribute(161, "style", "color: black");
                    __builder3.AddAttribute(162, "value", 
#nullable restore
#line 98 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                     pro.id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(163, 
#nullable restore
#line 98 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                              pro.Provincia

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(164, "\r\n");
#nullable restore
#line 99 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(165, "        ");
                }
                );
                __builder2.AddMarkupContent(166, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(167, "\r\n    <br><br>\r\n    ");
            __builder.AddMarkupContent(168, "<label style=\"font-size: 20px;\"><strong>Fecha de la primera dosis</strong></label>\r\n    ");
            __builder.OpenElement(169, "input");
            __builder.AddAttribute(170, "style", "width: 50%;");
            __builder.AddAttribute(171, "type", "text");
            __builder.AddAttribute(172, "class", "form-control");
            __builder.AddAttribute(173, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 104 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                             primeradosis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(174, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => primeradosis = __value, primeradosis));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(176, "input");
            __builder.AddAttribute(177, "style", "width: 50%;");
            __builder.AddAttribute(178, "type", "text");
            __builder.AddAttribute(179, "class", "form-control");
            __builder.AddAttribute(180, "placeholder", "Digite la latitud");
            __builder.AddAttribute(181, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 106 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                             lat

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(182, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lat = __value, lat));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(183, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(184, "input");
            __builder.AddAttribute(185, "style", "width: 50%;");
            __builder.AddAttribute(186, "type", "text");
            __builder.AddAttribute(187, "class", "form-control");
            __builder.AddAttribute(188, "placeholder", "Digite la longitud");
            __builder.AddAttribute(189, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 108 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                             lon

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(190, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => lon = __value, lon));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n    <br><br>\r\n    ");
            __builder.OpenElement(192, "button");
            __builder.AddAttribute(193, "class", "btn btn-dark");
            __builder.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                           EnviarDatos

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(195, "Enviar datos");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n    <br>\r\n");
#nullable restore
#line 112 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
     if (mensaje == 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(197, "        ");
            __builder.AddMarkupContent(198, "<div class=\"alert alert-success\" role=\"alert\">Datos subidos correctamente</div>\r\n");
#nullable restore
#line 115 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n");
#nullable restore
#line 117 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                                              
    string cedula = "", nombre = "", apellido = "", telefono = "", fecha_nacimiento = "", signo_zodiaco = "", primeradosis = "", idvacuna = "", idprovincia = "", lat = "", lon = "";

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                   
    string nombre_registrado = "", apellido_registrado = "", telefono_registrado = "", fecha_nacimiento_registrado = "", signo_zodiaco_registrado = "", primeradosis_registrado = "", idvacuna_registrado = "", idprovincia_registrado = "", lat_registrado = "", lon_registrado = "", segundadosis = "";

    //Campo para validar entrada
    bool validar;

    //Campo para mostrar que se ha ingresado con exito la persona
    int mensaje = 0;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\Ramirez Rodriguez\Desktop\Héctor\Itla\Materias\Programación III\Tarea-8\Tarea-8\Pages\Registrar-vacuna.razor"
                                                          
Data.DatosCedula padron = new Data.DatosCedula();
public List<inventario> GetInventarios() => new Contexto().Inventarios.ToList();
public List<provincia> GetProvincias() => new Contexto().Provincias.ToList();
public List<inventario> vacunas;
public List<provincia> provincias;

protected override void OnInitialized()
{
    vacunas = GetInventarios();
    provincias = GetProvincias();
}


public void DatosPersona()
{
    //Validando si la persona ingresada está en la bd
    using (Contexto context = new Contexto())
    {
        validar = context.Vacunadas.Any(ee => ee.Cedula == cedula);

        if (validar)
        {
            Vacunados va = context.Vacunadas
                        .Where(e => e.Cedula == cedula)
                        .FirstOrDefault();

            nombre_registrado = va.Nombre;
            apellido_registrado = va.Apellido;
            telefono_registrado = va.Telefono;
            fecha_nacimiento_registrado = va.Fecha_nacimiento;
            signo_zodiaco_registrado = va.signo_zodiaco;
            primeradosis_registrado = va.Fecha_Dosis1;
            idvacuna_registrado = va.Vacuna_recibida.ToString();
            idprovincia_registrado = va.Provincia.ToString();
            lat_registrado = va.Lat;
            lon_registrado = va.Lon;
        }

        else
        {
            //Asignando los valores a las variables creadas anteriormente
            var personaje = padron.Datos(cedula);
            nombre = personaje.Nombres;
            apellido = personaje.Apellido1 + " " + personaje.Apellido2;
            fecha_nacimiento = Convert.ToDateTime(personaje.FechaNacimiento).ToString("MM/dd/yyyy");
            int dia_zodiaco = int.Parse(Convert.ToDateTime(personaje.FechaNacimiento).ToString("dd"));
            int mes_zodiaco = int.Parse(Convert.ToDateTime(personaje.FechaNacimiento).ToString("MM"));
            signo_zodiaco = signo(dia_zodiaco, mes_zodiaco);
        }
    }
}

public void EnviarDatos()
{
    Modelos.Vacunados vacu = new Modelos.Vacunados();
    vacu.Cedula = cedula;
    vacu.Nombre = nombre;
    vacu.Apellido = apellido;
    vacu.Fecha_nacimiento = fecha_nacimiento;
    vacu.Telefono = telefono;
    vacu.signo_zodiaco = signo_zodiaco;
    vacu.Vacuna_recibida = int.Parse(idvacuna);
    vacu.Provincia = int.Parse(idprovincia);
    vacu.Fecha_Dosis1 = primeradosis;
    vacu.Lat = lat;
    vacu.Lon = lon;
    using (Contexto context = new Contexto())
    {
        var inventario = context.Inventarios.Find(int.Parse(idvacuna));
        inventario.cantidad = inventario.cantidad - 1;
        context.Add(vacu);
        context.SaveChanges();
    }

    mensaje = 1;

}

public void AplicarDosis()
{

    using (Contexto context = new Contexto())
    {
        Vacunados va = context.Vacunadas
                .Where(e => e.Cedula == cedula)
                .FirstOrDefault();

        var id = va.Id;
        var vacunados = context.Vacunadas.Find(id);
        vacunados.Fecha_Dosis2 = segundadosis;
        var inventario = context.Inventarios.Find(int.Parse(idvacuna_registrado));
        inventario.cantidad = inventario.cantidad - 1;

        context.SaveChanges();
    }

    mensaje = 1;

}

public string signo(int dia, int mes)
{
    if ((dia >= 21 && mes == 3) || (dia <= 20 && mes == 4))
        return "Aries";

    if ((dia >= 24 && mes == 9) || (dia <= 23 && mes == 10))
        return "Libra";

    if ((dia >= 21 && mes == 4) || (dia <= 21 && mes == 5))
        return "Tauro";

    if ((dia >= 24 && mes == 10) || (dia <= 22 && mes == 11))
        return "Escorpio";

    if ((dia >= 22 && mes == 5) || (dia <= 21 && mes == 6))
        return "Géminis";

    if ((dia >= 23 && mes == 11) || (dia <= 21 && mes == 12))
        return "Sagitario";

    if ((dia >= 21 && mes == 6) || (dia <= 23 && mes == 7))
        return "Cáncer";

    if ((dia >= 22 && mes == 12) || (dia <= 20 && mes == 1))
        return "Capricornio";

    if ((dia >= 24 && mes == 7) || (dia <= 23 && mes == 8))
        return "Leo";

    if ((dia >= 21 && mes == 1) || (dia <= 19 && mes == 2))
        return "Acuario";

    if ((dia >= 24 && mes == 8) || (dia <= 23 && mes == 9))
        return "Virgo";

    if ((dia >= 20 && mes == 2) || (dia <= 20 && mes == 3))
        return "Piscis";

    return "";
}


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.Tarea_8.Pages.Registrar_vacuna
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
