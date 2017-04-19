using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
// PascalCasing
// camelCasing
// kabob-casing
namespace WebApplication4
{
    public class RepeatTagHelper : TagHelper
    {
       
        /// <summary>
        /// <repeat count="5">HTML</repeat>
        /// </summary>
        public int Count { get; set; }

        public async override Task ProcessAsync(TagHelperContext context, 
                                            TagHelperOutput output)
        {
            for (int i = 0; i < Count; i++)
            {
                output.Content.AppendHtml(await output.GetChildContentAsync(useCachedResult: false));
            }
            
        }
    }
}
