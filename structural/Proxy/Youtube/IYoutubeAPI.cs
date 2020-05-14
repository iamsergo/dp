using System.Collections.Generic;

namespace Proxy
{
    // Общий интерфейс
    interface IYoutubeAPI
    {
        IEnumerable<string> ListVideos();
        string GetVideoInfo(int id);
        void DownloadVideo(int id);
    }
}