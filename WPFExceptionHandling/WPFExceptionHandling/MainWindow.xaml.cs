using System;
using System.IO;
using System.Windows;

namespace WPFExceptionHandling
{

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            ReadFile(0);
        }

        void ReadFile(int index)
        {
            string path = @"C:\Users\SebastianBerrio\source\Text.txt";
            StreamReader file = new StreamReader(path);
            char[] buffer = new char[80];

            try
            {
                file.ReadBlock(buffer, index, buffer.Length);
                string str = new string(buffer);
                throw new Exception();
                str.Trim();
                textBox.Text = str;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error reading from " + path + "\nMessage = " + e.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}