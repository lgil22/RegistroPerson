#pragma checksum "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8cc1c9c8ec7d5e28320a2714772f00e5060db3"
// <auto-generated/>
#pragma warning disable 1591
namespace RegistroPerson.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using RegistroPerson;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using RegistroPerson.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Aplicada2\RegistroPerson\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
using RegistroPerson.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
using RegistroPerson.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Personas")]
    public partial class PersonaComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Registro</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                 persona

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnInvalidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                           Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n    ");
                __builder2.AddMarkupContent(10, "<label for=\"Id\">ID:</label>\r\n    ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "input-group");
                __builder2.AddMarkupContent(13, "\r\n        ");
                __Blazor.RegistroPerson.Pages.PersonaComponent.TypeInference.CreateInputNumber_0(__builder2, 14, 15, "form-control", 16, 
#nullable restore
#line 18 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                  persona.personaId

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.personaId = __value, persona.personaId)), 18, () => persona.personaId);
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "input-group-append");
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "button");
                __builder2.AddAttribute(24, "type", "button");
                __builder2.AddAttribute(25, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                                                            Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(27, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n    ");
                __builder2.OpenElement(31, "p");
                __builder2.AddAttribute(32, "class", "nombre");
                __builder2.AddMarkupContent(33, "\r\n        Nombre: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                        persona.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.nombre = __value, persona.nombre))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n\r\n    ");
                __builder2.OpenElement(41, "p");
                __builder2.AddAttribute(42, "class", "telefono");
                __builder2.AddMarkupContent(43, "\r\n        Telefono: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "class", "form-control");
                __builder2.AddAttribute(46, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                          persona.telefono

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.telefono = __value, persona.telefono))));
                __builder2.AddAttribute(48, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.telefono));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(49, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n\r\n    ");
                __builder2.OpenElement(51, "p");
                __builder2.AddAttribute(52, "class", "cedula");
                __builder2.AddMarkupContent(53, "\r\n        Cedula: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "class", "form-control");
                __builder2.AddAttribute(56, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                        persona.cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.cedula = __value, persona.cedula))));
                __builder2.AddAttribute(58, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.cedula));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n\r\n    ");
                __builder2.OpenElement(61, "p");
                __builder2.AddAttribute(62, "class", "direccion");
                __builder2.AddMarkupContent(63, "\r\n        Direccion: ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 38 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                           persona.direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.direccion = __value, persona.direccion))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => persona.direccion));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n\r\n    ");
                __builder2.OpenElement(71, "p");
                __builder2.AddAttribute(72, "class", "fecha");
                __builder2.AddMarkupContent(73, "\r\n        Fecha Nacimiento: ");
                __Blazor.RegistroPerson.Pages.PersonaComponent.TypeInference.CreateInputDate_1(__builder2, 74, 75, "form-control", 76, 
#nullable restore
#line 42 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                                  persona.fecha

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => persona.fecha = __value, persona.fecha)), 78, () => persona.fecha);
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n        ");
                __builder2.OpenElement(84, "button");
                __builder2.AddAttribute(85, "type", "button");
                __builder2.AddAttribute(86, "class", "btn btn-outline-secondary");
                __builder2.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                                                          Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(88, "NUEVO");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n        ");
                __builder2.OpenElement(90, "button");
                __builder2.AddAttribute(91, "type", "button");
                __builder2.AddAttribute(92, "class", "btn btn-outline-success");
                __builder2.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                                                        Guardar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(94, "Guardar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n        ");
                __builder2.OpenElement(96, "button");
                __builder2.AddAttribute(97, "type", "button");
                __builder2.AddAttribute(98, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
                                                                       Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(100, "ELIMINAR");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(102, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Aplicada2\RegistroPerson\Pages\PersonaComponent.razor"
       
    private Personas persona = new Personas();

    [Parameter]
    public int PersonaId { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        persona.fecha = DateTime.Now;
        Buscar();
    }

    private void Nuevo()
    {
        this.persona = new Personas();
    }

    private void Guardar()
    {
        bool guardado;

        guardado = PersonasBLL.Guardar(persona);

        if (guardado)
        {
            Nuevo();
            //toast.ShowSuccess("Guardado correctamente");
        }
      //  else
           // toast.ShowError("No fue posible guardar");

    }

    private void Buscar()
    {

        if (persona.personaId > 0)
        {
            var encontrado = PersonasBLL.Buscar(persona.personaId);
            if (encontrado != null)
                persona = encontrado;
          //  else
               // toast.ShowWarning("La persona no fue encontrado");
        }
    }

    private void Eliminar()
    {
        bool elimino;

        elimino = PersonasBLL.Eliminar(persona.personaId);

        if (elimino)
        {
            Nuevo();
           // toast.ShowSuccess("Persona eliminada correctamente");
        }
       // else
           // toast.ShowError("No fue posible eliminarla persona");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.RegistroPerson.Pages.PersonaComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
