#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4387efd119a80159ba06d5a87ac8e7d67090830e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ShowEmployees), @"mvc.1.0.view", @"/Views/Employee/ShowEmployees.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
using Fitnes.Storage.Manager.Employers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4387efd119a80159ba06d5a87ac8e7d67090830e", @"/Views/Employee/ShowEmployees.cshtml")]
    public class Views_Employee_ShowEmployees : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeWithPositionAndGymName>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <table class=""table table-hover"">
            <thead>
                <tr>
                    <th scope=""col"">EmployeeId</th>
                    <th scope=""col"">Position name</th>
                    <th scope=""col"">Name</th>
                    <th scope=""col"">Experience</th>
                    <th scope=""col"">Salary</th>
                    <th scope=""col"">Gym</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                 foreach (var elem in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr class=\"table-success\">\r\n                        <td>");
#nullable restore
#line 21 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 22 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 25 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.Salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 26 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                       Write(elem.GymName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n");
#nullable restore
#line 28 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                             using (Html.BeginForm("UpdateEmployee", "Employee", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1222, "\"", 1238, 1);
#nullable restore
#line 30 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
WriteAttributeValue("", 1230, elem.Id, 1230, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Update\" />\r\n                                </div>\r\n");
#nullable restore
#line 33 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                        <td>\r\n");
#nullable restore
#line 36 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                             using (Html.BeginForm("DeleteEmployee", "Employee", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div>\r\n                                    <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1690, "\"", 1706, 1);
#nullable restore
#line 38 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
WriteAttributeValue("", 1698, elem.Id, 1698, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                    <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Delete\" />\r\n                                </div>\r\n");
#nullable restore
#line 41 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
#nullable restore
#line 47 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
         using (Html.BeginForm("CreateEmployee", "Employee", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <input type=\"submit\" class=\"btn btn-success\" value=\"Add employee\" />\r\n            </div>\r\n");
#nullable restore
#line 51 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
         using (Html.BeginForm("ShowPositions", "Position", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\r\n                <input type=\"submit\" class=\"btn btn-success\" value=\"Show positions\" />\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\ShowEmployees.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeWithPositionAndGymName>> Html { get; private set; }
    }
}
#pragma warning restore 1591
