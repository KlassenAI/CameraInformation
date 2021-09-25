using CameraInformation.model;
using CameraInformation.Services;
using CameraInformation.ViewModels;
using System.Collections.Generic;

namespace CameraInformation.viewmodel
{
    class MainViewModel : BaseViewModel
    {
        private ChannelInfoService Service = new ChannelInfoService();

        private Configuration Configuration { get; set; }

        private List<ChannelInfo> channelInfos;
        public List<ChannelInfo> ChannelInfos 
        { 
            get { return channelInfos; }
            set
            {
                SetProperty(ref channelInfos, value);
                /*
                 * Данная реализация не идеальна, возможно, стоит сделать
                 * по-другому доступ к имени сервера, ибо при таком способе
                 * занимается больше памяти, однако я не смог найти лучшего
                 */
                SetChannelInfosServerNames();
            } 
        }

        public MainViewModel()
        {
            var result = Service.GetRequestConfiguration();
            Configuration = result;
            ChannelInfos = Configuration.GetChannelInfos();
        }

        private void SetChannelInfosServerNames()
        {
            foreach (ChannelInfo channelInfo in channelInfos)
            {
                channelInfo.ServerName = Configuration.GetServerNameById(channelInfo.AttachedToServer);
            }
        }
    }
}
