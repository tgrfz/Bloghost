#pragma checksum "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a16cf0fde9cb56ce99734ad52f0bbd06791df51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Blog_Post), @"mvc.1.0.razor-page", @"/Pages/Blog/Post.cshtml")]
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
#line 2 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
using Bloghost.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
using Bloghost.Domain;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/Blog/{blogAddress}/Post/{url}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a16cf0fde9cb56ce99734ad52f0bbd06791df51", @"/Pages/Blog/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4acb448efc5dfbae4f3a40efe2956d945f6fba66", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Blog_Post : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "deletecomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("autocomplete", new global::Microsoft.AspNetCore.Html.HtmlString("off"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/signalr.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 9 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
  
    ViewData["Title"] = Model.Post.Title;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"font-family:Arial\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-2 text-right\" style=\"font-size:16px; margin:6pt\">\r\n            <div>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 500, "\"", 532, 2);
            WriteAttributeValue("", 507, "/Blog/", 507, 6, true);
#nullable restore
#line 17 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
WriteAttributeValue("", 513, Model.Blog.Address, 513, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 17 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                               Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <div>\r\n                <text style=\"color:dimgray\">");
#nullable restore
#line 20 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                       Write(Model.Post.CreateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n            </div>\r\n            <div>\r\n                <text style=\"color:dimgray\">");
#nullable restore
#line 23 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                       Write(Model.Post.CreateTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n            </div>\r\n            <br />\r\n");
#nullable restore
#line 26 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
             foreach (var tag in Model.Post.Tags)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 976, "\"", 992, 2);
            WriteAttributeValue("", 983, "/Tag/", 983, 5, true);
#nullable restore
#line 29 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
WriteAttributeValue("", 988, tag, 988, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"word-wrap:break-word\">");
#nullable restore
#line 29 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                </div>\r\n");
#nullable restore
#line 31 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
        <div class=""col-md-8"">
            <div class=""row"">
                <div style=""margin:auto auto auto 12px"">
                    <h1>
                        <a style=""color:black; font-size:larger; font-weight:700; word-wrap:break-word"">");
#nullable restore
#line 37 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                                                   Write(Model.Post.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </h1>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                 if (UserManager.GetUserId(User) == Model.Blog.AuthorId)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"row\" style=\"margin:auto 15px auto auto\">\r\n                        <a class=\"btn btn-link\" style=\"margin-right:6px\"");
            BeginWriteAttribute("href", " href=\"", 1652, "\"", 1709, 4);
            WriteAttributeValue("", 1659, "/Blog/", 1659, 6, true);
#nullable restore
#line 43 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
WriteAttributeValue("", 1665, Model.Blog.Address, 1665, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1684, "/PostEdit/", 1684, 10, true);
#nullable restore
#line 43 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
WriteAttributeValue("", 1694, Model.Post.Url, 1694, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5111986", async() => {
                WriteLiteral("<button class=\"btn btn-link\">Delete</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 46 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                }
                else
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                 if (User.Identity.IsAuthenticated && (User.IsInRole("admin") || User.IsInRole("moderator")))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div style=\"margin:auto 15px auto auto\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5114287", async() => {
                WriteLiteral("<button class=\"btn btn-link\">Delete</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 53 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n            <pre style=\"font-size:16px; white-space:pre-wrap; word-wrap:break-word\">");
#nullable restore
#line 55 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                               Write(Model.Post.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<hr />\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\" style=\"margin:6pt\">\r\n\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <h2>Comments</h2>\r\n\r\n");
#nullable restore
#line 69 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
         foreach (var comment in Model.Comments)
        {
            var author = db.Users.Find(comment.AuthorId);


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"font-family:Arial; margin: 8px\">\r\n                <div class=\"row\">\r\n                    <div>\r\n                        <a style=\"font-size:16px; margin:auto 8px\"");
            BeginWriteAttribute("href", " href=\"", 2899, "\"", 2928, 2);
            WriteAttributeValue("", 2906, "/User/", 2906, 6, true);
#nullable restore
#line 76 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
WriteAttributeValue("", 2912, author.UserName, 2912, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 76 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                                            Write(author.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div>\r\n                        <text style=\"color:dimgray; font-size:12px\">");
#nullable restore
#line 79 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                               Write(comment.CreateTime.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" at ");
#nullable restore
#line 79 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                                                          Write(comment.CreateTime.ToShortTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n                    </div>\r\n");
#nullable restore
#line 81 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                     if (User.Identity.IsAuthenticated && (User.IsInRole("admin") || User.IsInRole("moderator")))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div style=\"margin:auto 15px auto auto; font-size:14px\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5119216", async() => {
                WriteLiteral("<button class=\"btn btn-link\">Delete</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-commId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                                       WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["commId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-commId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["commId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 86 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n                <div>\r\n                    <pre style=\"font-size:16px; white-space:pre-wrap; word-wrap:break-word\">");
#nullable restore
#line 89 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
                                                                                       Write(comment.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</pre>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 92 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
         if (SignInManager.IsSignedIn(User))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div style=\"margin:6px\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5123083", async() => {
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5123362", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 97 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    <div class=\"form-group\">\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5125078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 99 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.CommentContent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5126780", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 100 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Input.CommentContent);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <button id=\"commBtn\" type=\"submit\" class=\"btn btn-primary\"");
                BeginWriteAttribute("onsubmit", " onsubmit=\"", 4528, "\"", 4562, 3);
                WriteAttributeValue("", 4539, "Comment(", 4539, 8, true);
#nullable restore
#line 103 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
WriteAttributeValue("", 4547, Model.Post.Id, 4547, 14, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4561, ")", 4561, 1, true);
                EndWriteAttribute();
                WriteLiteral(">Add comment</button>\r\n                    </div>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 107 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <text style=\"color:dimgray\">Log in to add your comment</text>\r\n            </div>\r\n");
#nullable restore
#line 113 "D:\Projects\dotnet\bloghost\Bloghost\Pages\Blog\Post.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a16cf0fde9cb56ce99734ad52f0bbd06791df5131202", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    const hubConnection = new signalR.HubConnectionBuilder()
        .withUrl(""/notifications"")
        .build();

    hubConnection.on(""Notify"", function (username) {
        alert(""{0} commented your post."", username)
    });

    function Comment(id) {
        hubConnection.invoke(""Send"", id);

    };

    hubConnection.start();
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Bloghost.Pages.Blog.PostModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bloghost.Pages.Blog.PostModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Bloghost.Pages.Blog.PostModel>)PageContext?.ViewData;
        public Bloghost.Pages.Blog.PostModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
