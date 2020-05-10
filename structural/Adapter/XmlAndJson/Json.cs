namespace Adapter
{
    class Json
    {
        private string json;
        public  string JSON { get { return this.json; } }
        public Json(string json)
        {
            this.json = json;
        }
    }
}