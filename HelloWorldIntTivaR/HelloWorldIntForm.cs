using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Created by: Tiva Rait
 * Created on: 12-02-2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day #5 - Hello World International
 * This program... Displays the words "Hello world" in four languages
*/

namespace HelloWorldIntTivaR
{
    public partial class frmHelloWorldInt : Form
    {
        public frmHelloWorldInt()
        {
            InitializeComponent();
        }

        // This is the in the fantasy language Klingon
        private void radKlingon_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "qo' vIvan";
        }

       // This Is displayed as "Common Tongue" fantasy language nerds will know this is english
        private void radEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World";
        }

        // This is in the fantasy language Dothraki
        private void radDothraki_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "M'athchomaroon rhaesheser";
        }

        // This is in the fantasy language Valyrian
        private void radValyrian_CheckedChanged(object sender, EventArgs e)
        {
            lblGreeting.Text = "Rytsas vys";
        }
    }
}
