// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Delete activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Delete")]
    [Rest.Serialization.JsonTransformation]
    public partial class DeleteActivity : ExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the DeleteActivity class.
        /// </summary>
        public DeleteActivity()
        {
            Dataset = new DatasetReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteActivity class.
        /// </summary>
        /// <param name="name">Activity name.</param>
        /// <param name="dataset">Delete activity dataset reference.</param>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="description">Activity description.</param>
        /// <param name="state">Activity state. This is an optional property
        /// and if not provided, the state will be Active by default. Possible
        /// values include: 'Active', 'Inactive'</param>
        /// <param name="onInactiveMarkAs">Status result of the activity when
        /// the state is set to Inactive. This is an optional property and if
        /// not provided when the activity is inactive, the status will be
        /// Succeeded by default. Possible values include: 'Succeeded',
        /// 'Failed', 'Skipped'</param>
        /// <param name="dependsOn">Activity depends on condition.</param>
        /// <param name="userProperties">Activity user properties.</param>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="policy">Activity policy.</param>
        /// <param name="recursive">If true, files or sub-folders under current
        /// folder path will be deleted recursively. Default is false. Type:
        /// boolean (or Expression with resultType boolean).</param>
        /// <param name="maxConcurrentConnections">The max concurrent
        /// connections to connect data source at the same time.</param>
        /// <param name="enableLogging">Whether to record detailed logs of
        /// delete-activity execution. Default value is false. Type: boolean
        /// (or Expression with resultType boolean).</param>
        /// <param name="logStorageSettings">Log storage settings customer need
        /// to provide when enableLogging is true.</param>
        /// <param name="storeSettings">Delete activity store settings.</param>
        public DeleteActivity(string name, DatasetReference dataset, IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string description = default(string), string state = default(string), string onInactiveMarkAs = default(string), IList<ActivityDependency> dependsOn = default(IList<ActivityDependency>), IList<UserProperty> userProperties = default(IList<UserProperty>), LinkedServiceReference linkedServiceName = default(LinkedServiceReference), ActivityPolicy policy = default(ActivityPolicy), object recursive = default(object), int? maxConcurrentConnections = default(int?), object enableLogging = default(object), LogStorageSettings logStorageSettings = default(LogStorageSettings), StoreReadSettings storeSettings = default(StoreReadSettings))
            : base(name, additionalProperties, description, state, onInactiveMarkAs, dependsOn, userProperties, linkedServiceName, policy)
        {
            Recursive = recursive;
            MaxConcurrentConnections = maxConcurrentConnections;
            EnableLogging = enableLogging;
            LogStorageSettings = logStorageSettings;
            Dataset = dataset;
            StoreSettings = storeSettings;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets if true, files or sub-folders under current folder
        /// path will be deleted recursively. Default is false. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.recursive")]
        public object Recursive { get; set; }

        /// <summary>
        /// Gets or sets the max concurrent connections to connect data source
        /// at the same time.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.maxConcurrentConnections")]
        public int? MaxConcurrentConnections { get; set; }

        /// <summary>
        /// Gets or sets whether to record detailed logs of delete-activity
        /// execution. Default value is false. Type: boolean (or Expression
        /// with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableLogging")]
        public object EnableLogging { get; set; }

        /// <summary>
        /// Gets or sets log storage settings customer need to provide when
        /// enableLogging is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.logStorageSettings")]
        public LogStorageSettings LogStorageSettings { get; set; }

        /// <summary>
        /// Gets or sets delete activity dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Gets or sets delete activity store settings.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.storeSettings")]
        public StoreReadSettings StoreSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dataset");
            }
            if (MaxConcurrentConnections != null)
            {
                if (MaxConcurrentConnections < 1)
                {
                    throw new ValidationException(ValidationRules.InclusiveMinimum, "MaxConcurrentConnections", 1);
                }
            }
            if (LogStorageSettings != null)
            {
                LogStorageSettings.Validate();
            }
            if (Dataset != null)
            {
                Dataset.Validate();
            }
        }
    }
}
