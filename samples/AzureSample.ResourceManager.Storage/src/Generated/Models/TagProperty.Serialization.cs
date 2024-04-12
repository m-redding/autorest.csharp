// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;

namespace AzureSample.ResourceManager.Storage.Models
{
    public partial class TagProperty
    {
        internal static TagProperty DeserializeTagProperty(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string tag = default;
            DateTimeOffset? timestamp = default;
            string objectIdentifier = default;
            Guid? tenantId = default;
            string upn = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tag"u8))
                {
                    tag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("objectIdentifier"u8))
                {
                    objectIdentifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("upn"u8))
                {
                    upn = property.Value.GetString();
                    continue;
                }
            }
            return new TagProperty(tag, timestamp, objectIdentifier, tenantId, upn);
        }
    }
}