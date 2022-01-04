// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;
using MgmtSubscriptionNameParameter.Models;

namespace MgmtSubscriptionNameParameter
{
    /// <summary> A class representing collection of SBSubscription and their operations over its parent. </summary>
    public partial class SBSubscriptionCollection : ArmCollection, IEnumerable<SBSubscription>, IAsyncEnumerable<SBSubscription>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SubscriptionsRestOperations _subscriptionsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SBSubscriptionCollection"/> class for mocking. </summary>
        protected SBSubscriptionCollection()
        {
        }

        /// <summary> Initializes a new instance of SBSubscriptionCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SBSubscriptionCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _subscriptionsRestClient = new SubscriptionsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroup.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Subscriptions_CreateOrUpdate
        /// <summary> Creates a topic subscription. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual SubscriptionCreateOrUpdateOperation CreateOrUpdate(string subscriptionName, SBSubscriptionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _subscriptionsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, parameters, cancellationToken);
                var operation = new SubscriptionCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Subscriptions_CreateOrUpdate
        /// <summary> Creates a topic subscription. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="parameters"> Parameters supplied to create a subscription resource. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SubscriptionCreateOrUpdateOperation> CreateOrUpdateAsync(string subscriptionName, SBSubscriptionData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _subscriptionsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SubscriptionCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Subscriptions_Get
        /// <summary> Returns a subscription description for the specified topic. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<SBSubscription> Get(string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = _subscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SBSubscription(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions/{subscriptionName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Subscriptions_Get
        /// <summary> Returns a subscription description for the specified topic. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public async virtual Task<Response<SBSubscription>> GetAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.Get");
            scope.Start();
            try
            {
                var response = await _subscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SBSubscription(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<SBSubscription> GetIfExists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _subscriptionsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SBSubscription>(null, response.GetRawResponse())
                    : Response.FromValue(new SBSubscription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public async virtual Task<Response<SBSubscription>> GetIfExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _subscriptionsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SBSubscription>(null, response.GetRawResponse())
                    : Response.FromValue(new SBSubscription(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public virtual Response<bool> Exists(string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(subscriptionName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="subscriptionName"> The subscription name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string subscriptionName, CancellationToken cancellationToken = default)
        {
            if (subscriptionName == null)
            {
                throw new ArgumentNullException(nameof(subscriptionName));
            }

            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(subscriptionName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Subscriptions_ListByTopic
        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SBSubscription" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SBSubscription> GetAll(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<SBSubscription> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionsRestClient.ListByTopic(Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SBSubscription> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _subscriptionsRestClient.ListByTopicNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ServiceBus/subscriptions
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}
        /// OperationId: Subscriptions_ListByTopic
        /// <summary> List all the subscriptions under a specified topic. </summary>
        /// <param name="skip"> Skip is only used if a previous operation returned a partial result. If a previous response contains a nextLink element, the value of the nextLink element will include a skip parameter that specifies a starting point to use for subsequent calls. </param>
        /// <param name="top"> May be used to limit the number of results to the most recent N usageDetails. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SBSubscription" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SBSubscription> GetAllAsync(int? skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<SBSubscription>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionsRestClient.ListByTopicAsync(Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SBSubscription>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _subscriptionsRestClient.ListByTopicNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, skip, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SBSubscription(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="SBSubscription" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SBSubscription.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="SBSubscription" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SBSubscriptionCollection.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(SBSubscription.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SBSubscription> IEnumerable<SBSubscription>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SBSubscription> IAsyncEnumerable<SBSubscription>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SBSubscription, SBSubscriptionData> Construct() { }
    }
}