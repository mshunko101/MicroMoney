using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avalonia.Controls.Templates;
using Avalonia.Controls;
using Avalonia.Metadata;

namespace MicroMoney.Views.TemplateUtils
{
    public class RightTabsTemplateSelector : IDataTemplate
    {
        // This Dictionary should store our shapes. We mark this as [Content], so we can directly add elements to it later.
        [Content]
        public Dictionary<string, IDataTemplate>? AvailableTemplates { get; } = new Dictionary<string, IDataTemplate>();

        // Build the DataTemplate here
        public Control Build(object? param)
        {
            var key = param?.ToString(); // Our Keys in the dictionary are strings, so we call .ToString() to get the key to look up
            if (key is null) // If the key is null, we throw an ArgumentNullException
            {
                throw new ArgumentNullException(nameof(param));
            }
            if(AvailableTemplates.TryGetValue(key, out var model)) // finally we look up the provided key and let the System build the DataTemplate for us
            {
                return model.Build(param) ?? throw new ArgumentNullException(nameof(param));;
            }
            throw new ArgumentNullException(nameof(param));
        }

        // Check if we can accept the provided data
        public bool Match(object? data)
        {
            var key = string.Empty;
            if (object.ReferenceEquals(data, null)) // If the key is null, we throw an ArgumentNullException
            {
                throw new ArgumentNullException(nameof(data));
            }
            else
            {
                key = data.ToString() ?? throw new ArgumentNullException(nameof(data));
            }
            // Our Keys in the dictionary are strings, so we call .ToString() to get the key to look up
            return AvailableTemplates.ContainsKey(key); // and the key must be found in our Dictionary
        }
    }
}