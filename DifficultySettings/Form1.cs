using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DifficultySettings
{
    


    public partial class Form1 : Form
    {
        string heroName;
        string difficultyLevel; 

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            heroName = userInput.Text;
            difficultyLevel = "Easy";
            
            
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "Medium";
        }

        private void hardButton_Click(object sender, EventArgs e)
        {
            difficultyLevel = "Hard";
        }
        private void startButton_Click(object sender, EventArgs e)
        {

            outputLabel.Text = $"Welcome {heroName}";
            outputLabel.Text += $"\nA true brave hero! Go forward and conquer the {difficultyLevel} path!";
        }
    }
}
