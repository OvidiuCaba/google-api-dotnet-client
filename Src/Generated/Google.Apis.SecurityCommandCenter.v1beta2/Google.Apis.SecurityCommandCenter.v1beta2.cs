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

namespace Google.Apis.SecurityCommandCenter.v1beta2
{
    /// <summary>The SecurityCommandCenter Service.</summary>
    public class SecurityCommandCenterService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1beta2";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public SecurityCommandCenterService() : this(new Google.Apis.Services.BaseClientService.Initializer())
        {
        }

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public SecurityCommandCenterService(Google.Apis.Services.BaseClientService.Initializer initializer) : base(initializer)
        {
            Folders = new FoldersResource(this);
            Organizations = new OrganizationsResource(this);
            Projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features => new string[0];

        /// <summary>Gets the service name.</summary>
        public override string Name => "securitycenter";

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri =>
        #if NETSTANDARD1_3 || NETSTANDARD2_0 || NET45
            BaseUriOverride ?? "https://securitycenter.googleapis.com/";
        #else
            "https://securitycenter.googleapis.com/";
        #endif

        /// <summary>Gets the service base path.</summary>
        public override string BasePath => "";

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri => "https://securitycenter.googleapis.com/batch";

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath => "batch";
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Security Command Center API.</summary>
        public class Scope
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Available OAuth 2.0 scope constants for use with the Security Command Center API.</summary>
        public static class ScopeConstants
        {
            /// <summary>
            /// See, edit, configure, and delete your Google Cloud data and see the email address for your Google
            /// Account.
            /// </summary>
            public const string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";
        }

        /// <summary>Gets the Folders resource.</summary>
        public virtual FoldersResource Folders { get; }

        /// <summary>Gets the Organizations resource.</summary>
        public virtual OrganizationsResource Organizations { get; }

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects { get; }
    }

    /// <summary>A base abstract class for SecurityCommandCenter requests.</summary>
    public abstract class SecurityCommandCenterBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        /// <summary>Constructs a new SecurityCommandCenterBaseServiceRequest instance.</summary>
        protected SecurityCommandCenterBaseServiceRequest(Google.Apis.Services.IClientService service) : base(service)
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

        /// <summary>Initializes SecurityCommandCenter parameter list.</summary>
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

    /// <summary>The "folders" collection of methods.</summary>
    public class FoldersResource
    {
        private const string Resource = "folders";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public FoldersResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
            EventThreatDetectionSettings = new EventThreatDetectionSettingsResource(service);
            RapidVulnerabilityDetectionSettings = new RapidVulnerabilityDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            VirtualMachineThreatDetectionSettings = new VirtualMachineThreatDetectionSettingsResource(service);
            WebSecurityScannerSettings = new WebSecurityScannerSettingsResource(service);
        }

        /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
        public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

        /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
        public class ContainerThreatDetectionSettingsResource
        {
            private const string Resource = "containerThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/containerThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the EventThreatDetectionSettings resource.</summary>
        public virtual EventThreatDetectionSettingsResource EventThreatDetectionSettings { get; }

        /// <summary>The "eventThreatDetectionSettings" collection of methods.</summary>
        public class EventThreatDetectionSettingsResource
        {
            private const string Resource = "eventThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/eventThreatDetectionSettings *
                /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/eventThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the RapidVulnerabilityDetectionSettings resource.</summary>
        public virtual RapidVulnerabilityDetectionSettingsResource RapidVulnerabilityDetectionSettings { get; }

        /// <summary>The "rapidVulnerabilityDetectionSettings" collection of methods.</summary>
        public class RapidVulnerabilityDetectionSettingsResource
        {
            private const string Resource = "rapidVulnerabilityDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RapidVulnerabilityDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
                /// folders/{folder}/rapidVulnerabilityDetectionSettings *
                /// projects/{project}/rapidVulnerabilityDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/rapidVulnerabilityDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
                /// organizations/{organization}/securityHealthAnalyticsSettings *
                /// folders/{folder}/securityHealthAnalyticsSettings *
                /// projects/{project}/securityHealthAnalyticsSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the VirtualMachineThreatDetectionSettings resource.</summary>
        public virtual VirtualMachineThreatDetectionSettingsResource VirtualMachineThreatDetectionSettings { get; }

        /// <summary>The "virtualMachineThreatDetectionSettings" collection of methods.</summary>
        public class VirtualMachineThreatDetectionSettingsResource
        {
            private const string Resource = "virtualMachineThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VirtualMachineThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/virtualMachineThreatDetectionSettings *
                /// folders/{folder}/virtualMachineThreatDetectionSettings *
                /// projects/{project}/virtualMachineThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/virtualMachineThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the WebSecurityScannerSettings resource.</summary>
        public virtual WebSecurityScannerSettingsResource WebSecurityScannerSettings { get; }

        /// <summary>The "webSecurityScannerSettings" collection of methods.</summary>
        public class WebSecurityScannerSettingsResource
        {
            private const string Resource = "webSecurityScannerSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebSecurityScannerSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
                /// organizations/{organization}/webSecurityScannerSettings *
                /// folders/{folder}/webSecurityScannerSettings * projects/{project}/webSecurityScannerSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^folders/[^/]+/webSecurityScannerSettings$",
                    });
                }
            }
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/containerThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/eventThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Retrieve the OnboardingState of a resource.</summary>
        /// <param name="name">
        /// Required. The name of the OnboardingState to retrieve. Formats: *
        /// organizations/{organization}/onboardingState * folders/{folder}/onboardingState *
        /// projects/{project}/onboardingState
        /// </param>
        public virtual GetOnboardingStateRequest GetOnboardingState(string name)
        {
            return new GetOnboardingStateRequest(service, name);
        }

        /// <summary>Retrieve the OnboardingState of a resource.</summary>
        public class GetOnboardingStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.OnboardingState>
        {
            /// <summary>Constructs a new GetOnboardingState request.</summary>
            public GetOnboardingStateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the OnboardingState to retrieve. Formats: *
            /// organizations/{organization}/onboardingState * folders/{folder}/onboardingState *
            /// projects/{project}/onboardingState
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOnboardingState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetOnboardingState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/onboardingState$",
                });
            }
        }

        /// <summary>Get the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the RapidVulnerabilityDetectionSettings resource.</summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/rapidVulnerabilityDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings Format:
        /// projects/{project}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityCenterSettings to retrieve. Format:
            /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings
            /// Format: projects/{project}/securityCenterSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityCenterSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityCenterSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/securityCenterSettings$",
                });
            }
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
                });
            }
        }

        /// <summary>Get the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the VirtualMachineThreatDetectionSettings resource.</summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/virtualMachineThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(service, name);
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/webSecurityScannerSettings$",
                });
            }
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the ContainerThreatDetectionSettings. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the EventThreatDetectionSettings. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/eventThreatDetectionSettings$",
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

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/rapidVulnerabilityDetectionSettings$",
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

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(service, body, name);
        }

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/securityHealthAnalyticsSettings$",
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

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/virtualMachineThreatDetectionSettings$",
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

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(service, body, name);
        }

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the WebSecurityScannerSettings. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^folders/[^/]+/webSecurityScannerSettings$",
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
    }

    /// <summary>The "organizations" collection of methods.</summary>
    public class OrganizationsResource
    {
        private const string Resource = "organizations";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public OrganizationsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
            EventThreatDetectionSettings = new EventThreatDetectionSettingsResource(service);
            RapidVulnerabilityDetectionSettings = new RapidVulnerabilityDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            VirtualMachineThreatDetectionSettings = new VirtualMachineThreatDetectionSettingsResource(service);
            WebSecurityScannerSettings = new WebSecurityScannerSettingsResource(service);
        }

        /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
        public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

        /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
        public class ContainerThreatDetectionSettingsResource
        {
            private const string Resource = "containerThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/containerThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the EventThreatDetectionSettings resource.</summary>
        public virtual EventThreatDetectionSettingsResource EventThreatDetectionSettings { get; }

        /// <summary>The "eventThreatDetectionSettings" collection of methods.</summary>
        public class EventThreatDetectionSettingsResource
        {
            private const string Resource = "eventThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/eventThreatDetectionSettings *
                /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/eventThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the RapidVulnerabilityDetectionSettings resource.</summary>
        public virtual RapidVulnerabilityDetectionSettingsResource RapidVulnerabilityDetectionSettings { get; }

        /// <summary>The "rapidVulnerabilityDetectionSettings" collection of methods.</summary>
        public class RapidVulnerabilityDetectionSettingsResource
        {
            private const string Resource = "rapidVulnerabilityDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RapidVulnerabilityDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
                /// folders/{folder}/rapidVulnerabilityDetectionSettings *
                /// projects/{project}/rapidVulnerabilityDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/rapidVulnerabilityDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
                /// organizations/{organization}/securityHealthAnalyticsSettings *
                /// folders/{folder}/securityHealthAnalyticsSettings *
                /// projects/{project}/securityHealthAnalyticsSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the VirtualMachineThreatDetectionSettings resource.</summary>
        public virtual VirtualMachineThreatDetectionSettingsResource VirtualMachineThreatDetectionSettings { get; }

        /// <summary>The "virtualMachineThreatDetectionSettings" collection of methods.</summary>
        public class VirtualMachineThreatDetectionSettingsResource
        {
            private const string Resource = "virtualMachineThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VirtualMachineThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/virtualMachineThreatDetectionSettings *
                /// folders/{folder}/virtualMachineThreatDetectionSettings *
                /// projects/{project}/virtualMachineThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/virtualMachineThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the WebSecurityScannerSettings resource.</summary>
        public virtual WebSecurityScannerSettingsResource WebSecurityScannerSettings { get; }

        /// <summary>The "webSecurityScannerSettings" collection of methods.</summary>
        public class WebSecurityScannerSettingsResource
        {
            private const string Resource = "webSecurityScannerSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebSecurityScannerSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
                /// organizations/{organization}/webSecurityScannerSettings *
                /// folders/{folder}/webSecurityScannerSettings * projects/{project}/webSecurityScannerSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^organizations/[^/]+/webSecurityScannerSettings$",
                    });
                }
            }
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/containerThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/eventThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Retrieve the OnboardingState of a resource.</summary>
        /// <param name="name">
        /// Required. The name of the OnboardingState to retrieve. Formats: *
        /// organizations/{organization}/onboardingState * folders/{folder}/onboardingState *
        /// projects/{project}/onboardingState
        /// </param>
        public virtual GetOnboardingStateRequest GetOnboardingState(string name)
        {
            return new GetOnboardingStateRequest(service, name);
        }

        /// <summary>Retrieve the OnboardingState of a resource.</summary>
        public class GetOnboardingStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.OnboardingState>
        {
            /// <summary>Constructs a new GetOnboardingState request.</summary>
            public GetOnboardingStateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the OnboardingState to retrieve. Formats: *
            /// organizations/{organization}/onboardingState * folders/{folder}/onboardingState *
            /// projects/{project}/onboardingState
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOnboardingState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetOnboardingState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/onboardingState$",
                });
            }
        }

        /// <summary>Get the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the RapidVulnerabilityDetectionSettings resource.</summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/rapidVulnerabilityDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings Format:
        /// projects/{project}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityCenterSettings to retrieve. Format:
            /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings
            /// Format: projects/{project}/securityCenterSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityCenterSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityCenterSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/securityCenterSettings$",
                });
            }
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
                });
            }
        }

        /// <summary>Get the Subscription resource.</summary>
        /// <param name="name">
        /// Required. The name of the subscription to retrieve. Format: organizations/{organization}/subscription
        /// </param>
        public virtual GetSubscriptionRequest GetSubscription(string name)
        {
            return new GetSubscriptionRequest(service, name);
        }

        /// <summary>Get the Subscription resource.</summary>
        public class GetSubscriptionRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.Subscription>
        {
            /// <summary>Constructs a new GetSubscription request.</summary>
            public GetSubscriptionRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the subscription to retrieve. Format: organizations/{organization}/subscription
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSubscription";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSubscription parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/subscription$",
                });
            }
        }

        /// <summary>Get the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the VirtualMachineThreatDetectionSettings resource.</summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/virtualMachineThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(service, name);
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/webSecurityScannerSettings$",
                });
            }
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the ContainerThreatDetectionSettings. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the EventThreatDetectionSettings. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/eventThreatDetectionSettings$",
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

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/rapidVulnerabilityDetectionSettings$",
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

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(service, body, name);
        }

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/securityHealthAnalyticsSettings$",
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

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/virtualMachineThreatDetectionSettings$",
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

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(service, body, name);
        }

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the WebSecurityScannerSettings. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^organizations/[^/]+/webSecurityScannerSettings$",
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
            ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
            EventThreatDetectionSettings = new EventThreatDetectionSettingsResource(service);
            Locations = new LocationsResource(service);
            RapidVulnerabilityDetectionSettings = new RapidVulnerabilityDetectionSettingsResource(service);
            SecurityHealthAnalyticsSettings = new SecurityHealthAnalyticsSettingsResource(service);
            VirtualMachineThreatDetectionSettings = new VirtualMachineThreatDetectionSettingsResource(service);
            WebSecurityScannerSettings = new WebSecurityScannerSettingsResource(service);
        }

        /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
        public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

        /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
        public class ContainerThreatDetectionSettingsResource
        {
            private const string Resource = "containerThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/containerThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the EventThreatDetectionSettings resource.</summary>
        public virtual EventThreatDetectionSettingsResource EventThreatDetectionSettings { get; }

        /// <summary>The "eventThreatDetectionSettings" collection of methods.</summary>
        public class EventThreatDetectionSettingsResource
        {
            private const string Resource = "eventThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public EventThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective EventThreatDetectionSettings based on its level in the resource hierarchy and
            /// its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the EventThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/eventThreatDetectionSettings *
                /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/eventThreatDetectionSettings$",
                    });
                }
            }
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
                Clusters = new ClustersResource(service);
            }

            /// <summary>Gets the Clusters resource.</summary>
            public virtual ClustersResource Clusters { get; }

            /// <summary>The "clusters" collection of methods.</summary>
            public class ClustersResource
            {
                private const string Resource = "clusters";

                /// <summary>The service which this resource belongs to.</summary>
                private readonly Google.Apis.Services.IClientService service;

                /// <summary>Constructs a new resource.</summary>
                public ClustersResource(Google.Apis.Services.IClientService service)
                {
                    this.service = service;
                    ContainerThreatDetectionSettings = new ContainerThreatDetectionSettingsResource(service);
                }

                /// <summary>Gets the ContainerThreatDetectionSettings resource.</summary>
                public virtual ContainerThreatDetectionSettingsResource ContainerThreatDetectionSettings { get; }

                /// <summary>The "containerThreatDetectionSettings" collection of methods.</summary>
                public class ContainerThreatDetectionSettingsResource
                {
                    private const string Resource = "containerThreatDetectionSettings";

                    /// <summary>The service which this resource belongs to.</summary>
                    private readonly Google.Apis.Services.IClientService service;

                    /// <summary>Constructs a new resource.</summary>
                    public ContainerThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
                    {
                        this.service = service;
                    }

                    /// <summary>
                    /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource
                    /// hierarchy and its settings.
                    /// </summary>
                    /// <param name="name">
                    /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                    /// organizations/{organization}/containerThreatDetectionSettings *
                    /// folders/{folder}/containerThreatDetectionSettings *
                    /// projects/{project}/containerThreatDetectionSettings *
                    /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                    /// </param>
                    public virtual CalculateRequest Calculate(string name)
                    {
                        return new CalculateRequest(service, name);
                    }

                    /// <summary>
                    /// Calculates the effective ContainerThreatDetectionSettings based on its level in the resource
                    /// hierarchy and its settings.
                    /// </summary>
                    public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                    {
                        /// <summary>Constructs a new Calculate request.</summary>
                        public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                        {
                            Name = name;
                            InitParameters();
                        }

                        /// <summary>
                        /// Required. The name of the ContainerThreatDetectionSettings to calculate. Formats: *
                        /// organizations/{organization}/containerThreatDetectionSettings *
                        /// folders/{folder}/containerThreatDetectionSettings *
                        /// projects/{project}/containerThreatDetectionSettings *
                        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                        /// </summary>
                        [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                        public virtual string Name { get; private set; }

                        /// <summary>Gets the method name.</summary>
                        public override string MethodName => "calculate";

                        /// <summary>Gets the HTTP method.</summary>
                        public override string HttpMethod => "GET";

                        /// <summary>Gets the REST path.</summary>
                        public override string RestPath => "v1beta2/{+name}:calculate";

                        /// <summary>Initializes Calculate parameter list.</summary>
                        protected override void InitParameters()
                        {
                            base.InitParameters();
                            RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                            {
                                Name = "name",
                                IsRequired = true,
                                ParameterType = "path",
                                DefaultValue = null,
                                Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/containerThreatDetectionSettings$",
                            });
                        }
                    }
                }

                /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
                /// <param name="name">
                /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </param>
                public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
                {
                    return new GetContainerThreatDetectionSettingsRequest(service, name);
                }

                /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
                public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                {
                    /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
                    public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                    {
                        Name = name;
                        InitParameters();
                    }

                    /// <summary>
                    /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
                    /// organizations/{organization}/containerThreatDetectionSettings *
                    /// folders/{folder}/containerThreatDetectionSettings *
                    /// projects/{project}/containerThreatDetectionSettings *
                    /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "getContainerThreatDetectionSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "GET";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

                    /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/containerThreatDetectionSettings$",
                        });
                    }
                }

                /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
                /// <param name="body">The body of the request.</param>
                /// <param name="name">
                /// The resource name of the ContainerThreatDetectionSettings. Formats: *
                /// organizations/{organization}/containerThreatDetectionSettings *
                /// folders/{folder}/containerThreatDetectionSettings *
                /// projects/{project}/containerThreatDetectionSettings *
                /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                /// </param>
                public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
                {
                    return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
                }

                /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
                public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
                {
                    /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
                    public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
                    {
                        Name = name;
                        Body = body;
                        InitParameters();
                    }

                    /// <summary>
                    /// The resource name of the ContainerThreatDetectionSettings. Formats: *
                    /// organizations/{organization}/containerThreatDetectionSettings *
                    /// folders/{folder}/containerThreatDetectionSettings *
                    /// projects/{project}/containerThreatDetectionSettings *
                    /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
                    /// </summary>
                    [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                    public virtual string Name { get; private set; }

                    /// <summary>The list of fields to be updated.</summary>
                    [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
                    public virtual object UpdateMask { get; set; }

                    /// <summary>Gets or sets the body of this request.</summary>
                    Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

                    /// <summary>Returns the body of the request.</summary>
                    protected override object GetBody() => Body;

                    /// <summary>Gets the method name.</summary>
                    public override string MethodName => "updateContainerThreatDetectionSettings";

                    /// <summary>Gets the HTTP method.</summary>
                    public override string HttpMethod => "PATCH";

                    /// <summary>Gets the REST path.</summary>
                    public override string RestPath => "v1beta2/{+name}";

                    /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
                    protected override void InitParameters()
                    {
                        base.InitParameters();
                        RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                        {
                            Name = "name",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = @"^projects/[^/]+/locations/[^/]+/clusters/[^/]+/containerThreatDetectionSettings$",
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
            }
        }

        /// <summary>Gets the RapidVulnerabilityDetectionSettings resource.</summary>
        public virtual RapidVulnerabilityDetectionSettingsResource RapidVulnerabilityDetectionSettings { get; }

        /// <summary>The "rapidVulnerabilityDetectionSettings" collection of methods.</summary>
        public class RapidVulnerabilityDetectionSettingsResource
        {
            private const string Resource = "rapidVulnerabilityDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public RapidVulnerabilityDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective RapidVulnerabilityDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the RapidVulnerabilityDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
                /// folders/{folder}/rapidVulnerabilityDetectionSettings *
                /// projects/{project}/rapidVulnerabilityDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/rapidVulnerabilityDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the SecurityHealthAnalyticsSettings resource.</summary>
        public virtual SecurityHealthAnalyticsSettingsResource SecurityHealthAnalyticsSettings { get; }

        /// <summary>The "securityHealthAnalyticsSettings" collection of methods.</summary>
        public class SecurityHealthAnalyticsSettingsResource
        {
            private const string Resource = "securityHealthAnalyticsSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public SecurityHealthAnalyticsSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective SecurityHealthAnalyticsSettings based on its level in the resource hierarchy
            /// and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the SecurityHealthAnalyticsSettings to calculate. Formats: *
                /// organizations/{organization}/securityHealthAnalyticsSettings *
                /// folders/{folder}/securityHealthAnalyticsSettings *
                /// projects/{project}/securityHealthAnalyticsSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the VirtualMachineThreatDetectionSettings resource.</summary>
        public virtual VirtualMachineThreatDetectionSettingsResource VirtualMachineThreatDetectionSettings { get; }

        /// <summary>The "virtualMachineThreatDetectionSettings" collection of methods.</summary>
        public class VirtualMachineThreatDetectionSettingsResource
        {
            private const string Resource = "virtualMachineThreatDetectionSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public VirtualMachineThreatDetectionSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective VirtualMachineThreatDetectionSettings based on its level in the resource
            /// hierarchy and its settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the VirtualMachineThreatDetectionSettings to calculate. Formats: *
                /// organizations/{organization}/virtualMachineThreatDetectionSettings *
                /// folders/{folder}/virtualMachineThreatDetectionSettings *
                /// projects/{project}/virtualMachineThreatDetectionSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/virtualMachineThreatDetectionSettings$",
                    });
                }
            }
        }

        /// <summary>Gets the WebSecurityScannerSettings resource.</summary>
        public virtual WebSecurityScannerSettingsResource WebSecurityScannerSettings { get; }

        /// <summary>The "webSecurityScannerSettings" collection of methods.</summary>
        public class WebSecurityScannerSettingsResource
        {
            private const string Resource = "webSecurityScannerSettings";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public WebSecurityScannerSettingsResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            /// <param name="name">
            /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </param>
            public virtual CalculateRequest Calculate(string name)
            {
                return new CalculateRequest(service, name);
            }

            /// <summary>
            /// Calculates the effective WebSecurityScannerSettings based on its level in the resource hierarchy and its
            /// settings.
            /// </summary>
            public class CalculateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
            {
                /// <summary>Constructs a new Calculate request.</summary>
                public CalculateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
                {
                    Name = name;
                    InitParameters();
                }

                /// <summary>
                /// Required. The name of the WebSecurityScannerSettings to calculate. Formats: *
                /// organizations/{organization}/webSecurityScannerSettings *
                /// folders/{folder}/webSecurityScannerSettings * projects/{project}/webSecurityScannerSettings
                /// </summary>
                [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string Name { get; private set; }

                /// <summary>Gets the method name.</summary>
                public override string MethodName => "calculate";

                /// <summary>Gets the HTTP method.</summary>
                public override string HttpMethod => "GET";

                /// <summary>Gets the REST path.</summary>
                public override string RestPath => "v1beta2/{+name}:calculate";

                /// <summary>Initializes Calculate parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();
                    RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                    {
                        Name = "name",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = @"^projects/[^/]+/webSecurityScannerSettings$",
                    });
                }
            }
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual GetContainerThreatDetectionSettingsRequest GetContainerThreatDetectionSettings(string name)
        {
            return new GetContainerThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the ContainerThreatDetectionSettings resource.</summary>
        public class GetContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetContainerThreatDetectionSettings request.</summary>
            public GetContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the ContainerThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/containerThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual GetEventThreatDetectionSettingsRequest GetEventThreatDetectionSettings(string name)
        {
            return new GetEventThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the EventThreatDetectionSettings resource.</summary>
        public class GetEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetEventThreatDetectionSettings request.</summary>
            public GetEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the EventThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/eventThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Retrieve the OnboardingState of a resource.</summary>
        /// <param name="name">
        /// Required. The name of the OnboardingState to retrieve. Formats: *
        /// organizations/{organization}/onboardingState * folders/{folder}/onboardingState *
        /// projects/{project}/onboardingState
        /// </param>
        public virtual GetOnboardingStateRequest GetOnboardingState(string name)
        {
            return new GetOnboardingStateRequest(service, name);
        }

        /// <summary>Retrieve the OnboardingState of a resource.</summary>
        public class GetOnboardingStateRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.OnboardingState>
        {
            /// <summary>Constructs a new GetOnboardingState request.</summary>
            public GetOnboardingStateRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the OnboardingState to retrieve. Formats: *
            /// organizations/{organization}/onboardingState * folders/{folder}/onboardingState *
            /// projects/{project}/onboardingState
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getOnboardingState";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetOnboardingState parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/onboardingState$",
                });
            }
        }

        /// <summary>Get the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual GetRapidVulnerabilityDetectionSettingsRequest GetRapidVulnerabilityDetectionSettings(string name)
        {
            return new GetRapidVulnerabilityDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the RapidVulnerabilityDetectionSettings resource.</summary>
        public class GetRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new GetRapidVulnerabilityDetectionSettings request.</summary>
            public GetRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the RapidVulnerabilityDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/rapidVulnerabilityDetectionSettings$",
                });
            }
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityCenterSettings to retrieve. Format:
        /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings Format:
        /// projects/{project}/securityCenterSettings
        /// </param>
        public virtual GetSecurityCenterSettingsRequest GetSecurityCenterSettings(string name)
        {
            return new GetSecurityCenterSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityCenterSettings resource.</summary>
        public class GetSecurityCenterSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityCenterSettings>
        {
            /// <summary>Constructs a new GetSecurityCenterSettings request.</summary>
            public GetSecurityCenterSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityCenterSettings to retrieve. Format:
            /// organizations/{organization}/securityCenterSettings Format: folders/{folder}/securityCenterSettings
            /// Format: projects/{project}/securityCenterSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityCenterSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityCenterSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/securityCenterSettings$",
                });
            }
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual GetSecurityHealthAnalyticsSettingsRequest GetSecurityHealthAnalyticsSettings(string name)
        {
            return new GetSecurityHealthAnalyticsSettingsRequest(service, name);
        }

        /// <summary>Get the SecurityHealthAnalyticsSettings resource.</summary>
        public class GetSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new GetSecurityHealthAnalyticsSettings request.</summary>
            public GetSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the SecurityHealthAnalyticsSettings to retrieve. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
                });
            }
        }

        /// <summary>Get the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual GetVirtualMachineThreatDetectionSettingsRequest GetVirtualMachineThreatDetectionSettings(string name)
        {
            return new GetVirtualMachineThreatDetectionSettingsRequest(service, name);
        }

        /// <summary>Get the VirtualMachineThreatDetectionSettings resource.</summary>
        public class GetVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new GetVirtualMachineThreatDetectionSettings request.</summary>
            public GetVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the VirtualMachineThreatDetectionSettings to retrieve. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/virtualMachineThreatDetectionSettings$",
                });
            }
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        /// <param name="name">
        /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual GetWebSecurityScannerSettingsRequest GetWebSecurityScannerSettings(string name)
        {
            return new GetWebSecurityScannerSettingsRequest(service, name);
        }

        /// <summary>Get the WebSecurityScannerSettings resource.</summary>
        public class GetWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new GetWebSecurityScannerSettings request.</summary>
            public GetWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, string name) : base(service)
            {
                Name = name;
                InitParameters();
            }

            /// <summary>
            /// Required. The name of the WebSecurityScannerSettings to retrieve. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "getWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "GET";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes GetWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/webSecurityScannerSettings$",
                });
            }
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </param>
        public virtual UpdateContainerThreatDetectionSettingsRequest UpdateContainerThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name)
        {
            return new UpdateContainerThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the ContainerThreatDetectionSettings resource.</summary>
        public class UpdateContainerThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateContainerThreatDetectionSettings request.</summary>
            public UpdateContainerThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the ContainerThreatDetectionSettings. Formats: *
            /// organizations/{organization}/containerThreatDetectionSettings *
            /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings
            /// * projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.ContainerThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateContainerThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateContainerThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/containerThreatDetectionSettings$",
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

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </param>
        public virtual UpdateEventThreatDetectionSettingsRequest UpdateEventThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name)
        {
            return new UpdateEventThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the EventThreatDetectionSettings resource.</summary>
        public class UpdateEventThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateEventThreatDetectionSettings request.</summary>
            public UpdateEventThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the EventThreatDetectionSettings. Formats: *
            /// organizations/{organization}/eventThreatDetectionSettings *
            /// folders/{folder}/eventThreatDetectionSettings * projects/{project}/eventThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.EventThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateEventThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateEventThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/eventThreatDetectionSettings$",
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

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </param>
        public virtual UpdateRapidVulnerabilityDetectionSettingsRequest UpdateRapidVulnerabilityDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name)
        {
            return new UpdateRapidVulnerabilityDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the RapidVulnerabilityDetectionSettings resource.</summary>
        public class UpdateRapidVulnerabilityDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings>
        {
            /// <summary>Constructs a new UpdateRapidVulnerabilityDetectionSettings request.</summary>
            public UpdateRapidVulnerabilityDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
            /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
            /// folders/{folder}/rapidVulnerabilityDetectionSettings *
            /// projects/{project}/rapidVulnerabilityDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.RapidVulnerabilityDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateRapidVulnerabilityDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateRapidVulnerabilityDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/rapidVulnerabilityDetectionSettings$",
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

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </param>
        public virtual UpdateSecurityHealthAnalyticsSettingsRequest UpdateSecurityHealthAnalyticsSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name)
        {
            return new UpdateSecurityHealthAnalyticsSettingsRequest(service, body, name);
        }

        /// <summary>Update the SecurityHealthAnalyticsSettings resource.</summary>
        public class UpdateSecurityHealthAnalyticsSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings>
        {
            /// <summary>Constructs a new UpdateSecurityHealthAnalyticsSettings request.</summary>
            public UpdateSecurityHealthAnalyticsSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
            /// organizations/{organization}/securityHealthAnalyticsSettings *
            /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.SecurityHealthAnalyticsSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateSecurityHealthAnalyticsSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateSecurityHealthAnalyticsSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/securityHealthAnalyticsSettings$",
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

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </param>
        public virtual UpdateVirtualMachineThreatDetectionSettingsRequest UpdateVirtualMachineThreatDetectionSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name)
        {
            return new UpdateVirtualMachineThreatDetectionSettingsRequest(service, body, name);
        }

        /// <summary>Update the VirtualMachineThreatDetectionSettings resource.</summary>
        public class UpdateVirtualMachineThreatDetectionSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings>
        {
            /// <summary>Constructs a new UpdateVirtualMachineThreatDetectionSettings request.</summary>
            public UpdateVirtualMachineThreatDetectionSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
            /// organizations/{organization}/virtualMachineThreatDetectionSettings *
            /// folders/{folder}/virtualMachineThreatDetectionSettings *
            /// projects/{project}/virtualMachineThreatDetectionSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.VirtualMachineThreatDetectionSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateVirtualMachineThreatDetectionSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateVirtualMachineThreatDetectionSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/virtualMachineThreatDetectionSettings$",
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

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="name">
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </param>
        public virtual UpdateWebSecurityScannerSettingsRequest UpdateWebSecurityScannerSettings(Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name)
        {
            return new UpdateWebSecurityScannerSettingsRequest(service, body, name);
        }

        /// <summary>Update the WebSecurityScannerSettings resource.</summary>
        public class UpdateWebSecurityScannerSettingsRequest : SecurityCommandCenterBaseServiceRequest<Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings>
        {
            /// <summary>Constructs a new UpdateWebSecurityScannerSettings request.</summary>
            public UpdateWebSecurityScannerSettingsRequest(Google.Apis.Services.IClientService service, Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings body, string name) : base(service)
            {
                Name = name;
                Body = body;
                InitParameters();
            }

            /// <summary>
            /// The resource name of the WebSecurityScannerSettings. Formats: *
            /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
            /// projects/{project}/webSecurityScannerSettings
            /// </summary>
            [Google.Apis.Util.RequestParameterAttribute("name", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string Name { get; private set; }

            /// <summary>The list of fields to be updated.</summary>
            [Google.Apis.Util.RequestParameterAttribute("updateMask", Google.Apis.Util.RequestParameterType.Query)]
            public virtual object UpdateMask { get; set; }

            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.SecurityCommandCenter.v1beta2.Data.WebSecurityScannerSettings Body { get; set; }

            /// <summary>Returns the body of the request.</summary>
            protected override object GetBody() => Body;

            /// <summary>Gets the method name.</summary>
            public override string MethodName => "updateWebSecurityScannerSettings";

            /// <summary>Gets the HTTP method.</summary>
            public override string HttpMethod => "PATCH";

            /// <summary>Gets the REST path.</summary>
            public override string RestPath => "v1beta2/{+name}";

            /// <summary>Initializes UpdateWebSecurityScannerSettings parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();
                RequestParameters.Add("name", new Google.Apis.Discovery.Parameter
                {
                    Name = "name",
                    IsRequired = true,
                    ParameterType = "path",
                    DefaultValue = null,
                    Pattern = @"^projects/[^/]+/webSecurityScannerSettings$",
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
    }
}
namespace Google.Apis.SecurityCommandCenter.v1beta2.Data
{
    /// <summary>Represents an access event.</summary>
    public class Access : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Caller's IP address, such as "1.1.1.1".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIp")]
        public virtual string CallerIp { get; set; }

        /// <summary>The caller IP's geolocation, which identifies where the call came from.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("callerIpGeo")]
        public virtual Geolocation CallerIpGeo { get; set; }

        /// <summary>The method that the service account called, e.g. "SetIamPolicy".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methodName")]
        public virtual string MethodName { get; set; }

        /// <summary>
        /// Associated email, such as "foo@google.com". The email address of the authenticated user (or service account
        /// on behalf of third party principal) making the request. For third party identity callers, the
        /// `principal_subject` field is populated instead of this field. For privacy reasons, the principal email
        /// address is sometimes redacted. For more information, see [Caller identities in audit
        /// logs](https://cloud.google.com/logging/docs/audit#user-id).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. As compared to `principal_email`,
        /// supports principals that aren't associated with email addresses, such as third party principals. For most
        /// identities, the format will be `principal://iam.googleapis.com/{identity pool name}/subjects/{subject}`
        /// except for some GKE identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy
        /// format `serviceAccount:{identity pool name}[{subject}]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>
        /// Identity delegation history of an authenticated service account that makes the request. It contains
        /// information on the real authorities that try to access GCP resources by delegating on a service account.
        /// When multiple authorities are present, they are guaranteed to be sorted based on the original ordering of
        /// the identity delegation events.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountDelegationInfo")]
        public virtual System.Collections.Generic.IList<ServiceAccountDelegationInfo> ServiceAccountDelegationInfo { get; set; }

        /// <summary>
        /// The name of the service account key used to create or exchange credentials for authenticating the service
        /// account making the request. This is a scheme-less URI full resource name. For example:
        /// "//iam.googleapis.com/projects/{PROJECT_ID}/serviceAccounts/{ACCOUNT}/keys/{key}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccountKeyName")]
        public virtual string ServiceAccountKeyName { get; set; }

        /// <summary>
        /// This is the API service that the service account made a call to, e.g. "iam.googleapis.com"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceName")]
        public virtual string ServiceName { get; set; }

        /// <summary>
        /// What kind of user agent is associated, e.g. operating system shells, embedded or stand-alone applications,
        /// etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userAgentFamily")]
        public virtual string UserAgentFamily { get; set; }

        /// <summary>
        /// A string representing a username. This is likely not an IAM principal. For instance, this may be the system
        /// user name if the finding is VM-related, or this may be some type of application login user name, depending
        /// on the type of finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Conveys information about a Kubernetes access review (e.g. kubectl auth can-i ...) that was involved in a
    /// finding.
    /// </summary>
    public class AccessReview : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Group is the API Group of the Resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("group")]
        public virtual string Group { get; set; }

        /// <summary>Name is the name of the resource being requested. Empty means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Namespace of the action being requested. Currently, there is no distinction between no namespace and all
        /// namespaces. Both are represented by "" (empty).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>Resource is the optional resource type requested. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>Subresource is the optional subresource type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subresource")]
        public virtual string Subresource { get; set; }

        /// <summary>
        /// Verb is a Kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy. "*" means
        /// all.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("verb")]
        public virtual string Verb { get; set; }

        /// <summary>Version is the API Version of the Resource. "*" means all.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A finding that is associated with this node in the exposure path.</summary>
    public class AssociatedFinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Canonical name of the associated findings. Example: organizations/123/sources/456/findings/789
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalFindingName")]
        public virtual string CanonicalFindingName { get; set; }

        /// <summary>The additional taxonomy group within findings from a given source.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingCategory")]
        public virtual string FindingCategory { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains compliance information about a security standard indicating unmet recommendations.</summary>
    public class Compliance : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Policies within the standard/benchmark e.g. A.12.4.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ids")]
        public virtual System.Collections.Generic.IList<string> Ids { get; set; }

        /// <summary>Refers to industry wide standards or benchmarks e.g. "cis", "pci", "owasp", etc.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("standard")]
        public virtual string Standard { get; set; }

        /// <summary>Version of the standard/benchmark e.g. 1.1</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configuration of a module.</summary>
    public class Config : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The state of enablement for the module at its level of the resource hierarchy.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("moduleEnablementState")]
        public virtual string ModuleEnablementState { get; set; }

        /// <summary>
        /// The configuration value for the module. The absence of this field implies its inheritance from the parent.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual System.Collections.Generic.IDictionary<string, object> Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Contains information about the IP connection associated with the finding.</summary>
    public class Connection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Destination IP address. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationIp")]
        public virtual string DestinationIp { get; set; }

        /// <summary>Destination port. Not present for sockets that are listening and not connected.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destinationPort")]
        public virtual System.Nullable<int> DestinationPort { get; set; }

        /// <summary>IANA Internet Protocol Number such as TCP(6) and UDP(17).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("protocol")]
        public virtual string Protocol { get; set; }

        /// <summary>Source IP address.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceIp")]
        public virtual string SourceIp { get; set; }

        /// <summary>Source port.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourcePort")]
        public virtual System.Nullable<int> SourcePort { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representa a single contact's email address</summary>
    public class Contact : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>An email address e.g. "person123@company.com"</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("email")]
        public virtual string Email { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The details pertaining to specific contacts</summary>
    public class ContactDetails : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of contacts</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IList<Contact> Contacts { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Container associated with the finding.</summary>
    public class Container : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Optional container image id, when provided by the container runtime. Uniquely identifies the container image
        /// launched using a container image digest.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("imageId")]
        public virtual string ImageId { get; set; }

        /// <summary>Container labels, as provided by the container runtime.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>Container name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Container image URI provided when configuring a pod/container. May identify a container image version using
        /// mutable tags.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Container Threat Detection service.</summary>
    public class ContainerThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the ContainerThreatDetectionSettings. Formats: *
        /// organizations/{organization}/containerThreatDetectionSettings *
        /// folders/{folder}/containerThreatDetectionSettings * projects/{project}/containerThreatDetectionSettings *
        /// projects/{project}/locations/{location}/clusters/{cluster}/containerThreatDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account used by Container Threat Detection for scanning. Service accounts are
        /// scoped at the project level meaning this field will be empty at any level above a project.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>CVE stands for Common Vulnerabilities and Exposures. More information: https://cve.mitre.org</summary>
    public class Cve : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Describe Common Vulnerability Scoring System specified at
        /// https://www.first.org/cvss/v3.1/specification-document
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cvssv3")]
        public virtual Cvssv3 Cvssv3 { get; set; }

        /// <summary>The unique identifier for the vulnerability. e.g. CVE-2021-34527</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual string Id { get; set; }

        /// <summary>
        /// Additional information about the CVE. e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("references")]
        public virtual System.Collections.Generic.IList<Reference> References { get; set; }

        /// <summary>Whether upstream fix is available for the CVE.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("upstreamFixAvailable")]
        public virtual System.Nullable<bool> UpstreamFixAvailable { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Common Vulnerability Scoring System version 3.</summary>
    public class Cvssv3 : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// This metric describes the conditions beyond the attacker's control that must exist in order to exploit the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackComplexity")]
        public virtual string AttackComplexity { get; set; }

        /// <summary>
        /// Base Metrics Represents the intrinsic characteristics of a vulnerability that are constant over time and
        /// across user environments. This metric reflects the context by which vulnerability exploitation is possible.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("attackVector")]
        public virtual string AttackVector { get; set; }

        /// <summary>
        /// This metric measures the impact to the availability of the impacted component resulting from a successfully
        /// exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("availabilityImpact")]
        public virtual string AvailabilityImpact { get; set; }

        /// <summary>The base score is a function of the base metric scores.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("baseScore")]
        public virtual System.Nullable<double> BaseScore { get; set; }

        /// <summary>
        /// This metric measures the impact to the confidentiality of the information resources managed by a software
        /// component due to a successfully exploited vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("confidentialityImpact")]
        public virtual string ConfidentialityImpact { get; set; }

        /// <summary>This metric measures the impact to integrity of a successfully exploited vulnerability.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("integrityImpact")]
        public virtual string IntegrityImpact { get; set; }

        /// <summary>
        /// This metric describes the level of privileges an attacker must possess before successfully exploiting the
        /// vulnerability.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("privilegesRequired")]
        public virtual string PrivilegesRequired { get; set; }

        /// <summary>
        /// The Scope metric captures whether a vulnerability in one vulnerable component impacts resources in
        /// components beyond its security scope.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// This metric captures the requirement for a human user, other than the attacker, to participate in the
        /// successful compromise of the vulnerable component.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userInteraction")]
        public virtual string UserInteraction { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents database access information, such as queries. A database may be a sub-resource of an instance (as in
    /// the case of CloudSQL instances or Cloud Spanner instances), or the database instance itself. Some database
    /// resources may not have the full resource name populated because these resource types are not yet supported by
    /// Cloud Asset Inventory (e.g. CloudSQL databases). In these cases only the display name will be provided.
    /// </summary>
    public class Database : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human readable name of the database the user connected to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The target usernames/roles/groups of a SQL privilege grant (not an IAM policy change).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("grantees")]
        public virtual System.Collections.Generic.IList<string> Grantees { get; set; }

        /// <summary>
        /// The full resource name of the database the user connected to, if it is supported by CAI.
        /// (https://google.aip.dev/122#full-resource-names)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The SQL statement associated with the relevant access.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("query")]
        public virtual string Query { get; set; }

        /// <summary>
        /// The username used to connect to the DB. This may not necessarily be an IAM principal, and has no required
        /// format.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("userName")]
        public virtual string UserName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Details of a subscription.</summary>
    public class Details : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The time the subscription has or will end.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; }

        /// <summary>The time the subscription has or will start.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; }

        /// <summary>The type of subscription</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Memory hash detection contributing to the binary family match.</summary>
    public class Detection : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the binary associated with the memory hash signature detection.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual string Binary { get; set; }

        /// <summary>The percentage of memory page hashes in the signature that were matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("percentPagesMatched")]
        public virtual System.Nullable<double> PercentPagesMatched { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a connection between a source node and a destination node in this exposure path.</summary>
    public class Edge : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>This is the resource name of the destination node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("destination")]
        public virtual string Destination { get; set; }

        /// <summary>This is the resource name of the source node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>EnvironmentVariable is a name-value pair to store environment variables for Process.</summary>
    public class EnvironmentVariable : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Environment variable name as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Environment variable value as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("val")]
        public virtual string Val { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Event Threat Detection service.</summary>
    public class EventThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the EventThreatDetectionSettings. Formats: *
        /// organizations/{organization}/eventThreatDetectionSettings * folders/{folder}/eventThreatDetectionSettings *
        /// projects/{project}/eventThreatDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource that has been exfiltrated or exfiltrated_to.</summary>
    public class ExfilResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Subcomponents of the asset that is exfiltrated - these could be URIs used during exfiltration, table names,
        /// databases, filenames, etc. For example, multiple tables may be exfiltrated from the same CloudSQL instance,
        /// or multiple files from the same Cloud Storage bucket.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("components")]
        public virtual System.Collections.Generic.IList<string> Components { get; set; }

        /// <summary>Resource's URI (https://google.aip.dev/122#full-resource-names)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Exfiltration represents a data exfiltration attempt of one or more sources to one or more targets. Sources
    /// represent the source of data that is exfiltrated, and Targets represents the destination the data was copied to.
    /// </summary>
    public class Exfiltration : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// If there are multiple sources, then the data is considered "joined" between them. For instance, BigQuery can
        /// join multiple tables, and each table would be considered a source.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sources")]
        public virtual System.Collections.Generic.IList<ExfilResource> Sources { get; set; }

        /// <summary>
        /// If there are multiple targets, each target would get a complete copy of the "joined" source data.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("targets")]
        public virtual System.Collections.Generic.IList<ExfilResource> Targets { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// File information about the related binary/library used by an executable, or the script used by a script
    /// interpreter
    /// </summary>
    public class File : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Prefix of the file contents as a JSON encoded string. (Currently only populated for Malicious Script
        /// Executed findings.)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contents")]
        public virtual string Contents { get; set; }

        /// <summary>
        /// The length in bytes of the file prefix that was hashed. If hashed_size == size, any hashes reported
        /// represent the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("hashedSize")]
        public virtual System.Nullable<long> HashedSize { get; set; }

        /// <summary>True when the hash covers only a prefix of the file.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("partiallyHashed")]
        public virtual System.Nullable<bool> PartiallyHashed { get; set; }

        /// <summary>Absolute path of the file as a JSON encoded string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("path")]
        public virtual string Path { get; set; }

        /// <summary>
        /// SHA256 hash of the first hashed_size bytes of the file encoded as a hex string. If hashed_size == size,
        /// sha256 represents the SHA256 hash of the entire file.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sha256")]
        public virtual string Sha256 { get; set; }

        /// <summary>Size of the file in bytes.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("size")]
        public virtual System.Nullable<long> Size { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data like security, risk, health, or
    /// privacy, that is ingested into Security Command Center for presentation, notification, analysis, policy testing,
    /// and enforcement. For example, a cross-site scripting (XSS) vulnerability in an App Engine application is a
    /// finding.
    /// </summary>
    public class Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Access details associated to the Finding, such as more information on the caller, which method was accessed,
        /// from where, etc.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("access")]
        public virtual Access Access { get; set; }

        /// <summary>
        /// The canonical name of the finding. It's either
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}" or
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}", depending on the closest CRM ancestor
        /// of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The additional taxonomy group within findings from a given source. This field is immutable after creation
        /// time. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>Contains compliance information for security standards associated to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("compliances")]
        public virtual System.Collections.Generic.IList<Compliance> Compliances { get; set; }

        /// <summary>Contains information about the IP connection associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("connections")]
        public virtual System.Collections.Generic.IList<Connection> Connections { get; set; }

        /// <summary>
        /// Output only. Map containing the points of contact for the given finding. The key represents the type of
        /// contact, while the value contains a list of all the contacts that pertain. Please refer to:
        /// https://cloud.google.com/resource-manager/docs/managing-notification-contacts#notification-categories {
        /// "security": { "contacts": [ { "email": "person1@company.com" }, { "email": "person2@company.com" } ] } }
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("contacts")]
        public virtual System.Collections.Generic.IDictionary<string, ContactDetails> Contacts { get; set; }

        /// <summary>
        /// Containers associated with the finding. containers provides information for both Kubernetes and
        /// non-Kubernetes containers.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>Database associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("database")]
        public virtual Database Database { get; set; }

        /// <summary>Contains more detail about the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// The time the finding was first detected. If an existing finding is updated, then this is the time the update
        /// occurred. For example, if the finding represents an open firewall, this property captures the time the
        /// detector believes the firewall became open. The accuracy is determined by the detector. If the finding is
        /// later resolved, then this time reflects when the finding was resolved. This must not be set to a value
        /// greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>Represents exfiltration associated with the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exfiltration")]
        public virtual Exfiltration Exfiltration { get; set; }

        /// <summary>
        /// Output only. Third party SIEM/SOAR fields within SCC, contains external system information and external
        /// system finding fields.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystems")]
        public virtual System.Collections.Generic.IDictionary<string, GoogleCloudSecuritycenterV1ExternalSystem> ExternalSystems { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>File associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("files")]
        public virtual System.Collections.Generic.IList<File> Files { get; set; }

        /// <summary>The class of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("findingClass")]
        public virtual string FindingClass { get; set; }

        /// <summary>Represents IAM bindings associated with the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("iamBindings")]
        public virtual System.Collections.Generic.IList<IamBinding> IamBindings { get; set; }

        /// <summary>
        /// Represents what's commonly known as an Indicator of compromise (IoC) in computer forensics. This is an
        /// artifact observed on a network or in an operating system that, with high confidence, indicates a computer
        /// intrusion. Reference: https://en.wikipedia.org/wiki/Indicator_of_compromise
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("indicator")]
        public virtual Indicator Indicator { get; set; }

        /// <summary>Kubernetes resources associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kubernetes")]
        public virtual Kubernetes Kubernetes { get; set; }

        /// <summary>
        /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mitreAttack")]
        public virtual MitreAttack MitreAttack { get; set; }

        /// <summary>
        /// Indicates the mute state of a finding (either muted, unmuted or undefined). Unlike other attributes of a
        /// finding, a finding provider shouldn't set the value of mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mute")]
        public virtual string Mute { get; set; }

        /// <summary>
        /// First known as mute_annotation. Records additional information about the mute operation e.g. mute config
        /// that muted the finding, user who muted the finding, etc. Unlike other attributes of a finding, a finding
        /// provider shouldn't set the value of mute.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteInitiator")]
        public virtual string MuteInitiator { get; set; }

        /// <summary>Output only. The most recent time this finding was muted or unmuted.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("muteUpdateTime")]
        public virtual object MuteUpdateTime { get; set; }

        /// <summary>
        /// The relative resource name of this finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Next steps associate to the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextSteps")]
        public virtual string NextSteps { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// Output only. The human readable display name of the finding source such as "Event Threat Detection" or
        /// "Security Health Analytics".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>Represents operating system processes associated with the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("processes")]
        public virtual System.Collections.Generic.IList<Process> Processes { get; set; }

        /// <summary>
        /// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is
        /// for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a
        /// non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is
        /// immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual SecurityMarks SecurityMarks { get; set; }

        /// <summary>The severity of the finding. This field is managed by the source that writes the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Source specific properties. These properties are managed by the source that writes the finding. The key
        /// names in the source_properties map must be between 1 and 255 characters, and must start with a letter and
        /// contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        /// <summary>The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>
        /// Represents vulnerability specific fields like cve, cvss scores etc. CVE stands for Common Vulnerabilities
        /// and Exposures (https://cve.mitre.org/about/)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("vulnerability")]
        public virtual Vulnerability Vulnerability { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of this folder. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        /// <summary>The user defined display name for this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a geographical location for a given access.</summary>
    public class Geolocation : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A CLDR.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("regionCode")]
        public virtual string RegionCode { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Configures how to deliver Findings to BigQuery Instance.</summary>
    public class GoogleCloudSecuritycenterV1BigQueryExport : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The time at which the big query export was created. This field is set by the server and will be
        /// ignored if provided on export on creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The dataset to write findings' updates to. Its format is
        /// "projects/[project_id]/datasets/[bigquery_dataset_id]". BigQuery Dataset unique ID must contain only letters
        /// (a-z, A-Z), numbers (0-9), or underscores (_).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("dataset")]
        public virtual string Dataset { get; set; }

        /// <summary>The description of the export (max of 1024 characters).</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>
        /// Expression that defines the filter to apply across create/update events of findings. The expression is a
        /// list of zero or more restrictions combined via logical operators `AND` and `OR`. Parentheses are supported,
        /// and `OR` has higher precedence than `AND`. Restrictions have the form ` ` and may have a `-` character in
        /// front of them to indicate negation. The fields map to those defined in the corresponding resource. The
        /// supported operators are: * `=` for all value types. * `&amp;gt;`, `&amp;lt;`, `&amp;gt;=`, `&amp;lt;=` for
        /// integer values. * `:`, meaning substring matching, for strings. The supported value types are: * string
        /// literals in quotes. * integer literals without quotes. * boolean literals `true` and `false` without quotes.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the big query export. This field is set by the server
        /// and will be ignored if provided on export creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// The relative resource name of this export. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name. Example format:
        /// "organizations/{organization_id}/bigQueryExports/{export_id}" Example format:
        /// "folders/{folder_id}/bigQueryExports/{export_id}" Example format:
        /// "projects/{project_id}/bigQueryExports/{export_id}" This field is provided in responses, and is ignored when
        /// provided in create requests.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The service account that needs permission to create table, upload data to the big query
        /// dataset.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principal")]
        public virtual string Principal { get; set; }

        /// <summary>
        /// Output only. The most recent time at which the big export was updated. This field is set by the server and
        /// will be ignored if provided on export creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Kubernetes RoleBinding or ClusterRoleBinding.</summary>
    public class GoogleCloudSecuritycenterV1Binding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name for binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The Role or ClusterRole referenced by the binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual Role Role { get; set; }

        /// <summary>Represents the subjects(s) bound to the role. Not always available for PATCH requests.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("subjects")]
        public virtual System.Collections.Generic.IList<Subject> Subjects { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>The response to a BulkMute request. Contains the LRO information.</summary>
    public class GoogleCloudSecuritycenterV1BulkMuteFindingsResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A resource that is exposed as a result of a finding.</summary>
    public class GoogleCloudSecuritycenterV1ExposedResource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Human readable name of the resource that is exposed.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>The ways in which this resource is exposed. Examples: Read, Write</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("methods")]
        public virtual System.Collections.Generic.IList<string> Methods { get; set; }

        /// <summary>
        /// Exposed Resource Name e.g.: `organizations/123/attackExposureResults/456/exposedResources/789`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The name of the resource that is exposed. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>
        /// The resource type of the exposed resource. See:
        /// https://cloud.google.com/asset-inventory/docs/supported-asset-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>How valuable this resource is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceValue")]
        public virtual string ResourceValue { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A path that an attacker could take to reach an exposed resource.</summary>
    public class GoogleCloudSecuritycenterV1ExposurePath : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>A list of the edges between nodes in this exposure path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("edges")]
        public virtual System.Collections.Generic.IList<Edge> Edges { get; set; }

        /// <summary>The leaf node of this exposure path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("exposedResource")]
        public virtual GoogleCloudSecuritycenterV1ExposedResource ExposedResource { get; set; }

        /// <summary>Exposure Path Name e.g.: `organizations/123/attackExposureResults/456/exposurePaths/789`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>A list of nodes that exist in this exposure path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pathNodes")]
        public virtual System.Collections.Generic.IList<PathNode> PathNodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Representation of third party SIEM/SOAR fields within SCC.</summary>
    public class GoogleCloudSecuritycenterV1ExternalSystem : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>References primary/secondary etc assignees in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("assignees")]
        public virtual System.Collections.Generic.IList<string> Assignees { get; set; }

        /// <summary>
        /// The most recent time when the corresponding finding's ticket/tracker was updated in the external system.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalSystemUpdateTime")]
        public virtual object ExternalSystemUpdateTime { get; set; }

        /// <summary>Identifier that's used to track the given finding in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUid")]
        public virtual string ExternalUid { get; set; }

        /// <summary>
        /// External System Name e.g. jira, demisto, etc. e.g.:
        /// `organizations/1234/sources/5678/findings/123456/externalSystems/jira`
        /// `folders/1234/sources/5678/findings/123456/externalSystems/jira`
        /// `projects/1234/sources/5678/findings/123456/externalSystems/jira`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Most recent status of the corresponding finding's ticket/tracker in the external system.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("status")]
        public virtual string Status { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A mute config is a Cloud SCC resource that contains the configuration to mute create/update events of findings.
    /// </summary>
    public class GoogleCloudSecuritycenterV1MuteConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. The time at which the mute config was created. This field is set by the server and will be
        /// ignored if provided on config creation.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>A description of the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("description")]
        public virtual string Description { get; set; }

        /// <summary>The human readable name to be displayed for the mute config.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Required. An expression that defines the filter to apply across create/update events of findings. While
        /// creating a filter string, be mindful of the scope in which the mute configuration is being created. E.g., If
        /// a filter contains project = X but is created under the project = Y scope, it might not match any findings.
        /// The following field and operator combinations are supported: * severity: `=`, `:` * category: `=`, `:` *
        /// resource.name: `=`, `:` * resource.project_name: `=`, `:` * resource.project_display_name: `=`, `:` *
        /// resource.folders.resource_folder: `=`, `:` * resource.parent_name: `=`, `:` * resource.parent_display_name:
        /// `=`, `:` * resource.type: `=`, `:` * finding_class: `=`, `:` * indicator.ip_addresses: `=`, `:` *
        /// indicator.domains: `=`, `:`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("filter")]
        public virtual string Filter { get; set; }

        /// <summary>
        /// Output only. Email address of the user who last edited the mute config. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("mostRecentEditor")]
        public virtual string MostRecentEditor { get; set; }

        /// <summary>
        /// This field will be ignored if provided on config creation. Format
        /// "organizations/{organization}/muteConfigs/{mute_config}" "folders/{folder}/muteConfigs/{mute_config}"
        /// "projects/{project}/muteConfigs/{mute_config}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Output only. The most recent time at which the mute config was updated. This field is set by the server and
        /// will be ignored if provided on config creation or update.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Cloud SCC's Notification</summary>
    public class GoogleCloudSecuritycenterV1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to this notification's Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The human readable name of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The project ID that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The full resource type of the resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("type")]
        public virtual string Type { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// A resource value config is a mapping configuration of user's tag values to resource values. Used by the attack
    /// path simulation.
    /// </summary>
    public class GoogleCloudSecuritycenterV1ResourceValueConfig : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Name for the resource value config</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Apply resource_value only to resources that match resource_type. resource_type will be checked with "AND" of
        /// other resources. E.g. "storage.googleapis.com/Bucket" with resource_value "HIGH" will apply "HIGH" value
        /// only to "storage.googleapis.com/Bucket" resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>Required. Resource value level this expression represents</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceValue")]
        public virtual string ResourceValue { get; set; }

        /// <summary>
        /// Project or folder to scope this config to. For example, "project/456" would apply this config only to
        /// resources in "project/456" scope will be checked with "AND" of other resources.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("scope")]
        public virtual string Scope { get; set; }

        /// <summary>
        /// Required. Tag values combined with AND to check against. Values in the form "tagValues/123" E.g. [
        /// "tagValues/123", "tagValues/456", "tagValues/789" ]
        /// https://cloud.google.com/resource-manager/docs/tags/tags-creating-and-managing
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tagValues")]
        public virtual System.Collections.Generic.IList<string> TagValues { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Security Command Center finding. A finding is a record of assessment data (security, risk, health or privacy)
    /// ingested into Security Command Center for presentation, notification, analysis, policy testing, and enforcement.
    /// For example, an XSS vulnerability in an App Engine application is a finding.
    /// </summary>
    public class GoogleCloudSecuritycenterV1p1beta1Finding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the finding. It's either
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}",
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}" or
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}", depending on the closest CRM ancestor
        /// of the resource associated with the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// The additional taxonomy group within findings from a given source. This field is immutable after creation
        /// time. Example: "XSS_FLASH_INJECTION"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("category")]
        public virtual string Category { get; set; }

        /// <summary>The time at which the finding was created in Security Command Center.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("createTime")]
        public virtual object CreateTime { get; set; }

        /// <summary>
        /// The time at which the event took place, or when an update to the finding occurred. For example, if the
        /// finding represents an open firewall it would capture the time the detector believes the firewall became
        /// open. The accuracy is determined by the detector. If the finding were to be resolved afterward, this time
        /// would reflect when the finding was resolved. Must not be set to a value greater than the current timestamp.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("eventTime")]
        public virtual object EventTime { get; set; }

        /// <summary>
        /// The URI that, if available, points to a web page outside of Security Command Center where additional
        /// information about the finding can be found. This field is guaranteed to be either empty or a well formed
        /// URL.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("externalUri")]
        public virtual string ExternalUri { get; set; }

        /// <summary>
        /// The relative resource name of this finding. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Example:
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The relative resource name of the source the finding belongs to. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name This field is immutable after
        /// creation time. For example: "organizations/{organization_id}/sources/{source_id}"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>
        /// For findings on Google Cloud resources, the full resource name of the Google Cloud resource this finding is
        /// for. See: https://cloud.google.com/apis/design/resource_names#full_resource_name When the finding is for a
        /// non-Google Cloud resource, the resourceName can be a customer or partner defined string. This field is
        /// immutable after creation time.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceName")]
        public virtual string ResourceName { get; set; }

        /// <summary>
        /// Output only. User specified security marks. These marks are entirely managed by the user and come from the
        /// SecurityMarks resource that belongs to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("securityMarks")]
        public virtual GoogleCloudSecuritycenterV1p1beta1SecurityMarks SecurityMarks { get; set; }

        /// <summary>The severity of the finding. This field is managed by the source that writes the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("severity")]
        public virtual string Severity { get; set; }

        /// <summary>
        /// Source specific properties. These properties are managed by the source that writes the finding. The key
        /// names in the source_properties map must be between 1 and 255 characters, and must start with a letter and
        /// contain alphanumeric characters or underscores only.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("sourceProperties")]
        public virtual System.Collections.Generic.IDictionary<string, object> SourceProperties { get; set; }

        /// <summary>The state of the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Message that contains the resource name and display name of a folder resource.</summary>
    public class GoogleCloudSecuritycenterV1p1beta1Folder : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Full resource name of this folder. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolder")]
        public virtual string ResourceFolder { get; set; }

        /// <summary>The user defined display name for this folder.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceFolderDisplayName")]
        public virtual string ResourceFolderDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Security Command Center's Notification</summary>
    public class GoogleCloudSecuritycenterV1p1beta1NotificationMessage : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If it's a Finding based notification config, this field will be populated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("finding")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Finding Finding { get; set; }

        /// <summary>Name of the notification config that generated current notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("notificationConfigName")]
        public virtual string NotificationConfigName { get; set; }

        /// <summary>The Cloud resource tied to the notification.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual GoogleCloudSecuritycenterV1p1beta1Resource Resource { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Information related to the Google Cloud resource.</summary>
    public class GoogleCloudSecuritycenterV1p1beta1Resource : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Output only. Contains a Folder message for each folder in the assets ancestry. The first folder is the
        /// deepest nested folder, and the last folder is the folder directly under the Organization.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("folders")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1p1beta1Folder> Folders { get; set; }

        /// <summary>
        /// The full resource name of the resource. See:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The full resource name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parent")]
        public virtual string Parent { get; set; }

        /// <summary>The human readable name of resource's parent.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentDisplayName")]
        public virtual string ParentDisplayName { get; set; }

        /// <summary>The full resource name of project that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("project")]
        public virtual string Project { get; set; }

        /// <summary>The project id that the resource belongs to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectDisplayName")]
        public virtual string ProjectDisplayName { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Response of asset discovery run</summary>
    public class GoogleCloudSecuritycenterV1p1beta1RunAssetDiscoveryResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The duration between asset discovery run start and end</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("duration")]
        public virtual object Duration { get; set; }

        /// <summary>The state of an asset discovery run.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("state")]
        public virtual string State { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class GoogleCloudSecuritycenterV1p1beta1SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. Examples: "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
        /// "projects/{project_number}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Mutable user specified security marks belonging to the parent resource. Constraints are as follows: * Keys
        /// and values are treated as case insensitive * Keys must be between 1 - 256 characters (inclusive) * Keys must
        /// be letters, numbers, underscores, or dashes * Values have leading and trailing whitespace trimmed, remaining
        /// characters must be between 1 - 4096 characters (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        /// <summary>
        /// The relative resource name of the SecurityMarks. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
        /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents a particular IAM binding, which captures a member's role addition, removal, or state.
    /// </summary>
    public class IamBinding : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The action that was performed on a Binding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("action")]
        public virtual string Action { get; set; }

        /// <summary>A single identity requesting access for a Cloud Platform resource, e.g. "foo@google.com".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("member")]
        public virtual string Member { get; set; }

        /// <summary>
        /// Role that is assigned to "members". For example, "roles/viewer", "roles/editor", or "roles/owner".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("role")]
        public virtual string Role { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Represents what's commonly known as an Indicator of compromise (IoC) in computer forensics. This is an artifact
    /// observed on a network or in an operating system that, with high confidence, indicates a computer intrusion.
    /// Reference: https://en.wikipedia.org/wiki/Indicator_of_compromise
    /// </summary>
    public class Indicator : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of domains associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("domains")]
        public virtual System.Collections.Generic.IList<string> Domains { get; set; }

        /// <summary>List of ip addresses associated to the Finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddresses")]
        public virtual System.Collections.Generic.IList<string> IpAddresses { get; set; }

        /// <summary>
        /// The list of matched signatures indicating that the given process is present in the environment.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("signatures")]
        public virtual System.Collections.Generic.IList<ProcessSignature> Signatures { get; set; }

        /// <summary>The list of URIs associated to the Findings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uris")]
        public virtual System.Collections.Generic.IList<string> Uris { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes related attributes.</summary>
    public class Kubernetes : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// Provides information on any Kubernetes access reviews (i.e. privilege checks) relevant to the finding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("accessReviews")]
        public virtual System.Collections.Generic.IList<AccessReview> AccessReviews { get; set; }

        /// <summary>
        /// Provides Kubernetes role binding information for findings that involve RoleBindings or ClusterRoleBindings.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("bindings")]
        public virtual System.Collections.Generic.IList<GoogleCloudSecuritycenterV1Binding> Bindings { get; set; }

        /// <summary>
        /// GKE Node Pools associated with the finding. This field will contain NodePool information for each Node, when
        /// it is available.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodePools")]
        public virtual System.Collections.Generic.IList<NodePool> NodePools { get; set; }

        /// <summary>Provides Kubernetes Node information.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>
        /// Kubernetes Pods associated with the finding. This field will contain Pod records for each container that is
        /// owned by a Pod.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pods")]
        public virtual System.Collections.Generic.IList<Pod> Pods { get; set; }

        /// <summary>Provides Kubernetes role information for findings that involve Roles or ClusterRoles.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("roles")]
        public virtual System.Collections.Generic.IList<Role> Roles { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// Label represents a generic name=value label. Label has separate name and value fields to support filtering with
    /// contains().
    /// </summary>
    public class Label : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Label name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Label value.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("value")]
        public virtual string Value { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to memory page hashes.</summary>
    public class MemoryHashSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The binary family.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binaryFamily")]
        public virtual string BinaryFamily { get; set; }

        /// <summary>The list of memory hash detections contributing to the binary family match.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("detections")]
        public virtual System.Collections.Generic.IList<Detection> Detections { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// MITRE ATT&amp;amp;CK tactics and techniques related to this finding. See: https://attack.mitre.org
    /// </summary>
    public class MitreAttack : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Additional MITRE ATT&amp;CK tactics related to this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTactics")]
        public virtual System.Collections.Generic.IList<string> AdditionalTactics { get; set; }

        /// <summary>
        /// Additional MITRE ATT&amp;amp;CK techniques related to this finding, if any, along with any of their
        /// respective parent techniques.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("additionalTechniques")]
        public virtual System.Collections.Generic.IList<string> AdditionalTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK tactic most closely represented by this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTactic")]
        public virtual string PrimaryTactic { get; set; }

        /// <summary>
        /// The MITRE ATT&amp;amp;CK technique most closely represented by this finding, if any. primary_techniques is a
        /// repeated field because there are multiple levels of MITRE ATT&amp;amp;CK techniques. If the technique most
        /// closely represented by this finding is a sub-technique (e.g. `SCANNING_IP_BLOCKS`), both the sub-technique
        /// and its parent technique(s) will be listed (e.g. `SCANNING_IP_BLOCKS`, `ACTIVE_SCANNING`).
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("primaryTechniques")]
        public virtual System.Collections.Generic.IList<string> PrimaryTechniques { get; set; }

        /// <summary>The MITRE ATT&amp;CK version referenced by the above fields. E.g. "8".</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("version")]
        public virtual string Version { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes Nodes associated with the finding.</summary>
    public class Node : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Full Resource name of the Compute Engine VM running the cluster node.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Provides GKE Node Pool information.</summary>
    public class NodePool : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Kubernetes Node pool name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Nodes associated with the finding.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nodes")]
        public virtual System.Collections.Generic.IList<Node> Nodes { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing onboarding information for a given CRM resource.</summary>
    public class OnboardingState : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the OnboardingState. Format: organizations/{organization}/onboardingState Format:
        /// folders/{folder}/onboardingState Format: projects/{project}/onboardingState
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// Describes the level a given organization, folder, or project is onboarded with SCC. If the resource wasn't
        /// onboarded, NOT_FOUND would have been thrown.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onboardingLevel")]
        public virtual string OnboardingLevel { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents one point that an attacker passes through in this exposure path.</summary>
    public class PathNode : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The findings associated with this node in the exposure path.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("associatedFindings")]
        public virtual System.Collections.Generic.IList<AssociatedFinding> AssociatedFindings { get; set; }

        /// <summary>Human readable name of this resource.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("displayName")]
        public virtual string DisplayName { get; set; }

        /// <summary>
        /// The name of the resource at this point in the exposure path. The format of the name is:
        /// https://cloud.google.com/apis/design/resource_names#full_resource_name
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resource")]
        public virtual string Resource { get; set; }

        /// <summary>
        /// The resource type of this resource. See: https://cloud.google.com/asset-inventory/docs/supported-asset-types
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("resourceType")]
        public virtual string ResourceType { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes Pod.</summary>
    public class Pod : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Pod containers associated with this finding, if any.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("containers")]
        public virtual System.Collections.Generic.IList<Container> Containers { get; set; }

        /// <summary>Pod labels. For Kubernetes containers, these are applied to the container.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IList<Label> Labels { get; set; }

        /// <summary>Kubernetes Pod name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Kubernetes Pod namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents an operating system process.</summary>
    public class Process : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Process arguments as JSON encoded strings.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("args")]
        public virtual System.Collections.Generic.IList<string> Args { get; set; }

        /// <summary>True if `args` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("argumentsTruncated")]
        public virtual System.Nullable<bool> ArgumentsTruncated { get; set; }

        /// <summary>File information for the process executable.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("binary")]
        public virtual File Binary { get; set; }

        /// <summary>Process environment variables.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariables")]
        public virtual System.Collections.Generic.IList<EnvironmentVariable> EnvVariables { get; set; }

        /// <summary>True if `env_variables` is incomplete.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("envVariablesTruncated")]
        public virtual System.Nullable<bool> EnvVariablesTruncated { get; set; }

        /// <summary>File information for libraries loaded by the process.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("libraries")]
        public virtual System.Collections.Generic.IList<File> Libraries { get; set; }

        /// <summary>
        /// The process name visible in utilities like `top` and `ps`; it can be accessed via `/proc/[pid]/comm` and
        /// changed with `prctl(PR_SET_NAME)`.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The parent process id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentPid")]
        public virtual System.Nullable<long> ParentPid { get; set; }

        /// <summary>The process id.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("pid")]
        public virtual System.Nullable<long> Pid { get; set; }

        /// <summary>
        /// When the process represents the invocation of a script, `binary` provides information about the interpreter
        /// while `script` provides information about the script file provided to the interpreter.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("script")]
        public virtual File Script { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Indicates what signature matched this process.</summary>
    public class ProcessSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Signature indicating that a binary family was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("memoryHashSignature")]
        public virtual MemoryHashSignature MemoryHashSignature { get; set; }

        /// <summary>Signature indicating that a YARA rule was matched.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRuleSignature")]
        public virtual YaraRuleSignature YaraRuleSignature { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Rapid Vulnerability Detection service.</summary>
    public class RapidVulnerabilityDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the RapidVulnerabilityDetectionSettings. Formats: *
        /// organizations/{organization}/rapidVulnerabilityDetectionSettings *
        /// folders/{folder}/rapidVulnerabilityDetectionSettings *
        /// projects/{project}/rapidVulnerabilityDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Additional Links</summary>
    public class Reference : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Source of the reference e.g. NVD</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("source")]
        public virtual string Source { get; set; }

        /// <summary>
        /// Uri for the mentioned source e.g. https://cve.mitre.org/cgi-bin/cvename.cgi?name=CVE-2021-34527.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("uri")]
        public virtual string Uri { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Kubernetes Role or ClusterRole.</summary>
    public class Role : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Role type.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Role name.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Role namespace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for Security Center.</summary>
    public class SecurityCenterSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The resource name of the project to send logs to. This project must be part of the organization this
        /// resource resides in. The format is `projects/{project_id}`. An empty value disables logging. This value is
        /// only referenced by services that support log sink. Please refer to the documentation for an updated list of
        /// compatible services. This may only be specified for organization level onboarding.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("logSinkProject")]
        public virtual string LogSinkProject { get; set; }

        /// <summary>
        /// The resource name of the SecurityCenterSettings. Format: organizations/{organization}/securityCenterSettings
        /// Format: folders/{folder}/securityCenterSettings Format: projects/{project}/securityCenterSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. Timestamp of when the customer organization was onboarded to SCC.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("onboardingTime")]
        public virtual object OnboardingTime { get; set; }

        /// <summary>
        /// Output only. The organization level service account to be used for security center components.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("orgServiceAccount")]
        public virtual string OrgServiceAccount { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Security Health Analytics service.</summary>
    public class SecurityHealthAnalyticsSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the SecurityHealthAnalyticsSettings. Formats: *
        /// organizations/{organization}/securityHealthAnalyticsSettings *
        /// folders/{folder}/securityHealthAnalyticsSettings * projects/{project}/securityHealthAnalyticsSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The service account used by Security Health Analytics detectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>
    /// User specified security marks that are attached to the parent Security Command Center resource. Security marks
    /// are scoped within a Security Command Center organization -- they can be modified and viewed by all users who
    /// have proper permissions on the organization.
    /// </summary>
    public class SecurityMarks : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The canonical name of the marks. Examples: "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "folders/{folder_id}/assets/{asset_id}/securityMarks"
        /// "projects/{project_number}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "folders/{folder_id}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// "projects/{project_number}/sources/{source_id}/findings/{finding_id}/securityMarks"
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("canonicalName")]
        public virtual string CanonicalName { get; set; }

        /// <summary>
        /// Mutable user specified security marks belonging to the parent resource. Constraints are as follows: * Keys
        /// and values are treated as case insensitive * Keys must be between 1 - 256 characters (inclusive) * Keys must
        /// be letters, numbers, underscores, or dashes * Values have leading and trailing whitespace trimmed, remaining
        /// characters must be between 1 - 4096 characters (inclusive)
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("marks")]
        public virtual System.Collections.Generic.IDictionary<string, string> Marks { get; set; }

        /// <summary>
        /// The relative resource name of the SecurityMarks. See:
        /// https://cloud.google.com/apis/design/resource_names#relative_resource_name Examples:
        /// "organizations/{organization_id}/assets/{asset_id}/securityMarks"
        /// "organizations/{organization_id}/sources/{source_id}/findings/{finding_id}/securityMarks".
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Identity delegation history of an authenticated service account.</summary>
    public class ServiceAccountDelegationInfo : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The email address of a Google account.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalEmail")]
        public virtual string PrincipalEmail { get; set; }

        /// <summary>
        /// A string representing the principal_subject associated with the identity. As compared to `principal_email`,
        /// supports principals that aren't associated with email addresses, such as third party principals. For most
        /// identities, the format will be `principal://iam.googleapis.com/{identity pool name}/subjects/{subject}`
        /// except for some GKE identities (GKE_WORKLOAD, FREEFORM, GKE_HUB_WORKLOAD) that are still in the legacy
        /// format `serviceAccount:{identity pool name}[{subject}]`
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("principalSubject")]
        public virtual string PrincipalSubject { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Represents a Kubernetes Subject.</summary>
    public class Subject : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Authentication type for subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; }

        /// <summary>Name for subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Namespace for subject.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ns")]
        public virtual string Ns { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the state of an organization's subscription.</summary>
    public class Subscription : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The details of the most recent active subscription. If there has never been a subscription this will be
        /// empty.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("details")]
        public virtual Details Details { get; set; }

        /// <summary>The resource name of the subscription. Format: organizations/{organization}/subscription</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>The tier of SCC features this organization currently has access to.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("tier")]
        public virtual string Tier { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Virtual Machine Threat Detection service.</summary>
    public class VirtualMachineThreatDetectionSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the VirtualMachineThreatDetectionSettings. Formats: *
        /// organizations/{organization}/virtualMachineThreatDetectionSettings *
        /// folders/{folder}/virtualMachineThreatDetectionSettings *
        /// projects/{project}/virtualMachineThreatDetectionSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>Output only. The service account used by Virtual Machine Threat Detection detectors.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceAccount")]
        public virtual string ServiceAccount { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Refers to common vulnerability fields e.g. cve, cvss, cwe etc.</summary>
    public class Vulnerability : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>CVE stands for Common Vulnerabilities and Exposures (https://cve.mitre.org/about/)</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("cve")]
        public virtual Cve Cve { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>Resource capturing the settings for the Web Security Scanner service.</summary>
    public class WebSecurityScannerSettings : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>
        /// The configurations including the state of enablement for the service's different modules. The absence of a
        /// module in the map implies its configuration is inherited from its parent's.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("modules")]
        public virtual System.Collections.Generic.IDictionary<string, Config> Modules { get; set; }

        /// <summary>
        /// The resource name of the WebSecurityScannerSettings. Formats: *
        /// organizations/{organization}/webSecurityScannerSettings * folders/{folder}/webSecurityScannerSettings *
        /// projects/{project}/webSecurityScannerSettings
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; }

        /// <summary>
        /// The state of enablement for the service at its level of the resource hierarchy. A DISABLED state will
        /// override all module enablement_states to DISABLED.
        /// </summary>
        [Newtonsoft.Json.JsonPropertyAttribute("serviceEnablementState")]
        public virtual string ServiceEnablementState { get; set; }

        /// <summary>Output only. The time the settings were last updated.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("updateTime")]
        public virtual object UpdateTime { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }

    /// <summary>A signature corresponding to a YARA rule.</summary>
    public class YaraRuleSignature : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The name of the YARA rule.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("yaraRule")]
        public virtual string YaraRule { get; set; }

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
