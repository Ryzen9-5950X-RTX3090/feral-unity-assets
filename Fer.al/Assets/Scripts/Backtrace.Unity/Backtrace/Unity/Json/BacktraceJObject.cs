using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Backtrace.Unity.Json
{
	public class BacktraceJObject
	{
		internal readonly Dictionary<string, string> PrimitiveValues;

		internal readonly Dictionary<string, string> UserPrimitives;

		internal readonly Dictionary<string, BacktraceJObject> InnerObjects;

		internal readonly Dictionary<string, object> ComplexObjects;

		public BacktraceJObject()
		{
		}

		public BacktraceJObject(Dictionary<string, string> source)
		{
		}

		public void Add(string key, bool value)
		{
		}

		public void Add(string key, string value)
		{
		}

		public void Add(string key, long value)
		{
		}

		public void Add(string key, BacktraceJObject value)
		{
		}

		public void Add(string key, IEnumerable value)
		{
		}

		public string ToJson()
		{
			return null;
		}

		internal void ToJson(StringBuilder stringBuilder)
		{
		}

		private void AddUserPrimitives(StringBuilder stringBuilder)
		{
		}

		private void AppendPrimitives(StringBuilder stringBuilder)
		{
		}

		private void AppendJObjects(StringBuilder stringBuilder)
		{
		}

		private void AppendComplexValues(StringBuilder stringBuilder)
		{
		}

		private bool ShouldContinueAddingJSONProperties(StringBuilder stringBuilder)
		{
			return default(bool);
		}

		private void AppendKey(string value, StringBuilder builder)
		{
		}

		private void EscapeString(string value, StringBuilder output)
		{
		}
	}
}
