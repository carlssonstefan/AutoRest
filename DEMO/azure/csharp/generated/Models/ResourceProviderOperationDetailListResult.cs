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
    /// List of resource provider operations.
    /// </summary>
    public partial class ResourceProviderOperationDetailListResult
    {
        /// <summary>
        /// Gets or sets the list of resource provider operations.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<ResourceProviderOperationDefinition> Value { get; set; }

    }
}
