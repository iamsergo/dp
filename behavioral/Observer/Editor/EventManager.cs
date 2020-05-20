using System.Collections.Generic;

namespace Observer
{
    // Издатель - оповещает об изменениях
    class EventManager
    {
        private Dictionary<string, IEditorListener> listeners;
        public EventManager()
        {
            this.listeners = new Dictionary<string, IEditorListener>();
        }
        public void Subscribe(string type, IEditorListener listener)
        {
            try
            {
                this.listeners.Add(type, listener);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine($"[{type}] has been declarated");
            }
            
        }
        public void Unsubscribe(string type, IEditorListener listener)
        {
            this.listeners.Remove(type, out listener);
        }
        public void Notify(string type, string data)
        {
            foreach (var l in this.listeners.Values)
            {
                l.Update(data);
            }
        }
    }
}