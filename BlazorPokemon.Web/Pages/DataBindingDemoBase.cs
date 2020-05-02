using Microsoft.AspNetCore.Components;

namespace BlazorPokemon.Web.Pages
{
    public class DataBindingDemoBase : ComponentBase
    {
        protected string Name { get; set; } = "Tom";
        
        protected string Gender { get; set; } = "Male";

        public string Colour { get; set; } = "background-color:gray";

        public string Description { get; set; } = string.Empty;

    }
}