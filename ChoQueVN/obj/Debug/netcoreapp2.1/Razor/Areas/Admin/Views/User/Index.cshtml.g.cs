#pragma checksum "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb3d8f1d6376817eeae6b85c9472f2ab632c66be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_User_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/User/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_User_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
#line 6 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
using System.Linq;

#line default
#line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 5 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
using ChoQueVN.Models;

#line default
#line hidden
#line 8 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb3d8f1d6376817eeae6b85c9472f2ab632c66be", @"/Areas/Admin/Views/User/Index.cshtml")]
    public class Areas_Admin_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Danh sách tài khoản";
    Layout = "~/Areas/Admin/Views/_Shared/_LayoutAdmin.cshtml";
    

#line default
#line hidden
#line 11 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
    var msg = ViewBag.msg;

#line default
#line hidden
            BeginContext(364, 678, true);
            WriteLiteral(@"<section class=""container-fluid"">
    <div class=""row"">
        <h3 class=""col-sm-10"">
            Danh sách tài khoản
        </h3>
        <form action=""/Admin/User/AddEdit"">
            <input type=""submit"" class=""btn btn-primary"" value=""Thêm tài khoản"" />
        </form>
    </div>
    <div class=""row form-group"">
        <table class=""table table-striped"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Họ tên</th>
                    <th scope=""col"">Tài khoản</th>
                    <th scope=""col"">Tác vụ</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 33 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1107, 101, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\"></th>\r\n                        <td>");
            EndContext();
            BeginContext(1209, 9, false);
#line 37 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1218, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1254, 12, false);
#line 38 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
                       Write(item.Account);

#line default
#line hidden
            EndContext();
            BeginContext(1266, 94, true);
            WriteLiteral("</td>\r\n                        <td style=\"text-align:center;\">\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1360, "\"", 1398, 2);
            WriteAttributeValue("", 1367, "/Admin/User/AddEdit?id=", 1367, 23, true);
#line 40 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1390, item.ID, 1390, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1399, 58, true);
            WriteLiteral(">Sửa</a>&nbsp;&nbsp;&nbsp;\r\n                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1457, "\"", 1494, 2);
            WriteAttributeValue("", 1464, "/Admin/User/Delete?id=", 1464, 22, true);
#line 41 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1486, item.ID, 1486, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1495, "\"", 1526, 3);
            WriteAttributeValue("", 1505, "Remove(this,", 1505, 12, true);
#line 41 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
WriteAttributeValue("", 1517, item.ID, 1517, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1525, ")", 1525, 1, true);
            EndWriteAttribute();
            BeginContext(1527, 68, true);
            WriteLiteral(">Xoá</a>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 44 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1614, 40, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            EndContext();
#line 50 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
          
            //lay bien key truyen tu url
            string _key = Context.Request.Query["key"];
        

#line default
#line hidden
            BeginContext(1932, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(1941, 89, false);
#line 54 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\User\Index.cshtml"
   Write(Html.PagedListPager(Model, page => Url.Action("Index", "User", new { page, key = _key })));

#line default
#line hidden
            EndContext();
            BeginContext(2030, 364, true);
            WriteLiteral(@"
    </div>
</section>

<script>
    var Remove = function (obj, id) {
        //debugger
        var host = window.location.host;
        var name = obj.parentNode.parentNode.children[1].textContent;
        if (window.confirm(""Ban muon xoa "" + name + "" ?""))
            window.location.href = host + ""/Admin/User/Delele?id="" + id;
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<User>> Html { get; private set; }
    }
}
#pragma warning restore 1591