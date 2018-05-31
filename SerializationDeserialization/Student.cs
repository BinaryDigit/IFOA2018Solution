using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    public abstract class BaseClass // : ISerialization
    {
        //public void Deserialize()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Serialize()
        //{
        //    throw new NotImplementedException();
        //}
    }

    public static class StudentExtension
    {
        public static Student Deserialize(string serializedObject)
        {
            throw new NotImplementedException();
        }
    }

    [Serializable()]
    public class Student
    {
        public int IDStudent { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }
    }
}
