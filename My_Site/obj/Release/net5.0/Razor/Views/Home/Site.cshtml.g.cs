#pragma checksum "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99e0571fc7457cc9e6078b33b6b89af1dede5c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Site), @"mvc.1.0.view", @"/Views/Home/Site.cshtml")]
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
#line 1 "C:\Users\user\Desktop\mySite-main\My_Site\Views\_ViewImports.cshtml"
using My_Site.ViewsModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99e0571fc7457cc9e6078b33b6b89af1dede5c87", @"/Views/Home/Site.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"341f0ef9fff54529ddd1905149d5bf506ef99f2b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Site : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "onClik", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "number", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Site", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e0571fc7457cc9e6078b33b6b89af1dede5c874594", async() => {
                WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
     if(!Model.UserNamber.onClik)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\n            <h4>Загадайте двухзначное число и нажмите на кнопку <button>Загадал</button></h4>\n        </div>\n");
#nullable restore
#line 7 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99e0571fc7457cc9e6078b33b6b89af1dede5c876922", async() => {
                WriteLiteral("\n");
#nullable restore
#line 10 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
     if (Model.UserNamber.onClik)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\n            <h3>Экстрасенс №1 предсказал число: ");
#nullable restore
#line 13 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                                           Write(Model.PsychicNamber.witch_1_Namber[Model.PsychicNamber.witch_1_Namber.Count - 1]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\n            <h3>Экстрасенс №2 предсказал число: ");
#nullable restore
#line 14 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                                           Write(Model.PsychicNamber.witch_2_Namber[Model.PsychicNamber.witch_2_Namber.Count - 1]);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h3>\n        </div>\n        <div>\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "99e0571fc7457cc9e6078b33b6b89af1dede5c878197", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#nullable restore
#line 17 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.UserNamber.namber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n            <button type=\"submit\">Отправить</button>\n        </div>\n");
#nullable restore
#line 20 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div>\n    <h3>Доверие к экстрасенсу №1: ");
#nullable restore
#line 24 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                             Write(Model.PsychicNamber.confidence_1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <h3>Доверие к экстрасенсу №2: ");
#nullable restore
#line 25 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                             Write(Model.PsychicNamber.confidence_2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n</div>\n\n<table>\n    <tr><th><h3> Введенные значения </h3></th><th><h3> Предсказания экстрасенсa №1 </h3></th><th><h3> Предсказания экстрасенсa №2 </h3></th></tr>\n\n    <tr>\n        <th>\n");
#nullable restore
#line 33 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
             foreach (int i in Model.UserNamber.ArrayNamber)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4> ");
#nullable restore
#line 35 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n");
#nullable restore
#line 36 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </th>\n        <th>\n");
#nullable restore
#line 39 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
             foreach (int i in Model.PsychicNamber.witch_1_Namber)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4> ");
#nullable restore
#line 41 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n");
#nullable restore
#line 42 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </th>\n        <th>\n");
#nullable restore
#line 45 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
             foreach (int i in Model.PsychicNamber.witch_2_Namber)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h4> ");
#nullable restore
#line 47 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\n");
#nullable restore
#line 48 "C:\Users\user\Desktop\mySite-main\My_Site\Views\Home\Site.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </th>\n    </tr>\n</table>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591