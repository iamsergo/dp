namespace Proxy
{
    class YoutubeApplication
    {
        public void Run()
        {
            var yservice = new YoutubeClass();
            var yproxy   = new CashedYoutube(yservice);

            var l1 = yproxy.ListVideos();
            var l2 = yproxy.ListVideos();
            var l3 = yproxy.ListVideos();

            System.Console.WriteLine(l1 == l2);
            System.Console.WriteLine(l1 == l3);
        }
    }   
}