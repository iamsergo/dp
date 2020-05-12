namespace Bridge
{
    // Общий интерфейс для всех устройств
    interface IDevice
    {
        void SetVolume(int v);
        void SetChannel(int v);
    }
}