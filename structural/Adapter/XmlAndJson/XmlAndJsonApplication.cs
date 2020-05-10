namespace Adapter
{
    class XmlAndJsonApplication
    {
        public void Run()
        {
            var wc = new WebClient();

            var j = new Json("{ data : 'hello' }");
            wc.GetData(j);

            var x = new Xml("<data>hello</data>");
            var xtj = new XmlToJson(x);
            wc.GetData(xtj);
        }
    }
}