// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SyncGroupsOperations.
    /// </summary>
    public static partial class SyncGroupsOperationsExtensions
    {
            /// <summary>
            /// Get a SyncGroup List.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            public static IEnumerable<SyncGroup> ListByStorageSyncService(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName)
            {
                return operations.ListByStorageSyncServiceAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a SyncGroup List.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<SyncGroup>> ListByStorageSyncServiceAsync(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByStorageSyncServiceWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new SyncGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='syncGroupName'>
            /// Name of Sync Group resource.
            /// </param>
            /// <param name='properties'>
            /// The parameters used to create the sync group
            /// </param>
            public static SyncGroup Create(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, object properties = default(object))
            {
                return operations.CreateAsync(resourceGroupName, storageSyncServiceName, syncGroupName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new SyncGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='syncGroupName'>
            /// Name of Sync Group resource.
            /// </param>
            /// <param name='properties'>
            /// The parameters used to create the sync group
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncGroup> CreateAsync(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, object properties = default(object), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get a given SyncGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='syncGroupName'>
            /// Name of Sync Group resource.
            /// </param>
            public static SyncGroup Get(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName)
            {
                return operations.GetAsync(resourceGroupName, storageSyncServiceName, syncGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a given SyncGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='syncGroupName'>
            /// Name of Sync Group resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncGroup> GetAsync(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a given SyncGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='syncGroupName'>
            /// Name of Sync Group resource.
            /// </param>
            public static SyncGroupsDeleteHeaders Delete(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName)
            {
                return operations.DeleteAsync(resourceGroupName, storageSyncServiceName, syncGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a given SyncGroup.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='syncGroupName'>
            /// Name of Sync Group resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SyncGroupsDeleteHeaders> DeleteAsync(this ISyncGroupsOperations operations, string resourceGroupName, string storageSyncServiceName, string syncGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, syncGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}