// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Storage.Management.Models
{
    public partial class ManagementPolicySchema : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("rules");
            writer.WriteStartArray();
            foreach (var item in Rules)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static ManagementPolicySchema DeserializeManagementPolicySchema(JsonElement element)
        {
            IList<ManagementPolicyRule> rules = new List<ManagementPolicyRule>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rules"))
                {
                    List<ManagementPolicyRule> array = new List<ManagementPolicyRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagementPolicyRule.DeserializeManagementPolicyRule(item));
                    }
                    rules = array;
                    continue;
                }
            }
            return new ManagementPolicySchema(rules);
        }
    }
}