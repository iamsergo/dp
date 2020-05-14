using System.Collections.Generic;

namespace Proxy
{
    // Основной класс для работы с видео
    class YoutubeClass : IYoutubeAPI
    {
        private List<string> list;
        public YoutubeClass()
        {
            this.list = new List<string>(){
                "ad426dads",
                "ajjh432hh",
                "89fhdsjk2"
            };
        }
        public IEnumerable<string> ListVideos()
        {
            return this.list;
        }
        public string GetVideoInfo(int id)
        {
            return this.list[id];
        }
        public void DownloadVideo(int id)
        {
            System.Console.WriteLine($"Video : {this.list[id]} downloaded!");
        }
    }
}