using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Extensions;
using System.Threading;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        int userNumber = 0;
        List<string> names;
        int[] timings;
        Random rnd = new Random();
        string charArray = "abcdefghijklmnopqrstuvwxyz";
        int NumberOfUsers = 1;

        List<string> colourArray = new List<string>() {"Bisque",
            "Aqua",
            "AliceBlue",
            "Red",
            "Blue",
            "Brown",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk" };
        string lastCharArray = ".!?.!?.!?";

        public void GetArrayOfNames(int number)
        {
            string name;
            names = new List<string>();
            for (int i = 0; i < number; ++i)
            {
                name = "";
                for (int j = 0; j <= 5; ++j)
                    name += charArray[rnd.Next(0, 26)];
                names.Add(name);
            }
        }

        public void GetArrayOfTimings(int number)
        {
            timings = new int[number];
            for (int i = 0; i < number; ++i)
                timings[i] = rnd.Next(3, 60);
        }

        public string[] GetMessage()
        {
            string word;
            int numberOfWords = rnd.Next(1, 15);
            string[] words = new string[numberOfWords];
            for (int i = 0; i < numberOfWords; ++i)
            {
                word = "";
                for (int j = 0; j < rnd.Next(1, 13); ++j)
                    word += charArray[rnd.Next(0, 26)];
                words[i] = word;
            }
            return words;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDownNumberOfUsers_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;
        }

        private void radioButtonChatVisibility_CheckedChanged(object sender, EventArgs e)
        {
            textBoxChat.Visible = true;
        }

        private void radioButtonChatInvisibility_CheckedChanged(object sender, EventArgs e)
        {
            textBoxChat.Visible = false;
        }

        private int ConvertToMS(int time)
        {
            return Convert.ToInt32((60.0 / time) * 1000);
        }

        private void TypeText()
        {
            int thisUserNumber = userNumber++;
            string name = names[thisUserNumber];
            int time;
            string colour = colourArray[thisUserNumber];
            string text; ;
            string[] message;
            
            while (true)
            {
                time = timings[thisUserNumber];
                message = GetMessage();
                text = name + ": ";
                Thread.Sleep(ConvertToMS(time));
                foreach (string word in message)
                    text += word + " ";
                Action action = () => textBoxChat.AppendText(text.Trim() + lastCharArray[rnd.Next(0, 8)] + Environment.NewLine, Color.FromName(colour));
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();
                Thread.Sleep(ConvertToMS(time));
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            NumberOfUsers = Convert.ToInt32(numericUpDownNumberOfUsers.Value);
            Thread[] threads = new Thread[NumberOfUsers];
            GetArrayOfNames(NumberOfUsers);
            GetArrayOfTimings(NumberOfUsers);
            numericUpDownUser.Maximum = Convert.ToInt32(NumberOfUsers);
                
            for (int i = 0; i < NumberOfUsers; ++i)
            {
                threads[i] = new Thread(TypeText);
                threads[i].IsBackground = true;
                threads[i].Start();
            }
            button.Enabled = false;
        }

        private void buttonTypingSpeed_Click(object sender, EventArgs e)
        {
            timings[Convert.ToInt32(numericUpDownUser.Value) - 1] = Convert.ToInt32(numericUpDownTypingSpeed.Value);
        }
    }
}
