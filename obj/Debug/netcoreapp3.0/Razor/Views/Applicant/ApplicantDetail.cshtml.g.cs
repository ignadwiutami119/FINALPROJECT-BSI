#pragma checksum "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fc10b98c610e146a72d380261efe46dc86dfa39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applicant_ApplicantDetail), @"mvc.1.0.view", @"/Views/Applicant/ApplicantDetail.cshtml")]
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
#line 1 "G:\FinalProject\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\FinalProject\HCWEB\Views\_ViewImports.cshtml"
using HC_WEB_FINALPROJECT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fc10b98c610e146a72d380261efe46dc86dfa39", @"/Views/Applicant/ApplicantDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7617a8a5b04142fd44fe79920582bdc0a6fd0da", @"/Views/_ViewImports.cshtml")]
    public class Views_Applicant_ApplicantDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
  
    Layout = "_LayoutHC";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link href=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css"" rel=""stylesheet"" id=""bootstrap-css"">
<script src=""//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/js/bootstrap.min.js""></script>
<script src=""//code.jquery.com/jquery-1.11.1.min.js""></script>
<!------ Include the above in your HEAD tag ---------->
<link href=""//maxcdn.bootstrapcdn.com/font-awesome/4.3.0/css/font-awesome.min.css"" rel=""stylesheet"">

<style>
.card {
    padding-top: 20px;
    margin: 10px 0 20px 0;
    background-color:#D4E6F1;
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: none;
    -moz-box-shadow: none;
    box-shadow: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}
.cardimage {
    margin: 10px 0 0px 0;
    background-color: rgba(214, 224, 226, 0.2);
    border-top-width: 0;
    border-bottom-width: 2px;
    -webkit-border-");
            WriteLiteral(@"radius: 3px;
    -moz-border-radius: 3px;
    border-radius: 3px;
    -webkit-box-shadow: none;
    -moz-box-shadow: none;
    box-shadow: none;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card .card-heading {
    padding: 0 20px;
    margin: 0;
}

.card .card-heading.simple {
    font-size: 20px;
    font-weight: 300;
    color: #777;
    border-bottom: 1px solid #e5e5e5;
}

.card .card-heading.image img {
    display: inline-block;
    width: 46px;
    height: 46px;
    margin-right: 15px;
    vertical-align: top;
    border: 0;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50%;
    border-radius: 5%;
}

.card .card-heading.image .card-heading-header {
    display: inline-block;
    vertical-align: top;
}

.card .card-heading.image .card-heading-header h3 {
    margin: 0;
    font-size: 14px;
    line-height: 16px;
    color: #262626;
}

.card .card-heading.image .card-heading-header span {
   ");
            WriteLiteral(@" font-size: 12px;
    color: #999999;
}

.card .card-body {
    padding: 0 20px;
    margin-top: 20px;
}

.card .card-media {
    padding: 0 20px;
    margin: 0 -14px;
}

.card .card-media img {
    max-width: 100%;
    max-height: 100%;
}

.card .card-actions {
    min-height: 30px;
    padding: 0 20px 20px 20px;
    margin: 20px 0 0 0;
}

.card .card-comments {
    padding: 20px;
    margin: 0;
    background-color: #f8f8f8;
}

.card .card-comments .comments-collapse-toggle {
    padding: 0;
    margin: 0 20px 12px 20px;
}

.card .card-comments .comments-collapse-toggle a,
.card .card-comments .comments-collapse-toggle span {
    padding-right: 5px;
    overflow: hidden;
    font-size: 12px;
    color: #999;
    text-overflow: ellipsis;
    white-space: nowrap;
}

.card-comments .media-heading {
    font-size: 13px;
    font-weight: bold;
}

.card.people {
    position: relative;
    display: inline-block;
    width: 170px;
    height: 300px;
    paddi");
            WriteLiteral(@"ng-top: 0;
    margin-left: 20px;
    overflow: hidden;
    vertical-align: top;
}

.card.people:first-child {
    margin-left: 0;
}

.card.people .card-top {
    position: absolute;
    top: 0;
    left: 0;
    display: inline-block;
    width: 170px;
    height: 150px;
    background-color: #ffffff;
}

.card.people .card-top.green {
    background-color: #53a93f;
}

.card.people .card-top.blue {
    background-color: #427fed;
}

.card.people .card-info {
    position: absolute;
    top: 150px;
    display: inline-block;
    width: 100%;
    height: 101px;
    overflow: hidden;
    background: #ffffff;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.people .card-info .title {
    display: block;
    margin: 8px 14px 0 14px;
    overflow: hidden;
    font-size: 16px;
    font-weight: bold;
    line-height: 18px;
    color: #404040;
}

.card.people .card-info .desc {
    display: block;
    margin: 8p");
            WriteLiteral(@"x 14px 0 14px;
    overflow: hidden;
    font-size: 12px;
    line-height: 16px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.people .card-bottom {
    position: absolute;
    bottom: 0;
    left: 0;
    display: inline-block;
    width: 100%;
    padding: 10px 20px;
    line-height: 29px;
    text-align: center;
    -webkit-box-sizing: border-box;
    -moz-box-sizing: border-box;
    box-sizing: border-box;
}

.card.hovercard {
    box-shadow: 1px 1px 10px #5499C7;
    position: relative;
    padding-top: 0;
    overflow: hidden;
    text-align: center;
    background-color: white;
}

.card.hovercard .cardheader {
    background: #1F618D;
    background-size: cover;
    height: 90px;
}

.card.hovercard .avatar {
    position: relative;
    top: -50px;
    margin-bottom: -50px;
}

.card.hovercard .avatar img {
    width: 100px;
    height: 100px;
    max-width: 100px;
    max-height: 100px;
    -webkit-border-radius: 50%;
    -moz-border-radius: 50");
            WriteLiteral(@"%;
    border-radius: 50%;
    border: 5px solid rgba(255,255,255,0.5);
}

.card.hovercard .info {
    padding: 4px 8px 10px;
}

.card.hovercard .info .title {
    margin-bottom: 4px;
    font-size: 24px;
    line-height: 1;
    color: #ffffff;
    vertical-align: middle;
}

.card.hovercard .info .desc {
    overflow: hidden;
    font-size: 12px;
    line-height: 20px;
    color: #737373;
    text-overflow: ellipsis;
}

.card.hovercard .bottom {
    padding: 0 20px;
    margin-bottom: 17px;
}
* {box-sizing: border-box}
body {font-family: ""Lato"", sans-serif;}

/* Style the tab */
.tab {
  float: left;
  background-color: #EBF5FB;
  width: 30%;
  height: 300px;
}

/* Style the buttons inside the tab */
.tab button {
  display: block;
  background: #1F618D;
  color: white;
  padding: 22px 16px;
  width: 100%;
  border : 0;
  text-align: left;
  cursor: pointer;
  transition: 0.3s;
  font-size: 17px;
}

/* Change background color of buttons on hover */
.tab b");
            WriteLiteral(@"utton:hover {
  background-color: #154360;
}

/* Create an active/current ""tab button"" class */
.tab button.active {
  background-color: #FF5693;
}

/* Style the tab content */
.tabcontent {
  float: left;
  padding: 0px 12px;
  width: 70%;
  border-left: none;
  height: 200px;
  background: white;
  box-shadow: 1px 1px 10px #5499C7;
}

  body {
  background-color: #EBF5FB;
      }

 .upload-btn-wrapper {
  position: relative;
  overflow: hidden;
  display: inline-block;
}
.btnx {
  border: 2px solid #FF5693;
  color: white;
  background-color: #FF98BE;
  padding: 6px 50px;
  border-radius: 6px;
  font-size: 10px;
  font-weight: bold;
}
.upload-btn-wrapper input[type=file] {
  font-size: 20px;
  position: absolute;
  left: 0;
  top: 0;
  opacity: 0;}
</style>

");
#nullable restore
#line 339 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
    
     var Applicant = ViewBag.items;
     var date = Applicant.BirthDate.ToString("dd MMMM yyyy");

#line default
#line hidden
#nullable disable
            WriteLiteral("     <input type=\"hidden\" id=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 7134, "\"", 7155, 1);
#nullable restore
#line 342 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
WriteAttributeValue("", 7142, Applicant.Id, 7142, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("<br><br>\r\n");
            WriteLiteral(@"<div class=""container"">
   <div class=""column"">
    <div class=""column text-right""> <div class=""col-lg-12 col-sm-5"">
<button class=""btn btn-warning""style=""text-left"" onclick=""javascript:Warning(this)""><b>Warning Message</b></button>
<button class=""btn btn-success"" onclick=""javascript:Update(this)""><b>Edit Data</b></button>
<button class=""btn btn-danger"" onclick=""javascript:Remove(this)""><b>Remove</b></button>
</div></div> </div>
	<div class=""row"">
		<div class=""col-lg-12 col-sm-6"">

            <div class=""card hovercard"">
                <div class=""cardheader"" style=""margin-top: 15px;"">
                    <div style=""padding-top:2px; padding-bottom:5px"">
                  <h2 style=""color:white""><b>");
#nullable restore
#line 361 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
                                        Write(Applicant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h2></div>\r\n                </div>\r\n                <div class=\"avatar\"><br>\r\n                    <img alt=\"profil-picture\"");
            BeginWriteAttribute("src", " src=", 8056, "", 8077, 1);
#nullable restore
#line 364 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
WriteAttributeValue("", 8061, Applicant.Image, 8061, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"info\">\r\n                    <div style=\"color:#FF4842\">\r\n                        <b>");
#nullable restore
#line 368 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
                      Write(Applicant.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                    </div>\r\n                    <div class=\"desc\"><b>Departement ");
#nullable restore
#line 370 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
                                                Write(Applicant.Placement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\r\n                    <div class=\"desc\">Status Proccess : ");
#nullable restore
#line 371 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
                                                   Write(Applicant.Status_Proccess);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                <div class=""bottom"">
                    <a class=""btn btn-primary btn-twitter btn-sm"" href=""https://twitter.com/webmaniac"">
                        <i class=""fa fa-twitter""></i>
                    </a>
                    <a class=""btn btn-danger btn-sm"" rel=""publisher""
                       href=""https://plus.google.com/+ahmshahnuralam"">
                        <i class=""fa fa-google-plus""></i>
                    </a>
                    <a class=""btn btn-primary btn-sm"" rel=""publisher""
                       href=""https://plus.google.com/shahnuralam"">
                        <i class=""fa fa-facebook""></i>
                    </a>
                    <a class=""btn btn-warning btn-sm"" rel=""publisher"" href=""https://plus.google.com/shahnuralam"">
                        <i class=""fa fa-behance""></i>
                    </a>
                </div>
            </div>
        </div>
	</div>

<div class=""col-lg-12 col-sm-6"">

<div class=""col-l");
            WriteLiteral(@"g-7 col-sm-5"" style=""background:white;float:left; padding-top:20px; box-shadow: 1px 1px 10px #5499C7;"">
    <div class=""text-center"">
            <h4>Personal Information</h4>
        </div><br>
<table class=""table table-hover"">
  <thead class=""thead-dark"">
  </thead>
  <tbody>
    <tr>
      <td><b>Name</b></td>
      <td>");
#nullable restore
#line 405 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Email</b></td>\r\n      <td>");
#nullable restore
#line 409 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Phone</b></td>\r\n      <td>");
#nullable restore
#line 413 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Address</b></td>\r\n      <td>");
#nullable restore
#line 417 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Birth Date</b></td>\r\n      <td>");
#nullable restore
#line 421 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Birth Place</b></td>\r\n      <td>");
#nullable restore
#line 425 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.BirthPlace);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
   </tbody>
</table> 
</div>

    <div class=""col-lg-4 col-sm-6"" style=""background:white;margin-left:18px; padding-top:20px; padding-left:10px;padding-right:10px; box-shadow: 1px 1px 10px #5499C7;"">
        <div class=""text-center"">
            <h4>Emergency Contact</h4>
        </div><br>
<table class=""table table-hover"">
  <thead class=""thead-dark"">
  </thead>
  <tbody>
    <tr>
      <td><b>Emergency Contact #1</b></td>
      <td>");
#nullable restore
#line 441 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.EmergencyContact1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b></b></td>\r\n      <td>");
#nullable restore
#line 445 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Phone1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Emergency Contact #2</b></td>\r\n      <td>");
#nullable restore
#line 449 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.EmergencyContact2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b></b></td>\r\n      <td>");
#nullable restore
#line 453 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Phone2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td><b>Emergency Contact #3</b></td>\r\n      <td>");
#nullable restore
#line 457 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.EmergencyContact3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n      <td></td>\r\n      <td>");
#nullable restore
#line 461 "G:\FinalProject\HCWEB\Views\Applicant\ApplicantDetail.cshtml"
     Write(Applicant.Phone3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n   </tbody>\r\n</table> \r\n</div>\r\n\r\n</div> \r\n\r\n</div>\r\n<br><br><br>\r\n");
            WriteLiteral(@"

<script type=""text/javascript"">
function Update()
{
    var Id = document.getElementById(""ID"").value;
    location.href='/Applicant/ApplicantUpdate?Id='+Id;
}

function Remove()
{
    var Id = document.getElementById(""ID"").value;
    location.href='/Applicant/Reject?Id='+Id;
}
</script>");
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