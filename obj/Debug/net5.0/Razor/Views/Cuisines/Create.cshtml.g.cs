#pragma checksum "/Users/phantom/Desktop/best-restos/Views/Cuisines/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21a83287876bb44bb2f678dacffd93d88f1bf037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuisines_Create), @"mvc.1.0.view", @"/Views/Cuisines/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21a83287876bb44bb2f678dacffd93d88f1bf037", @"/Views/Cuisines/Create.cshtml")]
    public class Views_Cuisines_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BestRestos.Models.Cuisine>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h4>Add a new cuisine</h4>\n");
#nullable restore
#line 4 "/Users/phantom/Desktop/best-restos/Views/Cuisines/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/phantom/Desktop/best-restos/Views/Cuisines/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/phantom/Desktop/best-restos/Views/Cuisines/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new cuisine\" />\n");
#nullable restore
#line 9 "/Users/phantom/Desktop/best-restos/Views/Cuisines/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 10 "/Users/phantom/Desktop/best-restos/Views/Cuisines/Create.cshtml"
Write(Html.ActionLink("Show all cuisines", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BestRestos.Models.Cuisine> Html { get; private set; }
    }
}
#pragma warning restore 1591
