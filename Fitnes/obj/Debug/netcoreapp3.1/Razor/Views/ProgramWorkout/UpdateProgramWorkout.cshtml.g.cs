#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4fc11ec7bf0f97ed92dab8bf66bd5a09d63afee9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProgramWorkout_UpdateProgramWorkout), @"mvc.1.0.view", @"/Views/ProgramWorkout/UpdateProgramWorkout.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4fc11ec7bf0f97ed92dab8bf66bd5a09d63afee9", @"/Views/ProgramWorkout/UpdateProgramWorkout.cshtml")]
    public class Views_ProgramWorkout_UpdateProgramWorkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(ProgramWorkout, List<KeyValuePair<int, string>>)>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
 using (Html.BeginForm("Update", "ProgramWorkout", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset class=\"container\">\r\n        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 271, "\"", 308, 1);
#nullable restore
#line 9 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
WriteAttributeValue("", 279, Model.Item1.ProgramWorkoutId, 279, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <legend>Update data</legend>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Name\" id=\"name\" aria-describedby=\"nameHelp\"");
            BeginWriteAttribute("value", " value=\"", 540, "\"", 565, 1);
#nullable restore
#line 13 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
WriteAttributeValue("", 548, Model.Item1.Name, 548, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"selectAuthor\">Choose author</label>\r\n            <select class=\"form-control\" name=\"AuthorId\" id=\"selectAuthor\">\r\n");
#nullable restore
#line 18 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
                 foreach (var elem in Model.Item2) {
                    if (elem.Key == Model.Item1.AuthorId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 903, "\"", 920, 1);
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
WriteAttributeValue("", 911, elem.Key, 911, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
                                                      Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 21 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1035, "\"", 1052, 1);
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
WriteAttributeValue("", 1043, elem.Key, 1043, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
                                             Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 24 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </select>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"period\">Period</label>\r\n            <input type=\"number\" required class=\"form-control\" name=\"Period\" id=\"period\" aria-describedby=\"periodHelp\"");
            BeginWriteAttribute("value", " value=\"", 1357, "\"", 1384, 1);
#nullable restore
#line 30 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
WriteAttributeValue("", 1365, Model.Item1.Period, 1365, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n    </fieldset>\r\n");
#nullable restore
#line 34 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\ProgramWorkout\UpdateProgramWorkout.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(ProgramWorkout, List<KeyValuePair<int, string>>)> Html { get; private set; }
    }
}
#pragma warning restore 1591