using System.Xml.Serialization;

namespace CameraInformation.model
{
	[XmlRoot(ElementName = "ChannelInfo")]
	public class ChannelInfo
	{
		[XmlAttribute(AttributeName = "Id")]
		public string Id { get; set; }

		[XmlAttribute(AttributeName = "Name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "AttachedToServer")]
		public string AttachedToServer { get; set; }

		[XmlAttribute(AttributeName = "IsSoundOn")]
		public bool IsSoundOn { get; set; }

		[XmlIgnore]
		public string ServerName { get; set; }
	}
}
