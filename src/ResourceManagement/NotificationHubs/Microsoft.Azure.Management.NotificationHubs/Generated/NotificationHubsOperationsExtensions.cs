// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.NotificationHubs
{
    using System.Threading.Tasks;
   using Microsoft.Rest.Azure;
   using Models;

    /// <summary>
    /// Extension methods for NotificationHubsOperations.
    /// </summary>
    public static partial class NotificationHubsOperationsExtensions
    {
            /// <summary>
            /// Checks the availability of the given notificationHub in a namespace.
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj870968.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// The notificationHub name.
            /// </param>
            public static CheckAvailabilityResult CheckAvailability(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, CheckAvailabilityParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).CheckAvailabilityAsync(resourceGroupName, namespaceName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Checks the availability of the given notificationHub in a namespace.
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj870968.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='parameters'>
            /// The notificationHub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CheckAvailabilityResult> CheckAvailabilityAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, CheckAvailabilityParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CheckAvailabilityWithHttpMessagesAsync(resourceGroupName, namespaceName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates/Update a NotificationHub in a namespace.
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj856303.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update a NotificationHub Resource.
            /// </param>
            public static NotificationHubResource CreateOrUpdate(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, NotificationHubCreateOrUpdateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).CreateOrUpdateAsync(resourceGroupName, namespaceName, notificationHubName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates/Update a NotificationHub in a namespace.
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj856303.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the create/update a NotificationHub Resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<NotificationHubResource> CreateOrUpdateAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, NotificationHubCreateOrUpdateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a notification hub associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static void Delete(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).DeleteAsync(resourceGroupName, namespaceName, notificationHubName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a notification hub associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static NotificationHubResource Get(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).GetAsync(resourceGroupName, namespaceName, notificationHubName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<NotificationHubResource> GetAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates/Updates an authorization rule for a NotificationHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            public static SharedAccessAuthorizationRuleResource CreateOrUpdateAuthorizationRule(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).CreateOrUpdateAuthorizationRuleAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates/Updates an authorization rule for a NotificationHub
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='parameters'>
            /// The shared access authorization rule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SharedAccessAuthorizationRuleResource> CreateOrUpdateAuthorizationRuleAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, SharedAccessAuthorizationRuleCreateOrUpdateParameters parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a notificationHub authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            public static void DeleteAuthorizationRule(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
            {
                System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).DeleteAuthorizationRuleAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None,  System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a notificationHub authorization rule
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// Authorization Rule Name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAuthorizationRuleAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                await operations.DeleteAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Gets an authorization rule for a NotificationHub by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// authorization rule name.
            /// </param>
            public static SharedAccessAuthorizationRuleResource GetAuthorizationRule(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).GetAuthorizationRuleAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets an authorization rule for a NotificationHub by name.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// authorization rule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<SharedAccessAuthorizationRuleResource> GetAuthorizationRuleAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetAuthorizationRuleWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<NotificationHubResource> List(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListAsync(resourceGroupName, namespaceName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<NotificationHubResource>> ListAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, namespaceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRules(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListAuthorizationRulesAsync(resourceGroupName, namespaceName, notificationHubName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the Primary and Secondary ConnectionStrings to the NotificationHub
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The connection string of the NotificationHub for the specified
            /// authorizationRule.
            /// </param>
            public static ResourceListKeys ListKeys(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListKeysAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Primary and Secondary ConnectionStrings to the NotificationHub
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The connection string of the NotificationHub for the specified
            /// authorizationRule.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceListKeys> ListKeysAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerates the Primary/Secondary Keys to the NotificationHub
            /// Authorization Rule
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The connection string of the NotificationHub for the specified
            /// authorizationRule.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the NotificationHub Authorization Rule
            /// Key.
            /// </param>
            public static ResourceListKeys RegenerateKeys(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, PolicykeyResource parameters)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).RegenerateKeysAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, parameters), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerates the Primary/Secondary Keys to the NotificationHub
            /// Authorization Rule
            /// <see href="http://msdn.microsoft.com/en-us/library/windowsazure/jj873988.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='authorizationRuleName'>
            /// The connection string of the NotificationHub for the specified
            /// authorizationRule.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to regenerate the NotificationHub Authorization Rule
            /// Key.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<ResourceListKeys> RegenerateKeysAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, string authorizationRuleName, PolicykeyResource parameters, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.RegenerateKeysWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, authorizationRuleName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the PNS Credentials associated with a notification hub .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            public static PnsCredentialsResource GetPnsCredentials(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).GetPnsCredentialsAsync(resourceGroupName, namespaceName, notificationHubName), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the PNS Credentials associated with a notification hub .
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name.
            /// </param>
            /// <param name='notificationHubName'>
            /// The notification hub name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<PnsCredentialsResource> GetPnsCredentialsAsync(this INotificationHubsOperations operations, string resourceGroupName, string namespaceName, string notificationHubName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetPnsCredentialsWithHttpMessagesAsync(resourceGroupName, namespaceName, notificationHubName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<NotificationHubResource> ListNext(this INotificationHubsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the notification hubs associated with a namespace.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<NotificationHubResource>> ListNextAsync(this INotificationHubsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static Microsoft.Rest.Azure.IPage<SharedAccessAuthorizationRuleResource> ListAuthorizationRulesNext(this INotificationHubsOperations operations, string nextPageLink)
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((INotificationHubsOperations)s).ListAuthorizationRulesNextAsync(nextPageLink), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the authorization rules for a NotificationHub.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Microsoft.Rest.Azure.IPage<SharedAccessAuthorizationRuleResource>> ListAuthorizationRulesNextAsync(this INotificationHubsOperations operations, string nextPageLink, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListAuthorizationRulesNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}