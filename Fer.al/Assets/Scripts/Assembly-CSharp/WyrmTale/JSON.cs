using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;

namespace WyrmTale
{
	public class JSON
	{
		private sealed class _JSON
		{
			private sealed class Parser : IDisposable
			{
				private enum TOKEN
				{
					NONE,
					CURLY_OPEN,
					CURLY_CLOSE,
					SQUARED_OPEN,
					SQUARED_CLOSE,
					COLON,
					COMMA,
					STRING,
					NUMBER,
					TRUE,
					FALSE,
					NULL
				}

				private const string WHITE_SPACE = " \t\n\r";

				private const string WORD_BREAK = " \t\n\r{}[],:\"";

				private StringReader json;

				private char PeekChar
				{
					get
					{
						return default(char);
					}
				}

				private char NextChar
				{
					get
					{
						return default(char);
					}
				}

				private string NextWord
				{
					get
					{
						return null;
					}
				}

				private TOKEN NextToken
				{
					get
					{
						return default(TOKEN);
					}
				}

				private Parser(string jsonString)
				{
				}

				public static JSON Parse(string jsonString)
				{
					return null;
				}

				public void Dispose()
				{
				}

				private JSON ParseObject()
				{
					return null;
				}

				private List<object> ParseArray()
				{
					return null;
				}

				private object ParseValue()
				{
					return null;
				}

				private object ParseByToken(TOKEN token)
				{
					return null;
				}

				private string ParseString()
				{
					return null;
				}

				private object ParseNumber()
				{
					return null;
				}

				private void EatWhitespace()
				{
				}
			}

			private sealed class Serializer
			{
				private StringBuilder builder;

				private Serializer()
				{
				}

				public static string Serialize(JSON obj)
				{
					return null;
				}

				private void SerializeValue(object value)
				{
				}

				private void SerializeObject(JSON obj)
				{
				}

				private void SerializeDictionary(IDictionary obj)
				{
				}

				private void SerializeArray(IList anArray)
				{
				}

				private void SerializeString(string str)
				{
				}

				private void SerializeOther(object value)
				{
				}
			}

			public static JSON Deserialize(string json)
			{
				return null;
			}

			public static string Serialize(JSON obj)
			{
				return null;
			}
		}

		public string originalJSON;

		public Dictionary<string, object> fields;

		public object this[string fieldName]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string serialized
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ToString(string fieldName)
		{
			return null;
		}

		public int ToInt(string fieldName)
		{
			return default(int);
		}

		public float ToFloat(string fieldName)
		{
			return default(float);
		}

		public bool ToBoolean(string fieldName)
		{
			return default(bool);
		}

		public JSON ToJSON(string fieldName)
		{
			return null;
		}

		public static implicit operator Vector2(JSON value)
		{
			return default(Vector2);
		}

		public static explicit operator JSON(Vector2 value)
		{
			return null;
		}

		public static implicit operator Vector3(JSON value)
		{
			return default(Vector3);
		}

		public static explicit operator JSON(Vector3 value)
		{
			return null;
		}

		public static implicit operator Quaternion(JSON value)
		{
			return default(Quaternion);
		}

		public static explicit operator JSON(Quaternion value)
		{
			return null;
		}

		public static implicit operator Color(JSON value)
		{
			return default(Color);
		}

		public static explicit operator JSON(Color value)
		{
			return null;
		}

		public static implicit operator Color32(JSON value)
		{
			return default(Color32);
		}

		public static explicit operator JSON(Color32 value)
		{
			return null;
		}

		public static implicit operator Rect(JSON value)
		{
			return default(Rect);
		}

		public static explicit operator JSON(Rect value)
		{
			return null;
		}

		public T[] ToArray<T>(string fieldName)
		{
			return null;
		}
	}
}
