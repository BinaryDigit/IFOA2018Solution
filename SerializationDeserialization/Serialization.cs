using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace SerializationDeserialization
{
    public delegate string SerializeDelegate(Student student);
    public delegate Student DeserializeDelegate(string serializedStudent);

    public class Serialization
    {
        public static SerializeDelegate Serialize;
        public static DeserializeDelegate Deserialize;
    }

    public class SerializationToXML: ISerialization
    {
        public string Serialize(Student student)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(Student));

            string SerializedStudent = string.Empty;

            using (StringWriter sw = new StringWriter())
            {
                using (XmlWriter xmlWtr = XmlWriter.Create(sw))
                {
                    Serializer.Serialize(xmlWtr, student);
                    SerializedStudent = sw.ToString();
                }
            }

            return SerializedStudent;
        }

        public Student Deserialize(string serializedStudent)
        {
            XmlSerializer Serializer = new XmlSerializer(typeof(Student));

            Student _Student = null;
            using (StringReader sr = new StringReader(serializedStudent))
            {
                _Student = (Student)Serializer.Deserialize(sr);
            }

            return _Student;
        }
    }

    public class SerializationToSOAP : ISerialization
    {
        public Student Deserialize(string serializedStudent)
        {
            SoapFormatter soapFormatter = new SoapFormatter();
            Student _Student = null;

            using (MemoryStream ms = 
                new MemoryStream(Encoding.ASCII.GetBytes(serializedStudent)))
            {
                _Student = (Student)soapFormatter.Deserialize(ms);
            }

            return _Student;
        }

        public string Serialize(Student student)
        {
            string SerializedStudent = string.Empty;
            
            using (MemoryStream ms = new MemoryStream())
            {
                SoapFormatter soapFormatter = new SoapFormatter();
                soapFormatter.Serialize(ms, student);
                SerializedStudent = Encoding.ASCII.GetString( ms.ToArray());
            }

            return SerializedStudent;
        }
    }
}
