using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Backtrace.Unity.Model.Database
{
	public class BacktraceDatabaseRecord
	{
		[Serializable]
		private struct BacktraceDatabaseRawRecord
		{
			public string Id;

			public string recordName;

			public string dataPath;

			public long size;

			public string hash;

			public List<string> attachments;
		}

		public Guid Id;

		internal bool Locked;

		public string Hash;

		private string _path;

		private string _diagnosticDataJson;

		private int _count;

		internal string RecordPath
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

		internal string DiagnosticDataPath
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

		internal long Size
		{
			[CompilerGenerated]
			get
			{
				return default(long);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal BacktraceData Record
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

		public List<string> Attachments
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

		public bool Duplicated
		{
			get
			{
				return default(bool);
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public BacktraceData BacktraceData
		{
			get
			{
				return null;
			}
		}

		public string BacktraceDataJson()
		{
			return null;
		}

		public string ToJson()
		{
			return null;
		}

		public static BacktraceDatabaseRecord Deserialize(string json)
		{
			return null;
		}

		private BacktraceDatabaseRecord(BacktraceDatabaseRawRecord rawRecord)
		{
		}

		public BacktraceDatabaseRecord(BacktraceData data, string path)
		{
		}

		public bool Save()
		{
			return default(bool);
		}

		internal void DatabasePath(string path)
		{
		}

		private void Save(string json, string destPath)
		{
		}

		public virtual void Increment()
		{
		}

		internal bool Valid()
		{
			return default(bool);
		}

		internal void Delete()
		{
		}

		private void Delete(string path)
		{
		}

		internal static BacktraceDatabaseRecord ReadFromFile(FileInfo file)
		{
			return null;
		}

		private bool IsInsideDatabaseDirectory(string path)
		{
			return default(bool);
		}

		public virtual void Unlock()
		{
		}
	}
}
