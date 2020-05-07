using System;

namespace AbstractFactory
{
    class FurnitureApp
    {
        private IFurniture f;
        private IChair ch;
        private ITable t;
        public FurnitureApp(IFurniture f)
        {
            this.f = f;
        }
        public void CreateFurniture()
        {
            this.ch = this.f.CreateChair();
            this.t  = this.f.CreateTable();
        }
        public void Put()
        {
            this.ch.Put();
            this.t.Put();
        }
    }
}
