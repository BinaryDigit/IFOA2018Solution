using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace SerializationDeserialization
{
    internal class SerialitationToBinary : ISerialization
    {
        public Student Deserialize(string serializedStudent)
        {
            Student _Student = null;
            using (MemoryStream ms = 
                new MemoryStream( Encoding.ASCII.GetBytes( serializedStudent)))
            {
                BinaryFormatter bf = new BinaryFormatter();
                _Student = (Student)bf.Deserialize(ms);
            }

            return _Student;
        }

        public string Serialize(Student student)
        {
            string SerializedStudent = string.Empty;

            using (StringWriter sw = new StringWriter())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(ms, student);
                    SerializedStudent = Encoding.ASCII.GetString(ms.ToArray());
                }
            }

            return SerializedStudent;
        }
    }
}