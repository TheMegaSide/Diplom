#pragma checksum "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6281f17c73849e9b1afa2df9e6f5d96ee49b73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Driver_DriverTablePage), @"mvc.1.0.view", @"/Views/Driver/DriverTablePage.cshtml")]
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
#line 1 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\_ViewImports.cshtml"
using FInalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\_ViewImports.cshtml"
using FInalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6281f17c73849e9b1afa2df9e6f5d96ee49b73", @"/Views/Driver/DriverTablePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decb2816051e72c51068a2a1bf3204347b0922a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Driver_DriverTablePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FInalProject.Models.Driver>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DriverDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DriverEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"

<p>База данных автомобилей</p>
<table border=""1"" style=""border-collapse: collapse; width: 100%;"">
    <tbody>
    <tr>
        
        <th style=""width: 11.1111%;"">Фамилия</th>
        <th style=""width: 11.1111%;"">Имя</th>
        <th style=""width: 11.1111%;"">Отчество</th>
        <th style=""width: 11.1111%;"">Номер ВУ</th>
        <th style=""width: 11.1111%;"">Дата выдачи ВУ</th>
        <th style=""width: 11.1111%;"">Классы вождения</th>
        <th style=""width: 11.1111%;"">Стаж</th>
    </tr>

");
#nullable restore
#line 18 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
     foreach (var driver in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 21 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 22 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 23 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.patronymic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 24 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.drcertnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 25 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.drcertdate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 26 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.classs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 27 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                    Write(driver.timedriving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6281f17c73849e9b1afa2df9e6f5d96ee49b736870", async() => {
                WriteLiteral("Удалить водителя с номером ");
#nullable restore
#line 29 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                                                                             Write(driver.id);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                               WriteLiteral(driver.id);

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
            WriteLiteral("</td> \r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef6281f17c73849e9b1afa2df9e6f5d96ee49b739367", async() => {
                WriteLiteral("Изменить");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
                                             WriteLiteral(driver.id);

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
            WriteLiteral("</td> \r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\Driver\DriverTablePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody >\r\n</table >");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FInalProject.Models.Driver>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
