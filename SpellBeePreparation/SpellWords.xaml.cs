using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.SpeechSynthesis;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace SpellBeePreparation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SpellWords : Page
    {
        SpeechSynthesizer speechSynthesizer;

        public SpellWords()
        {
            this.InitializeComponent();
            txtblkCounter.Text = "Word " + Counter.ToString() + " of " + DataHelper.words.Count.ToString();
            speechSynthesizer = new SpeechSynthesizer();
        }

        public int Counter = 1;

        private async void btnClick_Click(object sender, RoutedEventArgs e)
        {
            var stream = await speechSynthesizer.SynthesizeTextToStreamAsync(DataHelper.words[Counter - 1].Name);
            media.SetSource(stream, stream.ContentType);
            media.Play();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            var value = txtBox.Text.ToString();
            var word = DataHelper.words[Counter - 1].Name;
            Counter++;
            if (value.ToUpper().Equals(word.ToUpper()))
            {
                if (Counter == DataHelper.words.Count)
                {
                    MessageDialog message = new MessageDialog("Well Done !! You have learnt all the words");
                    message.ShowAsync();
                    txtBox.Text = string.Empty;
                    Frame.Navigate(typeof(MainPage));
                }
                else
                {
                    MessageDialog message = new MessageDialog("Good thats correct !! try next word");
                    message.ShowAsync();
                    txtblkCounter.Text = "Word " + Counter.ToString() + " of " + DataHelper.words.Count.ToString();
                    txtBox.Text = string.Empty;
                }
            }
            else
            {
                MessageDialog message = new MessageDialog("Sorry !! Correct Answer is : " + word.ToUpper());
                message.ShowAsync();
                txtblkCounter.Text = "Word " + Counter.ToString() + " of " + DataHelper.words.Count.ToString();
                txtBox.Text = string.Empty;
            }
        }
    }
}
