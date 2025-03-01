// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Apis.CloudIot.v1
{
    /// <summary>The CloudIot Service.</summary>
    public class CloudIotService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudIotService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudIotService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "cloudiot";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://cloudiot.googleapis.com/";
        #else
            "https://cloudiot.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://cloudiot.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Cloud IoT API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Register and manage devices in the Google Cloud IoT service</summary>
            public static string Cloudiot = "https://www.googleapis.com/auth/cloudiot";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Cloud IoT API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Register and manage devices in the Google Cloud IoT service</summary>
            public const string Cloudiot = "https://www.googleapis.com/auth/cloudiot";
        }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for CloudIot requests.</summary>
    public abstract class CloudIotBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new CloudIotBaseServiceRequest instance.</summary>
        protected CloudIotBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1 = 0,

            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2 = 1,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json = 0,

            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media = 1,

            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto = 2,
        }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>
        /// API key. Your API key identifies your project and provides you with API access, quota, and reports. Required
        /// unless you provide an OAuth 2.0 token.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>
        /// Available to use for quota purposes for server-side applications. Can be any arbitrary string assigned to a
        /// user, but should not exceed 40 characters.
        /// </summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CloudIot parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();
            RequestParameters.Add("$.xgafv", new Google.Apis.Discovery.Parameter
            {
                Name = "$.xgafv",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("access_token", new Google.Apis.Discovery.Parameter
            {
                Name = "access_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("alt", new Google.Apis.Discovery.Parameter
            {
                Name = "alt",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "json",
                Pattern = null,
            });
            RequestParameters.Add("callback", new Google.Apis.Discovery.Parameter
            {
                Name = "callback",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("fields", new Google.Apis.Discovery.Parameter
            {
                Name = "fields",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("key", new Google.Apis.Discovery.Parameter
            {
                Name = "key",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("oauth_token", new Google.Apis.Discovery.Parameter
            {
                Name = "oauth_token",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("prettyPrint", new Google.Apis.Discovery.Parameter
            {
                Name = "prettyPrint",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = "true",
                Pattern = null,
            });
            RequestParameters.Add("quotaUser", new Google.Apis.Discovery.Parameter
            {
                Name = "quotaUser",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("uploadType", new Google.Apis.Discovery.Parameter
            {
                Name = "uploadType",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
            RequestParameters.Add("upload_protocol", new Google.Apis.Discovery.Parameter
            {
                Name = "upload_protocol",
                IsRequired = false,
                ParameterType = "query",
                DefaultValue = null,
                Pattern = null,
            });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            Locations = new LocationsResource(service);
        }

        /// <summary>Gets the Locations resource.</summary>
        public virtual LocationsResource Locations { get; }

        /// <summary>The "locations" collection of methods.</summary>
        public class LocationsResource
        {
            private const string Resource = "locations";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public LocationsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
                Registries = new RegistriesResource(service);
            }

            /// <summary>Gets the Registries resource.</summary>
            public virtual RegistriesResource Registries { get; }

            /// <summary>The "registries" collection of methods.</summary>
            public class RegistriesResource
            {
                private const string Resource = "registries";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public RegistriesResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    Devices = new DevicesResource(service);
                    Groups = new GroupsResource(service);
                }

                /// <summary>Gets the Devices resource.</summary>
                public virtual DevicesResource Devices { get; }

                /// <summary>The "devices" collection of methods.</summary>
                public class DevicesResource
                {
                    private const string Resource = "devices";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public DevicesResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        ConfigVersions = new ConfigVersionsResource(service);
                        States = new StatesResource(service);
                    }

                    /// <summary>Gets the ConfigVersions resource.</summary>
                    public virtual ConfigVersionsResource ConfigVersions { get; }

                    /// <summary>The "configVersions" collection of methods.</summary>
                    public class ConfigVersionsResource
                    {
                        private const string Resource = "configVersions";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public ConfigVersionsResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Lists the last few versions of the device configuration in descending order (i.e.: newest
                        /// first).
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the device. For example,
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                        /// </param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists the last few versions of the device configuration in descending order (i.e.: newest
                        /// first).
                        /// </summary>
                        public class ListRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.ListDeviceConfigVersionsResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the device. For example,
                            /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                            /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The number of versions to list. Versions are listed in decreasing order of the version
                            /// number. The maximum number of versions retained is 10. If this value is zero, it will
                            /// return all the versions available.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("numVersions", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> NumVersions { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/configVersions";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                                });
                                RequestParameters.Add("numVersions", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "numVersions",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Gets the States resource.</summary>
                    public virtual StatesResource States { get; }

                    /// <summary>The "states" collection of methods.</summary>
                    public class StatesResource
                    {
                        private const string Resource = "states";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public StatesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>
                        /// Lists the last few versions of the device state in descending order (i.e.: newest first).
                        /// </summary>
                        /// <param name="name">
                        /// Required. The name of the device. For example,
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                        /// </param>
                        public virtual ListRequest List(string name)
                        {
                            return new ListRequest(service, name);
                        }

                        /// <summary>
                        /// Lists the last few versions of the device state in descending order (i.e.: newest first).
                        /// </summary>
                        public class ListRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.ListDeviceStatesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                            {
                                Name = name;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The name of the device. For example,
                            /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                            /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Name { get; private set; }

                            /// <summary>
                            /// The number of states to list. States are listed in descending order of update time. The
                            /// maximum number of states retained is 10. If this value is zero, it will return all the
                            /// states available.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("numStates", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> NumStates { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+name}/states";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "name",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                                });
                                RequestParameters.Add("numStates", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "numStates",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>Creates a device in a device registry.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="parent">
                    /// Required. The name of the device registry where this device should be created. For example,
                    /// `projects/example-project/locations/us-central1/registries/my-registry`.
                    /// </param>
                    public virtual CreateRequest Create(Google.Apis.CloudIot.v1.Data.Device body, string parent)
                    {
                        return new CreateRequest(service, body, parent);
                    }

                    /// <summary>Creates a device in a device registry.</summary>
                    public class CreateRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Device>
                    {
                        /// <summary>Constructs a new Create request.</summary>
                        public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.Device body, string parent) : base(service)
                        {
                            Parent = parent;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the device registry where this device should be created. For example,
                        /// `projects/example-project/locations/us-central1/registries/my-registry`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.Device Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "create";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/devices";

                        /// <summary>Initializes Create parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Deletes a device.</summary>
                    /// <param name="name">
                    /// Required. The name of the device. For example,
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                    /// </param>
                    public virtual DeleteRequest Delete(string name)
                    {
                        return new DeleteRequest(service, name);
                    }

                    /// <summary>Deletes a device.</summary>
                    public class DeleteRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Empty>
                    {
                        /// <summary>Constructs a new Delete request.</summary>
                        public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the device. For example,
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "delete";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "DELETE";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes Delete parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Gets details about a device.</summary>
                    /// <param name="name">
                    /// Required. The name of the device. For example,
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                    /// </param>
                    public virtual GetRequest Get(string name)
                    {
                        return new GetRequest(service, name);
                    }

                    /// <summary>Gets details about a device.</summary>
                    public class GetRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Device>
                    {
                        /// <summary>Constructs a new Get request.</summary>
                        public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the device. For example,
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// The fields of the `Device` resource to be returned in the response. If the field mask is
                        /// unset or empty, all fields are returned. Fields have to be provided in snake_case format,
                        /// for example: `last_heartbeat_time`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object FieldMask { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "get";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes Get parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                            });
                            RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fieldMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>List devices in a device registry.</summary>
                    /// <param name="parent">
                    /// Required. The device registry path. Required. For example,
                    /// `projects/my-project/locations/us-central1/registries/my-registry`.
                    /// </param>
                    public virtual ListRequest List(string parent)
                    {
                        return new ListRequest(service, parent);
                    }

                    /// <summary>List devices in a device registry.</summary>
                    public class ListRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.ListDevicesResponse>
                    {
                        /// <summary>Constructs a new List request.</summary>
                        public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                        {
                            Parent = parent;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The device registry path. Required. For example,
                        /// `projects/my-project/locations/us-central1/registries/my-registry`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Parent { get; private set; }

                        /// <summary>
                        /// A list of device string IDs. For example, `['device0', 'device12']`. If empty, this field is
                        /// ignored. Maximum IDs: 10,000
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("deviceIds", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> DeviceIds { get; set; }

                        /// <summary>
                        /// A list of device numeric IDs. If empty, this field is ignored. Maximum IDs: 10,000.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("deviceNumIds", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual Google.Apis.Util.Repeatable<string> DeviceNumIds { get; set; }

                        /// <summary>
                        /// The fields of the `Device` resource to be returned in the response. The fields `id` and
                        /// `num_id` are always returned, along with any other fields specified in snake_case format,
                        /// for example: `last_heartbeat_time`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object FieldMask { get; set; }

                        /// <summary>
                        /// If set, returns only the gateways with which the specified device is associated. The device
                        /// ID can be numeric (`num_id`) or the user-defined string (`id`). For example, if `456` is
                        /// specified, returns only the gateways to which the device with `num_id` 456 is bound.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gatewayListOptions.associationsDeviceId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string GatewayListOptionsAssociationsDeviceId { get; set; }

                        /// <summary>
                        /// If set, only devices associated with the specified gateway are returned. The gateway ID can
                        /// be numeric (`num_id`) or the user-defined string (`id`). For example, if `123` is specified,
                        /// only devices bound to the gateway with `num_id` 123 are returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gatewayListOptions.associationsGatewayId", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string GatewayListOptionsAssociationsGatewayId { get; set; }

                        /// <summary>
                        /// If `GATEWAY` is specified, only gateways are returned. If `NON_GATEWAY` is specified, only
                        /// non-gateway devices are returned. If `GATEWAY_TYPE_UNSPECIFIED` is specified, all devices
                        /// are returned.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("gatewayListOptions.gatewayType", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<GatewayListOptionsGatewayTypeEnum> GatewayListOptionsGatewayType { get; set; }

                        /// <summary>
                        /// If `GATEWAY` is specified, only gateways are returned. If `NON_GATEWAY` is specified, only
                        /// non-gateway devices are returned. If `GATEWAY_TYPE_UNSPECIFIED` is specified, all devices
                        /// are returned.
                        /// </summary>
                        public enum GatewayListOptionsGatewayTypeEnum
                        {
                            /// <summary>If unspecified, the device is considered a non-gateway device.</summary>
                            [Google.Apis.Util.StringValueAttribute("GATEWAY_TYPE_UNSPECIFIED")]
                            GATEWAYTYPEUNSPECIFIED = 0,

                            /// <summary>The device is a gateway.</summary>
                            [Google.Apis.Util.StringValueAttribute("GATEWAY")]
                            GATEWAY = 1,

                            /// <summary>The device is not a gateway.</summary>
                            [Google.Apis.Util.StringValueAttribute("NON_GATEWAY")]
                            NONGATEWAY = 2,
                        }

                        /// <summary>
                        /// The maximum number of devices to return in the response. If this value is zero, the service
                        /// will select a default size. A call may return fewer objects than requested. A non-empty
                        /// `next_page_token` in the response indicates that more data is available.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual System.Nullable<int> PageSize { get; set; }

                        /// <summary>
                        /// The value returned by the last `ListDevicesResponse`; indicates that this is a continuation
                        /// of a prior `ListDevices` call and the system should return the next page of data.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual string PageToken { get; set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "list";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+parent}/devices";

                        /// <summary>Initializes List parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                            {
                                Name = "parent",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                            });
                            RequestParameters.Add("deviceIds", new Google.Apis.Discovery.Parameter
                            {
                                Name = "deviceIds",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("deviceNumIds", new Google.Apis.Discovery.Parameter
                            {
                                Name = "deviceNumIds",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "fieldMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("gatewayListOptions.associationsDeviceId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gatewayListOptions.associationsDeviceId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("gatewayListOptions.associationsGatewayId", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gatewayListOptions.associationsGatewayId",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("gatewayListOptions.gatewayType", new Google.Apis.Discovery.Parameter
                            {
                                Name = "gatewayListOptions.gatewayType",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageSize",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                            RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                            {
                                Name = "pageToken",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Modifies the configuration for the device, which is eventually sent from the Cloud IoT Core
                    /// servers. Returns the modified configuration version and its metadata.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the device. For example,
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                    /// </param>
                    public virtual ModifyCloudToDeviceConfigRequest ModifyCloudToDeviceConfig(Google.Apis.CloudIot.v1.Data.ModifyCloudToDeviceConfigRequest body, string name)
                    {
                        return new ModifyCloudToDeviceConfigRequest(service, body, name);
                    }

                    /// <summary>
                    /// Modifies the configuration for the device, which is eventually sent from the Cloud IoT Core
                    /// servers. Returns the modified configuration version and its metadata.
                    /// </summary>
                    public class ModifyCloudToDeviceConfigRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.DeviceConfig>
                    {
                        /// <summary>Constructs a new ModifyCloudToDeviceConfig request.</summary>
                        public ModifyCloudToDeviceConfigRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.ModifyCloudToDeviceConfigRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the device. For example,
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.ModifyCloudToDeviceConfigRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "modifyCloudToDeviceConfig";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:modifyCloudToDeviceConfig";

                        /// <summary>Initializes ModifyCloudToDeviceConfig parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                            });
                        }
                    }

                    /// <summary>Updates a device.</summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// The resource path name. For example,
                    /// `projects/p1/locations/us-central1/registries/registry0/devices/dev0` or
                    /// `projects/p1/locations/us-central1/registries/registry0/devices/{num_id}`. When `name` is
                    /// populated as a response from the service, it always ends in the device numeric ID.
                    /// </param>
                    public virtual PatchRequest Patch(Google.Apis.CloudIot.v1.Data.Device body, string name)
                    {
                        return new PatchRequest(service, body, name);
                    }

                    /// <summary>Updates a device.</summary>
                    public class PatchRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Device>
                    {
                        /// <summary>Constructs a new Patch request.</summary>
                        public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.Device body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// The resource path name. For example,
                        /// `projects/p1/locations/us-central1/registries/registry0/devices/dev0` or
                        /// `projects/p1/locations/us-central1/registries/registry0/devices/{num_id}`. When `name` is
                        /// populated as a response from the service, it always ends in the device numeric ID.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>
                        /// Required. Only updates the `device` fields indicated by this mask. The field mask must not
                        /// be empty, and it must not contain fields that are immutable or only set by the server.
                        /// Mutable top-level fields: `credentials`, `blocked`, and `metadata`
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                        public virtual object UpdateMask { get; set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.Device Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "patch";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "PATCH";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}";

                        /// <summary>Initializes Patch parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                            });
                            RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                            {
                                Name = "updateMask",
                                IsRequired = false,
                                ParameterType = "query",
                                DefaultValue = null,
                                Pattern = null,
                            });
                        }
                    }

                    /// <summary>
                    /// Sends a command to the specified device. In order for a device to be able to receive commands,
                    /// it must: 1) be connected to Cloud IoT Core using the MQTT protocol, and 2) be subscribed to the
                    /// group of MQTT topics specified by /devices/{device-id}/commands/#. This subscription will
                    /// receive commands at the top-level topic /devices/{device-id}/commands as well as commands for
                    /// subfolders, like /devices/{device-id}/commands/subfolder. Note that subscribing to specific
                    /// subfolders is not supported. If the command could not be delivered to the device, this method
                    /// will return an error; in particular, if the device is not subscribed, this method will return
                    /// FAILED_PRECONDITION. Otherwise, this method will return OK. If the subscription is QoS 1, at
                    /// least once delivery will be guaranteed; for QoS 0, no acknowledgment will be expected from the
                    /// device.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="name">
                    /// Required. The name of the device. For example,
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                    /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                    /// </param>
                    public virtual SendCommandToDeviceRequest SendCommandToDevice(Google.Apis.CloudIot.v1.Data.SendCommandToDeviceRequest body, string name)
                    {
                        return new SendCommandToDeviceRequest(service, body, name);
                    }

                    /// <summary>
                    /// Sends a command to the specified device. In order for a device to be able to receive commands,
                    /// it must: 1) be connected to Cloud IoT Core using the MQTT protocol, and 2) be subscribed to the
                    /// group of MQTT topics specified by /devices/{device-id}/commands/#. This subscription will
                    /// receive commands at the top-level topic /devices/{device-id}/commands as well as commands for
                    /// subfolders, like /devices/{device-id}/commands/subfolder. Note that subscribing to specific
                    /// subfolders is not supported. If the command could not be delivered to the device, this method
                    /// will return an error; in particular, if the device is not subscribed, this method will return
                    /// FAILED_PRECONDITION. Otherwise, this method will return OK. If the subscription is QoS 1, at
                    /// least once delivery will be guaranteed; for QoS 0, no acknowledgment will be expected from the
                    /// device.
                    /// </summary>
                    public class SendCommandToDeviceRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.SendCommandToDeviceResponse>
                    {
                        /// <summary>Constructs a new SendCommandToDevice request.</summary>
                        public SendCommandToDeviceRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.SendCommandToDeviceRequest body, string name) : base(service)
                        {
                            Name = name;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the device. For example,
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/device0` or
                        /// `projects/p0/locations/us-central1/registries/registry0/devices/{num_id}`.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.SendCommandToDeviceRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "sendCommandToDevice";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+name}:sendCommandToDevice";

                        /// <summary>Initializes SendCommandToDevice parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/devices/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Gets the Groups resource.</summary>
                public virtual GroupsResource Groups { get; }

                /// <summary>The "groups" collection of methods.</summary>
                public class GroupsResource
                {
                    private const string Resource = "groups";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public GroupsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                        Devices = new DevicesResource(service);
                    }

                    /// <summary>Gets the Devices resource.</summary>
                    public virtual DevicesResource Devices { get; }

                    /// <summary>The "devices" collection of methods.</summary>
                    public class DevicesResource
                    {
                        private const string Resource = "devices";

                        /// <summary>The service which this resource belongs to.</summary>
                        private readonly Google.Apis.Services.IClientService service;

                        /// <summary>Constructs a new resource.</summary>
                        public DevicesResource(Google.Apis.Services.IClientService service)
                        {
                            this.service = service;
                        }

                        /// <summary>List devices in a device registry.</summary>
                        /// <param name="parent">
                        /// Required. The device registry path. Required. For example,
                        /// `projects/my-project/locations/us-central1/registries/my-registry`.
                        /// </param>
                        public virtual ListRequest List(string parent)
                        {
                            return new ListRequest(service, parent);
                        }

                        /// <summary>List devices in a device registry.</summary>
                        public class ListRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.ListDevicesResponse>
                        {
                            /// <summary>Constructs a new List request.</summary>
                            public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                            {
                                Parent = parent;
                                InitParameters();
                            }

                            /// <summary>
                            /// Required. The device registry path. Required. For example,
                            /// `projects/my-project/locations/us-central1/registries/my-registry`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                            public virtual string Parent { get; private set; }

                            /// <summary>
                            /// A list of device string IDs. For example, `['device0', 'device12']`. If empty, this
                            /// field is ignored. Maximum IDs: 10,000
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("deviceIds", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<string> DeviceIds { get; set; }

                            /// <summary>
                            /// A list of device numeric IDs. If empty, this field is ignored. Maximum IDs: 10,000.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("deviceNumIds", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual Google.Apis.Util.Repeatable<string> DeviceNumIds { get; set; }

                            /// <summary>
                            /// The fields of the `Device` resource to be returned in the response. The fields `id` and
                            /// `num_id` are always returned, along with any other fields specified in snake_case
                            /// format, for example: `last_heartbeat_time`.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("fieldMask", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual object FieldMask { get; set; }

                            /// <summary>
                            /// If set, returns only the gateways with which the specified device is associated. The
                            /// device ID can be numeric (`num_id`) or the user-defined string (`id`). For example, if
                            /// `456` is specified, returns only the gateways to which the device with `num_id` 456 is
                            /// bound.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("gatewayListOptions.associationsDeviceId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string GatewayListOptionsAssociationsDeviceId { get; set; }

                            /// <summary>
                            /// If set, only devices associated with the specified gateway are returned. The gateway ID
                            /// can be numeric (`num_id`) or the user-defined string (`id`). For example, if `123` is
                            /// specified, only devices bound to the gateway with `num_id` 123 are returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("gatewayListOptions.associationsGatewayId", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string GatewayListOptionsAssociationsGatewayId { get; set; }

                            /// <summary>
                            /// If `GATEWAY` is specified, only gateways are returned. If `NON_GATEWAY` is specified,
                            /// only non-gateway devices are returned. If `GATEWAY_TYPE_UNSPECIFIED` is specified, all
                            /// devices are returned.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("gatewayListOptions.gatewayType", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<GatewayListOptionsGatewayTypeEnum> GatewayListOptionsGatewayType { get; set; }

                            /// <summary>
                            /// If `GATEWAY` is specified, only gateways are returned. If `NON_GATEWAY` is specified,
                            /// only non-gateway devices are returned. If `GATEWAY_TYPE_UNSPECIFIED` is specified, all
                            /// devices are returned.
                            /// </summary>
                            public enum GatewayListOptionsGatewayTypeEnum
                            {
                                /// <summary>If unspecified, the device is considered a non-gateway device.</summary>
                                [Google.Apis.Util.StringValueAttribute("GATEWAY_TYPE_UNSPECIFIED")]
                                GATEWAYTYPEUNSPECIFIED = 0,

                                /// <summary>The device is a gateway.</summary>
                                [Google.Apis.Util.StringValueAttribute("GATEWAY")]
                                GATEWAY = 1,

                                /// <summary>The device is not a gateway.</summary>
                                [Google.Apis.Util.StringValueAttribute("NON_GATEWAY")]
                                NONGATEWAY = 2,
                            }

                            /// <summary>
                            /// The maximum number of devices to return in the response. If this value is zero, the
                            /// service will select a default size. A call may return fewer objects than requested. A
                            /// non-empty `next_page_token` in the response indicates that more data is available.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual System.Nullable<int> PageSize { get; set; }

                            /// <summary>
                            /// The value returned by the last `ListDevicesResponse`; indicates that this is a
                            /// continuation of a prior `ListDevices` call and the system should return the next page of
                            /// data.
                            /// </summary>
                            [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                            public virtual string PageToken { get; set; }

                            /// <summary>Gets the method name.</summary>
                            public override string MethodName => "list";

                            /// <summary>Gets the HTTP method.</summary>
                            public override string HttpMethod => "GET";

                            /// <summary>Gets the REST path.</summary>
                            public override string RestPath => "v1/{+parent}/devices";

                            /// <summary>Initializes List parameter list.</summary>
                            protected override void InitParameters()
                            {
                                base.InitParameters();
                                RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "parent",
                                    IsRequired = true,
                                    ParameterType = "path",
                                    DefaultValue = null,
                                    Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/groups/[^/]+$",
                                });
                                RequestParameters.Add("deviceIds", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "deviceIds",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("deviceNumIds", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "deviceNumIds",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("fieldMask", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "fieldMask",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("gatewayListOptions.associationsDeviceId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "gatewayListOptions.associationsDeviceId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("gatewayListOptions.associationsGatewayId", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "gatewayListOptions.associationsGatewayId",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("gatewayListOptions.gatewayType", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "gatewayListOptions.gatewayType",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageSize",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                                RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                                {
                                    Name = "pageToken",
                                    IsRequired = false,
                                    ParameterType = "query",
                                    DefaultValue = null,
                                    Pattern = null,
                                });
                            }
                        }
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudIot.v1.Data.GetIamPolicyRequest body, string resource)
                    {
                        return new GetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Gets the access control policy for a resource. Returns an empty policy if the resource exists
                    /// and does not have a policy set.
                    /// </summary>
                    public class GetIamPolicyRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new GetIamPolicy request.</summary>
                        public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.GetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "getIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:getIamPolicy";

                        /// <summary>Initializes GetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/groups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudIot.v1.Data.SetIamPolicyRequest body, string resource)
                    {
                        return new SetIamPolicyRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Sets the access control policy on the specified resource. Replaces any existing policy.
                    /// </summary>
                    public class SetIamPolicyRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Policy>
                    {
                        /// <summary>Constructs a new SetIamPolicy request.</summary>
                        public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy is being specified. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.SetIamPolicyRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "setIamPolicy";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:setIamPolicy";

                        /// <summary>Initializes SetIamPolicy parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/groups/[^/]+$",
                            });
                        }
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.
                    /// </summary>
                    /// <param name="body">The body of the request.</param>
                    /// <param name="resource">
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </param>
                    public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudIot.v1.Data.TestIamPermissionsRequest body, string resource)
                    {
                        return new TestIamPermissionsRequest(service, body, resource);
                    }

                    /// <summary>
                    /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                    /// this will return an empty set of permissions, not a NOT_FOUND error.
                    /// </summary>
                    public class TestIamPermissionsRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.TestIamPermissionsResponse>
                    {
                        /// <summary>Constructs a new TestIamPermissions request.</summary>
                        public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                        {
                            Resource = resource;
                            Body = body;
                            InitParameters();
                        }

                        /// <summary>
                        /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                        /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for
                        /// this field.
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Resource { get; private set; }

                        /// <summary>Gets or sets the body of this request.</summary>
                        Google.Apis.CloudIot.v1.Data.TestIamPermissionsRequest Body { get; set; }

                        /// <summary>Returns the body of the request.</summary>
                        protected override object GetBody() => Body;

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "testIamPermissions";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "POST";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1/{+resource}:testIamPermissions";

                        /// <summary>Initializes TestIamPermissions parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                            {
                                Name = "resource",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+/groups/[^/]+$",
                            });
                        }
                    }
                }

                /// <summary>Associates the device with the gateway.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the registry. For example,
                /// `projects/example-project/locations/us-central1/registries/my-registry`.
                /// </param>
                public virtual BindDeviceToGatewayRequest BindDeviceToGateway(Google.Apis.CloudIot.v1.Data.BindDeviceToGatewayRequest body, string parent)
                {
                    return new BindDeviceToGatewayRequest(service, body, parent);
                }

                /// <summary>Associates the device with the gateway.</summary>
                public class BindDeviceToGatewayRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.BindDeviceToGatewayResponse>
                {
                    /// <summary>Constructs a new BindDeviceToGateway request.</summary>
                    public BindDeviceToGatewayRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.BindDeviceToGatewayRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the registry. For example,
                    /// `projects/example-project/locations/us-central1/registries/my-registry`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.BindDeviceToGatewayRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "bindDeviceToGateway";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:bindDeviceToGateway";

                    /// <summary>Initializes BindDeviceToGateway parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }

                /// <summary>Creates a device registry that contains devices.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The project and cloud region where this device registry must be created. For example,
                /// `projects/example-project/locations/us-central1`.
                /// </param>
                public virtual CreateRequest Create(Google.Apis.CloudIot.v1.Data.DeviceRegistry body, string parent)
                {
                    return new CreateRequest(service, body, parent);
                }

                /// <summary>Creates a device registry that contains devices.</summary>
                public class CreateRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.DeviceRegistry>
                {
                    /// <summary>Constructs a new Create request.</summary>
                    public CreateRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.DeviceRegistry body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and cloud region where this device registry must be created. For example,
                    /// `projects/example-project/locations/us-central1`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.DeviceRegistry Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "create";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/registries";

                    /// <summary>Initializes Create parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes a device registry configuration.</summary>
                /// <param name="name">
                /// Required. The name of the device registry. For example,
                /// `projects/example-project/locations/us-central1/registries/my-registry`.
                /// </param>
                public virtual DeleteRequest Delete(string name)
                {
                    return new DeleteRequest(service, name);
                }

                /// <summary>Deletes a device registry configuration.</summary>
                public class DeleteRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Empty>
                {
                    /// <summary>Constructs a new Delete request.</summary>
                    public DeleteRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the device registry. For example,
                    /// `projects/example-project/locations/us-central1/registries/my-registry`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "delete";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "DELETE";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Delete parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }

                /// <summary>Gets a device registry configuration.</summary>
                /// <param name="name">
                /// Required. The name of the device registry. For example,
                /// `projects/example-project/locations/us-central1/registries/my-registry`.
                /// </param>
                public virtual GetRequest Get(string name)
                {
                    return new GetRequest(service, name);
                }

                /// <summary>Gets a device registry configuration.</summary>
                public class GetRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.DeviceRegistry>
                {
                    /// <summary>Constructs a new Get request.</summary>
                    public GetRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the device registry. For example,
                    /// `projects/example-project/locations/us-central1/registries/my-registry`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "get";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Get parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual GetIamPolicyRequest GetIamPolicy(Google.Apis.CloudIot.v1.Data.GetIamPolicyRequest body, string resource)
                {
                    return new GetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Gets the access control policy for a resource. Returns an empty policy if the resource exists and
                /// does not have a policy set.
                /// </summary>
                public class GetIamPolicyRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Policy>
                {
                    /// <summary>Constructs a new GetIamPolicy request.</summary>
                    public GetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.GetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.GetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:getIamPolicy";

                    /// <summary>Initializes GetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }

                /// <summary>Lists device registries.</summary>
                /// <param name="parent">
                /// Required. The project and cloud region path. For example,
                /// `projects/example-project/locations/us-central1`.
                /// </param>
                public virtual ListRequest List(string parent)
                {
                    return new ListRequest(service, parent);
                }

                /// <summary>Lists device registries.</summary>
                public class ListRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.ListDeviceRegistriesResponse>
                {
                    /// <summary>Constructs a new List request.</summary>
                    public ListRequest(Google.Apis.Services.IClientService service, string parent) : base(service)
                    {
                        Parent = parent;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The project and cloud region path. For example,
                    /// `projects/example-project/locations/us-central1`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>
                    /// The maximum number of registries to return in the response. If this value is zero, the service
                    /// will select a default size. A call may return fewer objects than requested. A non-empty
                    /// `next_page_token` in the response indicates that more data is available.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual System.Nullable<int> PageSize { get; set; }

                    /// <summary>
                    /// The value returned by the last `ListDeviceRegistriesResponse`; indicates that this is a
                    /// continuation of a prior `ListDeviceRegistries` call and the system should return the next page
                    /// of data.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual string PageToken { get; set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "list";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}/registries";

                    /// <summary>Initializes List parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+$",
                        });
                        RequestParameters.Add("pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                        RequestParameters.Add("pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>Updates a device registry configuration.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource path name. For example,
                /// `projects/example-project/locations/us-central1/registries/my-registry`.
                /// </param>
                public virtual PatchRequest Patch(Google.Apis.CloudIot.v1.Data.DeviceRegistry body, string name)
                {
                    return new PatchRequest(service, body, name);
                }

                /// <summary>Updates a device registry configuration.</summary>
                public class PatchRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.DeviceRegistry>
                {
                    /// <summary>Constructs a new Patch request.</summary>
                    public PatchRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.DeviceRegistry body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource path name. For example,
                    /// `projects/example-project/locations/us-central1/registries/my-registry`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>
                    /// Required. Only updates the `device_registry` fields indicated by this mask. The field mask must
                    /// not be empty, and it must not contain fields that are immutable or only set by the server.
                    /// Mutable top-level fields: `event_notification_config`, `http_config`, `mqtt_config`, and
                    /// `state_notification_config`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.DeviceRegistry Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "patch";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+name}";

                    /// <summary>Initializes Patch parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                        RequestParameters.Add("updateMask", new Google.Apis.Discovery.Parameter
                        {
                            Name = "updateMask",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    }
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy is being specified. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual SetIamPolicyRequest SetIamPolicy(Google.Apis.CloudIot.v1.Data.SetIamPolicyRequest body, string resource)
                {
                    return new SetIamPolicyRequest(service, body, resource);
                }

                /// <summary>
                /// Sets the access control policy on the specified resource. Replaces any existing policy.
                /// </summary>
                public class SetIamPolicyRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.Policy>
                {
                    /// <summary>Constructs a new SetIamPolicy request.</summary>
                    public SetIamPolicyRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.SetIamPolicyRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy is being specified. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.SetIamPolicyRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "setIamPolicy";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:setIamPolicy";

                    /// <summary>Initializes SetIamPolicy parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.
                /// </summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="resource">
                /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                /// field.
                /// </param>
                public virtual TestIamPermissionsRequest TestIamPermissions(Google.Apis.CloudIot.v1.Data.TestIamPermissionsRequest body, string resource)
                {
                    return new TestIamPermissionsRequest(service, body, resource);
                }

                /// <summary>
                /// Returns permissions that a caller has on the specified resource. If the resource does not exist,
                /// this will return an empty set of permissions, not a NOT_FOUND error.
                /// </summary>
                public class TestIamPermissionsRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.TestIamPermissionsResponse>
                {
                    /// <summary>Constructs a new TestIamPermissions request.</summary>
                    public TestIamPermissionsRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.TestIamPermissionsRequest body, string resource) : base(service)
                    {
                        Resource = resource;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// REQUIRED: The resource for which the policy detail is being requested. See [Resource
                    /// names](https://cloud.google.com/apis/design/resource_names) for the appropriate value for this
                    /// field.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("resource", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Resource { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.TestIamPermissionsRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "testIamPermissions";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+resource}:testIamPermissions";

                    /// <summary>Initializes TestIamPermissions parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("resource", new Google.Apis.Discovery.Parameter
                        {
                            Name = "resource",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }

                /// <summary>Deletes the association between the device and the gateway.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="parent">
                /// Required. The name of the registry. For example,
                /// `projects/example-project/locations/us-central1/registries/my-registry`.
                /// </param>
                public virtual UnbindDeviceFromGatewayRequest UnbindDeviceFromGateway(Google.Apis.CloudIot.v1.Data.UnbindDeviceFromGatewayRequest body, string parent)
                {
                    return new UnbindDeviceFromGatewayRequest(service, body, parent);
                }

                /// <summary>Deletes the association between the device and the gateway.</summary>
                public class UnbindDeviceFromGatewayRequest : CloudIotBaseServiceRequest<Google.Apis.CloudIot.v1.Data.UnbindDeviceFromGatewayResponse>
                {
                    /// <summary>Constructs a new UnbindDeviceFromGateway request.</summary>
                    public UnbindDeviceFromGatewayRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudIot.v1.Data.UnbindDeviceFromGatewayRequest body, string parent) : base(service)
                    {
                        Parent = parent;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the registry. For example,
                    /// `projects/example-project/locations/us-central1/registries/my-registry`.
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("parent", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Parent { get; private set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.CloudIot.v1.Data.UnbindDeviceFromGatewayRequest Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "unbindDeviceFromGateway";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "POST";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1/{+parent}:unbindDeviceFromGateway";

                    /// <summary>Initializes UnbindDeviceFromGateway parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("parent", new Google.Apis.Discovery.Parameter
                        {
                            Name = "parent",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/registries/[^/]+$",
                        });
                    }
                }
            }
        }
    }
}
namespace Google.Apis.CloudIot.v1.Data
{
    /// <summary>Request for `BindDeviceToGateway`.</summary>
    public class BindDeviceToGatewayRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The device to associate with the specified gateway. The value of `device_id` can be either the
        /// device numeric ID or the user-defined device identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>
        /// Required. The value of `gateway_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayId")]
        public virtual string GatewayId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `BindDeviceToGateway`.</summary>
    public class BindDeviceToGatewayResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Associates `members`, or principals, with a `role`.</summary>
    public class Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The condition that is associated with this binding. If the condition evaluates to `true`, then this binding
        /// applies to the current request. If the condition evaluates to `false`, then this binding does not apply to
        /// the current request. However, a different role binding might grant the same role to one or more of the
        /// principals in this binding. To learn which resources support conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("condition")]
        public virtual Expr Condition { get; set; }

        /// <summary>
        /// Specifies the principals requesting access for a Google Cloud resource. `members` can have the following
        /// values: * `allUsers`: A special identifier that represents anyone who is on the internet; with or without a
        /// Google account. * `allAuthenticatedUsers`: A special identifier that represents anyone who is authenticated
        /// with a Google account or a service account. Does not include identities that come from external identity
        /// providers (IdPs) through identity federation. * `user:{emailid}`: An email address that represents a
        /// specific Google account. For example, `alice@example.com` . * `serviceAccount:{emailid}`: An email address
        /// that represents a Google service account. For example, `my-other-app@appspot.gserviceaccount.com`. *
        /// `serviceAccount:{projectid}.svc.id.goog[{namespace}/{kubernetes-sa}]`: An identifier for a [Kubernetes
        /// service account](https://cloud.google.com/kubernetes-engine/docs/how-to/kubernetes-service-accounts). For
        /// example, `my-project.svc.id.goog[my-namespace/my-kubernetes-sa]`. * `group:{emailid}`: An email address that
        /// represents a Google group. For example, `admins@example.com`. * `deleted:user:{emailid}?uid={uniqueid}`: An
        /// email address (plus unique identifier) representing a user that has been recently deleted. For example,
        /// `alice@example.com?uid=123456789012345678901`. If the user is recovered, this value reverts to
        /// `user:{emailid}` and the recovered user retains the role in the binding. *
        /// `deleted:serviceAccount:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing a
        /// service account that has been recently deleted. For example,
        /// `my-other-app@appspot.gserviceaccount.com?uid=123456789012345678901`. If the service account is undeleted,
        /// this value reverts to `serviceAccount:{emailid}` and the undeleted service account retains the role in the
        /// binding. * `deleted:group:{emailid}?uid={uniqueid}`: An email address (plus unique identifier) representing
        /// a Google group that has been recently deleted. For example, `admins@example.com?uid=123456789012345678901`.
        /// If the group is recovered, this value reverts to `group:{emailid}` and the recovered group retains the role
        /// in the binding. * `domain:{domain}`: The G Suite domain (primary) that represents all the users of that
        /// domain. For example, `google.com` or `example.com`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("members")]
        public virtual System.Collections.Generic.IList<string> Members { get; set; }

        /// <summary>
        /// Role that is assigned to the list of `members`, or principals. For example, `roles/viewer`, `roles/editor`,
        /// or `roles/owner`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The device resource.</summary>
    public class Device : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If a device is blocked, connections or requests from this device will fail. Can be used to temporarily
        /// prevent the device from connecting if, for example, the sensor is generating bad data and needs maintenance.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("blocked")]
        public virtual System.Nullable<bool> Blocked { get; set; }

        /// <summary>
        /// The most recent device configuration, which is eventually sent from Cloud IoT Core to the device. If not
        /// present on creation, the configuration will be initialized with an empty payload and version value of `1`.
        /// To update this field after creation, use the `DeviceManager.ModifyCloudToDeviceConfig` method.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("config")]
        public virtual DeviceConfig Config { get; set; }

        /// <summary>
        /// The credentials used to authenticate this device. To allow credential rotation without interruption,
        /// multiple device credentials can be bound to this device. No more than 3 credentials can be bound to a single
        /// device at a time. When new credentials are added to a device, they are verified against the registry
        /// credentials. For details, see the description of the `DeviceRegistry.credentials` field.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentials")]
        public virtual System.Collections.Generic.IList<DeviceCredential> Credentials { get; set; }

        /// <summary>Gateway-related configuration and state.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayConfig")]
        public virtual GatewayConfig GatewayConfig { get; set; }

        /// <summary>
        /// The user-defined device identifier. The device ID must be unique within a device registry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// [Output only] The last time a cloud-to-device config version acknowledgment was received from the device.
        /// This field is only for configurations sent through MQTT.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastConfigAckTime")]
        public virtual object LastConfigAckTime { get; set; }

        /// <summary>[Output only] The last time a cloud-to-device config version was sent to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastConfigSendTime")]
        public virtual object LastConfigSendTime { get; set; }

        /// <summary>
        /// [Output only] The error message of the most recent error, such as a failure to publish to Cloud Pub/Sub.
        /// 'last_error_time' is the timestamp of this field. If no errors have occurred, this field has an empty
        /// message and the status code 0 == OK. Otherwise, this field is expected to have a status code other than OK.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastErrorStatus")]
        public virtual Status LastErrorStatus { get; set; }

        /// <summary>
        /// [Output only] The time the most recent error occurred, such as a failure to publish to Cloud Pub/Sub. This
        /// field is the timestamp of 'last_error_status'.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastErrorTime")]
        public virtual object LastErrorTime { get; set; }

        /// <summary>
        /// [Output only] The last time a telemetry event was received. Timestamps are periodically collected and
        /// written to storage; they may be stale by a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastEventTime")]
        public virtual object LastEventTime { get; set; }

        /// <summary>
        /// [Output only] The last time an MQTT `PINGREQ` was received. This field applies only to devices connecting
        /// through MQTT. MQTT clients usually only send `PINGREQ` messages if the connection is idle, and no other
        /// messages have been sent. Timestamps are periodically collected and written to storage; they may be stale by
        /// a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastHeartbeatTime")]
        public virtual object LastHeartbeatTime { get; set; }

        /// <summary>
        /// [Output only] The last time a state event was received. Timestamps are periodically collected and written to
        /// storage; they may be stale by a few minutes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastStateTime")]
        public virtual object LastStateTime { get; set; }

        /// <summary>
        /// **Beta Feature** The logging verbosity for device activity. If unspecified, DeviceRegistry.log_level will be
        /// used.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLevel")]
        public virtual string LogLevel { get; set; }

        /// <summary>
        /// The metadata key-value pairs assigned to the device. This metadata is not interpreted or indexed by Cloud
        /// IoT Core. It can be used to add contextual information for the device. Keys must conform to the regular
        /// expression a-zA-Z+ and be less than 128 bytes in length. Values are free-form strings. Each value must be
        /// less than or equal to 32 KB in size. The total size of all keys and values must be less than 256 KB, and the
        /// maximum number of key-value pairs is 500.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("metadata")]
        public virtual System.Collections.Generic.IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The resource path name. For example, `projects/p1/locations/us-central1/registries/registry0/devices/dev0`
        /// or `projects/p1/locations/us-central1/registries/registry0/devices/{num_id}`. When `name` is populated as a
        /// response from the service, it always ends in the device numeric ID.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// [Output only] A server-defined unique numeric ID for the device. This is a more compact way to identify
        /// devices, and it is globally unique.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("numId")]
        public virtual System.Nullable<ulong> NumId { get; set; }

        /// <summary>
        /// [Output only] The state most recently received from the device. If no state has been reported, this field is
        /// not present.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual DeviceState State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The device configuration. Eventually delivered to devices.</summary>
    public class DeviceConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device configuration data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryData")]
        public virtual string BinaryData { get; set; }

        /// <summary>
        /// [Output only] The time at which this configuration version was updated in Cloud IoT Core. This timestamp is
        /// set by the server.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cloudUpdateTime")]
        public virtual object CloudUpdateTime { get; set; }

        /// <summary>
        /// [Output only] The time at which Cloud IoT Core received the acknowledgment from the device, indicating that
        /// the device has received this configuration version. If this field is not present, the device has not yet
        /// acknowledged that it received this version. Note that when the config was sent to the device, many config
        /// versions may have been available in Cloud IoT Core while the device was disconnected, and on connection,
        /// only the latest version is sent to the device. Some versions may never be sent to the device, and therefore
        /// are never acknowledged. This timestamp is set by Cloud IoT Core.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceAckTime")]
        public virtual object DeviceAckTime { get; set; }

        /// <summary>
        /// [Output only] The version of this update. The version number is assigned by the server, and is always
        /// greater than 0 after device creation. The version must be 0 on the `CreateDevice` request if a `config` is
        /// specified; the response of `CreateDevice` will always have a value of 1.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<long> Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A server-stored device credential used for authentication.</summary>
    public class DeviceCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// [Optional] The time at which this credential becomes invalid. This credential will be ignored for new client
        /// authentication requests after this timestamp; however, it will not be automatically deleted.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expirationTime")]
        public virtual object ExpirationTime { get; set; }

        /// <summary>
        /// A public key used to verify the signature of JSON Web Tokens (JWTs). When adding a new device credential,
        /// either via device creation or via modifications, this public key credential may be required to be signed by
        /// one of the registry level certificates. More specifically, if the registry contains at least one
        /// certificate, any new device credential must be signed by one of the registry certificates. As a result, when
        /// the registry contains certificates, only X.509 certificates are accepted as device credentials. However, if
        /// the registry does not contain a certificate, self-signed certificates and public keys will be accepted. New
        /// device credentials must be different from every registry-level certificate.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKey")]
        public virtual PublicKeyCredential PublicKey { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A container for a group of devices.</summary>
    public class DeviceRegistry : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The credentials used to verify the device credentials. No more than 10 credentials can be bound to a single
        /// registry at a time. The verification process occurs at the time of device creation or update. If this field
        /// is empty, no verification is performed. Otherwise, the credentials of a newly created device or added
        /// credentials of an updated device should be signed with one of these registry credentials. Note, however,
        /// that existing devices will never be affected by modifications to this list of credentials: after a device
        /// has been successfully created in a registry, it should be able to connect even if its registry credentials
        /// are revoked, deleted, or modified.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("credentials")]
        public virtual System.Collections.Generic.IList<RegistryCredential> Credentials { get; set; }

        /// <summary>
        /// The configuration for notification of telemetry events received from the device. All telemetry events that
        /// were successfully published by the device and acknowledged by Cloud IoT Core are guaranteed to be delivered
        /// to Cloud Pub/Sub. If multiple configurations match a message, only the first matching configuration is used.
        /// If you try to publish a device telemetry event using MQTT without specifying a Cloud Pub/Sub topic for the
        /// device's registry, the connection closes automatically. If you try to do so using an HTTP connection, an
        /// error is returned. Up to 10 configurations may be provided.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventNotificationConfigs")]
        public virtual System.Collections.Generic.IList<EventNotificationConfig> EventNotificationConfigs { get; set; }

        /// <summary>The DeviceService (HTTP) configuration for this device registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpConfig")]
        public virtual HttpConfig HttpConfig { get; set; }

        /// <summary>The identifier of this device registry. For example, `myRegistry`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// **Beta Feature** The default logging verbosity for activity from devices in this registry. The verbosity
        /// level can be overridden by Device.log_level.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logLevel")]
        public virtual string LogLevel { get; set; }

        /// <summary>The MQTT configuration for this device registry.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mqttConfig")]
        public virtual MqttConfig MqttConfig { get; set; }

        /// <summary>
        /// The resource path name. For example,
        /// `projects/example-project/locations/us-central1/registries/my-registry`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The configuration for notification of new states received from the device. State updates are guaranteed to
        /// be stored in the state history, but notifications to Cloud Pub/Sub are not guaranteed. For example, if
        /// permissions are misconfigured or the specified topic doesn't exist, no notification will be published but
        /// the state will still be stored in Cloud IoT Core.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("stateNotificationConfig")]
        public virtual StateNotificationConfig StateNotificationConfig { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The device state, as reported by the device.</summary>
    public class DeviceState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The device state data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryData")]
        public virtual string BinaryData { get; set; }

        /// <summary>[Output only] The time at which this state version was updated in Cloud IoT Core.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A typical
    /// example is to use it as the request or the response type of an API method. For instance: service Foo { rpc
    /// Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    /// </summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for forwarding telemetry events.</summary>
    public class EventNotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Cloud Pub/Sub topic name. For example, `projects/myProject/topics/deviceEvents`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopicName")]
        public virtual string PubsubTopicName { get; set; }

        /// <summary>
        /// If the subfolder name matches this string exactly, this configuration will be used. The string must not
        /// include the leading '/' character. If empty, all strings are matched. This field is used only for telemetry
        /// events; subfolders are not supported for state changes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subfolderMatches")]
        public virtual string SubfolderMatches { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a textual expression in the Common Expression Language (CEL) syntax. CEL is a C-like expression
    /// language. The syntax and semantics of CEL are documented at https://github.com/google/cel-spec. Example
    /// (Comparison): title: "Summary size limit" description: "Determines if a summary is less than 100 chars"
    /// expression: "document.summary.size() &amp;lt; 100" Example (Equality): title: "Requestor is owner" description:
    /// "Determines if requestor is the document owner" expression: "document.owner == request.auth.claims.email"
    /// Example (Logic): title: "Public documents" description: "Determine whether the document should be publicly
    /// visible" expression: "document.type != 'private' &amp;amp;&amp;amp; document.type != 'internal'" Example (Data
    /// Manipulation): title: "Notification string" description: "Create a notification string with a timestamp."
    /// expression: "'New message received at ' + string(document.create_time)" The exact variables and functions that
    /// may be referenced within an expression are determined by the service that evaluates it. See the service
    /// documentation for additional information.
    /// </summary>
    public class Expr : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. Description of the expression. This is a longer text which describes the expression, e.g. when
        /// hovered over it in a UI.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>Textual representation of an expression in Common Expression Language syntax.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expression")]
        public virtual string Expression { get; set; }

        /// <summary>
        /// Optional. String indicating the location of the expression for error reporting, e.g. a file name and a
        /// position in the file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("location")]
        public virtual string Location { get; set; }

        /// <summary>
        /// Optional. Title for the expression, i.e. a short string describing its purpose. This can be used e.g. in UIs
        /// which allow to enter the expression.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("title")]
        public virtual string Title { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Gateway-related configuration and state.</summary>
    public class GatewayConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Indicates how to authorize and/or authenticate devices to access the gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayAuthMethod")]
        public virtual string GatewayAuthMethod { get; set; }

        /// <summary>Indicates whether the device is a gateway.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayType")]
        public virtual string GatewayType { get; set; }

        /// <summary>[Output only] The ID of the gateway the device accessed most recently.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAccessedGatewayId")]
        public virtual string LastAccessedGatewayId { get; set; }

        /// <summary>
        /// [Output only] The most recent time at which the device accessed the gateway specified in
        /// `last_accessed_gateway`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("lastAccessedGatewayTime")]
        public virtual object LastAccessedGatewayTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `GetIamPolicy` method.</summary>
    public class GetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>OPTIONAL: A `GetPolicyOptions` object for specifying options to `GetIamPolicy`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("options")]
        public virtual GetPolicyOptions Options { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Encapsulates settings provided to GetIamPolicy.</summary>
    public class GetPolicyOptions : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional. The maximum policy version that will be used to format the policy. Valid values are 0, 1, and 3.
        /// Requests specifying an invalid value will be rejected. Requests for policies with any conditional role
        /// bindings must specify version 3. Policies with no conditional role bindings may specify any valid value or
        /// leave the field unset. The policy in the response might use the policy version that you specified, or it
        /// might use a lower policy version. For example, if you specify version 3, but the policy has no conditional
        /// role bindings, the response uses version 1. To learn which resources support conditions in their IAM
        /// policies, see the [IAM documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("requestedPolicyVersion")]
        public virtual System.Nullable<int> RequestedPolicyVersion { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of the HTTP bridge for a device registry.</summary>
    public class HttpConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If enabled, allows devices to use DeviceService via the HTTP protocol. Otherwise, any requests to
        /// DeviceService will fail for this registry.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("httpEnabledState")]
        public virtual string HttpEnabledState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `ListDeviceConfigVersions`.</summary>
    public class ListDeviceConfigVersionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The device configuration for the last few versions. Versions are listed in decreasing order, starting from
        /// the most recent one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceConfigs")]
        public virtual System.Collections.Generic.IList<DeviceConfig> DeviceConfigs { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `ListDeviceRegistries`.</summary>
    public class ListDeviceRegistriesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The registries that matched the query.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceRegistries")]
        public virtual System.Collections.Generic.IList<DeviceRegistry> DeviceRegistries { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more registries that match the request; this value should be
        /// passed in a new `ListDeviceRegistriesRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `ListDeviceStates`.</summary>
    public class ListDeviceStatesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The last few device states. States are listed in descending order of server update time, starting from the
        /// most recent one.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceStates")]
        public virtual System.Collections.Generic.IList<DeviceState> DeviceStates { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `ListDevices`.</summary>
    public class ListDevicesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The devices that match the request.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("devices")]
        public virtual System.Collections.Generic.IList<Device> Devices { get; set; }

        /// <summary>
        /// If not empty, indicates that there may be more devices that match the request; this value should be passed
        /// in a new `ListDevicesRequest`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for `ModifyCloudToDeviceConfig`.</summary>
    public class ModifyCloudToDeviceConfigRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The configuration data for the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryData")]
        public virtual string BinaryData { get; set; }

        /// <summary>
        /// The version number to update. If this value is zero, it will not check the version number of the server and
        /// will always update the current version; otherwise, this update will fail if the version number found on the
        /// server does not match this version number. This is used to support multiple simultaneous updates without
        /// losing data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("versionToUpdate")]
        public virtual System.Nullable<long> VersionToUpdate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration of MQTT for a device registry.</summary>
    public class MqttConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If enabled, allows connections using the MQTT protocol. Otherwise, MQTT connections to this registry will
        /// fail.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mqttEnabledState")]
        public virtual string MqttEnabledState { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// An Identity and Access Management (IAM) policy, which specifies access controls for Google Cloud resources. A
    /// `Policy` is a collection of `bindings`. A `binding` binds one or more `members`, or principals, to a single
    /// `role`. Principals can be user accounts, service accounts, Google groups, and domains (such as G Suite). A
    /// `role` is a named list of permissions; each `role` can be an IAM predefined role or a user-created custom role.
    /// For some types of Google Cloud resources, a `binding` can also specify a `condition`, which is a logical
    /// expression that allows access to a resource only if the expression evaluates to `true`. A condition can add
    /// constraints based on attributes of the request, the resource, or both. To learn which resources support
    /// conditions in their IAM policies, see the [IAM
    /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies). **JSON example:** { "bindings":
    /// [ { "role": "roles/resourcemanager.organizationAdmin", "members": [ "user:mike@example.com",
    /// "group:admins@example.com", "domain:google.com", "serviceAccount:my-project-id@appspot.gserviceaccount.com" ] },
    /// { "role": "roles/resourcemanager.organizationViewer", "members": [ "user:eve@example.com" ], "condition": {
    /// "title": "expirable access", "description": "Does not grant access after Sep 2020", "expression": "request.time
    /// &amp;lt; timestamp('2020-10-01T00:00:00.000Z')", } } ], "etag": "BwWWja0YfJA=", "version": 3 } **YAML example:**
    /// bindings: - members: - user:mike@example.com - group:admins@example.com - domain:google.com -
    /// serviceAccount:my-project-id@appspot.gserviceaccount.com role: roles/resourcemanager.organizationAdmin -
    /// members: - user:eve@example.com role: roles/resourcemanager.organizationViewer condition: title: expirable
    /// access description: Does not grant access after Sep 2020 expression: request.time &amp;lt;
    /// timestamp('2020-10-01T00:00:00.000Z') etag: BwWWja0YfJA= version: 3 For a description of IAM and its features,
    /// see the [IAM documentation](https://cloud.google.com/iam/docs/).
    /// </summary>
    public class Policy : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Associates a list of `members`, or principals, with a `role`. Optionally, may specify a `condition` that
        /// determines how and when the `bindings` are applied. Each of the `bindings` must contain at least one
        /// principal. The `bindings` in a `Policy` can refer to up to 1,500 principals; up to 250 of these principals
        /// can be Google groups. Each occurrence of a principal counts towards these limits. For example, if the
        /// `bindings` grant 50 different roles to `user:alice@example.com`, and not to any other principal, then you
        /// can add another 1,450 principals to the `bindings` in the `Policy`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<Binding> Bindings { get; set; }

        /// <summary>
        /// `etag` is used for optimistic concurrency control as a way to help prevent simultaneous updates of a policy
        /// from overwriting each other. It is strongly suggested that systems make use of the `etag` in the
        /// read-modify-write cycle to perform policy updates in order to avoid race conditions: An `etag` is returned
        /// in the response to `getIamPolicy`, and systems are expected to put that etag in the request to
        /// `setIamPolicy` to ensure that their change will be applied to the same version of the policy. **Important:**
        /// If you use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit
        /// this field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("etag")]
        public virtual string ETag { get; set; }

        /// <summary>
        /// Specifies the format of the policy. Valid values are `0`, `1`, and `3`. Requests that specify an invalid
        /// value are rejected. Any operation that affects conditional role bindings must specify version `3`. This
        /// requirement applies to the following operations: * Getting a policy that includes a conditional role binding
        /// * Adding a conditional role binding to a policy * Changing a conditional role binding in a policy * Removing
        /// any role binding, with or without a condition, from a policy that includes conditions **Important:** If you
        /// use IAM Conditions, you must include the `etag` field whenever you call `setIamPolicy`. If you omit this
        /// field, then IAM allows you to overwrite a version `3` policy with a version `1` policy, and all of the
        /// conditions in the version `3` policy are lost. If a policy does not include any conditions, operations on
        /// that policy may specify any valid version or leave the field unset. To learn which resources support
        /// conditions in their IAM policies, see the [IAM
        /// documentation](https://cloud.google.com/iam/help/conditions/resource-policies).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual System.Nullable<int> Version { get; set; }
    }

    /// <summary>A public key certificate format and data.</summary>
    public class PublicKeyCertificate : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The certificate data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("certificate")]
        public virtual string Certificate { get; set; }

        /// <summary>The certificate format.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>[Output only] The certificate details. Used only for X.509 certificates.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("x509Details")]
        public virtual X509CertificateDetails X509Details { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A public key format and data.</summary>
    public class PublicKeyCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The format of the key.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("format")]
        public virtual string Format { get; set; }

        /// <summary>The key data.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("key")]
        public virtual string Key { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A server-stored registry credential used to validate device credentials.</summary>
    public class RegistryCredential : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A public key certificate used to verify the device credentials.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyCertificate")]
        public virtual PublicKeyCertificate PublicKeyCertificate { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for `SendCommandToDevice`.</summary>
    public class SendCommandToDeviceRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Required. The command data to send to the device.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryData")]
        public virtual string BinaryData { get; set; }

        /// <summary>
        /// Optional subfolder for the command. If empty, the command will be delivered to the
        /// /devices/{device-id}/commands topic, otherwise it will be delivered to the
        /// /devices/{device-id}/commands/{subfolder} topic. Multi-level subfolders are allowed. This field must not
        /// have more than 256 characters, and must not contain any MQTT wildcards ("+" or "#") or null characters.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subfolder")]
        public virtual string Subfolder { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `SendCommandToDevice`.</summary>
    public class SendCommandToDeviceResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `SetIamPolicy` method.</summary>
    public class SetIamPolicyRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of the policy is limited to a few
        /// 10s of KB. An empty policy is a valid policy but certain Google Cloud services (such as Projects) might
        /// reject them.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("policy")]
        public virtual Policy Policy { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The configuration for notification of new states received from the device.</summary>
    public class StateNotificationConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A Cloud Pub/Sub topic name. For example, `projects/myProject/topics/deviceEvents`.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pubsubTopicName")]
        public virtual string PubsubTopicName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// The `Status` type defines a logical error model that is suitable for different programming environments,
    /// including REST APIs and RPC APIs. It is used by [gRPC](https://github.com/grpc). Each `Status` message contains
    /// three pieces of data: error code, error message, and error details. You can find out more about this error model
    /// and how to work with it in the [API Design Guide](https://cloud.google.com/apis/design/errors).
    /// </summary>
    public class Status : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The status code, which should be an enum value of google.rpc.Code.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("code")]
        public virtual System.Nullable<int> Code { get; set; }

        /// <summary>
        /// A list of messages that carry the error details. There is a common set of message types for APIs to use.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual System.Collections.Generic.IList<System.Collections.Generic.IDictionary<string, object>> Details { get; set; }

        /// <summary>
        /// A developer-facing error message, which should be in English. Any user-facing error message should be
        /// localized and sent in the google.rpc.Status.details field, or localized by the client.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("message")]
        public virtual string Message { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The set of permissions to check for the `resource`. Permissions with wildcards (such as `*` or `storage.*`)
        /// are not allowed. For more information see [IAM
        /// Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response message for `TestIamPermissions` method.</summary>
    public class TestIamPermissionsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A subset of `TestPermissionsRequest.permissions` that the caller is allowed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("permissions")]
        public virtual System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Request for `UnbindDeviceFromGateway`.</summary>
    public class UnbindDeviceFromGatewayRequest : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Required. The device to disassociate from the specified gateway. The value of `device_id` can be either the
        /// device numeric ID or the user-defined device identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("deviceId")]
        public virtual string DeviceId { get; set; }

        /// <summary>
        /// Required. The value of `gateway_id` can be either the device numeric ID or the user-defined device
        /// identifier.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("gatewayId")]
        public virtual string GatewayId { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response for `UnbindDeviceFromGateway`.</summary>
    public class UnbindDeviceFromGatewayResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of an X.509 certificate. For informational purposes only.</summary>
    public class X509CertificateDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the certificate becomes invalid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("expiryTime")]
        public virtual object ExpiryTime { get; set; }

        /// <summary>The entity that signed the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("issuer")]
        public virtual string Issuer { get; set; }

        /// <summary>The type of public key in the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("publicKeyType")]
        public virtual string PublicKeyType { get; set; }

        /// <summary>The algorithm used to sign the certificate.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatureAlgorithm")]
        public virtual string SignatureAlgorithm { get; set; }

        /// <summary>The time the certificate becomes valid.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The entity the certificate and public key belong to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subject")]
        public virtual string Subject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
