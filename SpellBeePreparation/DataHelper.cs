using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellBeePreparation
{
    public static class DataHelper
    {
        public static List<Word> words = new List<Word>();

        public static List<Word> xmlWords = new List<Word>();

        static DataHelper()
        {
            //words.Add(new Word() { Name = "Able", Meaning = "having the talent and strength to do something" });
            //words.Add(new Word() { Name = "Abort", Meaning = "to stop some activity before completion" });
            //words.Add(new Word() { Name = "absent", Meaning = "to be missing" });
            //words.Add(new Word() { Name = "Across", Meaning = "from one side to another" });
            //words.Add(new Word() { Name = "Actual", Meaning = "real or original" });
            //words.Add(new Word() { Name = "adopt", Meaning = "to accept and follow an idea or action; to legendly raise another persons child as once own" });
            //words.Add(new Word() { Name = "adore", Meaning = "to like or respect someone or something verymuch" });
            //words.Add(new Word() { Name = "adorn", Meaning = "to make something more beautiful" });
            //words.Add(new Word() { Name = "advice", Meaning = "to give tips to someone to help them do better or be better" });
            //words.Add(new Word() { Name = "aeroplane", Meaning = "a vehicle that is used by travelling" });
            //words.Add(new Word() { Name = "afresh", Meaning = "again from the beginning, but in a new and different way" });
            //words.Add(new Word() { Name = "against", Meaning = "opposite to" });
            //words.Add(new Word() { Name = "agent", Meaning = "someone who does a job on behalf of someone else or a company;a person or thing that helps something to happen" });
            //words.Add(new Word() { Name = "agile", Meaning = "being able to move easily and quickly" });
            //words.Add(new Word() { Name = "agree", Meaning = "to accept" });
            //words.Add(new Word() { Name = "ahead", Meaning = "in front; in the future" });
            //words.Add(new Word() { Name = "allow", Meaning = "to let someone do something" });
            //words.Add(new Word() { Name = "ally", Meaning = "one who helps another in doing something" });
            //words.Add(new Word() { Name = "almost", Meaning = "very nearly; close to reach or finish something" });
            //words.Add(new Word() { Name = "alter", Meaning = "to make changes to something" });
            //words.Add(new Word() { Name = "although", Meaning = "even though" });
            //words.Add(new Word() { Name = "always", Meaning = "all the time" });
            //words.Add(new Word() { Name = "amount", Meaning = "the sum total of something" });
            //words.Add(new Word() { Name = "amuse", Meaning = "to make something laugh or smile by being funny" });
            //words.Add(new Word() { Name = "angle", Meaning = "the space between two straight lines where they join or cross each other; the way one looks at a particular thing" });
            //words.Add(new Word() { Name = "animal", Meaning = "any living being which moves on its own" });
            //words.Add(new Word() { Name = "annual", Meaning = "taking place every year" });
            //words.Add(new Word() { Name = "another", Meaning = "one more; something else" });
            //words.Add(new Word() { Name = "answer", Meaning = "a solution; to reply" });
            //words.Add(new Word() { Name = "anything", Meaning = "any one thing" });


            words = ((Words)XMLHelper.DeserializeFromXmlFile<Words>("WordList.xml")).words.ToList();

        }

        public static List<Word> GetWords(int count)
        {
            List<Word> result = new List<Word>();
            for (int i = count; i < count + 10; i++)
            {
                result.Add(words[i]);
            }
            return result;
        }

        public static int GetWordsCount()
        {
            return words.Count;
        }
    }
}
