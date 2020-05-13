namespace Composite
{
    class GraphicApplication
    {
        public void Run()
        {
            Dot d1 = new Dot(0, 0);
            Dot d2 = new Dot(0, 1);
            Dot d3 = new Dot(0, 2);
            Dot d4 = new Dot(0, 3);

            Container c1 = new Container();
            c1.Add(d1);
            c1.Add(d2);

            Container c2 = new Container();
            c2.Add(d3);
            c2.Add(c1);

            Container c3 = new Container();
            c3.Add(d4);
            c3.Add(c2);

            c3.Draw();
            c3.Move(1,1);
        }
    }
}