using Newtonsoft.Json;
using System;
using System.IO;

namespace SerializationDeserialization
{
    internal class SerializationToJSON : ISerialization
    {
        public Student Deserialize(string serializedStudent)
        {
            return JsonConvert.DeserializeObject<Student>(serializedStudent);
        }

        public string Serialize(Student student)
        {
            return JsonConvert.SerializeObject(student);
        }
    }
}