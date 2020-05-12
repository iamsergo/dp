namespace Bridge
{
    // Пульт - делегирует работу устройству
    class Remote
    {
        private IDevice device;
        public Remote(IDevice device)
        {
            this.device = device;
        }

        public void SetVolume(int v)
        {
            this.device.SetVolume(v);
        }
        public void SetChannel(int v)
        {
            this.device.SetChannel(v);
        }
    }
}