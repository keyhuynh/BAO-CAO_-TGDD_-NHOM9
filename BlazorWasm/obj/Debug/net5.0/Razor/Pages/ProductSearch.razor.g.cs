#pragma checksum "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cc75b0d969ebe56ee87a74e8629f0db43a4dffa"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWasm.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using BlazorWasm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\_Imports.razor"
using BlazorWasm.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
using BlazorWasm.Extensions;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/search/{keyword}")]
    public partial class ProductSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container mt-5");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "box-content");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "heading__custom");
            __builder.AddMarkupContent(6, "<i class=\"heading__custom-icon fab fa-searchengin\"></i> Kết quả tìm kiếm cho: ");
            __builder.AddContent(7, 
#nullable restore
#line 8 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                                                                                           keyword

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "h3");
            __builder.AddContent(10, 
#nullable restore
#line 9 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                 Products.Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, " sản phẩm");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
         if (Products == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "<div>Loading...</div>");
#nullable restore
#line 14 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "ul");
            __builder.AddAttribute(14, "class", "listproduct");
#nullable restore
#line 18 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                 foreach (var item in Products)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "item");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/productdetail/" + (
#nullable restore
#line 21 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                                                 item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "main-contain");
            __builder.AddMarkupContent(20, "<div class=\"item-label\"><span class=\"lb-tragop\">Trả góp 0%</span></div>\r\n                            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "item-img item-img_42");
            __builder.OpenElement(23, "img");
            __builder.AddAttribute(24, "class", "thumb ls-is-cached lazyloaded");
            __builder.AddAttribute(25, "alt", 
#nullable restore
#line 27 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                                           item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(26, "src", 
#nullable restore
#line 28 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                                           item.ThumbnailImage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                <img src=\"https://cdn.tgdd.vn/ValueIcons/label-moi-ra-mat-fnal.png\" width=\"40\" height=\"40\" loading=\"lazy\" class=\"lbliconimg lbliconimg_42 tgdd\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\r\n                            ");
            __builder.OpenElement(29, "h3");
            __builder.AddContent(30, 
#nullable restore
#line 36 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "strong");
            __builder.AddAttribute(33, "class", "price");
            __builder.AddContent(34, 
#nullable restore
#line 37 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                                                   DecimalExtensions.ToCurrency(item.Price)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.AddMarkupContent(36, "<div class=\"item-bottom\"><a href=\"#\" class=\"shiping\"></a></div>");
            __builder.CloseElement();
#nullable restore
#line 43 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 47 "D:\Gihub\TheGioiDiDong-TieuLuan\BlazorWasm\Pages\ProductSearch.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
