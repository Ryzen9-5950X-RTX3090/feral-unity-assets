using System;
using Rewired.Config;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.HID
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class HIDGyroscope : HIDControllerElementWithDataSet
	{
		internal class xoDNqPyYukPHaalvKDfsSvNgVzQ : FBPUlVOPtUXFfuAtXMDzKNjgpze
		{
			private int czwiIZKyAknjkMciFFJJFgQPSkut;

			private int wLREUfQCezeMvHoFzmQMeqYzcedr;

			public float[] eWkCANcBkaiDxZUsVOlJifJUZgpo
			{
				get
				{
					return null;
				}
			}

			public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> CwiXTYjYEpsCePDSubaxCKamKEGx
			{
				get
				{
					return null;
				}
			}

			public xoDNqPyYukPHaalvKDfsSvNgVzQ(UpdateLoopSetting updateLoopSetting, int valueLength, int eventCapacity)
			{
			}

			public override void Update(UpdateLoopType P_0)
			{
			}

			public void UQootxjXqIDuSdQLreCsJKPkYOm(float[] P_0, float P_1)
			{
			}

			private fsFsHJrfhlKUoloaavsvBeNbHQc dHihwHIJNAbwIXNzkrwAOZTncEW(UpdateLoopType P_0)
			{
				return null;
			}
		}

		internal class YqsjoDOkiSqcvIImjyMvGmFtaRK : fsFsHJrfhlKUoloaavsvBeNbHQc
		{
			private float[] TZMgsvJYjHVFHduTwAMMosvrfOF;

			public float[] eWkCANcBkaiDxZUsVOlJifJUZgpo;

			public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> CwiXTYjYEpsCePDSubaxCKamKEGx;

			private ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> magaMpbhcqHKXwPhgpMcMSonXIt;

			public YqsjoDOkiSqcvIImjyMvGmFtaRK(UpdateLoopType updateLoop, int valueLength, int eventCapacity)
			{
			}

			public void MrPMknIMZzaXDjcXZFUzCeTcWDAs()
			{
			}

			public void ZCQKmvcOXNATzEJVRrhmfgISsVPG(float[] P_0, float P_1)
			{
			}

			public override void Reset()
			{
			}
		}

		public class MHFgKytqZWorXhVxTJLZCCoNZhX : ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX>.TGuloXjPHhMZpLpbUVpnvAAKNDg, IComparable<MHFgKytqZWorXhVxTJLZCCoNZhX>
		{
			public Vector3 eWkCANcBkaiDxZUsVOlJifJUZgpo;

			public float RNhhaBXJSRDVYjlOvGsJHopqhGOD;

			public MHFgKytqZWorXhVxTJLZCCoNZhX()
			{
			}

			public MHFgKytqZWorXhVxTJLZCCoNZhX(float[] rawValues, float deltaTime)
			{
			}

			public void bnteExvucnBsCpxQAJWOTetSFlq(float[] P_0, float P_1)
			{
			}

			public void Set(MHFgKytqZWorXhVxTJLZCCoNZhX P_0)
			{
			}

			public bool Equals(MHFgKytqZWorXhVxTJLZCCoNZhX P_0)
			{
				return default(bool);
			}

			public void Clear()
			{
			}

			public int CompareTo(MHFgKytqZWorXhVxTJLZCCoNZhX other)
			{
				return default(int);
			}
		}

		public float timestamp;

		public readonly float[] lastRawValue;

		public readonly int valueLength;

		private readonly byte[] wuZPrKFhqfAdgfTBtloBkqjVrylu;

		private readonly float[] YfaqzewlXPKFkPwZPpmCBUugDFN;

		private readonly int vUlXhrGGqPAoBatyhmmMclfytPX;

		private readonly int hKTyGPOfFdpmnBQRnpBRLEKDhlKk;

		private readonly Action<byte[], float[]> PDRBnHNQdiYApABXTHhIWvbNQyR;

		private readonly Func<float> AXqBAWcyjZmkDlhCfZNaGLEdhxw;

		public float[] rawValue
		{
			get
			{
				return null;
			}
		}

		public ExpandableArray_DataContainer<MHFgKytqZWorXhVxTJLZCCoNZhX> events
		{
			get
			{
				return null;
			}
		}

		public HIDGyroscope(UpdateLoopSetting updateLoopSetting, byte reportId, HIDInfo hidInfo, int valueLength, int startingEventCapacity, Action<byte[], float[]> calcValueDelegate, Func<float> getSensorDeltaTimeDelegate)
		{
		}

		public override void UpdateValue(NativeBuffer inputReport, float timestamps)
		{
		}
	}
}
