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
    
    #line 1 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 2 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 3 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
    using Telerik.Sitefinity.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/CountryField/DesignerView.Simple.cshtml")]
    public partial class _MVC_Views_CountryField_DesignerView_Simple_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _MVC_Views_CountryField_DesignerView_Simple_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"title\"");

WriteLiteral(" class=\"full-width\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 7 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
       Write(Html.Resource("Label"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </label>\r\n        <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" class=\"col-xs-10\"");

WriteLiteral(">\r\n                <textarea");

WriteLiteral(" id=\"title\"");

WriteLiteral(" ng-model=\"properties.Model.MetaField.Title.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral("></textarea>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" class=\"full-width\"");

WriteLiteral(">");

            
            #line 16 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                             Write(Html.Resource("Choices"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n\r\n        <div");

WriteLiteral(" class=\"list-group list-group-endless\"");

WriteLiteral(" kendo-sortable");

WriteLiteral(" k-options=\"sortableOptions\"");

WriteLiteral(" k-on-change=\"sortItems(kendoEvent)\"");

WriteLiteral(">\r\n            <div");

WriteLiteral(" ng-repeat=\"item in currentItems track by $index\"");

WriteLiteral(" class=\"list-group-item list-group-item-multiselect\"");

WriteLiteral(" ng-class=\"currentItems.length > 1 ? \'list-group-item-draggable-2 list-group-item" +
"-draggable-2--noCheckbox\' : \'\'\"");

WriteLiteral(">\r\n                <span");

WriteLiteral(" ng-show=\"currentItems.length > 1\"");

WriteLiteral(" class=\"handler list-group-item-drag\"");

WriteLiteral("></span>\r\n                <div>\r\n                    <section");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                        <div");

WriteLiteral(" class=\"col-md-8\"");

WriteLiteral(">\r\n                            <input");

WriteLiteral(" ng-click=\"itemClicked($event)\"");

WriteLiteral(" ng-model=\"currentItems[$index]\"");

WriteLiteral(" ng-value=\"currentItems[$index]\"");

WriteAttribute("placeholder", Tuple.Create(" placeholder=\'", 1327), Tuple.Create("\'", 1369)
            
            #line 24 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                                                               , Tuple.Create(Tuple.Create("", 1341), Tuple.Create<System.Object, System.Int32>(Html.Resource("EnterLabel")
            
            #line default
            #line hidden
, 1341), false)
);

WriteLiteral(" type=\"text\"");

WriteLiteral(" class=\"form-control-highlight\"");

WriteLiteral(" />\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-md-2\"");

WriteLiteral(">\r\n                            <em");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(" ng-show=\"item == defaultValue\"");

WriteLiteral(">");

            
            #line 27 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                                                                             Write(Html.Resource("Default"));

            
            #line default
            #line hidden
WriteLiteral("</em>\r\n                            <a");

WriteLiteral(" class=\"make-default\"");

WriteLiteral(" ng-click=\"setDefault(item)\"");

WriteLiteral(" ng-hide=\"!item || item == defaultValue || properties.Model.ValidatorDefinition.R" +
"equired.PropertyValue === \'True\'\"");

WriteLiteral(">");

            
            #line 28 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                                                                                                                                                                                             Write(Html.Resource("MakeDefault"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                        </div>\r\n                        <div");

WriteLiteral(" class=\"col-md-2 text-right\"");

WriteLiteral(">\r\n                            <button");

WriteLiteral(" ng-show=\"currentItems.length > 1\"");

WriteLiteral(" ng-click=\"removeItem(item, $index)\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"close\"");

WriteLiteral(" aria-label=\"Close\"");

WriteLiteral("><span");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">&times;</span></button>\r\n                        </div>\r\n\r\n                    <" +
"/section>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <" +
"a");

WriteLiteral(" ng-click=\"addItem()\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"text-muted list-group-item-add\"");

WriteLiteral(">");

            
            #line 38 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                                                                                Write(Html.Resource("ClickToAddChoice"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"dropdown-list-required-field\"");

WriteLiteral(" class=\"full-width\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"dropdown-list-required-field\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-click=\"changeRequired()\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.Required.PropertyValue\"");

WriteLiteral("\r\n                       ng-true-value=\"\'True\'\"");

WriteLiteral(" ng-false-value=\"\'False\'\"");

WriteLiteral(" ng-checked=\"properties.Model.ValidatorDefinition.Required.PropertyValue === \'Tru" +
"e\'\"");

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 46 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
           Write(Html.Resource("RequiredField"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n        </div>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(" ng-show=\"properties.Model.ValidatorDefinition.Required.PropertyValue === \'True\'\"" +
"");

WriteLiteral(">\r\n        <label");

WriteLiteral(" for=\"example\"");

WriteLiteral(" class=\"full-width\"");

WriteLiteral(">\r\n");

WriteLiteral("            ");

            
            #line 53 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
       Write(Html.Resource("ErrorMessageDisplayedLabel"));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </label>\r\n        <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"example\"");

WriteLiteral(" ng-model=\"properties.Model.ValidatorDefinition.RequiredViolationMessage.Property" +
"Value\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"checkbox\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"multiple-choice-hidden\"");

WriteLiteral(" class=\"full-width\"");

WriteLiteral(">\r\n                <input");

WriteLiteral(" id=\"multiple-choice-hidden\"");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" ng-model=\"properties.Model.Hidden.PropertyValue\"");

WriteLiteral("\r\n                       ng-true-value=\"\'True\'\"");

WriteLiteral(" ng-false-value=\"\'False\'\"");

WriteLiteral(" ng-checked=\"properties.Model.Hidden.PropertyValue === \'True\'\"");

WriteLiteral(" />\r\n");

WriteLiteral("                ");

            
            #line 63 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
           Write(Html.Resource("HiddenField"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            </label>\r\n        </div>\r\n    </div>\r\n\r\n    <expander");

WriteAttribute("expander-title", Tuple.Create(" expander-title=\'", 3870), Tuple.Create("\'", 3916)
            
            #line 68 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 3887), Tuple.Create<System.Object, System.Int32>(Html.Resource("MoreOptions")
            
            #line default
            #line hidden
, 3887), false)
);

WriteLiteral(">\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"textFieldTemplateName\"");

WriteLiteral(">");

            
            #line 70 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                                          Write(Html.Resource("Template"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <div");

WriteLiteral(" class=\"row\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"col-xs-6\"");

WriteLiteral(">\r\n                    <select");

WriteLiteral(" id=\"textFieldTemplateName\"");

WriteLiteral(" ng-model=\"properties.WriteTemplateName.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(">\r\n");

            
            #line 74 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 74 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                         foreach (var viewName in Html.GetViewNames(((Telerik.Sitefinity.Mvc.Proxy.MvcProxyBase)Model).GetController(), @"^Write\.(?<viewName>[\w\s]*)$"))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <option");

WriteAttribute("value", Tuple.Create(" value=\"", 4474), Tuple.Create("\"", 4491)
            
            #line 76 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
, Tuple.Create(Tuple.Create("", 4482), Tuple.Create<System.Object, System.Int32>(viewName
            
            #line default
            #line hidden
, 4482), false)
);

WriteLiteral("> ");

            
            #line 76 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                                                  Write(viewName.SplitCamelCase());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");

            
            #line 77 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </select>\r\n                </div>\r\n            </div>\r\n      " +
"  </div>\r\n        <style-dropdown");

WriteLiteral(" selected-class=\"properties.Model.CssClass.PropertyValue\"");

WriteLiteral(" view-name=\"properties.WriteTemplateName.PropertyValue\"");

WriteLiteral("></style-dropdown>\r\n        <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\r\n            <label");

WriteLiteral(" for=\"cssClass\"");

WriteLiteral(">");

            
            #line 84 "..\..\MVC\Views\CountryField\DesignerView.Simple.cshtml"
                             Write(Html.Resource("CssClasses"));

            
            #line default
            #line hidden
WriteLiteral("</label>\r\n            <input");

WriteLiteral(" type=\"text\"");

WriteLiteral(" id=\"cssClass\"");

WriteLiteral(" ng-model=\"properties.Model.CssClass.PropertyValue\"");

WriteLiteral(" class=\"form-control\"");

WriteLiteral(" />\r\n        </div>\r\n    </expander>\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
