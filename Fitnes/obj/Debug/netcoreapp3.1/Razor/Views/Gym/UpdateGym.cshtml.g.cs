#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8da36831d63e1bf275c8a32869ab14f0c0025149"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Gym_UpdateGym), @"mvc.1.0.view", @"/Views/Gym/UpdateGym.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8da36831d63e1bf275c8a32869ab14f0c0025149", @"/Views/Gym/UpdateGym.cshtml")]
    public class Views_Gym_UpdateGym : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(Gym, List<KeyValuePair<int, KeyValuePair<bool, string>>>)>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
 using (Html.BeginForm("Update", "Gym", FormMethod.Post)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset class=\"container\">\r\n        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 269, "\"", 295, 1);
#nullable restore
#line 9 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 277, Model.Item1.GymId, 277, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <legend>Update data</legend>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Name\" id=\"name\" aria-describedby=\"nameHelp\"");
            BeginWriteAttribute("value", " value=\"", 527, "\"", 552, 1);
#nullable restore
#line 13 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 535, Model.Item1.Name, 535, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"address\">Address</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Address\" id=\"address\"");
            BeginWriteAttribute("value", " value=\"", 744, "\"", 772, 1);
#nullable restore
#line 17 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 752, Model.Item1.Address, 752, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n");
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
             foreach (var elem in Model.Item2) {
                if (elem.Value.Key == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"custom-control custom-checkbox\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 1064, "\"", 1078, 1);
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 1069, elem.Key, 1069, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1079, "\"", 1096, 1);
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 1087, elem.Key, 1087, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"MachinesIndex[]\" checked>\r\n                        <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 1190, "\"", 1205, 1);
#nullable restore
#line 24 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 1196, elem.Key, 1196, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 24 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
                                                                       Write(elem.Value.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 26 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
                }
                else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"custom-control custom-checkbox\">\r\n                        <input type=\"checkbox\" class=\"custom-control-input\"");
            BeginWriteAttribute("id", " id=\"", 1446, "\"", 1460, 1);
#nullable restore
#line 29 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 1451, elem.Key, 1451, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=\"", 1461, "\"", 1478, 1);
#nullable restore
#line 29 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 1469, elem.Key, 1469, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"MachinesIndex[]\">\r\n                        <label class=\"custom-control-label\"");
            BeginWriteAttribute("for", " for=\"", 1564, "\"", 1579, 1);
#nullable restore
#line 30 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
WriteAttributeValue("", 1570, elem.Key, 1570, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
                                                                       Write(elem.Value.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </div>\r\n");
#nullable restore
#line 32 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n    </fieldset>\r\n");
#nullable restore
#line 37 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Gym\UpdateGym.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(Gym, List<KeyValuePair<int, KeyValuePair<bool, string>>>)> Html { get; private set; }
    }
}
#pragma warning restore 1591
