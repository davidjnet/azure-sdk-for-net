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

    public partial class ManagementLockOwner
    {
        /// <summary>
        /// Initializes a new instance of the ManagementLockOwner class.
        /// </summary>
        public ManagementLockOwner() { }

        /// <summary>
        /// Initializes a new instance of the ManagementLockOwner class.
        /// </summary>
        /// <param name="applicationId">The application Id of the management
        /// lock owner.</param>
        public ManagementLockOwner(string applicationId = default(string))
        {
            ApplicationId = applicationId;
        }

        /// <summary>
        /// Gets or sets the application Id of the management lock owner.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationId")]
        public string ApplicationId { get; set; }

    }
}
