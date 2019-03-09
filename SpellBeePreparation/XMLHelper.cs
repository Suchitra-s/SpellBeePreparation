using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SpellBeePreparation
{
    //public class XMLHelper
    //{
    //    // public static void Write<T>(string filename)
    //    //{
    //    //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
    //    //    using (FileStream stream = File.OpenWrite(filename))
    //    //    {
    //    //        List<T> list = new List<T>();
    //    //        serializer.Serialize(stream, list);
    //    //    }
    //    //}

    //    //public static List<T> Read<T>(string filename)
    //    //{
    //    //    XmlSerializer serializer = new XmlSerializer(typeof(List<T>));
    //    //    List<T> list;
    //    //    using (FileStream stream = File.OpenRead(filename))
    //    //    {
    //    //        list = (List<T>)serializer.Deserialize(stream);
    //    //    }
    //    //    return list;
    //    //}

    //    //public static T Read<T>(string fileName)
    //    //{
    //    //    //using (FileStream stream = File.OpenRead(filename))
    //        //{
    //        //    //list = (list<t>)serializer.deserialize(stream);
    //        //    XmlReader reader = XmlReader.Create(new StringReader(stream));
    //        //    while (reader.Read())
    //        //    {
    //        //        if (reader.NodeType == XmlNodeType.Element)
    //        //        {

    //        //        }
    //        //    }
    //        //}

    //    //    try
    //    //    {
    //    //        object result;
    //    //        if (!File.Exists(fileName)) return default(T);
    //    //        var serializer = new XmlSerializer(typeof(T));
    //    //        using (FileStream stream = File.OpenRead(fileName))
    //    //        {
    //    //            TextReader ReadFileStream = new StreamReader(stream);
    //    //            result = serializer.Deserialize(ReadFileStream);
    //    //            //  ReadFileStream.Close();
    //    //        }
    //    //        return (T)result;
    //    //    }
    //    //    catch (Exception ex)
    //    //    {

    //    //    }

    //    //    return default(T);
    //    //}
    //}

    public static class XMLHelper
    {
        /// <summary>
        /// Serialize a serializable object to XML string.
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="xmlObject">Type of object</param>
        /// <param name="useNamespaces">Use of XML namespaces</param>
        /// <returns>XML string</returns>
        //public static string SerializeToXmlString<T>(T xmlObject, bool useNamespaces = true)
        //{
        //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
        //    MemoryStream memoryStream = new MemoryStream();
        //    XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
        //    xmlTextWriter.Formatting = Formatting.Indented;

        //    if (useNamespaces)
        //    {
        //        XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
        //        xmlSerializerNamespaces.Add("", "");
        //        xmlSerializer.Serialize(xmlTextWriter, xmlObject, xmlSerializerNamespaces);
        //    }
        //    else
        //        xmlSerializer.Serialize(xmlTextWriter, xmlObject);

        //    string output = Encoding.UTF8.GetString(memoryStream.ToArray());
        //    string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
        //    if (output.StartsWith(_byteOrderMarkUtf8))
        //    {
        //        output = output.Remove(0, _byteOrderMarkUtf8.Length);
        //    }

        //    return output;
        //}

        ///// <summary>
        ///// Serialize a serializable object to XML string and create a XML file.
        ///// </summary>
        ///// <typeparam name="T">Type of object</typeparam>
        ///// <param name="xmlObject">Type of object</param>
        ///// <param name="filename">XML filename with .XML extension</param>
        ///// <param name="useNamespaces">Use of XML namespaces</param>
        //public static void SerializeToXmlFile<T>(T xmlObject, string filename, bool useNamespaces = true)
        //{
        //    try
        //    {
        //        File.WriteAllText(filename, SerializeToXmlString<T>(xmlObject, useNamespaces));
        //    }
        //    catch
        //    {
        //        throw new Exception();
        //    }
        //}

        ///// <summary>
        ///// Deserialize XML string to an object.
        ///// </summary>
        ///// <typeparam name="T">Type of object</typeparam>
        ///// <param name="xml">XML string</param>
        ///// <returns>XML-deserialized object</returns>
        public static T DeserializeFromXmlString<T>(string xml) where T : new()
        {
            T xmlObject = new T();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);
            xmlObject = (T)xmlSerializer.Deserialize(stringReader);
            return xmlObject;
        }

        /// <summary>
        /// Deserialize XML string from XML file to an object.
        /// </summary>
        /// <typeparam name="T">Type of object</typeparam>
        /// <param name="filename">XML filename with .XML extension</param>
        /// <returns>XML-deserialized object</returns>
        public static T DeserializeFromXmlFile<T>(string filename) where T : new()
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            return DeserializeFromXmlString<T>(File.ReadAllText(filename));
        }

        //public static T Read<T>(string fileName)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(T));
        //    T result;
        //    using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
        //    {
        //        result = (T)serializer.Deserialize(fileStream);
        //    }
        //    return result;
        //}
    }
}


