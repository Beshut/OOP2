using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        Label firstClicked = null;
        Label secondClicked = null;
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor != Color.CornflowerBlue)
                    return;

                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;

                    if(clickedLabel.Text == "!")
                    {
                        firstClicked.ForeColor = Color.Black;
                    }

                    if (clickedLabel.Text == "N")
                    {
                        firstClicked.ForeColor = Color.Blue;
                    }

                    if (clickedLabel.Text == ",")
                    {
                        firstClicked.ForeColor = Color.Red;
                    }

                    if (clickedLabel.Text == "k")
                    {
                        firstClicked.ForeColor = Color.Green;
                    }

                    if (clickedLabel.Text == "b")
                    {
                        firstClicked.ForeColor = Color.Yellow;
                    }

                    if (clickedLabel.Text == "v")
                    {
                        firstClicked.ForeColor = Color.Purple;
                    }

                    if (clickedLabel.Text == "w")
                    {
                        firstClicked.ForeColor = Color.Orange;
                    }

                    if (clickedLabel.Text == "z")
                    {
                        firstClicked.ForeColor = Color.White;
                    }
                    return;
                }

                secondClicked = clickedLabel;

                if (clickedLabel.Text == "!")
                {
                    secondClicked.ForeColor = Color.Black;
                }

                if (clickedLabel.Text == "N")
                {
                    secondClicked.ForeColor = Color.Blue;
                }

                if (clickedLabel.Text == ",")
                {
                    secondClicked.ForeColor = Color.Red;
                }

                if (clickedLabel.Text == "k")
                {
                    secondClicked.ForeColor = Color.Green;
                }

                if (clickedLabel.Text == "b")
                {
                    secondClicked.ForeColor = Color.Yellow;
                }

                if (clickedLabel.Text == "v")
                {
                    secondClicked.ForeColor = Color.Purple;
                }

                if (clickedLabel.Text == "w")
                {
                    secondClicked.ForeColor = Color.Orange;
                }

                if (clickedLabel.Text == "z")
                {
                    secondClicked.ForeColor = Color.White;
                }

                if (secondClicked.Text == firstClicked.Text)
                {
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\User\Documents\Sound\Super.wav");
                    player.Play();
                }

                CheckForWinner();

                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }

                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            MessageBox.Show("Вы подобрали все иконки!", "Поздравляю");
            Close();
        }
    }
}
