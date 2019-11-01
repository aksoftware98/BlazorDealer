#pragma checksum "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bb45ef0a62fa2d0cc538658d6b147fc810b4b45"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorDealer.Admin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using BlazorDealer.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\_Imports.razor"
using BlazorDealer.Admin.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(AuthLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Register")]
    public class Register : RegisterBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                     Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                                           async () => await RegisterAsync()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n");
#nullable restore
#line 6 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
         if (Message != null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(5, "            ");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "alert alert-danger");
                __builder2.AddMarkupContent(8, "\r\n                ");
                __builder2.AddContent(9, 
#nullable restore
#line 9 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                 Message

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(11, "\r\n");
#nullable restore
#line 11 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(12, "        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.AddMarkupContent(16, "<label>Email address</label>\r\n            ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "type", "email");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "placeholder", "Email");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                                             Model.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Email = __value, Model.Email));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.AddMarkupContent(28, "<label>Password</label>\r\n            ");
                __builder2.OpenElement(29, "input");
                __builder2.AddAttribute(30, "type", "password");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "placeholder", "Password");
                __builder2.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                                          Model.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.Password = __value, Model.Password));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n            ");
                __builder2.AddMarkupContent(40, "<label>Confirm Password</label>\r\n            ");
                __builder2.OpenElement(41, "input");
                __builder2.AddAttribute(42, "type", "password");
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "placeholder", "Confirm Password");
                __builder2.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                                          Model.ConfirmPassword

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Model.ConfirmPassword = __value, Model.ConfirmPassword));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "type", "submit");
                __builder2.AddAttribute(51, "disabled", 
#nullable restore
#line 24 "C:\Users\dell\source\repos\BlazorDealer\BlazorDealer.Admin\Pages\Register.razor"
                                         IsBusy

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(52, "class", "btn btn-success btn-flat m-b-30 m-t-30");
                __builder2.AddContent(53, "Create Account");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n        ");
                __builder2.AddMarkupContent(55, "<div class=\"register-link m-t-15 text-center\">\r\n            <p>Already have an account? <a href=\"/Register\"> Login Here</a></p>\r\n        </div>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591