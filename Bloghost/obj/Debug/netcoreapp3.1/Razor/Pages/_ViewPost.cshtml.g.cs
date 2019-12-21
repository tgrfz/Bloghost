#pragma checksum "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61be2354ace1877498f3684b8cf3a973cad08fe0"
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
#nullable restore
#line 3 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
using Bloghost.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61be2354ace1877498f3684b8cf3a973cad08fe0", @"/Pages/_ViewPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acb448efc5dfbae4f3a40efe2956d945f6fba66", @"/Pages/_ViewImports.cshtml")]
    public class Pages__ViewPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
  
    var Post = db.Posts.Find(Model);
    var Blog = db.Blogs.Find(Post.BlogId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"font-family:Arial;\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2 text-right\" style=\"font-size:16px; margin:6pt\">\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 433, "\"", 459, 2);
            WriteAttributeValue("", 440, "/Blog/", 440, 6, true);
#nullable restore
#line 17 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
WriteAttributeValue("", 446, Blog.Address, 446, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                         Write(Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                <text style=\"color:dimgray\">");
#nullable restore
#line 20 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                       Write(Post.CreateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 23 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
             foreach (var tag in Post.Tags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <a style=\"word-wrap:break-word\">");
#nullable restore
#line 26 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                               Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 28 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-md-8"">
            <div class=""row"">
                <div style=""margin:auto auto auto 12px"">
                    <h1>
                        <a style=""color:black; font-size:larger; font-weight:700; word-wrap:break-word""");
            BeginWriteAttribute("href", " href=\"", 1096, "\"", 1137, 4);
            WriteAttributeValue("", 1103, "/Blog/", 1103, 6, true);
#nullable restore
#line 34 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
WriteAttributeValue("", 1109, Blog.Address, 1109, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1122, "/Post/", 1122, 6, true);
#nullable restore
#line 34 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
WriteAttributeValue("", 1128, Post.Url, 1128, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 34 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                                                                                                                             Write(Post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h1>\r\n                </div>\r\n            </div>\r\n            <hr style=\"width:inherit\" />\r\n            <pre style=\"font-size:16px; max-height:500px; overflow-y:scroll; white-space:pre-wrap; word-wrap:break-word\">");
#nullable restore
#line 39 "D:\Projects\dotnet\bloghost\Bloghost\Pages\_ViewPost.cshtml"
                                                                                                                    Write(Post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
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