using AppModel;
using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Pages
{
    public partial class ProductSearch
    {
        [Parameter]
        public string keyword { set; get; }

        [Inject] private IProductApiClient ProductApiClient { set; get; }


        private List<Product> Products = new List<Product>();


        protected override async Task OnInitializedAsync()
        {
            Products = await ProductApiClient.GetProducts(keyword);
        }
        protected override async Task OnParametersSetAsync()
        {
            Products = await ProductApiClient.GetProducts(keyword);
        }

    }
}
