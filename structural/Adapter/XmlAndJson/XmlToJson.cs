namespace Adapter
{
    class XmlToJson : Json
    {
        private Xml xml;
        public XmlToJson(Xml xml)
            : base("{ data : '" + xml.XML + "' }")
        {
            this.xml = xml;
        }
    }
}