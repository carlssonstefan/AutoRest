// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace .Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Resource provider operation information.
    /// </summary>
    public partial class ResourceProviderOperationDefinition
    {
        /// <summary>
        /// Gets or sets the provider operation name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the display property of the provider operation.
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public ResourceProviderOperationDisplayProperties Display { get; set; }

    }
}
