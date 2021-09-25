using System.Collections.Generic;
using System.Xml.Serialization;

namespace CameraInformation.model
{
	[XmlRoot(ElementName = "Configuration")]
	public class Configuration
	{

		[XmlElement(ElementName = "Servers")]
		public Servers Servers { get; set; }

		[XmlElement(ElementName = "Channels")]
		public Channels Channels { get; set; }

		public List<ChannelInfo> GetChannelInfos()
		{
			return Channels.ChannelInfo;
		}

		public string GetServerNameById(string id)
        {
			foreach (ServerInfo serverInfo in Servers.ServerInfo)
            {
				if (serverInfo.Id.Equals(id))
                {
					return serverInfo.Name;
                }
            }
			return "Неизвестный сервер";
        }
	}
}
