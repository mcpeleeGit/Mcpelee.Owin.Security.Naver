// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace Mcpelee.Owin.Security.Naver
{
    internal static class Constants
    {
        public const string DefaultAuthenticationType = "Naver";

        internal const string AuthorizationEndpoint = "https://nid.naver.com/oauth2.0/authorize";
        internal const string TokenEndpoint = "https://nid.naver.com/oauth2.0/token";
        internal const string UserInformationEndpoint = "https://openapi.naver.com/v1/nid/me";
    }
}
