#pragma checksum "D:\ThacSy\Do An\code-do-an\dbcontextpool-v1\dbcontexpool-v1\Pages\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0e311cc7028a692f01e4591633062c53098fa8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(EfQueryFilters.Pages.Pages_About), @"mvc.1.0.razor-page", @"/Pages/About.cshtml")]
namespace EfQueryFilters.Pages
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
#line 1 "D:\ThacSy\Do An\code-do-an\dbcontextpool-v1\dbcontexpool-v1\Pages\_ViewImports.cshtml"
using EfQueryFilters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ThacSy\Do An\code-do-an\dbcontextpool-v1\dbcontexpool-v1\Pages\About.cshtml"
using EfContextPooling.Pages;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0e311cc7028a692f01e4591633062c53098fa8a", @"/Pages/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acf8326613ed865911ddc735aa4a02b9e59d6293", @"/Pages/_ViewImports.cshtml")]
    public class Pages_About : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\ThacSy\Do An\code-do-an\dbcontextpool-v1\dbcontexpool-v1\Pages\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>");
#nullable restore
#line 7 "D:\ThacSy\Do An\code-do-an\dbcontextpool-v1\dbcontexpool-v1\Pages\About.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h3>");
#nullable restore
#line 8 "D:\ThacSy\Do An\code-do-an\dbcontextpool-v1\dbcontexpool-v1\Pages\About.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<p>Use this area to provide additional information.</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EfContextPooling.Pages.AboutModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EfContextPooling.Pages.AboutModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EfContextPooling.Pages.AboutModel>)PageContext?.ViewData;
        public EfContextPooling.Pages.AboutModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591