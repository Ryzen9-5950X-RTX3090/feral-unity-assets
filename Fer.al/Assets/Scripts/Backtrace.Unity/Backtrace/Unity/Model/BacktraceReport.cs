using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Backtrace.Unity.Model
{
	public class BacktraceReport
	{
		[CompilerGenerated]
		private string <Fingerprint>k__BackingField;

		[CompilerGenerated]
		private string <Factor>k__BackingField;

		public readonly Guid Uuid;

		public readonly long Timestamp;

		public readonly bool ExceptionTypeReport;

		public string Classifier;

		public BacktraceSourceCode SourceCode;

		public string Fingerprint
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public string Factor
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Dictionary<string, string> Attributes
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Message
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Exception Exception
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public List<string> AttachmentPaths
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

		public List<BacktraceStackFrame> DiagnosticStack
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

		public BacktraceReport(string message, [Optional] Dictionary<string, string> attributes, [Optional] List<string> attachmentPaths)
		{
		}

		public BacktraceReport(Exception exception, [Optional] Dictionary<string, string> attributes, [Optional] List<string> attachmentPaths)
		{
		}

		internal void AssignSourceCodeToReport(string text)
		{
		}

		private void SetClassifier()
		{
		}

		internal void SetReportFingerPrintForEmptyStackTrace()
		{
		}

		internal BacktraceData ToBacktraceData(Dictionary<string, string> clientAttributes, int gameObjectDepth)
		{
			return null;
		}

		internal void SetStacktraceInformation()
		{
		}

		internal BacktraceReport CreateInnerReport()
		{
			return null;
		}
	}
}
