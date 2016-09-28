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
    /// Location information.
    /// </summary>
    public partial class Location
    {
        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        public Location() { }

        /// <summary>
        /// Initializes a new instance of the Location class.
        /// </summary>
        /// <param name="id">The fully qualified Id of the location. For
        /// example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000/locations/westus.</param>
        /// <param name="subscriptionId">The subscription Id.</param>
        /// <param name="name">The location name.</param>
        /// <param name="displayName">The display name of the location.</param>
        /// <param name="latitude">The latitude of the location.</param>
        /// <param name="longitude">The longitude of the location.</param>
        public Location(string id = default(string), string subscriptionId = default(string), string name = default(string), string displayName = default(string), string latitude = default(string), string longitude = default(string))
        {
            Id = id;
            SubscriptionId = subscriptionId;
            Name = name;
            DisplayName = displayName;
            Latitude = latitude;
            Longitude = longitude;
        }

        /// <summary>
        /// Gets the fully qualified Id of the location. For example,
        /// /subscriptions/00000000-0000-0000-0000-000000000000/locations/westus.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the subscription Id.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "subscriptionId")]
        public string SubscriptionId { get; private set; }

        /// <summary>
        /// Gets the location name.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the display name of the location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Gets the latitude of the location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "latitude")]
        public string Latitude { get; private set; }

        /// <summary>
        /// Gets the longitude of the location.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "longitude")]
        public string Longitude { get; private set; }

    }
}
