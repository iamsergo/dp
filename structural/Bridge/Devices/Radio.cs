namespace Bridge
{
    // Радио - конкретное устройство
    class Radio : IDevice
    {
        private int volume;
        private int channel;
        public void SetVolume(int v)
        {
            System.Console.WriteLine("Radio changed!");
            System.Console.WriteLine("Volume[" + this.volume + "]");
            this.volume += v;
        }
        public void SetChannel(int v)
        {
            System.Console.WriteLine("Radio changed!");            
            this.channel = v;
            System.Console.WriteLine("Channel[" + this.channel + "]");
        }
    }
}