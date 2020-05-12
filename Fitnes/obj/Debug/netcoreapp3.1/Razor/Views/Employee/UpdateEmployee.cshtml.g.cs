#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a52b24823cb7020780ec54d110bb326680382e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_UpdateEmployee), @"mvc.1.0.view", @"/Views/Employee/UpdateEmployee.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a52b24823cb7020780ec54d110bb326680382e0", @"/Views/Employee/UpdateEmployee.cshtml")]
    public class Views_Employee_UpdateEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(Employee, (List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>))>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
 using (Html.BeginForm("Update", "Employee", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset class=\"container\">\r\n        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 293, "\"", 324, 1);
#nullable restore
#line 9 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 301, Model.Item1.EmployeeId, 301, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <legend>Update data</legend>\r\n        <div class=\"form-group\">\r\n            <label for=\"selectPosition\">Choose position</label>\r\n            <select class=\"form-control\" name=\"PositionId\" id=\"selectPosition\">\r\n");
#nullable restore
#line 14 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                 foreach (var elem in Model.Item2.Item1) {
                    if (elem.Key == Model.Item1.PositionId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 702, "\"", 719, 1);
#nullable restore
#line 16 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 710, elem.Key, 710, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 16 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                                                      Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 17 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 834, "\"", 851, 1);
#nullable restore
#line 19 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 842, elem.Key, 842, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                                             Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Name\" id=\"name\" aria-describedby=\"nameHelp\"");
            BeginWriteAttribute("value", " value=\"", 1144, "\"", 1169, 1);
#nullable restore
#line 26 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 1152, Model.Item1.Name, 1152, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"experience\">Experience</label>\r\n            <input type=\"number\" step=\"0.1\" required class=\"form-control\" name=\"Experience\" id=\"experience\"");
            BeginWriteAttribute("value", " value=\"", 1386, "\"", 1417, 1);
#nullable restore
#line 30 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 1394, Model.Item1.Experience, 1394, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"salary\">Salary</label>\r\n            <input type=\"number\" required class=\"form-control\" name=\"Salary\" id=\"salary\"");
            BeginWriteAttribute("value", " value=\"", 1607, "\"", 1634, 1);
#nullable restore
#line 34 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 1615, Model.Item1.Salary, 1615, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"selectGym\">Choose gym</label>\r\n            <select class=\"form-control\" name=\"GymId\" id=\"selectGym\">\r\n");
#nullable restore
#line 39 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                 foreach (var elem in Model.Item2.Item2) {
                    if (elem.Key == Model.Item1.EmployeeId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1968, "\"", 1985, 1);
#nullable restore
#line 41 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 1976, elem.Key, 1976, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 41 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                                                      Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 42 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 2100, "\"", 2117, 1);
#nullable restore
#line 44 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
WriteAttributeValue("", 2108, elem.Key, 2108, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                                             Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 45 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""form-group"">
            <label for=""exampleInputFile"">File input</label>
            <input type=""file"" class=""form-control-file"" id=""exampleInputFile"" aria-describedby=""fileHelp"">
            <small id=""fileHelp"" class=""form-text text-muted"">You can input photo new employee</small>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Update</button>
    </fieldset>
");
#nullable restore
#line 56 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Employee\UpdateEmployee.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(Employee, (List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>))> Html { get; private set; }
    }
}
#pragma warning restore 1591