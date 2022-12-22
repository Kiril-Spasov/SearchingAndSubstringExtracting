using System;
using System.Windows.Forms;


namespace SearchingAndSubstringExtracting
{
    public partial class FormSearchingAndSubstringExtracting : Form
    {
        public FormSearchingAndSubstringExtracting()
        {
            InitializeComponent();
        }

        int wordsCount = 0;

        private void BtnProblem1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter text: ", "Text");
            string character = Microsoft.VisualBasic.Interaction.InputBox("Enter a character: ", "Character");

            //We separate each word and add it to the array.
            string[] split = SplitString(input, Convert.ToChar(character), ref wordsCount);


            for (int i = split.Length - 1; i >= 0 ; i--)
            {
                if (split[i] != null)
                {
                    TxtResult.Text += split[i];

                    if (i != 0)
                    {
                        TxtResult.Text += " ";
                    }
                }
            }
        }

        private void BtnProblem2_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a phone number: ", "Phone");
            string character = Microsoft.VisualBasic.Interaction.InputBox("Enter a character: ", "Character");

            string[] split = SplitString(input, Convert.ToChar(character), ref wordsCount);


            TxtResult.Text += "Area code is: " + split[0] + Environment.NewLine;
            TxtResult.Text += "Phone number is: ";

            for (int i = 1; i < split.Length - 1; i++)
            {
                if (split[i] != null)
                {
                    TxtResult.Text += split[i];

                    if (i != wordsCount)
                    {
                        TxtResult.Text += "-";
                    }
                }
            }
        }

        private void BtnProblem3_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter a decimal number: ", "Number");

            int decimalPlaces;
            int integer;
            int fraction;

            decimalPlaces = input.IndexOf('.');
            integer = Convert.ToInt32(input.Substring(0, decimalPlaces));
            fraction = Convert.ToInt32(input.Substring(decimalPlaces + 1));

            TxtResult.Text += "The number of decimal places is: " + decimalPlaces + Environment.NewLine;
            TxtResult.Text += "The integer part is: " + integer + Environment.NewLine;
            TxtResult.Text += "The decimal part is: " + fraction;

        }

        private string[] SplitString(string input, char character, ref int wordsCount)
        {
            char tempChar;
            string[] words = new string[100];

            for (int i = 0; i < input.Length; i++)
            {
                tempChar = Convert.ToChar(input.Substring(i, 1));

                if (tempChar == character)
                {
                    wordsCount++;
                }
                else
                {
                    words[wordsCount] += tempChar.ToString();
                }
            }
            return words;
        }

    }
}
