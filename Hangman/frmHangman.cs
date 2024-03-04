using Hangman.Models;
using Hangman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        public List<String> UsedLetters { get; set; }
        String chars = "ABCDEFGHIJKLMNOPRSTQUVWXYZ";
        List<String> words;
        String selectedWord;
        String secretWord;
        int retryCount = 6;

        public frmHangman()
        {
            InitializeComponent();
            UsedLetters = new List<string>();
            words = HangmanWord.getWords();
            startNewGame();
        }

        private void startNewGame()
        {
            retryCount = 6;
            UsedLetters.Clear();
            lblKey.Text = "";
            int randomNumber = new Random().Next(0, words.Count);
            selectedWord = words[randomNumber].ToUpper();
            secretWord = "";
            Text = selectedWord;
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (i == 0)
                {
                    secretWord +="_ ";
                }
                else if (i==selectedWord.Length-1){
                    secretWord += " _";
                }
                else
                {
                    secretWord+= " _ ";
                }
                
            }
            lblDescription.Text = secretWord;
            addLetters();
           
        }

        private void frmHangman_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return;
            }
            controlChar(e.KeyChar.ToString().ToUpper());
            
        }
        private void controlChar(String letter)
        {
            if (!UsedLetters.Contains(letter))
            {
                lblKey.Text = letter; 
                UsedLetters.Add(letter);

                examineChar(letter);
                
                ResourceManager rm = Resources.ResourceManager; 
                if (UsedLetters.Count != 0)
                {
                    
                    Bitmap hangmanPicture = (Bitmap)rm.GetObject("_" + (7-retryCount).ToString("000"));
                    imgHangman.Image = hangmanPicture;

                    if (retryCount < 0)
                    {
                        MessageBox.Show("You lost");
                        
                        startNewGame();
                        return;
                    }
                }
                   
                addLetters();
            }
        }

        

        private void examineChar(String letter)
        {
            if (!selectedWord.Contains(letter[0]))
            {
                retryCount--;
            }

            secretWord = "";
            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (UsedLetters.Contains(selectedWord[i].ToString()))
                {
                    secretWord += String.Format(" {0} ", selectedWord[i].ToString());
                }
                else
                {
                    if (i == 0)
                    {
                        secretWord += "_ ";
                    }
                    else if (i==selectedWord.Length-1)
                    {
                        secretWord += " _";
                    }
                    else
                    {
                        secretWord += " _ ";
                    }
                    
                }
                
            }

            lblDescription.Text = secretWord;

        }

        private void addLetters()
        {
            grbLetters.Controls.Clear();
            int x = 0;
            int y = 20;

            for(int i=0;i<chars.Length;i++)
            {
                Button button = new Button();
                button.Enabled = !UsedLetters.Contains(chars.Substring(i, 1));
                
                button.Text = chars.Substring(i, 1);
                button.Width = 40;
                button.Height = 40;
                button.Top = y;
                button.Left = (x) * 50 + 10 ;
                x++;

                if (i == 12)
                {
                    y = 80;
                    x = 0;
                }

                button.Click += Button_Click;
                grbLetters.Controls.Add(button);
                    
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            controlChar(button.Text);
            
        }

        private void frmHangman_Load(object sender, EventArgs e)
        {
            addLetters();
        }
    }

}
