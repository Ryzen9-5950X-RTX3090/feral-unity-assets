using System.Reflection;
using ThisOtherThing.UI.Shapes;
using UnityEngine;

namespace ThisOtherThing.Utils.Animation
{
	[ExecuteInEditMode]
	public class ValueSetter2 : MonoBehaviour
	{
		public static BindingFlags binding;

		public int FieldType;

		public bool IsInArray;

		public int ArrayItemIndex;

		public bool IsInClass;

		public string TargetTypeName;

		public string TargetFieldName;

		public string FieldName;

		public string ArrayFieldName;

		public string TargetClassFieldName;

		public string ClassFieldName;

		public float FloatValue;

		public Color ColorValue;

		private float cachedFloatValue;

		private Color cachedColorValue;

		private bool cachedBoolValue;

		private IShape target;

		private object targetField;

		private FieldInfo fieldInfo;

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateCachedReferences()
		{
		}
	}
}
