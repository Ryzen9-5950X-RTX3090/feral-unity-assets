using System.Collections.Generic;

namespace Prototype.QuickGames
{
	public class PianoSong
	{
		public enum Pitch
		{
			NONE,
			C,
			C_SHARP,
			D,
			D_SHARP,
			E,
			F,
			F_SHARP,
			G,
			G_SHARP,
			A,
			A_SHARP,
			B
		}

		public class Note
		{
			public Pitch pitch;

			public int length;

			public int index;

			public Note(int l)
			{
			}

			public void Set(Pitch p, int l, int idx)
			{
			}
		}

		public class Beat
		{
			public int number;

			public List<Note> notes;

			public Beat(int n)
			{
			}

			public void Add(Pitch pitch, int length, int noteIndex)
			{
			}
		}

		public class Bar
		{
			public int numBeats;

			public Beat[] beats;

			public Bar(int n)
			{
			}

			public void Add(int beatNumber, Pitch pitch, int length, int noteIndex)
			{
			}
		}

		public int bpm;

		public int beat_unit;

		public int beats_per_bar;

		public int numBars;

		public Bar[] bars;

		public PianoSong(int beat_unit, int beats_per_bar, int numBars, int bpm)
		{
		}

		public void Add(int bar, int beat, Pitch pitch, int length, int noteIndex)
		{
		}
	}
}
