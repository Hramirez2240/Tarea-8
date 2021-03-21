#pragma checksum "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0015736362a0d7d4afd6339bf0174785162f19b4"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea_8.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Tarea_8;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Tarea_8.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\2021\Tarea-8\Tarea-8\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
using Tarea_8.Modelos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/ver_mapa")]
    public partial class Ver_mapa : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container\">\r\n    <h1 style=\"text-align: center; color: white; height: 65px\" class=\"mt-2 col-md-12 mb-1 pt-2\">Mostrar mapa de vacunados</h1>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(1);
            __builder.AddAttribute(2, "Style", "height: 600px;");
            __builder.AddAttribute(3, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 9 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
                                               zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 9 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
                                                               new GoogleMapPosition() { Lat = 18.735693, Lng = -70.162651}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "MapClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.GoogleMapClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.GoogleMapClickEventArgs>(this, 
#nullable restore
#line 9 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
                                                                                                                                         OnMapClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "MarkerClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Radzen.Blazor.RadzenGoogleMapMarker>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Radzen.Blazor.RadzenGoogleMapMarker>(this, 
#nullable restore
#line 9 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
                                                                                                                                                                  OnMarkerClick

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(8, "\r\n");
#nullable restore
#line 11 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
         foreach (var vacu in GetVacunados())
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(9, "            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(10);
                __builder2.AddAttribute(11, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
                                           vacu.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 13 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
                                                                    new GoogleMapPosition() { Lat = Convert.ToDouble(vacu.lat), Lng = Convert.ToDouble(vacu.lon)}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n");
#nullable restore
#line 14 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(14, "    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\2021\Tarea-8\Tarea-8\Pages\Ver-mapa.razor"
       

    int zoom = 3;
    string click = "";

    void OnMapClick(GoogleMapClickEventArgs args) {

        click = $"Map click lat: {args.Position.Lat} Lon: {args.Position.Lng}";
    }

    void OnMarkerClick(RadzenGoogleMapMarker args) {

        click = $"Map click provincia: {args.Title} lat: {args.Position.Lat} Lon: {args.Position.Lng}";
    }

    List<DataConsultaVacunados> GetVacunados() =>
    (
        from p in new Contexto().Vacunadas
            //group p by p.signo_zodiaco into g
        select new DataConsultaVacunados
        {
            nombre = " ID: "+p.Id+" "+p.Nombre+" "+ p.Apellido+" ,Telefono: "+p.Telefono+" ,Vacuna aplicada: "+p.Vacuna_recibida,
            lat = p.Lat,
            lon = p.Lon
        }
    ).ToList();


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
