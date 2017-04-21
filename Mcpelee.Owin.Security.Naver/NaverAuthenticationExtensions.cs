// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using Microsoft.Owin.Security;
using Mcpelee.Owin.Security.Naver;

namespace Owin
{
    /// <summary>
    /// Extension methods for using <see cref="NaverAuthenticationMiddleware"/>
    /// </summary>
    public static class NaverAuthenticationExtensions
    {
        /// <summary>
        /// Authenticate users using Naver
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="options">Middleware configuration options</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseNaverAuthentication(this IAppBuilder app, NaverAuthenticationOptions options)
        {
            if (app == null)
            {
                throw new ArgumentNullException("app");
            }
            if (options == null)
            {
                throw new ArgumentNullException("options");
            }

            app.Use(typeof(NaverAuthenticationMiddleware), app, options);
            return app;
        }

        /// <summary>
        /// Authenticate users using Naver
        /// </summary>
        /// <param name="app">The <see cref="IAppBuilder"/> passed to the configuration method</param>
        /// <param name="appId">The appId assigned by Naver</param>
        /// <param name="appSecret">The appSecret assigned by Naver</param>
        /// <returns>The updated <see cref="IAppBuilder"/></returns>
        public static IAppBuilder UseNaverAuthentication(
            this IAppBuilder app,
            string appId,
            string appSecret)
        {
            return UseNaverAuthentication(
                app,
                new NaverAuthenticationOptions
                {
                    AppId = appId,
                    AppSecret = appSecret,
                });
        }
    }
}
