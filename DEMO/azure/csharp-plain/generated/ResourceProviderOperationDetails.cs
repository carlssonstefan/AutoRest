// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace MyNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using Models;

    /// <summary>
    /// ResourceProviderOperationDetails operations.
    /// </summary>
    internal partial class ResourceProviderOperationDetails : IServiceOperations<ResourceManagementClient>, IResourceProviderOperationDetails
    {
        /// <summary>
        /// Initializes a new instance of the ResourceProviderOperationDetails class.
        /// </summary>
        /// <param name='client'>
        /// Reference to the service client.
        /// </param>
        internal ResourceProviderOperationDetails(ResourceManagementClient client)
        {
            this.Client = client;
        }

        /// <summary>
        /// Gets a reference to the ResourceManagementClient
        /// </summary>
        public ResourceManagementClient Client { get; private set; }

        /// <summary>
        /// Gets a list of resource providers.
        /// </summary>
        /// <param name='resourceProviderNamespace'>
        /// Resource identity.
        /// </param>
        /// <param name='apiVersion'>
        /// </param>
        /// <param name='customHeaders'>
        /// Headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        public async Task<HttpOperationResponse<ResourceProviderOperationDetailListResult>> ListWithHttpMessagesAsync(string resourceProviderNamespace, string apiVersion, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (resourceProviderNamespace == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "resourceProviderNamespace");
            }
            if (apiVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "apiVersion");
            }
            if (this.Client.SubscriptionId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "this.Client.SubscriptionId");
            }
            // Tracing
            bool shouldTrace = ServiceClientTracing.IsEnabled;
            string invocationId = null;
            if (shouldTrace)
            {
                invocationId = ServiceClientTracing.NextInvocationId.ToString();
                Dictionary<string, object> tracingParameters = new Dictionary<string, object>();
                tracingParameters.Add("resourceProviderNamespace", resourceProviderNamespace);
                tracingParameters.Add("apiVersion", apiVersion);
                tracingParameters.Add("cancellationToken", cancellationToken);
                ServiceClientTracing.Enter(invocationId, this, "List", tracingParameters);
            }
            // Construct URL
            var url = new Uri(this.Client.BaseUri, "/providers/{resourceProviderNamespace}/operations").ToString();
            url = url.Replace("{resourceProviderNamespace}", Uri.EscapeDataString(resourceProviderNamespace));
            url = url.Replace("{subscriptionId}", Uri.EscapeDataString(this.Client.SubscriptionId));
            List<string> queryParameters = new List<string>();
            if (apiVersion != null)
            {
                queryParameters.Add(string.Format("api-version={0}", Uri.EscapeDataString(apiVersion)));
            }
            if (queryParameters.Count > 0)
            {
                url += "?" + string.Join("&", queryParameters);
            }
            // Create HTTP transport objects
            HttpRequestMessage httpRequest = new HttpRequestMessage();
            httpRequest.Method = new HttpMethod("GET");
            httpRequest.RequestUri = new Uri(url);
            // Set Headers
            if (customHeaders != null)
            {
                foreach(var header in customHeaders)
                {
                    if (httpRequest.Headers.Contains(header.Key))
                    {
                        httpRequest.Headers.Remove(header.Key);
                    }
                    httpRequest.Headers.TryAddWithoutValidation(header.Key, header.Value);
                }
            }

            // Send Request
            if (shouldTrace)
            {
                ServiceClientTracing.SendRequest(invocationId, httpRequest);
            }
            cancellationToken.ThrowIfCancellationRequested();
            HttpResponseMessage httpResponse = await this.Client.HttpClient.SendAsync(httpRequest, cancellationToken).ConfigureAwait(false);
            if (shouldTrace)
            {
                ServiceClientTracing.ReceiveResponse(invocationId, httpResponse);
            }
            HttpStatusCode statusCode = httpResponse.StatusCode;
            cancellationToken.ThrowIfCancellationRequested();
            if (!(statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK") || statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "NoContent")))
            {
                var ex = new HttpOperationException(string.Format("Operation returned an invalid status code '{0}'", statusCode));
                ex.Request = httpRequest;
                ex.Response = httpResponse;
                if (shouldTrace)
                {
                    ServiceClientTracing.Error(invocationId, ex);
                }
                throw ex;
            }
            // Create Result
            var result = new HttpOperationResponse<ResourceProviderOperationDetailListResult>();
            result.Request = httpRequest;
            result.Response = httpResponse;
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "OK"))
            {
                string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                result.Body = JsonConvert.DeserializeObject<ResourceProviderOperationDetailListResult>(responseContent, this.Client.DeserializationSettings);
            }
            // Deserialize Response
            if (statusCode == (HttpStatusCode)Enum.Parse(typeof(HttpStatusCode), "NoContent"))
            {
                string responseContent = await httpResponse.Content.ReadAsStringAsync().ConfigureAwait(false);
                result.Body = JsonConvert.DeserializeObject<ResourceProviderOperationDetailListResult>(responseContent, this.Client.DeserializationSettings);
            }
            if (shouldTrace)
            {
                ServiceClientTracing.Exit(invocationId, result);
            }
            return result;
        }

    }
}
