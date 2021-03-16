using System.Xml.Serialization;

namespace XmlApp_with_two_prices
{
    public class price
    {
        [XmlElement("rub")]
        public string rub { get; set; }

        [XmlElement("dol")]
        public string dol { get; set; }
    }
}
