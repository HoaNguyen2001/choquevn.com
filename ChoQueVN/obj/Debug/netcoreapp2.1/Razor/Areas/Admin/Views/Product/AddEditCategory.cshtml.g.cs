#pragma checksum "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95eb13e91faea2d73b968ac13f131be316a30e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Product_AddEditCategory), @"mvc.1.0.view", @"/Areas/Admin/Views/Product/AddEditCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Product/AddEditCategory.cshtml", typeof(AspNetCore.Areas_Admin_Views_Product_AddEditCategory))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95eb13e91faea2d73b968ac13f131be316a30e5", @"/Areas/Admin/Views/Product/AddEditCategory.cshtml")]
    public class Areas_Admin_Views_Product_AddEditCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
  
    ViewData["Title"] = "AddEditCategory";
    Layout = "~/Areas/Admin/Views/_Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(118, 72, true);
            WriteLiteral("\r\n<section class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <h2>");
            EndContext();
            BeginContext(191, 14, false);
#line 9 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
       Write(ViewBag.Header);

#line default
#line hidden
            EndContext();
            BeginContext(205, 42, true);
            WriteLiteral("</h2>\r\n    </div>\r\n    <form method=\"post\"");
            EndContext();
            BeginWriteAttribute("action", " action=\"", 247, "\"", 275, 1);
#line 11 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
WriteAttributeValue("", 256, ViewBag.FormAction, 256, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(276, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(288, 23, false);
#line 12 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(311, 283, true);
            WriteLiteral(@"
        <div class=""row form-group"">
            <label for=""inputName"" class=""col-sm-2 col-form-label"">Tên danh mục</label>
            <div class=""col-sm-10"">
                <input type=""text"" class=""form-control"" id=""inputCategory"" name=""Category"" placeholder=""Tên danh mục""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 594, "\"", 650, 1);
            WriteAttributeValue("", 602, new Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_attribute_value_writer) => {
                PushWriter(__razor_attribute_value_writer);
#line 16 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                                                                                              if (Model != null) { 

#line default
#line hidden
                BeginContext(631, 10, false);
#line 16 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                                                                                                                    Write(Model.Name);

#line default
#line hidden
                EndContext();
#line 16 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                                                                                                                                            }

#line default
#line hidden
                PopWriter();
            }
            ), 602, 48, false);
            EndWriteAttribute();
            BeginContext(651, 369, true);
            WriteLiteral(@" required>
            </div>
        </div>

        <div class=""row form-group"">
            <label for=""ParentCategory"" class=""col-sm-2 col-form-label"">Danh mục cha</label>
            <div class=""col-sm-10"">
                <select class=""form-control"" id=""ParentCategory"" name=""ParentID"">
                    <option value=""0"">---Danh mục cha---</option>
");
            EndContext();
#line 25 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                     foreach (var item in ViewBag.Categories)
                    {
                        if (Model != null)
                        {

#line default
#line hidden
            BeginContext(1177, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1212, "\"", 1228, 1);
#line 29 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
WriteAttributeValue("", 1220, item.ID, 1220, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1229, 1, true);
            WriteLiteral(" ");
            EndContext();
#line 29 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                      if (Model.ParentID == item.ID) { 

#line default
#line hidden
            BeginContext(1270, 9, true);
            WriteLiteral(" selected");
            EndContext();
#line 29 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                                                                              }

#line default
#line hidden
            BeginContext(1288, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1290, 9, false);
#line 29 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                                                                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 30 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1394, 35, true);
            WriteLiteral("                            <option");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1429, "\"", 1445, 1);
#line 33 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
WriteAttributeValue("", 1437, item.ID, 1437, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1446, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(1448, 9, false);
#line 33 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                                                Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1457, 11, true);
            WriteLiteral("</option>\r\n");
            EndContext();
#line 34 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
                        }
                    }

#line default
#line hidden
            BeginContext(1518, 65, true);
            WriteLiteral("                </select>\r\n            </div>\r\n        </div>\r\n\r\n");
            EndContext();
#line 40 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
         if (ViewBag.FormAction == "/Admin/Product/AddEditCategoryPost")
        {

#line default
#line hidden
            BeginContext(1668, 85, true);
            WriteLiteral("            <input type=\"submit\" value=\"Thêm danh mục\" class=\"btn btn-secondary\" />\r\n");
            EndContext();
#line 43 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1789, 84, true);
            WriteLiteral("            <input type=\"submit\" value=\"Sửa danh mục\" class=\"btn btn-secondary\" />\r\n");
            EndContext();
#line 47 "G:\DHCNHN\Nam3_KiHe\ASP.NET\BTL\ChoqueVN.Com\ChoQueVN\Areas\Admin\Views\Product\AddEditCategory.cshtml"
        }

#line default
#line hidden
            BeginContext(1884, 29, true);
            WriteLiteral("\r\n    </form>\r\n</section>\r\n\r\n");
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
