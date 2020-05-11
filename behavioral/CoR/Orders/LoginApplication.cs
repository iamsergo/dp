namespace CoR
{
    class LoginApplication
    {
        public void Run()
        {
            var ac = new Authentication();
            var az = new Authorization();
            var en = new Entrance();


            ac
             .SetNext(az)
             .SetNext(en);

            ac.Handle("12");
        }
    }
}