// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System.Linq;

    /// <summary>
    /// Tag information.
    /// </summary>
    public partial class TagValue
    {
        /// <summary>
        /// Initializes a new instance of the TagValue class.
        /// </summary>
        public TagValue() { }

        /// <summary>
        /// Initializes a new instance of the TagValue class.
        /// </summary>
        /// <param name="id">The tag ID.</param>
        /// <param name="tagValue">The tag value.</param>
        /// <param name="count">The tag value count.</param>
        public TagValue(string id = default(string), string tagValue = default(string), TagCount count = default(TagCount))
        {
            Id = id;
            TagValueProperty = tagValue;
            Count = count;
        }

        /// <summary>
        /// Gets or sets the tag ID.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the tag value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tagValue")]
        public string TagValueProperty { get; set; }

        /// <summary>
        /// Gets or sets the tag value count.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "count")]
        public TagCount Count { get; set; }

    }
}
