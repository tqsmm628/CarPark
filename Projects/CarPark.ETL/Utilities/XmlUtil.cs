using System.IO;
using System.Xml.Serialization;

namespace CarPark.ETL.Utilities {
    public class XmlUtil {
        public static T ParseFile<T>(string filePath) {
            using(var stream = File.OpenRead(filePath)) {
                return (T) new XmlSerializer(typeof(T)).Deserialize(stream);
            }
        }
    }
}