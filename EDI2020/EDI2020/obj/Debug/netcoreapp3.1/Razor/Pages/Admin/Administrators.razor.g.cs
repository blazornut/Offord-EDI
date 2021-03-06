#pragma checksum "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd25422fe7ae6e64d7748076c9f7c7af4f25acdb"
// <auto-generated/>
#pragma warning disable 1591
namespace EDI2020.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using EDI2020;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\_Imports.razor"
using EDI2020.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
using EDI2020.DAL.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
using EDI2020.DAL.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Admin/Admins")]
    public partial class Administrators : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Admins Page</h1>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Roles", "Administrators");
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __builder2.AddMarkupContent(5, "<h4>Current Admins</h4>\r\n");
#nullable restore
#line 12 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
         if (admins is null)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(6, "            ");
                __builder2.AddMarkupContent(7, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 15 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(8, "            ");
                __builder2.OpenElement(9, "table");
                __builder2.AddAttribute(10, "class", "table table-striped");
                __builder2.AddMarkupContent(11, "\r\n                ");
                __builder2.AddMarkupContent(12, @"<thead>
                    <tr>
                        <th>Name</th>
                        <th>Email</th>
                        <th>Password</th>
                        <th>Access</th>
                    </tr>
                </thead>
                ");
                __builder2.OpenElement(13, "tbody");
                __builder2.AddMarkupContent(14, "\r\n");
#nullable restore
#line 28 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
                     foreach (var admin in admins)
                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(15, "                        ");
                __builder2.OpenElement(16, "tr");
                __builder2.AddMarkupContent(17, "\r\n                            ");
                __builder2.OpenElement(18, "td");
                __builder2.AddContent(19, 
#nullable restore
#line 31 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
                                 admin.StrName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                            ");
                __builder2.OpenElement(21, "td");
                __builder2.AddContent(22, 
#nullable restore
#line 32 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
                                 admin.StrEmail

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                            ");
                __builder2.OpenElement(24, "td");
                __builder2.AddContent(25, 
#nullable restore
#line 33 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
                                 admin.StrPassword

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                            ");
                __builder2.OpenElement(27, "td");
                __builder2.AddContent(28, 
#nullable restore
#line 34 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
                                 admin.IntAccess

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n");
#nullable restore
#line 36 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(31, "                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n");
#nullable restore
#line 39 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(34, "        ");
            }
            ));
            __builder.AddAttribute(35, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n        ");
                __builder2.AddMarkupContent(37, "<h4>Sorry you are not authorized to view the admins.</h4>\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\andre\source\repos\Sources\Offord-EDI\EDI2020\EDI2020\Pages\Admin\Administrators.razor"
       

    
    private List<Admin> admins;
    
        protected override Task OnInitializedAsync()
        {   
            
            admins = edi.Admins.ToList();
            return base.OnInitializedAsync();
        }    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private EDI2020Context edi { get; set; }
    }
}
#pragma warning restore 1591
