using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlApp
{
    [XmlRoot("katalog")]

    public class root
    {
        [XmlElement("phone")]

        public List<phone> Children { get; set; }



    }
}
