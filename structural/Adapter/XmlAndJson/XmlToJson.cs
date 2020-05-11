namespace Adapter
{
    class XmlToJson : Json
    {
        public XmlToJson(Xml xml) : base("{ data : '" + xml.XML + "' }") {}
    }
}