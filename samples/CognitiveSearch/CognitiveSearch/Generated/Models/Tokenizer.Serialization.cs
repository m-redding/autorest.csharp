// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace CognitiveSearch.Models
{
    public partial class Tokenizer : Azure.Core.IUtf8JsonSerializable
    {
        void Azure.Core.IUtf8JsonSerializable.Write(System.Text.Json.Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WriteEndObject();
        }
        internal static CognitiveSearch.Models.Tokenizer DeserializeTokenizer(System.Text.Json.JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out System.Text.Json.JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.ClassicTokenizer": return CognitiveSearch.Models.ClassicTokenizer.DeserializeClassicTokenizer(element);
                    case "#Microsoft.Azure.Search.EdgeNGramTokenizer": return CognitiveSearch.Models.EdgeNGramTokenizer.DeserializeEdgeNGramTokenizer(element);
                    case "#Microsoft.Azure.Search.KeywordTokenizer": return CognitiveSearch.Models.KeywordTokenizer.DeserializeKeywordTokenizer(element);
                    case "#Microsoft.Azure.Search.KeywordTokenizerV2": return CognitiveSearch.Models.KeywordTokenizerV2.DeserializeKeywordTokenizerV2(element);
                    case "#Microsoft.Azure.Search.MicrosoftLanguageStemmingTokenizer": return CognitiveSearch.Models.MicrosoftLanguageStemmingTokenizer.DeserializeMicrosoftLanguageStemmingTokenizer(element);
                    case "#Microsoft.Azure.Search.MicrosoftLanguageTokenizer": return CognitiveSearch.Models.MicrosoftLanguageTokenizer.DeserializeMicrosoftLanguageTokenizer(element);
                    case "#Microsoft.Azure.Search.NGramTokenizer": return CognitiveSearch.Models.NGramTokenizer.DeserializeNGramTokenizer(element);
                    case "#Microsoft.Azure.Search.PathHierarchyTokenizer": return CognitiveSearch.Models.PathHierarchyTokenizer.DeserializePathHierarchyTokenizer(element);
                    case "#Microsoft.Azure.Search.PathHierarchyTokenizerV2": return CognitiveSearch.Models.PathHierarchyTokenizerV2.DeserializePathHierarchyTokenizerV2(element);
                    case "#Microsoft.Azure.Search.PatternTokenizer": return CognitiveSearch.Models.PatternTokenizer.DeserializePatternTokenizer(element);
                    case "#Microsoft.Azure.Search.StandardTokenizer": return CognitiveSearch.Models.StandardTokenizer.DeserializeStandardTokenizer(element);
                    case "#Microsoft.Azure.Search.StandardTokenizerV2": return CognitiveSearch.Models.StandardTokenizerV2.DeserializeStandardTokenizerV2(element);
                    case "#Microsoft.Azure.Search.UaxUrlEmailTokenizer": return CognitiveSearch.Models.UaxUrlEmailTokenizer.DeserializeUaxUrlEmailTokenizer(element);
                }
            }
            CognitiveSearch.Models.Tokenizer result = new CognitiveSearch.Models.Tokenizer();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    result.OdataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}