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
            currentViewer = new MovieView("Test", dateTimePicker1.Value, false, true);
        }
    }
}
