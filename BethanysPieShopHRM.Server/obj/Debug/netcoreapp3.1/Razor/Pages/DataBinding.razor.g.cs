#pragma checksum "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35a890b945f7935a5f4cf68a8d5cf42a937670c8"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\_Imports.razor"
using BethanysPieShopHRM.ComponentsLibrary.Map;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/databinding")]
    public partial class DataBinding : DataBindingBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DataBinding</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h2>One Way</h2>\r\n    Employee First Name: ");
            __builder.OpenElement(4, "label");
            __builder.AddContent(5, 
#nullable restore
#line 8 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                 Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    Employee Last Name: ");
            __builder.OpenElement(7, "label");
            __builder.AddContent(8, 
#nullable restore
#line 9 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.AddMarkupContent(13, "<h2>One Way Form Control</h2>\r\n    Employee First Name: ");
            __builder.OpenElement(14, "input");
            __builder.AddAttribute(15, "value", 
#nullable restore
#line 14 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    Employee Last Name: ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "value", 
#nullable restore
#line 15 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                       Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.AddMarkupContent(23, "<h2>Two Way Form Control</h2>\r\n    Employee First Name: ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                        Employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.FirstName = __value, Employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    Employee Last Name: ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                       Employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(30, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.LastName = __value, Employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n");
            __builder.OpenElement(33, "div");
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.AddMarkupContent(35, "<h2>Two Way Form Control on input</h2>\r\n    Employee First Name: ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                              Employee.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.FirstName = __value, Employee.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    Employee Last Name: ");
            __builder.OpenElement(40, "input");
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 28 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                                             Employee.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Employee.LastName = __value, Employee.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n\r\n");
            __builder.OpenElement(45, "div");
            __builder.AddMarkupContent(46, "\r\n    ");
            __builder.AddMarkupContent(47, "<h2>Two Way Form code</h2>\r\n   \r\n    ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Anasr\source\repos\BethanysPieShopHRM.Server\BethanysPieShopHRM.Server\Pages\DataBinding.razor"
                        ()=>ChangeEmpFirstName("wewewe")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(50, "Click");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591