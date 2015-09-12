// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is

namespace MyNamespace
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class ResourceGroupsExtensions
    {
            /// <summary>
            /// Get all of the resources under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Query parameters. If null is passed returns all resource groups.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// Query parameters. If null is passed returns all resource groups.
            /// </param>
            public static ResourceListResult ListResources(this IResourceGroups operations, string resourceGroupName, string filter = default(string), int? top = default(int?))
            {
                return Task.Factory.StartNew(s => ((IResourceGroups)s).ListResourcesAsync(resourceGroupName, filter, top), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all of the resources under a subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Query parameters. If null is passed returns all resource groups.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// Query parameters. If null is passed returns all resource groups.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ResourceListResult> ListResourcesAsync( this IResourceGroups operations, string resourceGroupName, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<ResourceListResult> result = await operations.ListResourcesWithHttpMessagesAsync(resourceGroupName, filter, top, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Checks whether resource group exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            public static void CheckExistence(this IResourceGroups operations, string resourceGroupName)
            {
                Task.Factory.StartNew(s => ((IResourceGroups)s).CheckExistenceAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks whether resource group exists.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to check. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task CheckExistenceAsync( this IResourceGroups operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CheckExistenceWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Create a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update resource group service
            /// operation.
            /// </param>
            public static ResourceGroup CreateOrUpdate(this IResourceGroups operations, string resourceGroupName, ResourceGroup parameters)
            {
                return Task.Factory.StartNew(s => ((IResourceGroups)s).CreateOrUpdateAsync(resourceGroupName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to be created or updated.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create or update resource group service
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ResourceGroup> CreateOrUpdateAsync( this IResourceGroups operations, string resourceGroupName, ResourceGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<ResourceGroup> result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Begin deleting resource group.To determine whether the operation has
            /// finished processing the request, call GetLongRunningOperationStatus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to be deleted. The name is case insensitive.
            /// </param>
            public static void Delete(this IResourceGroups operations, string resourceGroupName)
            {
                Task.Factory.StartNew(s => ((IResourceGroups)s).DeleteAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Begin deleting resource group.To determine whether the operation has
            /// finished processing the request, call GetLongRunningOperationStatus.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to be deleted. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task DeleteAsync( this IResourceGroups operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            public static ResourceGroup Get(this IResourceGroups operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IResourceGroups)s).GetAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a resource group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to get. The name is case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ResourceGroup> GetAsync( this IResourceGroups operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<ResourceGroup> result = await operations.GetWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Resource groups can be updated through a simple PATCH operation to a group
            /// address. The format of the request is the same as that for creating a
            /// resource groups, though if a field is unspecified current value will be
            /// carried over.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to be created or updated. The name is case
            /// insensitive.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update state resource group service operation.
            /// </param>
            public static ResourceGroup Patch(this IResourceGroups operations, string resourceGroupName, ResourceGroup parameters)
            {
                return Task.Factory.StartNew(s => ((IResourceGroups)s).PatchAsync(resourceGroupName, parameters), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resource groups can be updated through a simple PATCH operation to a group
            /// address. The format of the request is the same as that for creating a
            /// resource groups, though if a field is unspecified current value will be
            /// carried over.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to be created or updated. The name is case
            /// insensitive.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the update state resource group service operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ResourceGroup> PatchAsync( this IResourceGroups operations, string resourceGroupName, ResourceGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<ResourceGroup> result = await operations.PatchWithHttpMessagesAsync(resourceGroupName, parameters, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets a collection of resource groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// Query parameters. If null is passed returns all resource groups.
            /// </param>
            public static ResourceGroupListResult List(this IResourceGroups operations, string filter = default(string), int? top = default(int?))
            {
                return Task.Factory.StartNew(s => ((IResourceGroups)s).ListAsync(filter, top), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a collection of resource groups.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='filter'>
            /// The filter to apply on the operation.
            /// </param>
            /// <param name='top'>
            /// Query parameters. If null is passed returns all resource groups.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<ResourceGroupListResult> ListAsync( this IResourceGroups operations, string filter = default(string), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<ResourceGroupListResult> result = await operations.ListWithHttpMessagesAsync(filter, top, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
