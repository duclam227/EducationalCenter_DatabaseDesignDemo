﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalCenter_Demo
{
    public partial class EnrollClassWindow : Form
    {
        public EnrollClassWindow()
        {
            InitializeComponent();
        }

        public EnrollClassWindow(string username)
        {
            Username = username;
        }

        public string Username { get; }
    }
}
