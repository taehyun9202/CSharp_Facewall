#pragma checksum "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserMessage), @"mvc.1.0.view", @"/Views/Home/UserMessage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UserMessage.cshtml", typeof(AspNetCore.Views_Home_UserMessage))]
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
#line 1 "C:\Users\TylerN\Coding\C#\Wall\Views\_ViewImports.cshtml"
using Wall;

#line default
#line hidden
#line 2 "C:\Users\TylerN\Coding\C#\Wall\Views\_ViewImports.cshtml"
using Wall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce", @"/Views/Home/UserMessage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"087dc1efdb6a89ed46a72156b1116f85a093d338", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserMessage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Message>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red; font-size: 12px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reply", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 643, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce5371", async() => {
                BeginContext(56, 81, true);
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <h3 style=\"margin-left: 15px;\">Leave Message to ");
                EndContext();
                BeginContext(138, 24, false);
#line 4 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                   Write(ViewBag.getOne.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(162, 63, true);
                WriteLiteral("</h3>\r\n        <div class=\"form-group col-sm-10\">\r\n            ");
                EndContext();
                BeginContext(225, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce6285", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 6 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 284, "What\'s", 284, 6, true);
                AddHtmlAttributeValue(" ", 290, "on", 291, 3, true);
                AddHtmlAttributeValue(" ", 293, "your", 294, 5, true);
                AddHtmlAttributeValue(" ", 298, "mind,", 299, 6, true);
#line 6 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
AddHtmlAttributeValue(" ", 304, ViewBag.getUser.FirstName, 305, 26, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 331, "?", 331, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(334, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(348, 79, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce8755", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#line 7 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(427, 14, true);
                WriteLiteral("\r\n            ");
                EndContext();
                BeginContext(441, 88, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce10513", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 8 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ToId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 8 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                WriteLiteral(ViewBag.getOne.UserId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(529, 123, true);
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\">\r\n        </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(659, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
 foreach (var m in @ViewBag.allMessages){

#line default
#line hidden
            BeginContext(704, 129, true);
            WriteLiteral("    <div class=\"col col-sm-12\" style=\"border: 2px black solid; margin-botton: 10px;\">\r\n        <p style=\"font-weight: bolder;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 833, "\"", 863, 2);
            WriteAttributeValue("", 840, "/user/", 840, 6, true);
#line 16 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
WriteAttributeValue("", 846, m.Creator.UserId, 846, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(864, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(866, 19, false);
#line 16 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                     Write(m.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(885, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(887, 18, false);
#line 16 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                                          Write(m.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(905, 18, true);
            WriteLiteral("</a> commented at ");
            EndContext();
            BeginContext(924, 11, false);
#line 16 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                                                                               Write(m.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(935, 17, true);
            WriteLiteral("</p>\r\n        <p>");
            EndContext();
            BeginContext(953, 9, false);
#line 17 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
      Write(m.Content);

#line default
#line hidden
            EndContext();
            BeginContext(962, 33, true);
            WriteLiteral("</p>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(995, 367, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce17046", async() => {
                BeginContext(1034, 74, true);
                WriteLiteral("\r\n                <div class=\"form-group col-sm-12\">\r\n                    ");
                EndContext();
                BeginContext(1108, 109, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce17508", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 21 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Content);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 6, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1167, "What\'s", 1167, 6, true);
                AddHtmlAttributeValue(" ", 1173, "on", 1174, 3, true);
                AddHtmlAttributeValue(" ", 1176, "your", 1177, 5, true);
                AddHtmlAttributeValue(" ", 1181, "mind,", 1182, 6, true);
#line 21 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
AddHtmlAttributeValue(" ", 1187, ViewBag.getUser.FirstName, 1188, 26, false);

#line default
#line hidden
                AddHtmlAttributeValue("", 1214, "?", 1214, 1, true);
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1217, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(1239, 78, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "4c1d59f4f2e614585fb2b2fff6b4b58ce24cf1ce20003", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 22 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ToId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
#line 22 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                        WriteLiteral(m.MessageId);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1317, 38, true);
                WriteLiteral("\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1362, 33, true);
            WriteLiteral("\r\n        </div>\r\n        <div>\r\n");
            EndContext();
#line 27 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
             foreach (var c in @ViewBag.allComments)
            {
                

#line default
#line hidden
#line 29 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                 if(c.MessageId == m.MessageId){

#line default
#line hidden
            BeginContext(1514, 58, true);
            WriteLiteral("                    <small style=\"font-weight: bolder;\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1572, "\"", 1602, 2);
            WriteAttributeValue("", 1579, "/user/", 1579, 6, true);
#line 30 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
WriteAttributeValue("", 1585, m.Creator.UserId, 1585, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1603, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1605, 19, false);
#line 30 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                                     Write(c.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1624, 16, true);
            WriteLiteral("</a> Replied at ");
            EndContext();
            BeginContext(1641, 11, false);
#line 30 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                                                                                                                         Write(c.CreatedAt);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 33, true);
            WriteLiteral("</small>\r\n                    <p>");
            EndContext();
            BeginContext(1686, 9, false);
#line 31 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                  Write(c.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1695, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 32 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                }

#line default
#line hidden
#line 32 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(1735, 28, true);
            WriteLiteral("        </div>\r\n    </div>\r\n");
            EndContext();
#line 36 "C:\Users\TylerN\Coding\C#\Wall\Views\Home\UserMessage.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
