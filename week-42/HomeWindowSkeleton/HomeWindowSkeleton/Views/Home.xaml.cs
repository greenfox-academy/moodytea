﻿using System.Windows;
using System.Diagnostics;

namespace HomeWindowSkeleton
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Window
    {
        private ProcessStartInfo processInfo = new ProcessStartInfo("cmd")
        {
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardInput = true,
            WorkingDirectory = @"C:\Users\"
        };

        private Process process;

        private string route = @"C:\";

        public Home()
        {
            InitializeComponent();
            //DataContext = new ClassNameViewModel();
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {

            //process.StandardInput.WriteLine("echo hello");
            //process.StandardInput.WriteLine("exit");

            Start();
            ChangeWorkingDirectory();
            SendCommandToCommandLine();

        }

        private void Start()
        {
            process = Process.Start(processInfo);
        }

        private void SendCommandToCommandLine()
        {
            
            string command = "echo hello";
            process.StandardInput.WriteLine(command);
            process.StandardInput.WriteLine("exit");
            string s = process.StandardOutput.ReadToEnd();

            //ExitCommandLine();
            MessageBox.Show(s.Substring(78));
        }

        private void ChangeWorkingDirectory()
        {
            ExitCommandLine();
            processInfo.WorkingDirectory = route;
            process = Process.Start(processInfo);
        }

        private void ExitCommandLine()
        {
            //process.StandardInput.WriteLine("exit");
            process.Kill();
        }

        //private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    string className = ComboYear.SelectedItem.ToString();
        //    className = className.Substring(38);
        //    MessageBox.Show(className);


        ////////////////////////process data here///////////// pro.CreateNoWindow = true;
        //}
    }
}
