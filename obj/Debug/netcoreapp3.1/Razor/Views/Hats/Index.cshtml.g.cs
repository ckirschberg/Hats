#pragma checksum "/Users/christiankirschberg/repos/school/Hats/Views/Hats/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ffd722f4f45185f6fb0740763dd2f92d3027808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hats_Index), @"mvc.1.0.view", @"/Views/Hats/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/christiankirschberg/repos/school/Hats/Views/_ViewImports.cshtml"
using Hats;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/christiankirschberg/repos/school/Hats/Views/_ViewImports.cshtml"
using Hats.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ffd722f4f45185f6fb0740763dd2f92d3027808", @"/Views/Hats/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4f8a13d09ff5cd86e0d2cfddcc4db09272f9c81", @"/Views/_ViewImports.cshtml")]
    public class Views_Hats_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Hello from view</h1>\n\n");
#nullable restore
#line 3 "/Users/christiankirschberg/repos/school/Hats/Views/Hats/Index.cshtml"
Write(ViewBag.Play);

#line default
#line hidden
#nullable disable
            WriteLiteral(" No!");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
