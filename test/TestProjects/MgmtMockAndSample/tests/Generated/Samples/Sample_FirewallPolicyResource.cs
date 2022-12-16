// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using MgmtMockAndSample.Models;

namespace MgmtMockAndSample
{
    public partial class Sample_FirewallPolicyResource
    {
        // Delete Firewall Policy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Delete_DeleteFirewallPolicy()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "FirewallPolicies_Delete" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this FirewallPolicyResource created on azure
            // for more information of creating FirewallPolicyResource, please refer to the document of FirewallPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            ResourceIdentifier firewallPolicyResourceId = FirewallPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName);
            FirewallPolicyResource firewallPolicy = client.GetFirewallPolicyResource(firewallPolicyResourceId);

            // invoke the operation
            await firewallPolicy.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine($"Succeeded");
        }

        // Get FirewallPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GetFirewallPolicy()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "FirewallPolicies_Get" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this FirewallPolicyResource created on azure
            // for more information of creating FirewallPolicyResource, please refer to the document of FirewallPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            ResourceIdentifier firewallPolicyResourceId = FirewallPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName);
            FirewallPolicyResource firewallPolicy = client.GetFirewallPolicyResource(firewallPolicyResourceId);

            // invoke the operation
            FirewallPolicyResource result = await firewallPolicy.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // Create FirewallPolicy
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Update_CreateFirewallPolicy()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "FirewallPolicies_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this FirewallPolicyResource created on azure
            // for more information of creating FirewallPolicyResource, please refer to the document of FirewallPolicyResource
            string subscriptionId = "subid";
            string resourceGroupName = "rg1";
            string firewallPolicyName = "firewallPolicy";
            ResourceIdentifier firewallPolicyResourceId = FirewallPolicyResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, firewallPolicyName);
            FirewallPolicyResource firewallPolicy = client.GetFirewallPolicyResource(firewallPolicyResourceId);

            // invoke the operation
            FirewallPolicyData data = new FirewallPolicyData(new AzureLocation("West US"))
            {
                ThreatIntelWhitelist = new FirewallPolicyThreatIntelWhitelist()
                {
                    IpAddresses =
{
"20.3.4.5"
},
                    Fqdns =
{
"*.microsoft.com"
},
                },
                Insights = new FirewallPolicyInsights()
                {
                    IsEnabled = true,
                    RetentionDays = 100,
                    LogAnalyticsResources = new FirewallPolicyLogAnalyticsResources()
                    {
                        Workspaces =
{
new FirewallPolicyLogAnalyticsWorkspace()
{
Region = "westus",
WorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/workspace1"),
},new FirewallPolicyLogAnalyticsWorkspace()
{
Region = "eastus",
WorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/workspace2"),
}
},
                        DefaultWorkspaceIdId = new ResourceIdentifier("/subscriptions/subid/resourcegroups/rg1/providers/microsoft.operationalinsights/workspaces/defaultWorkspace"),
                    },
                },
                SnatPrivateRanges =
{
"IANAPrivateRanges"
},
                DnsSettings = new DnsSettings()
                {
                    Servers =
{
"30.3.4.5"
},
                    EnableProxy = true,
                    RequireProxyForNetworkRules = false,
                },
                IntrusionDetection = new FirewallPolicyIntrusionDetection()
                {
                    Mode = FirewallPolicyIntrusionDetectionStateType.Alert,
                    Configuration = new FirewallPolicyIntrusionDetectionConfiguration()
                    {
                        SignatureOverrides =
{
new FirewallPolicyIntrusionDetectionSignatureSpecification()
{
Id = "2525004",
Mode = FirewallPolicyIntrusionDetectionStateType.Deny,
}
},
                        BypassTrafficSettings =
{
new FirewallPolicyIntrusionDetectionBypassTrafficSpecifications()
{
Name = "bypassRule1",
Description = "Rule 1",
Protocol = FirewallPolicyIntrusionDetectionProtocol.TCP,
SourceAddresses =
{
"1.2.3.4"
},
DestinationAddresses =
{
"5.6.7.8"
},
DestinationPorts =
{
"*"
},
}
},
                    },
                },
                TransportSecurityCertificateAuthority = new FirewallPolicyCertificateAuthority()
                {
                    KeyVaultSecretId = "https://kv/secret",
                    Name = "clientcert",
                },
                SkuTier = FirewallPolicySkuTier.Premium,
                Tags =
{
["key1"] = "value1",
},
            };
            ArmOperation<FirewallPolicyResource> lro = await firewallPolicy.UpdateAsync(WaitUntil.Completed, data);
            FirewallPolicyResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            FirewallPolicyData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // List all Firewall Policies for a given subscription
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetFirewallPolicies_ListAllFirewallPoliciesForAGivenSubscription()
        {
            // Generated from example definition: 
            // this example is just showing the usage of "FirewallPolicies_ListAll" operation, for the dependent resources, they will have to be created separately.

            // authenticate your client
            ArmClient client = new ArmClient(new DefaultAzureCredential());

            // this example assumes you already have this SubscriptionResource created on azure
            // for more information of creating SubscriptionResource, please refer to the document of SubscriptionResource
            string subscriptionId = "subid";
            ResourceIdentifier subscriptionResourceId = SubscriptionResource.CreateResourceIdentifier(subscriptionId);
            SubscriptionResource subscriptionResource = client.GetSubscriptionResource(subscriptionResourceId);

            // invoke the operation and iterate over the result
            await foreach (FirewallPolicyResource item in subscriptionResource.GetFirewallPoliciesAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                FirewallPolicyData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}