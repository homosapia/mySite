#pragma checksum "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20311f21b24b7a5b9961671bc82f13ac0d383155"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_OutputTemplate), @"mvc.1.0.view", @"/Views/Home/OutputTemplate.cshtml")]
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
#line 2 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\_ViewImports.cshtml"
using WebTestTaskEasy.Objects;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20311f21b24b7a5b9961671bc82f13ac0d383155", @"/Views/Home/OutputTemplate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cafa01fd57f99503b198bc11ca5620863f9239f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_OutputTemplate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Game>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
   
    var trust = Model.GetPsychicTrusts();
    var gameData = Model.GetGameData();

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n");
#nullable restore
#line 7 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
     for (int l = 0; l < trust.Count; l++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h3>Доверие к экстрасенсу №");
#nullable restore
#line 9 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
                               Write(l+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
                                      Write(trust[l]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\n");
#nullable restore
#line 10 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<table>\n    <tr>\n        <th>\n           <h3> Введенные значения </h3>\n        </th>\n");
#nullable restore
#line 18 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
         for(int i = 0; i < gameData.Psychics.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th><h3> Предсказания экстрасенсa №");
#nullable restore
#line 20 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3></th>\n");
#nullable restore
#line 21 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\n\n");
#nullable restore
#line 24 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
     foreach (var round in gameData.GameRoundsHistory)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <th>\n                ");
#nullable restore
#line 28 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
           Write(round.UserNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n");
#nullable restore
#line 30 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
             foreach (var number in round.PsychicNumber)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>\n                    ");
#nullable restore
#line 33 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
               Write(number);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n");
#nullable restore
#line 35 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n");
#nullable restore
#line 37 "C:\Users\user1\Desktop\mySite-main\My_Site\Views\Home\OutputTemplate.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Game> Html { get; private set; }
    }
}
#pragma warning restore 1591
