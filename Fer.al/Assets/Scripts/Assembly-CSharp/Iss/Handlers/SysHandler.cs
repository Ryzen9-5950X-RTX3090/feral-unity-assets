using System.Xml;

namespace Iss.Handlers
{
	public class SysHandler : IMessageHandler
	{
		private IssClient sfs;

		public SysHandler(IssClient sfs)
		{
		}

		public void HandleMessage(object msgObj, IssClient.XtMsgType type)
		{
		}

		public void HandleApiOK(XmlNode xml)
		{
		}

		public void HandleApiKO(XmlNode xml)
		{
		}

		public void HandleLoginOk(XmlNode xml)
		{
		}

		public void HandleLoginKo(XmlNode xml)
		{
		}

		public void HandleLogout(XmlNode xml)
		{
		}

		public void HandlePublicMessage(XmlNode xml)
		{
		}

		private void HandleRandomKey(XmlNode xml)
		{
		}

		public void DispatchDisconnection()
		{
		}
	}
}
