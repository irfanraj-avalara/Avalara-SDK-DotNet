using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Avalara.SDK.Client
{
    [DataContract]
    public class OpenIdConnectURLs
    {
        public OpenIdConnectURLs()
        {
        }

        [DataMember(Name = "token_endpoint", EmitDefaultValue = true)]
        public string TokenEndpoint { get; set; }
        [DataMember(Name = "device_authorization_endpoint", EmitDefaultValue = true)]
        public string DeviceAuthorizationEndpoint { get; set; }
    }
}
