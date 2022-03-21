using System;
using System.Collections.Generic;

namespace GestureRecognizer
{
	[Serializable]
	public class GestureData
	{
		public List<GestureLine> lines;

		public GestureLine LastLine
		{
			get
			{
				return null;
			}
		}
	}
}
