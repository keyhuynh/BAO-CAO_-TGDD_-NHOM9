using AppModel;
using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace BlazorWasm.Pages
{
    public partial class ProductByCategory
    {
        [Parameter]
        public string categoryId { set; get; }

        [Inject] private IProductApiClient ProductApiClient { set; get; }


        private List<Product> Products = new List<Product>();
        private Category category = new Category();


        protected override async Task OnInitializedAsync()
        {
            Products = await ProductApiClient.GetProductsByCategoryId(Int32.Parse(categoryId));
            category = await ProductApiClient.GetCategoryById(Int32.Parse(categoryId));
        }
        protected override async Task OnParametersSetAsync()
        {
            Products = await ProductApiClient.GetProductsByCategoryId(Int32.Parse(categoryId));
            category = await ProductApiClient.GetCategoryById(Int32.Parse(categoryId));
        }
    }
}
