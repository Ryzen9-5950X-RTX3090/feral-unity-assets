using System;
using System.Collections.Generic;

namespace AppsFlyerSDK
{
	public class AppsFlyer : MonoBehaviour
	{
		public static readonly string kAppsFlyerPluginVersion;

		public static string CallBackObjectName;

		private static EventHandler onRequestResponse;

		private static EventHandler onInAppResponse;

		private static EventHandler onDeepLinkReceived;

		public static event EventHandler OnRequestResponse
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event EventHandler OnInAppResponse
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event EventHandler OnDeepLinkReceived
		{
			add
			{
			}
			remove
			{
			}
		}

		public static void initSDK(string devKey, string appID)
		{
		}

		public static void initSDK(string devKey, string appID, MonoBehaviour gameObject)
		{
		}

		public static void startSDK()
		{
		}

		public static void sendEvent(string eventName, Dictionary<string, string> eventValues)
		{
		}

		public static void stopSDK(bool isSDKStopped)
		{
		}

		public static bool isSDKStopped()
		{
			return default(bool);
		}

		public static string getSdkVersion()
		{
			return null;
		}

		public static void setIsDebug(bool shouldEnable)
		{
		}

		public static void setCustomerUserId(string id)
		{
		}

		public static void setAppInviteOneLinkID(string oneLinkId)
		{
		}

		public static void setAdditionalData(Dictionary<string, string> customData)
		{
		}

		public static void setResolveDeepLinkURLs(string[] urls)
		{
		}

		public static void setOneLinkCustomDomain(string[] domains)
		{
		}

		public static void setCurrencyCode(string currencyCode)
		{
		}

		public static void recordLocation(double latitude, double longitude)
		{
		}

		public static void anonymizeUser(bool shouldAnonymizeUser)
		{
		}

		public static string getAppsFlyerId()
		{
			return null;
		}

		public static void setMinTimeBetweenSessions(int seconds)
		{
		}

		public static void setHost(string hostPrefixName, string hostName)
		{
		}

		public static void setUserEmails(EmailCryptType cryptMethod, string[] emails)
		{
		}

		public static void setPhoneNumber(string phoneNumber)
		{
		}

		public static void setSharingFilterForAllPartners()
		{
		}

		public static void setSharingFilter(string[] partners)
		{
		}

		public static void getConversionData(string objectName)
		{
		}

		public static void attributeAndOpenStore(string appID, string campaign, Dictionary<string, string> userParams, MonoBehaviour gameObject)
		{
		}

		public static void recordCrossPromoteImpression(string appID, string campaign, Dictionary<string, string> parameters)
		{
		}

		public static void generateUserInviteLink(Dictionary<string, string> parameters, MonoBehaviour gameObject)
		{
		}

		public static void addPushNotificationDeepLinkPath(string[] paths)
		{
		}

		public static void subscribeForDeepLink()
		{
		}

		public void inAppResponseReceived(string response)
		{
		}

		public void requestResponseReceived(string response)
		{
		}

		public void onDeepLinking(string response)
		{
		}

		private static AppsFlyerRequestEventArgs parseRequestCallback(string response)
		{
			return null;
		}

		public static Dictionary<string, object> CallbackStringToDictionary(string str)
		{
			return null;
		}

		public static void AFLog(string methodName, string str)
		{
		}
	}
}
