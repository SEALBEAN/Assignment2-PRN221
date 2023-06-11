#pragma checksum "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ad2abc561de5d581207a245ef3e0310a6eb5196"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPage.Pages.Flower.Pages_Flower_EditFlower), @"mvc.1.0.razor-page", @"/Pages/Flower/EditFlower.cshtml")]
namespace RazorPage.Pages.Flower
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
#line 1 "D:\Assignment2\RazorPage\Pages\_ViewImports.cshtml"
using RazorPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
using Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ad2abc561de5d581207a245ef3e0310a6eb5196", @"/Pages/Flower/EditFlower.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e22f18812073ba4f6cd646dc18520ef2aaf1b7ac", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Flower_EditFlower : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "UpdateFlower", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
  
    var role = HttpContext.Session.GetString("role");
    var name = HttpContext.Session.GetString("name");

    IFlowerRepository _flowerRepository = new FlowerRepository();
    var flowerId = HttpContext.Session.GetString("FlowerID");
    var flower = _flowerRepository.GetFlowers().Where(x => x.FlowerBouquetId == int.Parse(flowerId)).FirstOrDefault();

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    .btn-primary {\r\n        float: left;\r\n    }\r\n\r\n    .btn-right {\r\n        float: right;\r\n    }\r\n\r\n</style>\r\n");
#nullable restore
#line 24 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
  
    if (role == "admin")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Manage Customers</h1>\r\n        <p>Welcome, Admin ");
#nullable restore
#line 28 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                     Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\r\n");
#nullable restore
#line 29 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"

        ICategoryRepository _categoryRepository = new CategoryRepository();
        var categories = _categoryRepository.GetCategories();
        var currentCategory = _categoryRepository.GetCategoryByID(flower.CategoryId);
        ISupplierRepository _supplierRepository = new SupplierRepository();
        var suppliers = _supplierRepository.GetSuppliers();
        var currentSupplier = _supplierRepository.GetSupplierByID(flower.SupplierId.Value);





#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad2abc561de5d581207a245ef3e0310a6eb51965930", async() => {
                WriteLiteral("\r\n            <input type=\"hidden\" name=\"flowerId\"");
                BeginWriteAttribute("value", " value=\"", 1265, "\"", 1296, 1);
#nullable restore
#line 41 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
WriteAttributeValue("", 1273, flower.FlowerBouquetId, 1273, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            <div class=\"form-group\">\r\n                <label for=\"categoryId\">Category</label>\r\n                <select class=\"form-control\" id=\"categoryId\" name=\"categoryId\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad2abc561de5d581207a245ef3e0310a6eb51966824", async() => {
#nullable restore
#line 45 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                                                           Write(currentCategory.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                       WriteLiteral(currentCategory.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 46 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                     foreach (var category in categories)
                    {
                        if (category.CategoryName != currentCategory.CategoryName)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad2abc561de5d581207a245ef3e0310a6eb51969081", async() => {
#nullable restore
#line 50 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                                                            Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                               WriteLiteral(category.CategoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 51 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"flowerName\">Flower Bouquet Name</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"flowerName\" name=\"flowerName\"");
                BeginWriteAttribute("value", " value=\"", 2167, "\"", 2200, 1);
#nullable restore
#line 57 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
WriteAttributeValue("", 2175, flower.FlowerBouquetName, 2175, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"description\">Description</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"description\" name=\"description\"");
                BeginWriteAttribute("value", " value=\"", 2417, "\"", 2444, 1);
#nullable restore
#line 61 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
WriteAttributeValue("", 2425, flower.Description, 2425, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"unitPrice\">Unit Price</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"unitPrice\" name=\"unitPrice\"");
                BeginWriteAttribute("value", " value=\"", 2654, "\"", 2679, 1);
#nullable restore
#line 65 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
WriteAttributeValue("", 2662, flower.UnitPrice, 2662, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <label for=\"unitInStock\">Unit In Stock</label>\r\n                <input type=\"text\" class=\"form-control\" id=\"unitInStock\" name=\"unitInStock\"");
                BeginWriteAttribute("value", " value=\"", 2900, "\"", 2928, 1);
#nullable restore
#line 70 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
WriteAttributeValue("", 2908, flower.UnitsInStock, 2908, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label for=\"supplierId\">Supplier</label>\r\n                <select class=\"form-control\" id=\"supplierId\" name=\"supplierId\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad2abc561de5d581207a245ef3e0310a6eb519613819", async() => {
#nullable restore
#line 75 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                                                           Write(currentSupplier.SupplierName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                       WriteLiteral(currentSupplier.SupplierId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 76 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                     foreach (var supplier in suppliers)
                    {
                        if (supplier.SupplierName != currentSupplier.SupplierName)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ad2abc561de5d581207a245ef3e0310a6eb519616076", async() => {
#nullable restore
#line 80 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                                                            Write(supplier.SupplierName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                               WriteLiteral(supplier.SupplierId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 81 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div class=""form-group"">
                <label for=""flowerBouquetStatus"">Status</label>
                <input type=""text"" class=""form-control"" id=""flowerBouquetStatus"" name=""flowerBouquetStatus""");
                BeginWriteAttribute("value", " value=\"", 3832, "\"", 3867, 1);
#nullable restore
#line 87 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
WriteAttributeValue("", 3840, flower.FlowerBouquetStatus, 3840, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Update</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 91 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
        //if update success show the message using
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
         if (ViewData["Message"] != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"alert alert-success\" role=\"alert\">\r\n                ");
#nullable restore
#line 95 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
           Write(ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n");
#nullable restore
#line 97 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a href=\"/Flower/ManageFlower\" class=\"btn btn-primary btn-right\">Back to Manage Flower</a>\r\n");
#nullable restore
#line 101 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"

    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Access Denied</h1>\r\n        <p>This page is restricted to administrators only. Please log in as an admin to access this page.</p>\r\n        <a href=\"/login\" class=\"btn btn-primary\">Go to Login</a>\r\n");
#nullable restore
#line 108 "D:\Assignment2\RazorPage\Pages\Flower\EditFlower.cshtml"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EditFlowerModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EditFlowerModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<EditFlowerModel>)PageContext?.ViewData;
        public EditFlowerModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
