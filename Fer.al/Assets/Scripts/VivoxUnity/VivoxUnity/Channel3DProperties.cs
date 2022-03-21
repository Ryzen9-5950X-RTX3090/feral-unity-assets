namespace VivoxUnity
{
	public sealed class Channel3DProperties
	{
		private readonly int _audibleDistance;

		private readonly int _conversationalDistance;

		private readonly float _audioFadeIntensityByDistance;

		private readonly AudioFadeModel _audioFadeModel;

		public int AudibleDistance
		{
			get
			{
				return default(int);
			}
		}

		public int ConversationalDistance
		{
			get
			{
				return default(int);
			}
		}

		public float AudioFadeIntensityByDistance
		{
			get
			{
				return default(float);
			}
		}

		public AudioFadeModel AudioFadeModel
		{
			get
			{
				return default(AudioFadeModel);
			}
		}

		public Channel3DProperties()
		{
		}

		internal Channel3DProperties(string properties)
		{
		}

		public Channel3DProperties(int audibleDistance, int conversationalDistance, float audioFadeIntensityByDistanceaudio, AudioFadeModel audioFadeModel)
		{
		}

		internal bool IsValid()
		{
			return default(bool);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
