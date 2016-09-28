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
    /// Sku for the resource.
    /// </summary>
    public partial class Sku
    {
        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        public Sku() { }

        /// <summary>
        /// Initializes a new instance of the Sku class.
        /// </summary>
        /// <param name="name">The sku name.</param>
        /// <param name="tier">The sku tier.</param>
        /// <param name="size">The sku size.</param>
        /// <param name="family">The sku family.</param>
        /// <param name="model">The sku model.</param>
        /// <param name="capacity">The sku capacity.</param>
        public Sku(string name = default(string), string tier = default(string), string size = default(string), string family = default(string), string model = default(string), int? capacity = default(int?))
        {
            Name = name;
            Tier = tier;
            Size = size;
            Family = family;
            Model = model;
            Capacity = capacity;
        }

        /// <summary>
        /// Gets or sets the sku name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the sku tier.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "tier")]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or sets the sku size.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the sku family.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "family")]
        public string Family { get; set; }

        /// <summary>
        /// Gets or sets the sku model.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets or sets the sku capacity.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "capacity")]
        public int? Capacity { get; set; }

    }
}
