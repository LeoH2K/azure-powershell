// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Extensions;

    /// <summary>Details about restoring a deleted app.</summary>
    public partial class DeletedAppRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestInternal,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource __proxyOnlyResource = new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.ProxyOnlyResource();

        /// <summary>
        /// ARM resource ID of the deleted app. Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string DeletedSiteId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).DeletedSiteId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).DeletedSiteId = value ?? null; }

        /// <summary>Resource Id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; }

        /// <summary>Kind of resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Kind { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Kind = value ?? null; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Id { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Id = value; }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name = value; }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal.Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestProperties Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.DeletedAppRestoreRequestProperties()); set { {_property = value;} } }

        /// <summary>Resource Name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Name { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Name; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestProperties _property;

        /// <summary>DeletedAppRestoreRequest resource specific properties</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.DeletedAppRestoreRequestProperties()); set => this._property = value; }

        /// <summary>If true, deleted site configuration, in addition to content, will be restored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public bool? RecoverConfiguration { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).RecoverConfiguration; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).RecoverConfiguration = value ?? default(bool); }

        /// <summary>
        /// Point in time to restore the deleted app from, formatted as a DateTime string.
        /// If unspecified, default value is the time that the app was deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public string SnapshotTime { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).SnapshotTime; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).SnapshotTime = value ?? null; }

        /// <summary>Resource type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inherited)]
        public string Type { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal)__proxyOnlyResource).Type; }

        /// <summary>If true, the snapshot is retrieved from DRSecondary endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Origin(Microsoft.Azure.PowerShell.Cmdlets.Websites.PropertyOrigin.Inlined)]
        public bool? UseDrSecondary { get => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).UseDrSecondary; set => ((Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestPropertiesInternal)Property).UseDrSecondary = value ?? default(bool); }

        /// <summary>Creates an new <see cref="DeletedAppRestoreRequest" /> instance.</summary>
        public DeletedAppRestoreRequest()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__proxyOnlyResource), __proxyOnlyResource);
            await eventListener.AssertObjectIsValid(nameof(__proxyOnlyResource), __proxyOnlyResource);
        }
    }
    /// Details about restoring a deleted app.
    public partial interface IDeletedAppRestoreRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResource
    {
        /// <summary>
        /// ARM resource ID of the deleted app. Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"ARM resource ID of the deleted app. Example:
        /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}",
        SerializedName = @"deletedSiteId",
        PossibleTypes = new [] { typeof(string) })]
        string DeletedSiteId { get; set; }
        /// <summary>If true, deleted site configuration, in addition to content, will be restored.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If true, deleted site configuration, in addition to content, will be restored.",
        SerializedName = @"recoverConfiguration",
        PossibleTypes = new [] { typeof(bool) })]
        bool? RecoverConfiguration { get; set; }
        /// <summary>
        /// Point in time to restore the deleted app from, formatted as a DateTime string.
        /// If unspecified, default value is the time that the app was deleted.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Point in time to restore the deleted app from, formatted as a DateTime string.
        If unspecified, default value is the time that the app was deleted.",
        SerializedName = @"snapshotTime",
        PossibleTypes = new [] { typeof(string) })]
        string SnapshotTime { get; set; }
        /// <summary>If true, the snapshot is retrieved from DRSecondary endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Websites.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"If true, the snapshot is retrieved from DRSecondary endpoint.",
        SerializedName = @"useDRSecondary",
        PossibleTypes = new [] { typeof(bool) })]
        bool? UseDrSecondary { get; set; }

    }
    /// Details about restoring a deleted app.
    internal partial interface IDeletedAppRestoreRequestInternal :
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20201201.IProxyOnlyResourceInternal
    {
        /// <summary>
        /// ARM resource ID of the deleted app. Example:
        /// /subscriptions/{subId}/providers/Microsoft.Web/deletedSites/{deletedSiteId}
        /// </summary>
        string DeletedSiteId { get; set; }
        /// <summary>DeletedAppRestoreRequest resource specific properties</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Websites.Models.Api20210201.IDeletedAppRestoreRequestProperties Property { get; set; }
        /// <summary>If true, deleted site configuration, in addition to content, will be restored.</summary>
        bool? RecoverConfiguration { get; set; }
        /// <summary>
        /// Point in time to restore the deleted app from, formatted as a DateTime string.
        /// If unspecified, default value is the time that the app was deleted.
        /// </summary>
        string SnapshotTime { get; set; }
        /// <summary>If true, the snapshot is retrieved from DRSecondary endpoint.</summary>
        bool? UseDrSecondary { get; set; }

    }
}