// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace MyNamespace.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Entity representing the reference to the deployment paramaters.
    /// </summary>
    public partial class ParametersLink
    {
        /// <summary>
        /// URI referencing the template.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// If included it must match the ContentVersion in the template.
        /// </summary>
        [JsonProperty(PropertyName = "contentVersion")]
        public string ContentVersion { get; set; }

    }
}
