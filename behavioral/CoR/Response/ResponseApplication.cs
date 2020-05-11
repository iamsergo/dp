namespace CoR
{
    class ResponseApplication
    {
        public void Run()
        {
            // Все обработчики - ответчики
            var a = new Auto();
            var b = new Base();
            var c = new Concrete();

            // Настройка следующих
            a.SetNext(b);
            b.SetNext(c);

            // Создание запроса
            a.Handle("not undestand");

            c.SetNext(b);
            b.Handle("aaa");
        }
    }
}