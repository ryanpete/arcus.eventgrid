﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Arcus.EventGrid.Tests {
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class TestArtifacts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal TestArtifacts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Arcus.EventGrid.Tests.TestArtifacts", typeof(TestArtifacts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///  &quot;topic&quot;: &quot;/subscriptions/b73995e3-caad-4882-8644-f2175789c3ff/resourceGroups/azure-eventgrid-demo/providers/Microsoft.Storage/storageAccounts/savanheventgridstorage&quot;,
        ///  &quot;subject&quot;: &quot;/blobServices/default/containers/event-container/blobs/finnishjpeg&quot;,
        ///  &quot;eventType&quot;: &quot;Microsoft.Storage.BlobCreated&quot;,
        ///  &quot;eventTime&quot;: &quot;2018-03-15T10:25:17.7535274Z&quot;,
        ///  &quot;id&quot;: &quot;5647b67c-b01e-002d-6a47-bc01ac063360&quot;,
        ///  &quot;data&quot;: {
        ///    &quot;api&quot;: &quot;PutBlockList&quot;,
        ///    &quot;clientRequestId&quot;: &quot;5c24a322-35c9-4b46-8ef5-245a81af7037&quot;,
        ///    [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string BlobCreateEvent {
            get {
                return ResourceManager.GetString("BlobCreateEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///  &quot;id&quot;: &quot;38a23a83-f9c2-493f-e6fb-4b57c7c43d28&quot;,
        ///  &quot;topic&quot;: &quot;/SUBSCRIPTIONS/B73995E3-CAAD-4882-8644-F2175789C3FF/RESOURCEGROUPS/AZURE-EVENTGRID-DEMO/PROVIDERS/MICROSOFT.DEVICES/IOTHUBS/SAVANH-EVENTGRID-IOTHUB&quot;,
        ///  &quot;subject&quot;: &quot;devices/grid-test-01&quot;,
        ///  &quot;eventType&quot;: &quot;Microsoft.Devices.DeviceCreated&quot;,
        ///  &quot;eventTime&quot;: &quot;2018-03-16T05:47:28.1359543Z&quot;,
        ///  &quot;data&quot;: {
        ///    &quot;twin&quot;: {
        ///      &quot;deviceId&quot;: &quot;grid-test-01&quot;,
        ///      &quot;etag&quot;: &quot;AAAAAAAAAAE=&quot;,
        ///      &quot;deviceEtag&quot;: null,
        ///      &quot;status&quot;: &quot;enabled&quot;,
        ///      &quot;sta [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IoTDeviceCreateEvent {
            get {
                return ResourceManager.GetString("IoTDeviceCreateEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [{
        ///  &quot;id&quot;: &quot;c8dbb6f7-4a80-f4a1-7875-040e3e909d71&quot;,
        ///  &quot;topic&quot;: &quot;/SUBSCRIPTIONS/B73995E3-CAAD-4882-8644-F2175789C3FF/RESOURCEGROUPS/AZURE-EVENTGRID-DEMO/PROVIDERS/MICROSOFT.DEVICES/IOTHUBS/SAVANH-EVENTGRID-IOTHUB&quot;,
        ///  &quot;subject&quot;: &quot;devices/grid-test-01&quot;,
        ///  &quot;eventType&quot;: &quot;Microsoft.Devices.DeviceDeleted&quot;,
        ///  &quot;eventTime&quot;: &quot;2018-03-16T06:15:42.5023869Z&quot;,
        ///  &quot;data&quot;: {
        ///    &quot;twin&quot;: {
        ///      &quot;deviceId&quot;: &quot;grid-test-01&quot;,
        ///      &quot;etag&quot;: &quot;AAAAAAAAAAE=&quot;,
        ///      &quot;deviceEtag&quot;: null,
        ///      &quot;status&quot;: &quot;enabled&quot;,
        ///      &quot;sta [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string IoTDeviceDeleteEvent {
            get {
                return ResourceManager.GetString("IoTDeviceDeleteEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to [
        ///                  {
        ///                    &quot;id&quot;: &quot;2d1781af-3a4c-4d7c-bd0c-e34b19da4e66&quot;,
        ///                    &quot;topic&quot;: &quot;/subscriptions/xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx&quot;,
        ///                    &quot;subject&quot;: &quot;&quot;,
        ///                    &quot;data&quot;: {
        ///                        &quot;validationCode&quot;: &quot;512d38b6-c7b8-40c8-89fe-f46f9e9622b6&quot;
        ///                    },
        ///                    &quot;eventType&quot;: &quot;Microsoft.EventGrid.SubscriptionValidationEvent&quot;,
        ///                    &quot;eventTime&quot;: &quot;2017-08-06T22:09:30.740323Z&quot;
        ///               [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SubscriptionValidationEvent {
            get {
                return ResourceManager.GetString("SubscriptionValidationEvent", resourceCulture);
            }
        }
    }
}