public static T DeserializeFromString<T>(string value) {
    T outObject;
    XmlSerializer deserializer = new XmlSerializer(typeof(T));
    StringReader stringReader = new StringReader(value);
    outObject = (T)deserializer.Deserialize(stringReader);
    stringReader.Close();
    return outObject;
}
