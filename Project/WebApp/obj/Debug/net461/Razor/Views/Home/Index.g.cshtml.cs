#pragma checksum "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21e90e4466af3aa6ab0d6a5ebbd4231e1f1fdb05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp;

#line default
#line hidden
#line 2 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#line 5 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21e90e4466af3aa6ab0d6a5ebbd4231e1f1fdb05", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2f98f970d24f6881606ae75842e99b849213bb4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 148, true);
            WriteLiteral("\r\n\r\n<script type=\"text/javascript\">\r\n    function UploadPic() {\r\n        debugger;\r\n        $.ajax({\r\n            type: \'POST\',\r\n            url: (\"");
            EndContext();
            BeginContext(194, 29, false);
#line 11 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
              Write(Url.Content("~/Photo/Rebind"));

#line default
#line hidden
            EndContext();
            BeginContext(223, 545, true);
            WriteLiteral(@"/""),
            dataType: 'json',
            success: function (data) {
                $(""#show"").attr(""src"", data);
                document.getElementById('Submit1').disabled = false;
                alert(""Photo Capture successfully!"");
            }
        });
    }

    function Uploadsubmit() {
        debugger;
        var src = $('img').attr('src');
        src_array = src.split('/');
        src = src_array[4];
        if (src != """") {
            $.ajax({
                type: 'POST',
                url: (""");
            EndContext();
            BeginContext(769, 28, false);
#line 29 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
                  Write(Url.Content("~/Photo/Index"));

#line default
#line hidden
            EndContext();
            BeginContext(797, 266, true);
            WriteLiteral(@"/""),
               dataType: 'json',
               data: { Imagename: src },
               success: function () { }
           });
            window.opener.location.href = ""http://localhost:55694/Photo/Changephoto"";
            self.close();}}
</script>
");
            EndContext();
#line 37 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            DefineSection("scripts", async() => {
                BeginContext(1124, 203, true);
                WriteLiteral("\r\n      \r\n        <script type=\"text/javascript\">\r\n            $(\"#Camera\").webcam({\r\n                width: 320,\r\n                height: 240,\r\n                mode: \"save\",\r\n                 swffile: \"");
                EndContext();
                BeginContext(1328, 44, false);
#line 47 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
                      Write(Url.Content("~/lib/jQuery-webcam/jscam.swf"));

#line default
#line hidden
                EndContext();
                BeginContext(1372, 214, true);
                WriteLiteral("\",\r\n                onTick: function () { },\r\n                onSave: function () {\r\n                    UploadPic();\r\n                },\r\n                onCapture: function () {\r\n                    webcam.save(\"");
                EndContext();
                BeginContext(1587, 30, false);
#line 53 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
                            Write(Url.Content("~/Photo/Capture"));

#line default
#line hidden
                EndContext();
                BeginContext(1617, 149, true);
                WriteLiteral("/\");\r\n             },\r\n                debug: function () { },\r\n                onLoad: function () { }\r\n\r\n            });\r\n\r\n        </script>\r\n    ");
                EndContext();
            }
            );
            BeginContext(1769, 687, true);
            WriteLiteral(@"    <div class=""row"" style=""margin: 0 auto; width: 980px; text-align: center; padding-top : 15px"">
        <div style=""float: left; border: 4px solid #ccc; padding: 5px"">
            <div id=""Camera"">
            </div>
            <br>
            <input type=""button"" value=""Capture"" onclick=""webcam.capture();"" />
        </div>
        <div style=""float: left; margin-left: 20px; border: 4px solid #ccc; padding: 5px"">
            <img id=""show"" style=""width: 320px; height: 240px;"" src=""../../WebImages/person.jpg"" />
            <br>
            <br>
            <input id=""Submit1"" type=""submit"" onclick=""Uploadsubmit();"" value=""submit"" />
        </div>
    </div>
");
            EndContext();
#line 76 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"

}

#line default
#line hidden
            BeginContext(2461, 226, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    window.onload = load();\r\n\r\n    function load() {\r\n      \r\n        document.getElementById(\'Submit1\').disabled = true;\r\n    }\r\n\r\n</script>\r\n\r\n<label style=\"padding-top:50px\">Config</label>  ");
            EndContext();
            BeginContext(2688, 20, false);
#line 88 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
                                           Write(ViewBag.AppSQLConfig);

#line default
#line hidden
            EndContext();
            BeginContext(2708, 29, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n\r\n    ");
            EndContext();
            BeginContext(2739, 777, false);
#line 92 "C:\Users\Keerthi Raja P\source\repos\EmployeeManage\Project\WebApp\Views\Home\Index.cshtml"
Write(Html.Kendo().Grid<WebApp.Models.UserAccountViewModel>()
                                .Name("grid")
                                .Columns(columns =>
                                {
                                    columns.Bound(c => c.FullName).Width(140);
                                    columns.Bound(c => c.Email).Width(190);
                                    columns.Bound(c => c.LastName);
                                    columns.Bound(c => c.IsActive).Width(110);
                                })
                                .DataSource(dataSource => dataSource
                                    .Ajax()
                                    .Read(read => read.Action("Products_Read", "Home"))
                                )
    );

#line default
#line hidden
            EndContext();
            BeginContext(3517, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
