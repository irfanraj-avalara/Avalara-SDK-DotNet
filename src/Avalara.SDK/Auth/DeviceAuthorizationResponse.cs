using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// Represents the response from the Device Authorization OAuth2 flow endpoint.
    /// </summary>
    public class DeviceAuthorizationResponse
    {
        /// <summary>
        /// The device verification code.
        /// </summary>
        public string DeviceCode { get; set; }
        /// <summary>
        /// The end-user verification code.
        /// </summary>
        public string UserCode { get; set; }
        /// <summary>
        /// The end-user verification URI on the authorization server. The URI
        /// should be and easy to remember as end-users will be asked to
        /// manually type it into their user-agent..
        /// </summary>
        public string VerificationUrl { get; set; }
        /// <summary>
        /// Optional. A verification URI that includes the "user_code" (or other
        /// information with the same function as the "user_code"), designed for
        /// non-textual transmission.
        /// </summary>
        public string VerificationUrlComplete { get; set; }
        /// <summary>
        /// The lifetime in seconds of the "device_code" and "user_code".
        /// </summary>
        public int Expiry { get; set; }
        /// <summary>
        /// The device verification code.
        /// </summary>
        public int Interval { get; set; }
    }
}
