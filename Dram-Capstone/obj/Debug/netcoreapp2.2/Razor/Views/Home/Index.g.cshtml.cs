#pragma checksum "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1096d65776c53a3568fcb009c46a0a42a440ccd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\_ViewImports.cshtml"
using Dram_Capstone;

#line default
#line hidden
#line 2 "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\_ViewImports.cshtml"
using Dram_Capstone.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1096d65776c53a3568fcb009c46a0a42a440ccd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85910785503533cdb305f921c9a669901a8a7d1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dram_Capstone.Models.WhiskeyViewModels.WhiskeyHomeIndexView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(117, 98, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-sm-6\">\r\n        <h2>Recent Whiskey Reviews on Dram</h2>\r\n");
            EndContext();
#line 11 "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\Home\Index.cshtml"
         foreach (var item in Model.OthersWhiskeys)
        {

#line default
#line hidden
            BeginContext(279, 62, true);
            WriteLiteral("            <div>\r\n                <div>\r\n                    ");
            EndContext();
            BeginContext(342, 121, false);
#line 15 "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\Home\Index.cshtml"
               Write(Html.ActionLink(($"{item.WhiskeyEntry} reviewed by {item.User.Id} "), "Details", "Whiskeys", new { id = item.WhiskeyId }));

#line default
#line hidden
            EndContext();
            BeginContext(463, 46, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 18 "C:\Users\nickh\workspace\Dram-Capstone\Dram-Capstone\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(520, 52, true);
            WriteLiteral("    </div>\r\n            <h2>Favorite Whiskeys</h2>\r\n");
            EndContext();
            BeginContext(1015, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dram_Capstone.Models.WhiskeyViewModels.WhiskeyHomeIndexView> Html { get; private set; }
    }
}
#pragma warning restore 1591
