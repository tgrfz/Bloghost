#pragma checksum "D:\Projects\dotnet\bloghost\Bloghost\Pages\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e96bda42aa6f6b6618dc70196e8c359a3c7f85aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Error), @"mvc.1.0.razor-page", @"/Pages/Error.cshtml")]
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
#line 1 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewImports.cshtml"
using Bloghost;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Error.cshtml"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e96bda42aa6f6b6618dc70196e8c359a3c7f85aa", @"/Pages/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acb448efc5dfbae4f3a40efe2956d945f6fba66", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Error : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center\">Error ");
#nullable restore
#line 8 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Error.cshtml"
                         Write(Request.Query["code"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 8 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Error.cshtml"
                                                 Write(ReasonPhrases.GetReasonPhrase(Int32.Parse(Request.Query["code"])));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bloghost.Pages.ErrorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bloghost.Pages.ErrorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bloghost.Pages.ErrorModel>)PageContext?.ViewData;
        public Bloghost.Pages.ErrorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
