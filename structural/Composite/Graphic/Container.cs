using System.Collections.Generic;

namespace Composite
{
    // Контейнер графических элементов
    class Container : IGraphic
    {
        private List<IGraphic> children;
        public Container()
        {
            this.children = new List<IGraphic>();
        }
        public void Add(IGraphic item)
        {
            this.children.Add(item);
        }
        public void Move(int x, int y)
        {
            foreach (var item in this.children)
            {
                item.Move(x , y);
            }
        }
        public void Draw()
        {
            foreach (var item in this.children)
            {
                item.Draw();
            }
        }
    }
}