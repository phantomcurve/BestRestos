#pragma checksum "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46b83995ac1dc4f11e81f7b52d4fc4a264cdbeb2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Restaurants_Index), @"mvc.1.0.view", @"/Views/Restaurants/Index.cshtml")]
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
#line 1 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
using BestRestos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46b83995ac1dc4f11e81f7b52d4fc4a264cdbeb2", @"/Views/Restaurants/Index.cshtml")]
    public class Views_Restaurants_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BestRestos.Models.Restaurant>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Restaurants</h1>\n\n");
#nullable restore
#line 6 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No restaurants have been added yet!</h3>\n");
#nullable restore
#line 9 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<ul>\n");
#nullable restore
#line 12 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
   foreach(Restaurant restaurant in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <li>");
#nullable restore
#line 14 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
     Write(Html.ActionLink($"{restaurant.Name}", "Details", new { id = restaurant.RestaurantId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 15 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
      //add breed, doa, and gender
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n\n<p>");
#nullable restore
#line 19 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
Write(Html.ActionLink("Add new restaurant", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 20 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
Write(Html.ActionLink("See all restaurants", "Index", "Restaurants"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> \n<p>");
#nullable restore
#line 21 "/Users/phantom/Desktop/best-restos/Views/Restaurants/Index.cshtml"
Write(Html.ActionLink("See all cuisines", "Index", "Cuisines"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BestRestos.Models.Restaurant>> Html { get; private set; }
    }
}
#pragma warning restore 1591
