#pragma checksum "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a05664bc90a725e7c0e79efc302204e45ea70e94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApplicationMBegyn.Pages.Students.Pages_Students_TableSortByAge), @"mvc.1.0.razor-page", @"/Pages/Students/TableSortByAge.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a05664bc90a725e7c0e79efc302204e45ea70e94", @"/Pages/Students/TableSortByAge.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f76bee77d5fe24db78c18a593de7003bb68f542", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Students_TableSortByAge : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
  
    ViewData["Title"] = "TableFilterPerAge";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Students sorted by age</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].AverageGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].NbOfCourses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
           Write(Html.DisplayNameFor(model => model.Student[0].PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
         foreach (var item in Model.Student)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 41 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.AverageGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 44 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.NbOfCourses));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 47 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 50 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 53 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 56 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\git\WebApplicationMBegyn\Pages\Students\TableSortByAge.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationMBegyn.Pages.Students.TableFilterPerAgeModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationMBegyn.Pages.Students.TableFilterPerAgeModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WebApplicationMBegyn.Pages.Students.TableFilterPerAgeModel>)PageContext?.ViewData;
        public WebApplicationMBegyn.Pages.Students.TableFilterPerAgeModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
