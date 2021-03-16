using System.Xml.Serialization;

namespace XmlApp
{
    public class phone
    {
        [XmlElement("company")]
        public string company { get; set; }

        [XmlElement("model")]
        public string model { get; set; }

        [XmlElement("mem_size")]
        public string mem_size { get; set; }

        [XmlElement("price")]
        public string price { get; set; }

    }
}
