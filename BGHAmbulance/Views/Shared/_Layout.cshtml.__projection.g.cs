namespace ASP {
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Helpers;
using System.Web.Security;
using System.Web.UI;
using System.Web.WebPages;
using System.Web.WebPages.Html;

public class _Page__Layout_cshtml : System.Web.WebPages.WebPage {
private static object @__o;
#line hidden
public _Page__Layout_cshtml() {
}
protected System.Web.HttpApplication ApplicationInstance {
get {
return ((System.Web.HttpApplication)(Context.ApplicationInstance));
}
}
public override void Execute() {

#line 1 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
      __o = ViewBag.Title;


#line default
#line hidden

#line 2 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
__o = Styles.Render("~/Content/css");


#line default
#line hidden

#line 3 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/modernizr");


#line default
#line hidden

#line 4 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
       __o = Html.ActionLink("BGH Ambulance", "Index", "Home", new { area = "" }, new { @class = "navbar-brand" });


#line default
#line hidden

#line 5 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                   __o = Html.ActionLink("Home", "Index", "Home", new { area = "" }, new { @class = "nav-link" });


#line default
#line hidden

#line 6 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                      
                        if (Request.IsAuthenticated)
                        {
                            

#line default
#line hidden

#line 7 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                           __o = Html.ActionLink("Ambulances", "Index", "Ambulances", new { area = "" }, new { @class = "nav-link" });


#line default
#line hidden

#line 8 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                                                                                                                                          
                            

#line default
#line hidden

#line 9 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                           __o = Html.ActionLink("Employees", "Index", "Employees", new { area = "" }, new { @class = "nav-link" });


#line default
#line hidden

#line 10 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                                                                                                                                        
                        }
                    

#line default
#line hidden

#line 11 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                   __o = Html.ActionLink("About", "About", "Home", new { area = "" }, new { @class = "nav-link" });


#line default
#line hidden

#line 12 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                   __o = Html.ActionLink("Contact", "Contact", "Home", new { area = "" }, new { @class = "nav-link" });


#line default
#line hidden

#line 13 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
            __o = Html.Partial("_LoginPartial");


#line default
#line hidden

#line 14 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
   __o = RenderBody();


#line default
#line hidden

#line 15 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
                 __o = DateTime.Now.Year;


#line default
#line hidden

#line 16 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/jquery");


#line default
#line hidden

#line 17 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
__o = Scripts.Render("~/bundles/bootstrap");


#line default
#line hidden

#line 18 "C:\Users\user\AppData\Local\Temp\97BEFB8C640ACD3C5B142F374E883D8894BC\5\BGHAmbulance\BGHAmbulance\Views\Shared\_Layout.cshtml"
__o = RenderSection("scripts", required: false);


#line default
#line hidden
}
}
}
