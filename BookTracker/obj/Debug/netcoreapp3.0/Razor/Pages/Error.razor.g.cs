#pragma checksum "C:\BookTracker\BookTracker\BookTracker\Pages\Error.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eeca9cdb6fde0c11029a10d88f1c7e7dadae8a5c"
// <auto-generated/>
#pragma warning disable 1591
namespace BookTracker.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using BookTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BookTracker\BookTracker\BookTracker\_Imports.razor"
using BookTracker.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/error")]
    public class Error : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Error.</h1>\r\n");
            __builder.AddMarkupContent(1, "<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            __builder.AddMarkupContent(2, "<h3>Development Mode</h3>\r\n");
            __builder.AddMarkupContent(3, "<p>\r\n    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.\r\n</p>\r\n");
            __builder.AddMarkupContent(4, @"<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
