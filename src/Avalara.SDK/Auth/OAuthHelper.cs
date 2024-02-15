using Avalara.SDK.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace Avalara.SDK.Auth
{
    /// <summary>
    /// OAuth2 Helper class for the Device Code Flow.
    /// </summary>
    public class OAuthHelper
    {
        /// <summary>
        /// Initiates the Device Code Flow by calling the /device/authorize endpoint to retrieve the device_code and user_code.
        /// </summary>
        public static DeviceAuthorizationResponse initiateDeviceAuthorizationFlow(string scopes, Configuration config)
        {
            var deviceCodeHelper = new OAuth2DeviceCode(config, scopes);
            return deviceCodeHelper.GetDeviceAuthorizationCode();
        }

        /// <summary>
        /// Initiates the Device Code Flow by calling the /device/authorize endpoint to retrieve the device_code and user_code.
        /// </summary>
        public static TokenResponse getAccessTokenForDeviceFlow(string deviceAuthorizationCode, Configuration config)
        {
            var deviceCodeHelper = new OAuth2DeviceCode(config, null, deviceAuthorizationCode);
            return deviceCodeHelper.GetAccessToken();
        }
    }
}
