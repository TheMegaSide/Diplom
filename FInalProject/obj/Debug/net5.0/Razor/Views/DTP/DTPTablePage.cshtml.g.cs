#pragma checksum "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f5b747f9414c5eb2c5c786e7810bd8fad18ff2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DTP_DTPTablePage), @"mvc.1.0.view", @"/Views/DTP/DTPTablePage.cshtml")]
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
#line 1 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\_ViewImports.cshtml"
using FInalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\_ViewImports.cshtml"
using FInalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f5b747f9414c5eb2c5c786e7810bd8fad18ff2e", @"/Views/DTP/DTPTablePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decb2816051e72c51068a2a1bf3204347b0922a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_DTP_DTPTablePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FInalProject.Models.DTP>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DTPEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
  
    ViewData["Title"] = "Таблица ДТП";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5b747f9414c5eb2c5c786e7810bd8fad18ff2e4647", async() => {
                WriteLiteral("На главную");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<p>Совершенные рейсы</p>\r\n\r\n\r\n");
            WriteLiteral(@"<table border=""1"" class=""table"" style=""border-collapse: collapse; width: 100%;alignment: left"">
    <thead class=""thead-dark"">
    <tr>
        <th > </th>
        <th >Данные о водителе</th>
        <th >Данные о транспортном средстве</th>
        <th >Условия организации и осуществлении перевозок</th>
        <th >Сведения о пострадавших</th>
        <th >Материальный ущерб (кол. Транспорта)</th>
        <th >Вина водителя ООО «ЭкоЦентр»</th>
        <th >Дата совершения ДТП</th>
        <th >Место ДТП</th>
        <th >Вид ДТП</th>
        <th >Условия способствовавшие возникновению ДТП</th>
        <th >Выявленные причины ДТП</th>
        <th >Погибло (чел.)</th>
        <th >Ранено (чел.)</th>
        <th >Оформление ДТП</th>
        <th >Примечания</th>
        
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 47 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
     foreach (var dtp in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td  style=\"width: 10%\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f5b747f9414c5eb2c5c786e7810bd8fad18ff2e7302", async() => {
                WriteLiteral("Изменить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
                                                                                      WriteLiteral(dtp.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 51 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.drivername);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 52 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.autodata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 53 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.conditions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 54 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.victimsdata);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.damagedtransport);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.driverfault);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 58 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.region);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 59 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 60 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.dtpcodintions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 61 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.dtpreasons);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 62 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.died);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 63 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.traumas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 64 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.oform);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 65 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
           Write(dtp.addtitions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 70 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\DTP\DTPTablePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    \r\n    </tbody>\r\n</table >\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FInalProject.Models.DTP>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
