// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace MyNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// </summary>
    public partial interface IResourceManagementClient
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }        

        /// <summary>
        /// Gets subscription credentials which uniquely identify Microsoft
        /// Azure subscription. The subscription ID forms part of the URI for
        /// every service call.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// Client Api Version.
        /// </summary>
        string ApiVersion { get; set; }


        IProviders Providers { get; }

        IResourceGroups ResourceGroups { get; }

        IResources Resources { get; }

        ITags Tags { get; }

        IDeploymentOperations DeploymentOperations { get; }

        IResourceProviderOperationDetails ResourceProviderOperationDetails { get; }

        IDeployments Deployments { get; }

    }
}
