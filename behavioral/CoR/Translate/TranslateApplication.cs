namespace CoR
{
    class TranslateApplication
    {
        public void Run()
        {
            var app = new Middleware();
                                    
            app.Use(new Russian());
            app.Use(new English());
            app.Use(new France());
            
            app.Translate("france");
        }
    }
}