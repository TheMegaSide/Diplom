#pragma checksum "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\Category\CategoryTablePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1450042534f45b79fad7dd0944d319aaa0feb305"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryTablePage), @"mvc.1.0.view", @"/Views/Category/CategoryTablePage.cshtml")]
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
#line 1 "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\_ViewImports.cshtml"
using FInalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\_ViewImports.cshtml"
using FInalProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1450042534f45b79fad7dd0944d319aaa0feb305", @"/Views/Category/CategoryTablePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"decb2816051e72c51068a2a1bf3204347b0922a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_CategoryTablePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FInalProject.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<p>Таблица \"Категории\"</p>\r\n<table border=\"1\" style=\"border-collapse: collapse; width: 100%;\">\r\n    <tbody>\r\n    <tr>\r\n        <th style=\"width: 11.1111%;\">ID</th>\r\n        <th style=\"width: 11.1111%;\">Наименование</th>\r\n\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 14 "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\Category\CategoryTablePage.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 17 "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\Category\CategoryTablePage.cshtml"
                                    Write(product.CategoryId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td style=\"width: 11.1111%;\">");
#nullable restore
#line 18 "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\Category\CategoryTablePage.cshtml"
                                    Write(product.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\Александр\RiderProjects\FInalProject\FInalProject\Views\Category\CategoryTablePage.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody >\r\n</table >");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FInalProject.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
