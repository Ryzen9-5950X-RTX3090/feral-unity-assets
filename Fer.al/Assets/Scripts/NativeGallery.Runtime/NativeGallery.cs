using System;
using System.Runtime.InteropServices;
using UnityEngine;

public static class NativeGallery
{
	public struct ImageProperties
	{
		public readonly int width;

		public readonly int height;

		public readonly string mimeType;

		public readonly ImageOrientation orientation;

		public ImageProperties(int width, int height, string mimeType, ImageOrientation orientation)
		{
		}
	}

	public struct VideoProperties
	{
		public readonly int width;

		public readonly int height;

		public readonly long duration;

		public readonly float rotation;

		public VideoProperties(int width, int height, long duration, float rotation)
		{
		}
	}

	public enum PermissionType
	{
		Read,
		Write
	}

	public enum Permission
	{
		Denied,
		Granted,
		ShouldAsk
	}

	[Flags]
	public enum MediaType
	{
		Image = 1,
		Video = 2,
		Audio = 4
	}

	public enum ImageOrientation
	{
		Unknown = -1,
		Normal,
		Rotate90,
		Rotate180,
		Rotate270,
		FlipHorizontal,
		Transpose,
		FlipVertical,
		Transverse
	}

	public delegate void MediaSaveCallback(bool success, string path);

	public delegate void MediaPickCallback(string path);

	public delegate void MediaPickMultipleCallback(string[] paths);

	private const bool PermissionFreeMode = true;

	public static Permission CheckPermission(PermissionType permissionType)
	{
		return default(Permission);
	}

	public static Permission RequestPermission(PermissionType permissionType)
	{
		return default(Permission);
	}

	private static void TryExtendLimitedAccessPermission()
	{
	}

	public static bool CanOpenSettings()
	{
		return default(bool);
	}

	public static void OpenSettings()
	{
	}

	public static Permission SaveImageToGallery(byte[] mediaBytes, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	public static Permission SaveImageToGallery(string existingMediaPath, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	public static Permission SaveImageToGallery(Texture2D image, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	public static Permission SaveVideoToGallery(byte[] mediaBytes, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	public static Permission SaveVideoToGallery(string existingMediaPath, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	private static Permission SaveAudioToGallery(byte[] mediaBytes, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	private static Permission SaveAudioToGallery(string existingMediaPath, string album, string filename, [Optional] MediaSaveCallback callback)
	{
		return default(Permission);
	}

	public static bool CanSelectMultipleFilesFromGallery()
	{
		return default(bool);
	}

	public static bool CanSelectMultipleMediaTypesFromGallery()
	{
		return default(bool);
	}

	public static Permission GetImageFromGallery(MediaPickCallback callback, string title = "", string mime = "image/*")
	{
		return default(Permission);
	}

	public static Permission GetVideoFromGallery(MediaPickCallback callback, string title = "", string mime = "video/*")
	{
		return default(Permission);
	}

	public static Permission GetAudioFromGallery(MediaPickCallback callback, string title = "", string mime = "audio/*")
	{
		return default(Permission);
	}

	public static Permission GetMixedMediaFromGallery(MediaPickCallback callback, MediaType mediaTypes, string title = "")
	{
		return default(Permission);
	}

	public static Permission GetImagesFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "image/*")
	{
		return default(Permission);
	}

	public static Permission GetVideosFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "video/*")
	{
		return default(Permission);
	}

	public static Permission GetAudiosFromGallery(MediaPickMultipleCallback callback, string title = "", string mime = "audio/*")
	{
		return default(Permission);
	}

	public static Permission GetMixedMediasFromGallery(MediaPickMultipleCallback callback, MediaType mediaTypes, string title = "")
	{
		return default(Permission);
	}

	public static bool IsMediaPickerBusy()
	{
		return default(bool);
	}

	public static MediaType GetMediaTypeOfFile(string path)
	{
		return default(MediaType);
	}

	private static Permission SaveToGallery(byte[] mediaBytes, string album, string filename, MediaType mediaType, MediaSaveCallback callback)
	{
		return default(Permission);
	}

	private static Permission SaveToGallery(string existingMediaPath, string album, string filename, MediaType mediaType, MediaSaveCallback callback)
	{
		return default(Permission);
	}

	private static void SaveToGalleryInternal(string path, string album, MediaType mediaType, MediaSaveCallback callback)
	{
	}

	private static string GetTemporarySavePath(string filename)
	{
		return null;
	}

	private static Permission GetMediaFromGallery(MediaPickCallback callback, MediaType mediaType, string mime, string title)
	{
		return default(Permission);
	}

	private static Permission GetMultipleMediaFromGallery(MediaPickMultipleCallback callback, MediaType mediaType, string mime, string title)
	{
		return default(Permission);
	}

	private static byte[] GetTextureBytes(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	private static byte[] GetTextureBytesFromCopy(Texture2D texture, bool isJpeg)
	{
		return null;
	}

	public static Texture2D LoadImageAtPath(string imagePath, int maxSize = -1, bool markTextureNonReadable = true, bool generateMipmaps = true, bool linearColorSpace = false)
	{
		return null;
	}

	public static Texture2D GetVideoThumbnail(string videoPath, int maxSize = -1, double captureTimeInSeconds = -1.0, bool markTextureNonReadable = true)
	{
		return null;
	}

	public static ImageProperties GetImageProperties(string imagePath)
	{
		return default(ImageProperties);
	}

	public static VideoProperties GetVideoProperties(string videoPath)
	{
		return default(VideoProperties);
	}
}
