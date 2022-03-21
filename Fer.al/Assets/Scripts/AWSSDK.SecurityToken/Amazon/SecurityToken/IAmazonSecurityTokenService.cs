using System;
using System.Runtime.InteropServices;
using Amazon.Runtime;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
	public interface IAmazonSecurityTokenService : IDisposable, ICoreAmazonSTS, IAmazonService
	{
		void AssumeRoleAsync(AssumeRoleRequest request, AmazonServiceCallback<AssumeRoleRequest, AssumeRoleResponse> callback, [Optional] AsyncOptions options);

		void AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, AmazonServiceCallback<AssumeRoleWithSAMLRequest, AssumeRoleWithSAMLResponse> callback, [Optional] AsyncOptions options);

		void AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, AmazonServiceCallback<AssumeRoleWithWebIdentityRequest, AssumeRoleWithWebIdentityResponse> callback, [Optional] AsyncOptions options);

		void DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, AmazonServiceCallback<DecodeAuthorizationMessageRequest, DecodeAuthorizationMessageResponse> callback, [Optional] AsyncOptions options);

		void GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, AmazonServiceCallback<GetAccessKeyInfoRequest, GetAccessKeyInfoResponse> callback, [Optional] AsyncOptions options);

		void GetCallerIdentityAsync(GetCallerIdentityRequest request, AmazonServiceCallback<GetCallerIdentityRequest, GetCallerIdentityResponse> callback, [Optional] AsyncOptions options);

		void GetFederationTokenAsync(GetFederationTokenRequest request, AmazonServiceCallback<GetFederationTokenRequest, GetFederationTokenResponse> callback, [Optional] AsyncOptions options);

		void GetSessionTokenAsync(GetSessionTokenRequest request, AmazonServiceCallback<GetSessionTokenRequest, GetSessionTokenResponse> callback, [Optional] AsyncOptions options);
	}
}
