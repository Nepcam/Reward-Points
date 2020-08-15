using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reward_Points
{
    public partial class Form1 : Form
    {
        string movie = "";
        bool threeD = false;
        bool delux = false;

        MovieView currentViewer = new MovieView(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {            
            DateTime today = DateTime.Now;

            bool hasExpired = currentViewer.Expired(today);           
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            movie = textBoxMovie.Text;
            threeD = radioButtonThreeD.Checked;
            delux = radioButtonDelux.Checked;
            currentViewer = new MovieView(movie, dateTimePicker1.Value, threeD, delux);
            listBoxDisplay.Items.Add(currentViewer);
        }
    }
}
