#pragma checksum "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1b9bf34c5778e9019bac6cb7d430727a73a7080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Attendance_AttendanceList), @"mvc.1.0.view", @"/Views/Attendance/AttendanceList.cshtml")]
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
#line 1 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1b9bf34c5778e9019bac6cb7d430727a73a7080", @"/Views/Attendance/AttendanceList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Attendance_AttendanceList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
  <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<style>
       body {
  background-color: #EBF5FB;
         }
</style>

 <br>

<div class=""container"">
    <div class=""column"">
        <div class=""col-lg-12 col-sm-5"">
");
#nullable restore
#line 17 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
           var u = ViewBag.employee;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h2><b>");
#nullable restore
#line 18 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
          Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2>");
            WriteLiteral("        <h4>Attendance History</h4></div>\r\n<div class=\"col-lg-12 col-sm-5\"><div class=\"column text-right\">\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 507, "\"", 561, 3);
            WriteAttributeValue("", 517, "location.href=\'/Attendance/ClockIn?Id=", 517, 38, true);
#nullable restore
#line 21 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
WriteAttributeValue("", 555, u.Id, 555, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 560, "\'", 560, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-bottom:1.5px\" class=\"btn btn-success\"><b>Clock In</b></button>\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 648, "\"", 703, 3);
            WriteAttributeValue("", 658, "location.href=\'/Attendance/ClockOut?Id=", 658, 39, true);
#nullable restore
#line 22 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
WriteAttributeValue("", 697, u.Id, 697, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 702, "\'", 702, 1, true);
            EndWriteAttribute();
            WriteLiteral(@"  style=""margin-bottom:1.5px"" class=""btn btn-success""><b>Clock Out</b></button>
</div>

<table style=""background:white; box-shadow: 1px 1px 10px #5499C7"" class=""table text-left"">
            <tbody>
    <br>
    <thead style=""text-center;"" class=""thead-dark"">
    <tr><th>        </th>
");
#nullable restore
#line 30 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
           
        var a = ViewBag.items;
        var date_only = a.Date;
        for(int i=1;i<8;i++)
            {
        var day = date_only.AddDays(i);
        var getDate = day.ToString("dd/MM/yyyy");
        var getHari = day.DayOfWeek;
        if(day.DayOfWeek!=DayOfWeek.Saturday && day.DayOfWeek!=DayOfWeek.Sunday)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("             <th scope=\"col\">");
#nullable restore
#line 40 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                        Write(getDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> ");
#nullable restore
#line 40 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                      Write(getHari);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th> \r\n");
#nullable restore
#line 41 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
            } 
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n  </thead>  \r\n        <tr><th><b>Clock In</b></th>\r\n");
#nullable restore
#line 47 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
        var Attendance = ViewBag.Attendance;
        var n = ViewBag.items;
        var dateonly = n.Date;
        var cek2 = 0;
        var timeonly1 ="";
        for(int i=1;i<8;i++)
            {cek2=0;
        var day = dateonly.AddDays(i);
        var getDate = day.ToString("dd/MM/yyyy");
        var getHari = day.DayOfWeek;
        if(day.DayOfWeek!=DayOfWeek.Saturday && day.DayOfWeek!=DayOfWeek.Sunday)
            { foreach(var item in Attendance){
                if(getDate == (item.ClockIn).ToString("dd/MM/yyyy")){
                cek2=1;
                timeonly1 = item.ClockIn.ToString("hh:mm:ss tt");

#line default
#line hidden
#nullable disable
            WriteLiteral("               <td style=\"background:#00BF61; color:white\" scope=\"col\">");
#nullable restore
#line 62 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                  Write(timeonly1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> ");
#nullable restore
#line 62 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                                  Write(item.Remarks_in);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> ");
#nullable restore
#line 62 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                                                             }
               }
            if(cek2==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <td style=\"background:#E03535; color:white\" scope=\"col\">Absent</td>\r\n");
#nullable restore
#line 66 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
               }
            } 
            }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr> \r\n\r\n        <tr><th><b>Clock Out</b></th>\r\n");
#nullable restore
#line 73 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
        var cek1 = 0;
        var timeonly="";
        for(int i=1;i<8;i++)
            {cek1 = 0;
        var day = dateonly.AddDays(i);
        var getDate = day.ToString("dd/MM/yyyy");
        var getHari = day.DayOfWeek;
        if(day.DayOfWeek!=DayOfWeek.Saturday && day.DayOfWeek!=DayOfWeek.Sunday)
            {
                foreach(var item in Attendance){
                if(getDate == (item.ClockOut).ToString("dd/MM/yyyy")){
                cek1=1;
                timeonly = item.ClockOut.ToString("hh:mm:ss tt");

#line default
#line hidden
#nullable disable
            WriteLiteral("               <td style=\"background:#00BF61; color:white\" scope=\"col\">");
#nullable restore
#line 86 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                  Write(timeonly);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br> ");
#nullable restore
#line 86 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                                 Write(item.Remarks_out);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> ");
#nullable restore
#line 86 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                                                             }
              }
             if(cek1==0){

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <td style=\"background:#E03535; color:white\" scope=\"col\">Absent</td>\r\n");
#nullable restore
#line 90 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
               }
            } 
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr> \r\n\r\n\r\n        <tr><th><b>Status</b></th>\r\n");
#nullable restore
#line 98 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
        var cek = 0;
        for(int i=1;i<8;i++)
            { 
        var day = dateonly.AddDays(i);
        var getDate = day.ToString("dd/MM/yyyy");
        var getHari = day.DayOfWeek;
        cek = 0;
       
        if(day.DayOfWeek!=DayOfWeek.Saturday && day.DayOfWeek!=DayOfWeek.Sunday)
        { 
            foreach(var item in Attendance)
            {
                if(getDate == (item.ClockOut).ToString("dd/MM/yyyy"))
                {
                    cek =1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background:#00BF61; color:white\" scope=\"col\">");
#nullable restore
#line 113 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                       Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 114 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                }
                else if(getDate == (item.ClockIn).ToString("dd/MM/yyyy") && cek == 0)
                {   cek =1;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td style=\"background:#00BF61; color:white\" scope=\"col\">");
#nullable restore
#line 117 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                                                                       Write(item.status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 118 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
                }
            }
            if(cek == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td style=\"background:#E03535; color:white\" scope=\"col\">Absent</td>\r\n");
#nullable restore
#line 123 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
            }
        } 
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tr> \r\n </tbody> \r\n    </table>\r\n<div class=\"text-center\">\r\n<button");
            BeginWriteAttribute("onclick", " onclick=\"", 4496, "\"", 4562, 3);
            WriteAttributeValue("", 4506, "location.href=\'/Attendance/AttendanceThisMonth?Id=", 4506, 50, true);
#nullable restore
#line 132 "D:\FINALPROJECT\FINALPROJECT-BSI\Views\Attendance\AttendanceList.cshtml"
WriteAttributeValue("", 4556, u.Id, 4556, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4561, "\'", 4561, 1, true);
            EndWriteAttribute();
            WriteLiteral(" style=\"background:#FF5693; color:white; float:center\" class=\"btn\">View This Month</button>\r\n</div>\r\n</div>\r\n                </div>\r\n            <br>\r\n        </div>\r\n    </div>\r\n</div>\r\n\t</div>\r\n</div>\r\n  </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
