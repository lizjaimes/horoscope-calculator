using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice_Exam_1_Blank         // Elizabeth Jaimes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }
        // These are the variables for my textboxes
        int birthMonth;
        int birthDay;
        int birthYear;

        private void btnBirthDate_Click(object sender, EventArgs e)
        {
            // Go Button code
            // This will show an error when user tries to input anything else but a number
            try
            {
               
                birthMonth = int.Parse(txtBirthMonth.Text);
                birthDay = int.Parse(txtBirthDate.Text);
                birthYear = int.Parse(txtBirthYear.Text);
                if (birthMonth >= 13)
                {
                    MessageBox.Show("Enter a month 1-12");
                    txtBirthMonth.Text = "";

                }
                if (birthDay >= 32)
                {
                    MessageBox.Show("Enter a valid date");
                    txtBirthDate.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Please enter numerical values");
                txtBirthMonth.Text = "";
                txtBirthDate.Text = "";
                txtBirthYear.Text = "";
                txtBirthMonth.Focus(); // FOCUS CODE 
                lblLeapYear.Text = "";
                lblOutputSentence.Text = "";
                lblZodiacChinese.Text = "";
            }

            
            // This will determine if the user's birth year was a leap year.
            if (birthYear % 4 == 0)
                {
                    lblLeapYear.Text = "Yes";
                    lblLeapYear.Visible = true;
                }
                else
                {
                    lblLeapYear.Text = "No";
                    lblLeapYear.Visible = true;
                }
            // This will calculate user's Zodiac sign if it falls within the designitated dates

                if ((birthMonth == 03 && (birthDay >= 21 && birthDay <= 31)) || (birthMonth == 04 && birthDay <= 19))
                {
                    lblZodiac.Text = "Aries";
                }
                else if ((birthMonth == 04 && (birthDay >= 20 && birthDay <= 30)) || (birthMonth == 05 && birthDay <= 20))
                {
                    lblZodiac.Text = "Taurus";
                }
                else if ((birthMonth == 05 && (birthDay >= 21 && birthDay <= 31)) || (birthMonth == 06 && birthDay <= 21))
                {
                    lblZodiac.Text = "Gemini";
                }
                else if ((birthMonth == 06 && (birthDay >= 22 && birthDay <= 30)) || (birthMonth == 07 && birthDay <= 22))
                {
                    lblZodiac.Text = "Cancer";
                }
                else if ((birthMonth == 07 && (birthDay >= 23 && birthDay <= 31)) || (birthMonth == 08 && birthDay <= 22))
                {
                    lblZodiac.Text = "Leo";
                }
                else if ((birthMonth == 08 && (birthDay >= 23 && birthDay <= 31)) || (birthMonth == 09 && birthDay <= 22))
                {
                    lblZodiac.Text = "Virgo";
                }
                else if ((birthMonth == 09 && (birthDay >= 23 && birthDay <= 30)) || (birthMonth == 10 && birthDay <= 23))
                {
                    lblZodiac.Text = "Libra";
                }
                else if ((birthMonth == 10 && (birthDay >= 24 && birthDay <= 31)) || (birthMonth == 11 && birthDay <= 21))
                {
                    lblZodiac.Text = "Scorpio";
                }
                else if ((birthMonth == 11 && (birthDay >= 22 && birthDay <= 30)) || (birthMonth == 12 && birthDay <= 21))
                {
                    lblZodiac.Text = "Sagittarius";
                }
                else if ((birthMonth == 12 && (birthDay >= 22 && birthDay <= 31)) || (birthMonth == 01 && birthDay <= 19))
                {
                    lblZodiac.Text = "Capricorn";
                }
                else if ((birthMonth == 01 && (birthDay >= 20 && birthDay <= 31)) || (birthMonth == 02 && birthDay <= 18))
                {
                    lblZodiac.Text = "Aquarius";
                }
                else if ((birthMonth == 02 && (birthDay >= 19 && birthDay <= 29)) || (birthMonth == 03 && birthDay <= 20))
                {
                    lblZodiac.Text = "Pisces";
                }
                else {
                MessageBox.Show("NA");
                    }

            //  switch () This will give the chinese zodiac sign based on the birth year of the user

                switch (birthYear % 12)
                {

                // This will select my chinese zodiac from the list box based on the birthyear modulus calculation

                case 0:
                    lstZodiacChinese.SelectedIndex = 8;
                    break;
                case 1:
                    lstZodiacChinese.SelectedIndex = 9;
                    break;
                case 2:
                    lstZodiacChinese.SelectedIndex = 10;
                    break;
                case 3:
                    lstZodiacChinese.SelectedIndex = 11;
                    break;
                case 4:
                    lstZodiacChinese.SelectedIndex = 0;
                    break;
                case 5:
                    lstZodiacChinese.SelectedIndex = 1;
                    break;
                case 6:
                    lstZodiacChinese.SelectedIndex = 2;
                    break;
                case 7:
                    lstZodiacChinese.SelectedIndex = 3;
                    break;
                case 8:
                    lstZodiacChinese.SelectedIndex = 4;
                    break;
                case 9:
                    lstZodiacChinese.SelectedIndex = 5;
                    break;
                case 10:
                    lstZodiacChinese.SelectedIndex = 6;
                    break;
                case 11:
                    lstZodiacChinese.SelectedIndex = 7;
                    break;
            }
            // This will display the Chinese Zodiac from the listbox into the Chinese Zodiac label output
            lblZodiacChinese.Text = lstZodiacChinese.SelectedItem.ToString();

            //This will display a sentence for the user mentioning their zodiac and chinese zodiac sign. 
           lblOutputSentence.Text = "I am a" + " " + (lblZodiac.Text) + " " + "born in the year of the" + " " + (lblZodiacChinese.Text);

            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                // Clear Button code
                lblLeapYear.Text = "";
                lblZodiac.Text = "";
                lblZodiacChinese.Text = "";
                lblOutputSentence.Text = "";


                txtBirthDate.Text = "";
                txtBirthMonth.Text = "";
                txtBirthYear.Text = "";
            }

            private void btnExit_Click(object sender, EventArgs e)
            {
                // Exit Button code
                this.Close();
            }

            private void Form1_Load(object sender, EventArgs e)
            {
                // Form loader code
            }


        }
    
}
