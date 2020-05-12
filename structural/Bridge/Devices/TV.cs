namespace Bridge
{
    // ТВ - конкретное устройство
    class TV : IDevice
    {
        private int volume;
        private int channel;
        public void SetVolume(int v)
        {
            System.Console.WriteLine("TV changed!");
            System.Console.WriteLine("Volume[" + this.volume + "]");
            this.volume += v;
        }
        public void SetChannel(int v)
        {
            System.Console.WriteLine("TV changed!");            
            this.channel = v;
            System.Console.WriteLine("Channel[" + this.channel + "]");
        }
    }
}