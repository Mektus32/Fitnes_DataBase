#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "002ef2042dc551a267c9f23bc5498d3e836775a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_UpdateClient), @"mvc.1.0.view", @"/Views/Client/UpdateClient.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
using Fitnes.Storage.Repository;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"002ef2042dc551a267c9f23bc5498d3e836775a7", @"/Views/Client/UpdateClient.cshtml")]
    public class Views_Client_UpdateClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(Client, (List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>))>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
     using (Html.BeginForm("Update", "Client", FormMethod.Post)) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("    <fieldset class=\"container\">\r\n        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 294, "\"", 323, 1);
#nullable restore
#line 9 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 302, Model.Item1.ClientId, 302, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <legend>Update data</legend>\r\n        <div class=\"form-group\">\r\n            <label for=\"name\">Name</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"Name\" id=\"name\" aria-describedby=\"nameHelp\"");
            BeginWriteAttribute("value", " value=\"", 555, "\"", 580, 1);
#nullable restore
#line 13 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 563, Model.Item1.Name, 563, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"lastName\">Lastname</label>\r\n            <input type=\"text\" required class=\"form-control\" name=\"LastName\" id=\"lastName\"");
            BeginWriteAttribute("value", " value=\"", 776, "\"", 805, 1);
#nullable restore
#line 17 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 784, Model.Item1.LastName, 784, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label for=\"selectTrainer\">Choose trainer</label>\r\n            <select class=\"form-control\" name=\"TrainerId\" id=\"selectTrainer\">\r\n                <option value=\"0\"></option>\r\n");
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                 foreach (var elem in Model.Item2.Item1) {
                    if (elem.Key != Model.Item1.TrainerId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1199, "\"", 1216, 1);
#nullable restore
#line 25 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 1207, elem.Key, 1207, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                                             Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 26 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1322, "\"", 1339, 1);
#nullable restore
#line 28 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 1330, elem.Key, 1330, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 28 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                                                      Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 29 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </select>
        </div>
        <div class=""form-group"">
            <label for=""selectSubscription"">Choose subscription</label>
            <select class=""form-control"" name=""SubscriptionId"" id=""selectSubscription"">
                <option value=""0""></option>
");
#nullable restore
#line 37 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                 foreach (var elem in Model.Item2.Item2) {
                    if (elem.Key != Model.Item1.SubscriptionId) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1852, "\"", 1869, 1);
#nullable restore
#line 39 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 1860, elem.Key, 1860, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 39 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                                             Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 40 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                    }
                    else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 1975, "\"", 1992, 1);
#nullable restore
#line 42 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
WriteAttributeValue("", 1983, elem.Key, 1983, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" selected>");
#nullable restore
#line 42 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
                                                      Write(elem.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 43 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
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
            <small id=""fileHelp"" class=""form-text text-muted"">You can input photo new client</small>
        </div>
        <button type=""submit"" class=""btn btn-primary"">Update</button>
    </fieldset>
");
#nullable restore
#line 54 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\UpdateClient.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(Client, (List<KeyValuePair<int, string>>, List<KeyValuePair<int, string>>))> Html { get; private set; }
    }
}
#pragma warning restore 1591
