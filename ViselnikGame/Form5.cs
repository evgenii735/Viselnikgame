﻿//<copyright file="Form5.cs" company="OmGTU"> 
//Copyright (c) OmGTU. All rights reserved.
//</copyright> 
//<author>
//Kalita Aleksandr, Valyn Ivan, Loshchinina Tatyana
//</author> 
namespace OmGTU.Advance.Profit.Loyal.ViselnikGame
    {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// Copy of a class of the form.
    /// </summary>
    public partial class Form5 : Form
        {
        /// <summary>
        ///  Form start.
        /// </summary>
        public Form5()
            {
            InitializeComponent();
            }

        /// <summary>
        /// Transition to the form back.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1Click(object sender, EventArgs e)
            {
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
            }
        }
    }
