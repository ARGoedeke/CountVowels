//Author: Amanda Goedeke
//Date: 9/23/2020
//Count Vowels Excercise
//When trying to implement txtChanged event for the text box, it would no longer let me type anything. 
//Left as is as when the Count button is pressed again, updates accordingly.



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;

namespace CountVowels
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            //Variables
            int vowel_count = 0;

            //Text box to string conversion
            string countString = txtParagraph.Text;

            //String to lower case 
            countString.ToLower();

            //Counting string length
            int len = countString.Length;

            //For loop to count the vowels
            for(int i = 0; i < len; i++)
            {
                if (countString[i] == 'a' || countString[i] == 'e' || countString[i] == 'i' || countString[i] == 'o' || countString[i] == 'u')
                {
                    vowel_count++;
                }
            }

                //Final vowel total display
                txtVowels.Text = Convert.ToString(vowel_count);
        }
    }
}
