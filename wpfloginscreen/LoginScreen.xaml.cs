﻿using System;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Windows;
using System.Linq;
using System.Data.Entity.Validation;
using System.Runtime.InteropServices;

// download sql database: https://www.microsoft.com/en-US/download/details.aspx?id=29062
// kies voor SQLEXPRADV_x64_ENU.exe
// tutorial: https://docs.microsoft.com/en-us/sql/relational-databases/lesson-1-connecting-to-the-database-engine?view=sql-server-2017

namespace wpfloginscreen
{
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        public User currentUser;

        public User getUser ()
        {
            return currentUser;
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Password))
            {
                MessageBox.Show("Verkeerde inloggegevens!");
            }
            else
            {
                using (var db = new webshopHostEntities())
                {
                    MainWindow webshopPage = new MainWindow();

                    if (db.Users.Any(u => u.Username == txtUsername.Text && u.Password == txtPassword.Password))
                    {
                        // als account bestaat en login gegevens kloppen
                        MessageBox.Show("Login gelukt!", "Systeem melding");
                        
                        // set current user object to this user
                      //  currentUser = db.Users.Find(txtUsername.Text);

                        Close();
                        webshopPage.Show();
                    }
                        else
                    {
                        // ongeldige gegevens
                        MessageBox.Show("Username onbekend", "Systeem melding");
                    }
                }
            }
        }

        private void ButtonRegister_Click(object sender, RoutedEventArgs e)
        {
            Registration registrationPage = new Registration();
            registrationPage.Show();
            Close();
        }
    }
}




