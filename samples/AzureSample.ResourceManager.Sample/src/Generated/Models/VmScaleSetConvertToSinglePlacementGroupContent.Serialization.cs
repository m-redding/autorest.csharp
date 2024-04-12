// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace AzureSample.ResourceManager.Sample.Models
{
    public partial class VmScaleSetConvertToSinglePlacementGroupContent : IUtf8JsonSerializable, IJsonModel<VmScaleSetConvertToSinglePlacementGroupContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VmScaleSetConvertToSinglePlacementGroupContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VmScaleSetConvertToSinglePlacementGroupContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmScaleSetConvertToSinglePlacementGroupContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ActivePlacementGroupId))
            {
                writer.WritePropertyName("activePlacementGroupId"u8);
                writer.WriteStringValue(ActivePlacementGroupId);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        VmScaleSetConvertToSinglePlacementGroupContent IJsonModel<VmScaleSetConvertToSinglePlacementGroupContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VmScaleSetConvertToSinglePlacementGroupContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVmScaleSetConvertToSinglePlacementGroupContent(document.RootElement, options);
        }

        internal static VmScaleSetConvertToSinglePlacementGroupContent DeserializeVmScaleSetConvertToSinglePlacementGroupContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string activePlacementGroupId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("activePlacementGroupId"u8))
                {
                    activePlacementGroupId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VmScaleSetConvertToSinglePlacementGroupContent(activePlacementGroupId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VmScaleSetConvertToSinglePlacementGroupContent)} does not support writing '{options.Format}' format.");
            }
        }

        VmScaleSetConvertToSinglePlacementGroupContent IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVmScaleSetConvertToSinglePlacementGroupContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VmScaleSetConvertToSinglePlacementGroupContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VmScaleSetConvertToSinglePlacementGroupContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}