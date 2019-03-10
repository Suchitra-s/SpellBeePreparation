using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SpellBeePreparation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WordMeanings : Page
    {
        public List<int> numbers;

        public List<Word> words;

        public int count = 0;

        public bool IsAllCorrect = true;

        public Dictionary<int, int> answers = new Dictionary<int, int>();

        public WordMeanings()
        {
            this.InitializeComponent();
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            CheckAnswers();
            if (IsAllCorrect)
            {
                btnTwo.Content = "Next";
            }
            else
            {
                btnTwo.Content = "Retry";
            }
        }

        public void CheckAnswers()
        {
            IsAllCorrect = true;

            if (txtMatch1.Text == getAlphabet(answers[0]))
            {
                img1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img1.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch2.Text == getAlphabet(answers[1]))
            {
                img2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img2.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch3.Text == getAlphabet(answers[2]))
            {
                img3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img3.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch4.Text == getAlphabet(answers[3]))
            {
                img4.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img4.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch5.Text == getAlphabet(answers[4]))
            {
                img5.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img5.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch6.Text == getAlphabet(answers[5]))
            {
                img6.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img6.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch7.Text == getAlphabet(answers[6]))
            {
                img7.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img7.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch8.Text == getAlphabet(answers[7]))
            {
                img8.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img8.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch9.Text == getAlphabet(answers[8]))
            {
                img9.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img9.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }

            if (txtMatch10.Text == getAlphabet(answers[9]))
            {
                img10.Source = new BitmapImage(new Uri("ms-appx:///Assets/Correct.jpg"));
            }
            else
            {
                img10.Source = new BitmapImage(new Uri("ms-appx:///Assets/Wrong.png"));
                IsAllCorrect = false;
            }
        }

        public string getAlphabet(int i)
        {
            if (i == 0)
            {
                return "A";
            }
            if (i == 1)
            {
                return "B";
            }
            if (i == 2)
            {
                return "C";
            }
            if (i == 3)
            {
                return "D";
            }
            if (i == 4)
            {
                return "E";
            }
            if (i == 5)
            {
                return "F";
            }
            if (i == 6)
            {
                return "G";
            }
            if (i == 7)
            {
                return "H";
            }
            if (i == 8)
            {
                return "I";
            }
            if (i == 9)
            {
                return "J";
            }
            else
            {
                return "K";
            }
        }

        public int getNumber(string alphabet)
        {
            if (alphabet.ToUpper() == "A")
            {
                return 0;
            }
            if (alphabet.ToUpper() == "B")
            {
                return 1;
            }
            if (alphabet.ToUpper() == "C")
            {
                return 2;
            }
            if (alphabet.ToUpper() == "D")
            {
                return 3;
            }
            if (alphabet.ToUpper() == "E")
            {
                return 4;
            }
            if (alphabet.ToUpper() == "F")
            {
                return 5;
            }
            if (alphabet.ToUpper() == "G")
            {
                return 6;
            }
            if (alphabet.ToUpper() == "H")
            {
                return 7;
            }
            if (alphabet.ToUpper() == "I")
            {
                return 8;
            }
            if (alphabet.ToUpper() == "J")
            {
                return 9;
            }
            else
            {
                return 10;
            }
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            // Update words with the words and meanings combinations
            UpdateWords();

            PopulateWords();
        }

        public void PopulateWords()
        {
            PopulateOrders();

            // Populate words

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Word1.Text = words[i].Name;
                }
                if (i == 1)
                {
                    Word2.Text = words[i].Name;
                }
                if (i == 2)
                {
                    Word3.Text = words[i].Name;
                }
                if (i == 3)
                {
                    Word4.Text = words[i].Name;
                }
                if (i == 4)
                {
                    Word5.Text = words[i].Name;
                }
                if (i == 5)
                {
                    Word6.Text = words[i].Name;
                }
                if (i == 6)
                {
                    Word7.Text = words[i].Name;
                }
                if (i == 7)
                {
                    Word8.Text = words[i].Name;
                }
                if (i == 8)
                {
                    Word9.Text = words[i].Name;
                }
                if (i == 9)
                {
                    Word10.Text = words[i].Name;
                }
            }
            // Populate Meanings

            for (int i = 0; i < 10; i++)
            {
                int order = answers[i];

                if (i == 0)
                {
                    Meaning1.Text = words[order].Meaning;
                }
                if (i == 1)
                {
                    Meaning2.Text = words[order].Meaning;
                }
                if (i == 2)
                {
                    Meaning3.Text = words[order].Meaning;
                }
                if (i == 3)
                {
                    Meaning4.Text = words[order].Meaning;
                }
                if (i == 4)
                {
                    Meaning5.Text = words[order].Meaning;
                }
                if (i == 5)
                {
                    Meaning6.Text = words[order].Meaning;
                }
                if (i == 6)
                {
                    Meaning7.Text = words[order].Meaning;
                }
                if (i == 7)
                {
                    Meaning8.Text = words[order].Meaning;
                }
                if (i == 8)
                {
                    Meaning9.Text = words[order].Meaning;
                }
                if (i == 9)
                {
                    Meaning10.Text = words[order].Meaning;
                }

            }
        }


        public bool CheckContains(List<int> ints, int value)
        {
            foreach (var i in ints)
            {
                if (i == value)
                {
                    return true;
                }
            }
            return false;
        }

        public void PopulateOrders()
        {
            answers.Clear();
            List<int> integers = new List<int>();

            int count = 0;
            while (count < 10)
            {
                Random r = new Random();
                int x = r.Next(10);
                if (!CheckContains(integers, x))
                {
                    integers.Add(x);
                    answers.Add(count, x);
                    count++;
                }
            }
        }


        public bool UpdateWords()
        {
            // trying to get words from xml

            words = DataHelper.xmlWords;

            int c = DataHelper.GetWordsCount();
            if (c > (count + 10))
            {
                txtWordsStatus.Text = "Words " + (count+1) + " to " + (count + 10);
                // update new words from dataservice
                words = DataHelper.GetWords(count);
                return true;
            }
            else
            {
                MessageDialog message = new MessageDialog("Congratulations! all the words are completed");
                message.ShowAsync();
                Frame.Navigate(typeof(MainPage));
                return false;
            }
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            if (btnTwo.Content.ToString() == "Retry")
            {
                txtMatch1.Text = string.Empty;
                txtMatch2.Text = string.Empty;
                txtMatch3.Text = string.Empty;
                txtMatch4.Text = string.Empty;
                txtMatch5.Text = string.Empty;
                txtMatch6.Text = string.Empty;
                txtMatch7.Text = string.Empty;
                txtMatch8.Text = string.Empty;
                txtMatch9.Text = string.Empty;
                txtMatch10.Text = string.Empty;

                img1.Source = null;
                img2.Source = null;
                img3.Source = null;
                img4.Source = null;
                img5.Source = null;
                img6.Source = null;
                img7.Source = null;
                img8.Source = null;
                img9.Source = null;
                img10.Source = null;
            }
            else
            {
                txtMatch1.Text = string.Empty;
                txtMatch2.Text = string.Empty;
                txtMatch3.Text = string.Empty;
                txtMatch4.Text = string.Empty;
                txtMatch5.Text = string.Empty;
                txtMatch6.Text = string.Empty;
                txtMatch7.Text = string.Empty;
                txtMatch8.Text = string.Empty;
                txtMatch9.Text = string.Empty;
                txtMatch10.Text = string.Empty;

                img1.Source = null;
                img2.Source = null;
                img3.Source = null;
                img4.Source = null;
                img5.Source = null;
                img6.Source = null;
                img7.Source = null;
                img8.Source = null;
                img9.Source = null;
                img10.Source = null;
                count = count + 10;
                var result = UpdateWords();
                if(result)
                PopulateWords();

            }
        }
    }
}
