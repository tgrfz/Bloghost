#pragma checksum "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dfe44b25a3e45ed990efc63549ba29d97d7266a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages__ViewPost), @"mvc.1.0.view", @"/Pages/_ViewPost.cshtml")]
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
#line 1 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
using Bloghost.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dfe44b25a3e45ed990efc63549ba29d97d7266a", @"/Pages/_ViewPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acb448efc5dfbae4f3a40efe2956d945f6fba66", @"/Pages/_ViewImports.cshtml")]
    public class Pages__ViewPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
   
    var Post = db.Posts.Find(Model);
    var Blog = db.Blogs.Find(Post.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"font-family:Arial;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2 text-right\" style=\"font-size:16px; margin:6pt\">\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 333, "\"", 359, 2);
            WriteAttributeValue("", 340, "/Blog/", 340, 6, true);
#nullable restore
#line 14 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
WriteAttributeValue("", 346, Blog.Address, 346, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 14 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                         Write(Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                <text style=\"color:dimgray\">");
#nullable restore
#line 17 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                       Write(Post.CreateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 20 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
             foreach (var tag in Post.Tags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <a style=\"word-wrap:break-word\">");
#nullable restore
#line 23 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                               Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 25 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-8\">\r\n            <h1>\r\n                <a style=\"color:black; font-size:larger; font-weight:700; word-wrap:break-word\"");
            BeginWriteAttribute("href", "  href=\"", 891, "\"", 933, 4);
            WriteAttributeValue("", 899, "/Blog/", 899, 6, true);
#nullable restore
#line 29 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
WriteAttributeValue("", 905, Blog.Address, 905, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 918, "/Post/", 918, 6, true);
#nullable restore
#line 29 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
WriteAttributeValue("", 924, Post.Url, 924, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                                                                                                                      Write(Post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </h1>\r\n            <hr style=\"width:inherit\"/>\r\n            <pre style=\"font-size:16px; max-height:500px; overflow-y:scroll; white-space:pre-wrap; word-wrap:break-word\">");
#nullable restore
#line 32 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                                                                                                    Write(Post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationDBContext db { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
