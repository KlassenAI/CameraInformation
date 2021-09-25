using System.Collections.Generic;
using System.Xml.Serialization;

namespace CameraInformation.model
{
	[XmlRoot(ElementName = "Servers")]
	public class Servers
	{
		[XmlElement(ElementName = "ServerInfo")]
		public List<ServerInfo> ServerInfo { get; set; }
	}
}
