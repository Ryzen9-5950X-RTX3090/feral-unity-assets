using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Backtrace.Unity.Model.JsonData;

namespace Backtrace.Unity.Model
{
	public class BacktraceData
	{
		private string _uuidString;

		public const string Lang = "csharp";

		public readonly string LangVersion;

		public const string Agent = "backtrace-unity";

		public const string AgentVersion = "3.4.0";

		public Dictionary<string, ThreadInformation> ThreadInformations;

		public string MainThread;

		public string[] Classifier;

		public BacktraceSourceCode SourceCode;

		public List<string> Attachments;

		public BacktraceAttributes Attributes;

		public Annotations Annotation;

		public ThreadData ThreadData;

		public int Deduplication;

		public Guid Uuid
		{
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		internal string UuidString
		{
			get
			{
				return null;
			}
		}

		public long Timestamp
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public BacktraceReport Report
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public BacktraceData(BacktraceReport report, [Optional] Dictionary<string, string> clientAttributes, int gameObjectDepth = -1)
		{
		}

		public string ToJson()
		{
			return null;
		}

		private void SetThreadInformations()
		{
		}

		private void SetAttributes(Dictionary<string, string> clientAttributes, int gameObjectDepth)
		{
		}
	}
}
