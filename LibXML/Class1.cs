using System;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace LibXML
{
    // Класс для работы с XML файлами
    public static class xml
    {
        public static XDocument Serelialize<T>(T source)
        {
            if (source == null) throw new ArgumentNullException($"{source} не должно быть null");
            using (var stream = new MemoryStream())
            {
                var ser = new XmlSerializer(typeof(T));

                ser.Serialize(stream, source);
                stream.Position = 0;

                return XDocument.Load(stream);

            }
        }

        public static T Deserelialize<T>(XDocument source)
        {
            using (var stream = source.CreateReader())
            {
                var ser = new XmlSerializer(typeof(T));
                return (T)ser.Deserialize(stream);
            }
        }

        public static T LoadObjectFromFile<T>(string path)
        {
            var xml = XDocument.Load(path);
            return Deserelialize<T>(xml);
        }

        public static T LoadObjectFromString<T>(string textxml)
        {
            var xml = XDocument.Parse(textxml);
            return Deserelialize<T>(xml);

        }
    }
}


