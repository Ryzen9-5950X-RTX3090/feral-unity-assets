using System.Collections;

namespace Iss.Data
{
	public class IssObject
	{
		private Hashtable map;

		public void Put(object key, object value)
		{
		}

		public void PutNumber(object key, double value)
		{
		}

		public void PutBool(object key, bool value)
		{
		}

		public void PutList(object key, IList collection)
		{
		}

		public void PutDictionary(object key, IDictionary collection)
		{
		}

		private void PopulateList(IssObject aobj, string key, IList collection)
		{
		}

		private void PopulateDictionary(IssObject aobj, string key, IDictionary collection)
		{
		}

		public object Get(object key)
		{
			return null;
		}

		public string GetString(object key)
		{
			return null;
		}

		public double GetNumber(object key)
		{
			return default(double);
		}

		public bool GetBool(object key)
		{
			return default(bool);
		}

		public IssObject GetObj(object key)
		{
			return null;
		}

		public IssObject GetObj(int key)
		{
			return null;
		}

		public int Size()
		{
			return default(int);
		}

		public ICollection Keys()
		{
			return null;
		}

		public void Remove(object key)
		{
		}
	}
}
