using System;
using System.Collections.Generic;

[Serializable]
public class BundleDownloadQueue
{
	public string editorQueueName;

	public BundleQueue queue;

	public List<DownloadingBundle> bundles;
}
