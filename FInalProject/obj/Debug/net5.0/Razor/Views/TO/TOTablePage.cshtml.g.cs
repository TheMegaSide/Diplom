#pragma checksum "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786aa68c44d12522b6d283b6ac1d5bd9b8b63e46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TO_TOTablePage), @"mvc.1.0.view", @"/Views/TO/TOTablePage.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
using FInalProject.Util.DB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
using FInalProject.Util.DbHandlers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786aa68c44d12522b6d283b6ac1d5bd9b8b63e46", @"/Views/TO/TOTablePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decb2816051e72c51068a2a1bf3204347b0922a2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_TO_TOTablePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FInalProject.Models.TO>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("~/TO/TOAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
  
    string month="";
    if (ViewBag.Month == "01")
        month = "Январь";
    else if (ViewBag.Month == "02")
        month = "Февраль";
    else if (ViewBag.Month == "03")
        month = "Март";
    else if (ViewBag.Month == "04")
        month = "Апрель";
    else if (ViewBag.Month == "05")
        month = "Май";
    else if (ViewBag.Month == "06")
        month = "Июнь";
    else if (ViewBag.Month == "07")
        month = "Июль";
    else if (ViewBag.Month == "08")
        month = "Август";
    else if (ViewBag.Month == "09")
        month = "Сентябрь";
    else if (ViewBag.Month == "10")
        month = "Октябрь";
    else if (ViewBag.Month == "11")
        month = "Ноябрь";
    else if (ViewBag.Month == "12")
        month = "Декабрь";
        
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>График ТО на ");
#nullable restore
#line 33 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
           Write(month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 33 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                  Write(ViewBag.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" г.</p>

<table border=""1"" style=""border-collapse: collapse; width: 100%;"">
    <tbody>
    <tr>
        <th style=""width: 11.1111%;"">Автомашина</th>
        <th style=""width: 11.1111%;"">Шасси</th>
        <th style=""width: 11.1111%;"">Тип загрузки</th>
        <th style=""width: 11.1111%;"">Год выпуска</th>
");
#nullable restore
#line 42 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
          
            for (int i = 1; i < 31; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <th>");
#nullable restore
#line 45 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 46 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n    \r\n");
#nullable restore
#line 50 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
     foreach (var to in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 53 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                                    Write(to.govnum);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 54 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                                    Write(to.model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 55 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                                    Write(to.autoType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 56 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                                    Write(to.yearProd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 57 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
              
                for (int i = 1; i < 31; i++)
                {
                    string currDate = i + "." + ViewBag.Month + "." + ViewBag.Year;
                    string TO1 = "ТО-1 запланировано";

                    List<TO> GetCarNextTO1()
                    {
                        string comText =
                            "select Max(date) from public.\"to\" where auto=" + to.auto + " and totype='ТО-1'";
                        Console.WriteLine($"INFO:{comText}");
                        return DbExecutor.Execute<TO>("Server=127.0.0.1;User Id=postgres;Password=6851;Database=Dilpom;", comText, new DBNextTOHandler());
                    }


                    
                        List<TO> nextTO = GetCarNextTO1();
                        TimeSpan add = new TimeSpan(34560000);
                        DateTime nextToDate = new DateTime();
                        
                        
                    
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"width: 11.1111%;\">\r\n");
#nullable restore
#line 81 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                          
                            if (to.date.Day==i)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                           Write(to.toType);

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                                          
                            }
                        
                             try
                             {
                                  nextToDate = nextTO[0].date.Add(add);
                                }
                            catch (Exception)
                             {
                                  nextToDate = DateTime.Now;
                            }
                        
                             if (DateTime.Parse(currDate) == nextToDate) 
                             { 
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                            Write(TO1);

#line default
#line hidden
#nullable disable
#nullable restore
#line 98 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                                      
                             } 
                        
                         

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n");
#nullable restore
#line 103 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            \r\n           \r\n");
            WriteLiteral("\r\n\r\n        </tr>\r\n");
#nullable restore
#line 113 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    \r\n    </tbody >\r\n</table >\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786aa68c44d12522b6d283b6ac1d5bd9b8b63e4612200", async() => {
                WriteLiteral("\r\n        <input type = \"hidden\" name=\"month\"");
                BeginWriteAttribute("value", " value=\"", 3990, "\"", 4012, 1);
#nullable restore
#line 120 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
WriteAttributeValue("", 3998, ViewBag.Month, 3998, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n        <input type = \"hidden\" name=\"year\"");
                BeginWriteAttribute("value", " value=\"", 4059, "\"", 4080, 1);
#nullable restore
#line 121 "C:\Users\Александр\RiderProjects\rollback\FInalProject\Views\TO\TOTablePage.cshtml"
WriteAttributeValue("", 4067, ViewBag.Year, 4067, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n    <p>\r\n        <input type=\"submit\" value=\"Добавить ТО\"/>\r\n    </p>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FInalProject.Models.TO>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
