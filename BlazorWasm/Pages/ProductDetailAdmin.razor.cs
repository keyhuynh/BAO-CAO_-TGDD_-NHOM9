using AppModel;
using BlazorWasm.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.Pages
{
    public partial class ProductDetailAdmin
    {
        [Parameter]
        public string id { set; get; }
        [Inject] private IProductApiClient ProductApiClient { set; get; }


        private Product Product = new Product();


        protected override async Task OnInitializedAsync()
        {
            Product = await ProductApiClient.GetProduct(Int32.Parse(id));
        }
    }
}
