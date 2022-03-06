﻿using System;
using System.Data;
using System.Collections;
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
using System.Windows.Threading;
using System.Diagnostics;
using System.Data.SqlClient;

namespace FreePlantcer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        string currentTime = string.Empty;
        string rateString;
        double rate = 15.00;
        double hourlyRate;
        string hoursWorked;
       
        public MainWindow()
        {

            InitializeComponent();
            dt.Tick += new EventHandler(dt_Tick);
            dt.Interval = new TimeSpan(0, 0, 0, 0, 1);
            calendar1.SelectedDate = DateTime.Today;




        }

        Dictionary<string, string> mydictionary = new Dictionary<string, string>();
        void GetTime(string deight, string currentTime)
        {

            bool keyExists = mydictionary.ContainsKey(deight);
            if (!keyExists)
            {
                mydictionary.Add(deight, currentTime);
                elapsedtimeitem.Text = datetxtblock.Text + " " + mydictionary[deight];


            }
            else
            {
                //elapsedtimeitem.Text = " " + DateTime.Today;
                elapsedtimeitem.Text = ("Already Logged!");
            }





        }
        void dt_Tick(object sender, EventArgs e)
        {
            if (sw.IsRunning)
            {
                TimeSpan ts = sw.Elapsed;

                rateString = ratebox.Text;
                rate = double.Parse(rateString);
                hoursWorked = String.Format("{0}.{1}", ts.Hours, ts.Minutes / 60);



                hourlyRate = rate * double.Parse(hoursWorked);


                timelogged.Text = hourlyRate.ToString();

                currentTime = String.Format("{0:00}:{1:00}:{2:00}",
                ts.Hours, ts.Minutes, ts.Seconds);
                clocktxtblock.Text = currentTime;

            }
        }

        private void startbtn_Click(object sender, RoutedEventArgs e)
        {
            sw.Start();
            dt.Start();
        }

        private void stopbtn_Click(object sender, RoutedEventArgs e)
        {
            if (sw.IsRunning)
            {
                sw.Stop();
            }

        }

        private void resetbtn_Click(object sender, RoutedEventArgs e)
        {
            sw.Reset();
            clocktxtblock.Text = "00:00:00";



        }



        private void logbtn_Click(object sender, RoutedEventArgs e)
        {
            GetTime(datetxtblock.Text, currentTime);

        
            
            string connetionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=CalendarDatabase;Integrated Security=True";
            SqlConnection cnn = new SqlConnection(connetionString); //Connecting to SQL DB
            //SqlDataReader dataReader;

            string dateToLog = "12/25/20";
            string updateTime = "P Diddy";
            string InsertQuery = "UPDATE CalendarTable_1 SET TimeLogged_1 = @t Where Date = @d;"; //Querying SQL DB
            
                                   
            SqlCommand cmd = cnn.CreateCommand();
            cnn.Open();
            MessageBox.Show("Connection Open  !");

            cmd.CommandText = InsertQuery;  //Inserting Values to DB
            cmd.Parameters.AddWithValue("@d", dateToLog); 
            cmd.Parameters.AddWithValue("@t", updateTime);
            cmd.ExecuteNonQuery();
            cnn.Close();

            MessageBox.Show("Connection Closed  !");
        }
    }
}

