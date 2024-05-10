// <auto-generated/>

#nullable disable

using System;

namespace OpenAI.Models
{
    internal static partial class OpenAIFileStatusExtensions
    {
        public static string ToSerialString(this OpenAIFileStatus value) => value switch
        {
            OpenAIFileStatus.Uploaded => "uploaded",
            OpenAIFileStatus.Processed => "processed",
            OpenAIFileStatus.Pending => "pending",
            OpenAIFileStatus.Error => "error",
            OpenAIFileStatus.Deleting => "deleting",
            OpenAIFileStatus.Deleted => "deleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OpenAIFileStatus value.")
        };

        public static OpenAIFileStatus ToOpenAIFileStatus(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "uploaded")) return OpenAIFileStatus.Uploaded;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "processed")) return OpenAIFileStatus.Processed;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "pending")) return OpenAIFileStatus.Pending;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "error")) return OpenAIFileStatus.Error;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "deleting")) return OpenAIFileStatus.Deleting;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "deleted")) return OpenAIFileStatus.Deleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown OpenAIFileStatus value.");
        }
    }
}