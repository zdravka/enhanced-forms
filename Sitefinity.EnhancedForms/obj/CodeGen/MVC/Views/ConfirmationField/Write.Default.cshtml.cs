#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 9 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.StringResources;
    
    #line default
    #line hidden
    
    #line 5 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 8 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.Localization;
    
    #line default
    #line hidden
    
    #line 6 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 7 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ConfirmationField/Write.Default.cshtml")]
    public partial class _MVC_Views_ConfirmationField_Write_Default_cshtml : System.Web.Mvc.WebViewPage<Sitefinity.EnhancedForms.Mvc.Models.ConfirmationField.ConfirmationFieldViewModel>
    {
        public _MVC_Views_ConfirmationField_Write_Default_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 11 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 465), Tuple.Create("\"", 500)
            
            #line 12 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 473), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 473), false)
, Tuple.Create(Tuple.Create(" ", 488), Tuple.Create("sf-fieldWrp", 489), true)
);

WriteLiteral(" data-sf-role=\"confirmation-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 610), Tuple.Create("\'", 723)
, Tuple.Create(Tuple.Create("", 618), Tuple.Create("{\"maxLength\":\"", 618), true)
            
            #line 13 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
     , Tuple.Create(Tuple.Create("", 632), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 632), false)
, Tuple.Create(Tuple.Create("", 668), Tuple.Create("\",", 668), true)
, Tuple.Create(Tuple.Create(" ", 670), Tuple.Create("\"minLength\":", 671), true)
, Tuple.Create(Tuple.Create(" ", 683), Tuple.Create("\"", 684), true)
            
            #line 13 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                          , Tuple.Create(Tuple.Create("", 685), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 685), false)
, Tuple.Create(Tuple.Create("", 721), Tuple.Create("\"}", 721), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" data-sf-description=\"");

            
            #line 14 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                             Write(Html.UniqueId("Textbox"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 835), Tuple.Create("\'", 1170)
, Tuple.Create(Tuple.Create("", 843), Tuple.Create("{\"fieldsMatch\":\"", 843), true)
            
            #line 14 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                   , Tuple.Create(Tuple.Create("", 859), Tuple.Create<System.Object, System.Int32>(Model.ConfirmValidatorDefinition.FieldsDoNotMatchMessage
            
            #line default
            #line hidden
, 859), false)
, Tuple.Create(Tuple.Create("", 916), Tuple.Create("\",", 916), true)
, Tuple.Create(Tuple.Create(" ", 918), Tuple.Create("\"maxLength\":\"", 919), true)
            
            #line 14 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                                            , Tuple.Create(Tuple.Create("", 932), Tuple.Create<System.Object, System.Int32>(Model.MaxLengthViolationMessage
            
            #line default
            #line hidden
, 932), false)
, Tuple.Create(Tuple.Create("", 964), Tuple.Create("\",", 964), true)
, Tuple.Create(Tuple.Create(" ", 966), Tuple.Create("\"required\":", 967), true)
, Tuple.Create(Tuple.Create(" ", 978), Tuple.Create("\"", 979), true)
            
            #line 14 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 980), Tuple.Create<System.Object, System.Int32>(Model.MainFieldRequiredViolationMessage
            
            #line default
            #line hidden
, 980), false)
, Tuple.Create(Tuple.Create("", 1020), Tuple.Create("\",", 1020), true)
, Tuple.Create(Tuple.Create(" ", 1022), Tuple.Create("\"invalid\":", 1023), true)
, Tuple.Create(Tuple.Create(" ", 1033), Tuple.Create("\"", 1034), true)
            
            #line 14 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1035), Tuple.Create<System.Object, System.Int32>(Res.Get<FieldResources>().InvalidEntryMessage
            
            #line default
            #line hidden
, 1035), false)
, Tuple.Create(Tuple.Create("", 1083), Tuple.Create("\",", 1083), true)
, Tuple.Create(Tuple.Create(" ", 1085), Tuple.Create("\"regularExpression\":", 1086), true)
, Tuple.Create(Tuple.Create(" ", 1106), Tuple.Create("\"", 1107), true)
            
            #line 14 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1108), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.RegularExpressionViolationMessage
            
            #line default
            #line hidden
, 1108), false)
, Tuple.Create(Tuple.Create("", 1168), Tuple.Create("\"}", 1168), true)
);

WriteLiteral(" />\r\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 1186), Tuple.Create("\'", 1217)
            
            #line 15 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1192), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1192), false)
);

WriteLiteral(">");

            
            #line 15 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                      Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\'", 1261), Tuple.Create("\'", 1291)
            
            #line 16 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("Textbox")
            
            #line default
            #line hidden
, 1266), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-sf-role=\"text-field-input\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1357), Tuple.Create("\"", 1390)
            
            #line 16 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                 , Tuple.Create(Tuple.Create("", 1364), Tuple.Create<System.Object, System.Int32>(Model.MetaField.FieldName
            
            #line default
            #line hidden
, 1364), false)
);

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 1391), Tuple.Create("\"", 1427)
            
            #line 16 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                          , Tuple.Create(Tuple.Create("", 1405), Tuple.Create<System.Object, System.Int32>(Model.PlaceholderText
            
            #line default
            #line hidden
, 1405), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1428), Tuple.Create("\"", 1448)
            
            #line 16 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                         , Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(Model.Value
            
            #line default
            #line hidden
, 1436), false)
);

WriteLiteral(" ");

            
            #line 16 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                                                                                                                  Write(Html.Raw(Model.ValidationAttributes));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 1500), Tuple.Create("\'", 1542)
            
            #line 17 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 1505), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("TextboxErrorMessage")
            
            #line default
            #line hidden
, 1505), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-restrictions\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1698), Tuple.Create("\'", 1811)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create("{\"maxLength\":\"", 1706), true)
            
            #line 18 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
    , Tuple.Create(Tuple.Create("", 1720), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MaxLength
            
            #line default
            #line hidden
, 1720), false)
, Tuple.Create(Tuple.Create("", 1756), Tuple.Create("\",", 1756), true)
, Tuple.Create(Tuple.Create(" ", 1758), Tuple.Create("\"minLength\":", 1759), true)
, Tuple.Create(Tuple.Create(" ", 1771), Tuple.Create("\"", 1772), true)
            
            #line 18 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                         , Tuple.Create(Tuple.Create("", 1773), Tuple.Create<System.Object, System.Int32>(Model.ValidatorDefinition.MinLength
            
            #line default
            #line hidden
, 1773), false)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("\"}", 1809), true)
);

WriteLiteral(" />\r\n    <input");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteLiteral(" data-sf-description=\"");

            
            #line 19 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                             Write(Html.UniqueId("ConfirmTextbox"));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" type=\"hidden\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1930), Tuple.Create("\'", 2002)
, Tuple.Create(Tuple.Create("", 1938), Tuple.Create("{\"required\":", 1938), true)
, Tuple.Create(Tuple.Create(" ", 1950), Tuple.Create("\"", 1951), true)
            
            #line 19 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                       , Tuple.Create(Tuple.Create("", 1952), Tuple.Create<System.Object, System.Int32>(Model.ConfirmationFieldRequiredViolationMessage
            
            #line default
            #line hidden
, 1952), false)
, Tuple.Create(Tuple.Create("", 2000), Tuple.Create("\"}", 2000), true)
);

WriteLiteral(" />\r\n    <label");

WriteAttribute("for", Tuple.Create(" for=\'", 2018), Tuple.Create("\'", 2056)
            
            #line 20 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2024), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ConfirmTextbox")
            
            #line default
            #line hidden
, 2024), false)
);

WriteLiteral(">");

            
            #line 20 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                             Write(Model.ConfirmationTitle);

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n    <input");

WriteAttribute("id", Tuple.Create(" id=\'", 2102), Tuple.Create("\'", 2139)
            
            #line 21 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
, Tuple.Create(Tuple.Create("", 2107), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("ConfirmTextbox")
            
            #line default
            #line hidden
, 2107), false)
);

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" data-sf-role=\"text-field-confirmation-input\"");

WriteLiteral(" type=\"text\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\"", 2218), Tuple.Create("\"", 2262)
            
            #line 21 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                            , Tuple.Create(Tuple.Create("", 2232), Tuple.Create<System.Object, System.Int32>(Model.ConfirmationPlaceholder
            
            #line default
            #line hidden
, 2232), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 2263), Tuple.Create("\"", 2289)
            
            #line 21 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2271), Tuple.Create<System.Object, System.Int32>(Model.SecondValue
            
            #line default
            #line hidden
, 2271), false)
);

WriteLiteral(" />\r\n    <div");

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</div>\r\n");

            
            #line 24 "..\..\MVC\Views\ConfirmationField\Write.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ConfirmationField/confirmation-field.js"), "bottom"));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
