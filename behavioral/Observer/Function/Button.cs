using System;
using System.Collections.Generic;

namespace Observer
{
    // Кнопка - издатель
    class Button
    {
        private List<Action<EventType>> listeners;
        public Button()
        {
            this.listeners = new List<Action<EventType>>();
        }
        public void OnClick(Action<EventType> l)
        {
            this.listeners.Add(l);
        }
        public void Click(EventType e)
        {
            foreach (var l in this.listeners)
            {
                l.Invoke(e);
            }
        }
    }
}