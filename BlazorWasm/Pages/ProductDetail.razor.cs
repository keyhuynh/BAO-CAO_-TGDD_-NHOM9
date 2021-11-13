using AppModel;
using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Pages
{
    public partial class ProductDetail
    {
        [Parameter]
        public string id { set; get; }
        [Inject] private IProductApiClient ProductApiClient { set; get; }

        private int SoLuong = 1;
        private Product Product = new Product();
        private List<Product> Products = new List<Product>();

        protected override async Task OnInitializedAsync()
        {
            Product = await ProductApiClient.GetProduct(Int32.Parse(id));
            if (Product != null)
            {
                Products = await ProductApiClient.GetProductsByCategoryId(Product.CategoryId);
                Products = Products.Where(x => x.Id != Product.Id).ToList();
            }
        }
        protected override async Task OnParametersSetAsync()
        {
            Product = await ProductApiClient.GetProduct(Int32.Parse(id));
            if (Product != null)
            {
                Products = await ProductApiClient.GetProductsByCategoryId(Product.CategoryId);
                Products = Products.Where(x => x.Id != Product.Id).ToList();
            }
        }
    }
}
