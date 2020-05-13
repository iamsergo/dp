using System.Collections.Generic;

namespace Composite
{
    // Коробка - конейтнер компонентов
    class Box : IOrder
    {
        private List<IOrder> items;
        public Box()
        {
            this.items = new List<IOrder>();
        }
        public void Add(IOrder item)
        {
            this.items.Add(item);
        }
        public int Price()
        {
            int p = 0;
            foreach (var item in this.items)
            {
                p += item.Price();
            }
            return p;
        }
    }
}