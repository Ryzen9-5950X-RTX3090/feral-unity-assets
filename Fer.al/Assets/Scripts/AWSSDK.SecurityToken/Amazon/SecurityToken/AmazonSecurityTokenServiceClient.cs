using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.SharedInterfaces;
using Amazon.SecurityToken.Model;

namespace Amazon.SecurityToken
{
	public class AmazonSecurityTokenServiceClient : AmazonServiceClient, IAmazonSecurityTokenService, IDisposable, ICoreAmazonSTS, IAmazonService
	{
		private static IServiceMetadata serviceMetadata;

		protected override IServiceMetadata ServiceMetadata
		{
			get
			{
				return null;
			}
		}

		AssumeRoleImmutableCredentials ICoreAmazonSTS.CredentialsFromAssumeRoleAuthentication(string roleArn, string roleSessionName, AssumeRoleAWSCredentialsOptions options)
		{
			return null;
		}

		public AmazonSecurityTokenServiceClient(AWSCredentials credentials)
		{
		}

		public AmazonSecurityTokenServiceClient(AWSCredentials credentials, RegionEndpoint region)
		{
		}

		public AmazonSecurityTokenServiceClient(AWSCredentials credentials, AmazonSecurityTokenServiceConfig clientConfig)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSecurityTokenServiceConfig clientConfig)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
		{
		}

		public AmazonSecurityTokenServiceClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSecurityTokenServiceConfig clientConfig)
		{
		}

		protected override AbstractAWSSigner CreateSigner()
		{
			return null;
		}

		protected override void Dispose(bool disposing)
		{
		}

		internal virtual AssumeRoleResponse AssumeRole(AssumeRoleRequest request)
		{
			return null;
		}

		public virtual void AssumeRoleAsync(AssumeRoleRequest request, AmazonServiceCallback<AssumeRoleRequest, AssumeRoleResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual AssumeRoleWithSAMLResponse AssumeRoleWithSAML(AssumeRoleWithSAMLRequest request)
		{
			return null;
		}

		public virtual void AssumeRoleWithSAMLAsync(AssumeRoleWithSAMLRequest request, AmazonServiceCallback<AssumeRoleWithSAMLRequest, AssumeRoleWithSAMLResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest request)
		{
			return null;
		}

		public virtual void AssumeRoleWithWebIdentityAsync(AssumeRoleWithWebIdentityRequest request, AmazonServiceCallback<AssumeRoleWithWebIdentityRequest, AssumeRoleWithWebIdentityResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual DecodeAuthorizationMessageResponse DecodeAuthorizationMessage(DecodeAuthorizationMessageRequest request)
		{
			return null;
		}

		public virtual void DecodeAuthorizationMessageAsync(DecodeAuthorizationMessageRequest request, AmazonServiceCallback<DecodeAuthorizationMessageRequest, DecodeAuthorizationMessageResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual GetAccessKeyInfoResponse GetAccessKeyInfo(GetAccessKeyInfoRequest request)
		{
			return null;
		}

		public virtual void GetAccessKeyInfoAsync(GetAccessKeyInfoRequest request, AmazonServiceCallback<GetAccessKeyInfoRequest, GetAccessKeyInfoResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual GetCallerIdentityResponse GetCallerIdentity(GetCallerIdentityRequest request)
		{
			return null;
		}

		public virtual void GetCallerIdentityAsync(GetCallerIdentityRequest request, AmazonServiceCallback<GetCallerIdentityRequest, GetCallerIdentityResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual GetFederationTokenResponse GetFederationToken(GetFederationTokenRequest request)
		{
			return null;
		}

		public virtual void GetFederationTokenAsync(GetFederationTokenRequest request, AmazonServiceCallback<GetFederationTokenRequest, GetFederationTokenResponse> callback, [Optional] AsyncOptions options)
		{
		}

		internal virtual GetSessionTokenResponse GetSessionToken()
		{
			return null;
		}

		internal virtual GetSessionTokenResponse GetSessionToken(GetSessionTokenRequest request)
		{
			return null;
		}

		public virtual void GetSessionTokenAsync(AmazonServiceCallback<GetSessionTokenRequest, GetSessionTokenResponse> callback, [Optional] AsyncOptions options)
		{
		}

		public virtual void GetSessionTokenAsync(GetSessionTokenRequest request, AmazonServiceCallback<GetSessionTokenRequest, GetSessionTokenResponse> callback, [Optional] AsyncOptions options)
		{
		}

		[SpecialName]
		IClientConfig IAmazonService.get_Config()
		{
			return null;
		}
	}
}
