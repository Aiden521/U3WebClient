/*
 * U3Webclient
 * Aiden Jolley Ruhn
 * April 3, 2018
 * Reads from a webpage and outputs data to a file
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace U3WebClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // webclient 
            System.Net.WebClient webClient = new System.Net.WebClient();
            webClient.BaseAddress = "https://http://ele.tldsb.ca/";
            System.IO.StreamReader streamReader = new System.IO.StreamReader(webClient.OpenRead("https://www.youtube.com"));
            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("tldsb.txt");

            try
            {
                streamWriter.Write(streamReader.ReadToEnd());
                streamWriter.Flush();
                streamWriter.Close();
                streamWriter.Close();
                MessageBox.Show("I Have read everything!");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "Error");
            }
        }
    }
}
