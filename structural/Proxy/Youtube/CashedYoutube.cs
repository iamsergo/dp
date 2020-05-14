using System.Collections.Generic;

namespace Proxy
{
    // Класс - заместитель
    class CashedYoutube : IYoutubeAPI
    {
        private YoutubeClass api;
        private IEnumerable<string> listCashe;
        private string videoCashe;

        public CashedYoutube(YoutubeClass api)
        {
            this.api = api;
        }

        public IEnumerable<string> ListVideos()
        {
            if(this.listCashe == null)
            {
                this.listCashe = this.api.ListVideos();
            }
            return this.listCashe;
        }
        public string GetVideoInfo(int id)
        {
            if(this.videoCashe == null)
            {
                this.videoCashe = this.api.GetVideoInfo(id);
            }
            return this.videoCashe;
        }
        public void DownloadVideo(int id)
        {
            this.api.DownloadVideo(id);
        }
    }
}