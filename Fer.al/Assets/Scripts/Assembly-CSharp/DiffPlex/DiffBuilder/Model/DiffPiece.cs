using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace DiffPlex.DiffBuilder.Model
{
	public class DiffPiece : IEquatable<DiffPiece>
	{
		public ChangeType Type
		{
			[CompilerGenerated]
			get
			{
				return default(ChangeType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int? Position
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

		public string Text
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

		public List<DiffPiece> SubPieces
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

		public DiffPiece(string text, ChangeType type, [Optional] int? position)
		{
		}

		public DiffPiece()
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public bool Equals(DiffPiece other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		private bool SubPiecesEqual(DiffPiece other)
		{
			return default(bool);
		}
	}
}
