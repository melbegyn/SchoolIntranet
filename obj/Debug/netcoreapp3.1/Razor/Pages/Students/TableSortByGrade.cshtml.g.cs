#pragma checksum "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b57c2cfde8a954a2331a2aa7846bbde36a185c29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplicationMBegyn.Pages.Students.Pages_Students_TableSortByGrade), @"mvc.1.0.razor-page", @"/Pages/Students/TableSortByGrade.cshtml")]
namespace WebApplicationMBegyn.Pages.Students
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
#line 1 "C:\git\WebApplicationMBegyn\Pages\_ViewImports.cshtml"
using WebApplicationMBegyn;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b57c2cfde8a954a2331a2aa7846bbde36a185c29", @"/Pages/Students/TableSortByGrade.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f76bee77d5fe24db78c18a593de7003bb68f542", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_TableSortByGrade : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
  
    ViewData["Title"] = "TableSortByGrade";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Students sorted by grade</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].AverageGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].NbOfCourses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 30 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
         foreach (var item in Model.Student)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.AverageGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.NbOfCourses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 60 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 63 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByGrade.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationMBegyn.Pages.Students.TableSortByGradeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationMBegyn.Pages.Students.TableSortByGradeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationMBegyn.Pages.Students.TableSortByGradeModel>)PageContext?.ViewData;
        public WebApplicationMBegyn.Pages.Students.TableSortByGradeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
