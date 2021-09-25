using System.Xml.Serialization;

namespace CameraInformation.model
{
	[XmlRoot(ElementName = "ServerInfo")]
	public class ServerInfo
	{
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "Name")]
		public string Name { get; set; }
	}
}
