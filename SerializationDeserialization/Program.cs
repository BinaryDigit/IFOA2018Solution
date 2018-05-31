using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDeserialization
{
    class Program
    {
        public enum SerializationMethod { XML, JSON, SOAP, BINARY};
        private static ISerialization LoadSerializator(SerializationMethod method)
        {
            switch (method)
            {
                case SerializationMethod.XML: return new SerializationToXML();
                case SerializationMethod.SOAP: return new SerializationToSOAP();
                case SerializationMethod.JSON: return new SerializationToJSON();
                default: return new SerialitationToBinary();
            }
        }

        static void Main(string[] args)
        {
            SerializationMethod Method = SerializationMethod.BINARY;
            ISerialization Serializator = LoadSerializator( Method);

            Serialization.Serialize += Serializator.Serialize;
            Serialization.Deserialize += Serializator.Deserialize;

            Student _Student = new Student()
                {
                    IDStudent = 1233498
                    , Name = "Francesco Paolo"
                    , Surname = "Lovero"
                };

            string FileName = string.Format("{0}_{1}.{2}", 
                _Student.Name, _Student.Surname, Enum.GetName( typeof(SerializationMethod), Method));

            string SerializedStudent = Serialization.Serialize( _Student);
            System.IO.File.WriteAllText(FileName, SerializedStudent);

            string SerializedStudentFromFile = 
                System.IO.File.ReadAllText( FileName);
            Student _StudentDeserialized = 
                Serialization.Deserialize( SerializedStudentFromFile);

            Console.WriteLine( @"
                ID: {0}
                Name: {1}
                Surname: {2}
                ", 
                _StudentDeserialized.IDStudent
                , _StudentDeserialized.Name
                , _StudentDeserialized.Surname);

            Console.ReadLine();
        }
    }
}
