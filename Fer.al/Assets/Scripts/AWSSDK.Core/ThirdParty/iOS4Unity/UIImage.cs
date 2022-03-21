using System;
using System.Runtime.InteropServices;

namespace ThirdParty.iOS4Unity
{
	public class UIImage : NSObject
	{
		private class UIImageDispatcher : NSObject
		{
			private static readonly IntPtr _classHandle;

			public readonly Action<NSError> Action;

			public override IntPtr ClassHandle
			{
				get
				{
					return default(IntPtr);
				}
			}

			static UIImageDispatcher()
			{
			}

			public UIImageDispatcher(Action<NSError> action)
			{
			}
		}

		private const string SelectorName = "__onSaveToPhotoAlbum:";

		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public float CurrentScale
		{
			get
			{
				return default(float);
			}
		}

		public CGSize Size
		{
			get
			{
				return default(CGSize);
			}
		}

		private static extern IntPtr UIImageJPEGRepresentation(IntPtr image, float compressionQuality);

		private static extern IntPtr UIImagePNGRepresentation(IntPtr image);

		private static extern void UIImageWriteToSavedPhotosAlbum(IntPtr image, IntPtr obj, IntPtr selector, IntPtr ctx);

		static UIImage()
		{
		}

		internal UIImage(IntPtr handle)
		{
		}

		public NSData AsJPEG(float compressionQuality = 1f)
		{
			return null;
		}

		public NSData AsPNG()
		{
			return null;
		}

		public static UIImage FromBundle(string name)
		{
			return null;
		}

		public static UIImage FromFile(string filename)
		{
			return null;
		}

		public static UIImage LoadFromData(NSData data)
		{
			return null;
		}

		public static UIImage LoadFromData(NSData data, float scale)
		{
			return null;
		}

		public void SaveToPhotosAlbum([Optional] Action<NSError> callback)
		{
		}
	}
}
