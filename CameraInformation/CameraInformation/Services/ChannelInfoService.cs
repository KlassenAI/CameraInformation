using CameraInformation.model;
using System.IO;
using System.Net;
using System.Xml.Serialization;

namespace CameraInformation.Services
{
    class ChannelInfoService
    {
        private const string url = "http://demo.macroscop.com/configex?login=root";

        public Configuration GetRequestConfiguration()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();

            XmlSerializer serializer = new XmlSerializer(typeof(Configuration));
            return (Configuration)serializer.Deserialize(responseStream);
        }
    }
}
