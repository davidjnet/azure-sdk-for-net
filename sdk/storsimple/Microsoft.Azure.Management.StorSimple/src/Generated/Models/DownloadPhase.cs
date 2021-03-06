// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DownloadPhase.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DownloadPhase
    {
        [EnumMember(Value = "Unknown")]
        Unknown,
        [EnumMember(Value = "Initializing")]
        Initializing,
        [EnumMember(Value = "Downloading")]
        Downloading,
        [EnumMember(Value = "Verifying")]
        Verifying
    }
    internal static class DownloadPhaseEnumExtension
    {
        internal static string ToSerializedValue(this DownloadPhase? value)
        {
            return value == null ? null : ((DownloadPhase)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DownloadPhase value)
        {
            switch( value )
            {
                case DownloadPhase.Unknown:
                    return "Unknown";
                case DownloadPhase.Initializing:
                    return "Initializing";
                case DownloadPhase.Downloading:
                    return "Downloading";
                case DownloadPhase.Verifying:
                    return "Verifying";
            }
            return null;
        }

        internal static DownloadPhase? ParseDownloadPhase(this string value)
        {
            switch( value )
            {
                case "Unknown":
                    return DownloadPhase.Unknown;
                case "Initializing":
                    return DownloadPhase.Initializing;
                case "Downloading":
                    return DownloadPhase.Downloading;
                case "Verifying":
                    return DownloadPhase.Verifying;
            }
            return null;
        }
    }
}
