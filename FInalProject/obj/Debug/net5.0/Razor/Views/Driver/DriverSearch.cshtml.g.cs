#pragma checksum "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc04c1cf0b82ab30cda2770e374c9721c58af33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Driver_DriverSearch), @"mvc.1.0.view", @"/Views/Driver/DriverSearch.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
using FInalProject.Util.DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
using FInalProject.Util.DbHandlers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc04c1cf0b82ab30cda2770e374c9721c58af33", @"/Views/Driver/DriverSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decb2816051e72c51068a2a1bf3204347b0922a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Driver_DriverSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FInalProject.Models.Driver>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DriverEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Driver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DriverTablePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
  
    ViewData["Title"] = "Поиск";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc04c1cf0b82ab30cda2770e374c9721c58af335653", async() => {
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
            WriteLiteral(@"
<h1>База данных автомобилей</h1>

<table border=""1"" class=""table"" style=""border-collapse: collapse; width: 100%;alignment: left"">
    <thead class=""thead-dark"">
    <tr>
        
        <th></th>
        <th style=""width: 11.1111%;"">ФИО</th>
       
        <th style=""width: 11.1111%;"">Номер ВУ</th>
        <th style=""width: 11.1111%;"">Дата выдачи ВУ</th>
        <th style=""width: 11.1111%;"">Классы вождения</th>
        <th style=""width: 11.1111%;"">Стаж</th>
        <th>Закрепленный автомобиль</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
     foreach (var driver in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc04c1cf0b82ab30cda2770e374c9721c58af337953", async() => {
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
#line 28 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
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
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 29 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                                    Write(driver.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 31 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                                    Write(driver.drcertnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 32 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                                    Write(driver.drcertdate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 33 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                                    Write(driver.classs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 34 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                                    Write(driver.timedriving);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n");
#nullable restore
#line 36 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                  
                    List<CarNew> GetCars()
                    {
                        string comText =
                            "select \"CarList\".* from \"CarList\", drivers where \"CarList\".id=drivers.auto and drivers.id="+driver.id;
                        Console.WriteLine($"INFO:{comText}");
                        return DbExecutor.Execute<CarNew>("Server=127.0.0.1;User Id=postgres;Password=6851;Database=Dilpom;", comText, new DBCarNewHandler());
                    }

                    List<CarNew> cars = GetCars();
                    foreach (var car in cars)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 48 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                       Write(car.govnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n");
            WriteLiteral("           \r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Driver\DriverSearch.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("       </tbody >\r\n    </table >\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9dc04c1cf0b82ab30cda2770e374c9721c58af3313569", async() => {
                WriteLiteral("Назад");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
