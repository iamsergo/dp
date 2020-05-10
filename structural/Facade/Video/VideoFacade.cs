namespace Facade
{
    // Фасад
    class VideoFacade
    {
        // Логика инкапсулирована
        public void Convert()
        {
            Settings.Setup();
            Image.Create();
            Audio.Create();
            Video.Create();
        }
    }
}