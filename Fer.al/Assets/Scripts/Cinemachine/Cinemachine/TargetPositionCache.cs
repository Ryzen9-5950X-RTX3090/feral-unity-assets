using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	internal class TargetPositionCache
	{
		public enum Mode
		{
			Disabled,
			Record,
			Playback
		}

		private class CacheCurve
		{
			public struct Item
			{
				public Vector3 Pos;

				public Quaternion Rot;

				public static Item Empty
				{
					get
					{
						return default(Item);
					}
				}

				public static Item Lerp(Item a, Item b, float t)
				{
					return default(Item);
				}
			}

			public float StartTime;

			public float StepSize;

			private List<Item> m_Cache;

			public Item Evaluate(float time)
			{
				return default(Item);
			}
		}

		private class CacheEntry
		{
			private struct RecordingItem
			{
				public float Time;

				public bool IsCut;

				public CacheCurve.Item Item;
			}

			public CacheCurve Curve;

			private List<RecordingItem> RawItems;

			public void AddRawItem(float time, bool isCut, Transform target)
			{
			}
		}

		public struct TimeRange
		{
			public float Start;

			public float End;

			public bool IsEmpty
			{
				get
				{
					return default(bool);
				}
			}

			public static TimeRange Empty
			{
				get
				{
					return default(TimeRange);
				}
			}

			public bool Contains(float time)
			{
				return default(bool);
			}

			public void Include(float time)
			{
			}
		}

		[CompilerGenerated]
		private static bool <UseCache>k__BackingField;

		private static Mode m_CacheMode;

		private static Dictionary<Transform, CacheEntry> m_Cache;

		private static TimeRange m_CacheTimeRange;

		public static bool UseCache
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		public static Mode CacheMode
		{
			get
			{
				return default(Mode);
			}
		}

		public static float CurrentTime
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static int CurrentFrame
		{
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool IsCameraCut
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static bool HasHurrentTime
		{
			get
			{
				return default(bool);
			}
		}

		public static void ClearCache()
		{
		}

		public static Vector3 GetTargetPosition(Transform target)
		{
			return default(Vector3);
		}

		public static Quaternion GetTargetRotation(Transform target)
		{
			return default(Quaternion);
		}
	}
}
