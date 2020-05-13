using System.Collections.Generic;

namespace Composite
{
    // Контейнер компонентов - содержит такие же контейнеры,
    // либо элементарные компоненты
    class SimpleContainer : IComponent
    {
        private List<IComponent> childrens;
        public SimpleContainer()
        {
            this.childrens = new List<IComponent>();
        }
        public void Add(IComponent item)
        {
            this.childrens.Add(item);
        }
        public void Method()
        {
            foreach (var item in this.childrens)
            {
                item.Method();
            }
        }
    }
}