// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class InputFieldMappingEntry : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Source != null)
            {
                writer.WritePropertyName("source");
                writer.WriteStringValue(Source);
            }
            if (SourceContext != null)
            {
                writer.WritePropertyName("sourceContext");
                writer.WriteStringValue(SourceContext);
            }
            if (Inputs != null)
            {
                writer.WritePropertyName("inputs");
                writer.WriteStartArray();
                foreach (var item in Inputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
        internal static InputFieldMappingEntry DeserializeInputFieldMappingEntry(JsonElement element)
        {
            InputFieldMappingEntry result = new InputFieldMappingEntry();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Source = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceContext"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.SourceContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Inputs = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        result.Inputs.Add(DeserializeInputFieldMappingEntry(item));
                    }
                    continue;
                }
            }
            return result;
        }
    }
}