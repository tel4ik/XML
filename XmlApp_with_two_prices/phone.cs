using System.Xml.Serialization;

namespace XmlApp_with_two_prices
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
        public price[] Price { get; set; }

        [XmlIgnore]
        public string ruble { get => Price[0].rub; }

        [XmlIgnore]
        public string dollar { get => Price[0].dol; }


    }
}
