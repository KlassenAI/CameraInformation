using System.Collections.Generic;
using System.Xml.Serialization;

namespace CameraInformation.model
{
	[XmlRoot(ElementName = "Channels")]
	public class Channels
	{
		[XmlElement(ElementName = "ChannelInfo")]
		public List<ChannelInfo> ChannelInfo { get; set; }
	}
}
