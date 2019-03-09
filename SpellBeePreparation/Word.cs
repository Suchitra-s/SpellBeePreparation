using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SpellBeePreparation
{
    public class Word
    {
        [XmlElement("Name")]
        public string Name { get; set; }
        [XmlElement("Meaning")]
        public string Meaning { get; set; }
    }

    [XmlRoot("Words")]
    public class Words
    {
        [XmlElement("Word")]
        public List<Word> words { get; set; }
    }
}
