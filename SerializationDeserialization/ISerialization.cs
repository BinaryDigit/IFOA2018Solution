namespace SerializationDeserialization
{
    public interface ISerialization
    {
        string Serialize(Student student);
        Student Deserialize( string serializedStudent);
    }
}