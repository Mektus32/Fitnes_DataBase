#pragma checksum "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0aebcf968476f22072953f3edf1ae1c41a1adad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_SearchClient), @"mvc.1.0.view", @"/Views/Client/SearchClient.cshtml")]
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
#line 1 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
using Fitnes.Storage.Manager.Clients;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0aebcf968476f22072953f3edf1ae1c41a1adad", @"/Views/Client/SearchClient.cshtml")]
    public class Views_Client_SearchClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ClientWithTrainerAndSubscriptionsName>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">ClientId</th>
                <th scope=""col"">Name</th>
                <th scope=""col"">LastName</th>
                <th scope=""col"">Trainer</th>
                <th scope=""col"">Subscription</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 18 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
             foreach (var elem in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"table-success\">\r\n                    <td>");
#nullable restore
#line 20 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                   Write(elem.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                   Write(elem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                   Write(elem.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                   Write(elem.TrainerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                   Write(elem.SubscriptionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>\r\n");
#nullable restore
#line 26 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                         using (Html.BeginForm("UpdateClient", "Client", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1040, "\"", 1056, 1);
#nullable restore
#line 28 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
WriteAttributeValue("", 1048, elem.Id, 1048, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Update\" />\r\n                            </div>\r\n");
#nullable restore
#line 31 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 34 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                         using (Html.BeginForm("DeleteClient", "Client", FormMethod.Get)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1472, "\"", 1488, 1);
#nullable restore
#line 36 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
WriteAttributeValue("", 1480, elem.Id, 1480, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Delete\" />\r\n                            </div>\r\n");
#nullable restore
#line 39 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\mtara\Desktop\Fitnes_DataBase\Fitnes\Views\Client\SearchClient.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ClientWithTrainerAndSubscriptionsName>> Html { get; private set; }
    }
}
#pragma warning restore 1591
