using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlApp_with_two_prices
{
        [XmlRoot("katalog")]

        public class Root
        {
            [XmlElement("phone")]

            public List<phone> Children { get; set; }

        }

}

