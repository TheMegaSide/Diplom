#pragma checksum "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83ff696a9c72bab340a389fbe29e8a2eb2a1b40c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_CarTablePage), @"mvc.1.0.view", @"/Views/Car/CarTablePage.cshtml")]
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
#line 1 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
using Type = FInalProject.Models.Type;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
using FInalProject.Util.DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
using FInalProject.Util.DbHandlers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83ff696a9c72bab340a389fbe29e8a2eb2a1b40c", @"/Views/Car/CarTablePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decb2816051e72c51068a2a1bf3204347b0922a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Car_CarTablePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FInalProject.Models.CarNew>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "type", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/Car/CarSearch"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CarEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ff696a9c72bab340a389fbe29e8a2eb2a1b40c6565", async() => {
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
            WriteLiteral("\r\n<h1>База данных автомобилей</h1>\r\n\r\n<h3>Поиск</h3>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ff696a9c72bab340a389fbe29e8a2eb2a1b40c8071", async() => {
                WriteLiteral("\r\n    <p>\r\n        <label class=\"control-label\">Параметр</label>\r\n        <br/>\r\n        <select name=\"field\" class=\"custom-select\" >\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ff696a9c72bab340a389fbe29e8a2eb2a1b40c8488", async() => {
                    WriteLiteral("Тип");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </select>\r\n    </p>\r\n    <p>\r\n        <label class=\"control-label\">Значение</label>\r\n        <br/>\r\n        <select name=\"key\" class=\"custom-select\" >\r\n");
#nullable restore
#line 22 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
              
                List<Type> GetTypes()
                {
                    string comText =
                        "select * from types;";
                    Console.WriteLine($"INFO:{comText}");
                    return DbExecutor.Execute<Type>("Server=127.0.0.1;User Id=postgres;Password=6851;Database=Dilpom;", comText, new DBTypeHandler());
                }

                List<Type> types = GetTypes();
                foreach (var type in types)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ff696a9c72bab340a389fbe29e8a2eb2a1b40c10615", async() => {
#nullable restore
#line 34 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
                                          Write(type.type);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
                       WriteLiteral(type.type);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
                }


            

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        \r\n\r\n    </p>\r\n    <p>\r\n        <input class=\"btn btn-primary\" type=\"submit\" value=\"Поиск\"/>\r\n    </p>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table border=""1"" class=""table"" style=""border-collapse: collapse; width: 100%;alignment: left"">
    <thead class=""thead-dark"" >
    <tr>
        <th></th>
        <th >Тип, модификация</th>
        <th >Модель</th>
        <th >Марка, модель</th>
        <th >Год выпуска</th>
        <th >Гос.авто.номер</th>
        <th >Объём, м3</th>
        <th >Масса без нагрузки кг</th>
        <th >Разрешенная максимальная масса кг</th>
        <th >Марка топлива, объём топливного бака</th>
        <th >Техническое состояние (№ страхового полиса исправной техники)</th>
        <th >Срок по ДК</th>
        <th >Стаховая компания по ОСАГО</th>
        <th >Стоимость ОСАГО</th>
        <th >ПЛАТОН, №</th>
        <th >Дата окончания срока службы БУ</th>
        <th >Замена БУ ПЛАТОН на безвозмездной основе</th>
        <th >Тип устройства глонасс</th>
        <th >Номер СИМ</th>
        <th >Дата установки</th>
        <th >Вид работы</th>
        <th >Собственник по ПТС</th>
        <th >Собстве");
            WriteLiteral("нник по СТС</th>\r\n        <th >Местонахождение транспорта (регион)</th>\r\n\r\n\r\n    </tr>\r\n    </thead>\r\n <tbody>\r\n");
#nullable restore
#line 79 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
     foreach (var car in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83ff696a9c72bab340a389fbe29e8a2eb2a1b40c15885", async() => {
                WriteLiteral("Профиль");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 82 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
                                                                  WriteLiteral(car.id);

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
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 83 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 84 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 85 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.vin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 86 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.yearprod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 87 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.govnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 88 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td width=\"3%\">");
#nullable restore
#line 89 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
                      Write(car.weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td width=\"3%\">");
#nullable restore
#line 90 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
                      Write(car.maxweight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 91 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.fueltype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 92 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.techstate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 93 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.srokpodk.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 94 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.inscomp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 95 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.osagocost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 96 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.platonnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 97 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.platondate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 98 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.platonreplace);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 99 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.glonastype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 100 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.simnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 101 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.glonasdate.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 102 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.worktype);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 103 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.ptsowner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 104 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.stsowner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td >");
#nullable restore
#line 105 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
            Write(car.regionloc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
            WriteLiteral("\r\n\r\n        </tr>\r\n");
#nullable restore
#line 112 "C:\Users\Александр\RiderProjects\DiplomFinal\FInalProject\Views\Car\CarTablePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    \r\n    </tbody >\r\n</table >\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FInalProject.Models.CarNew>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
