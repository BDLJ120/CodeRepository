using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingScrew
{
    public partial class SplashForm : Form
    {
        static SplashForm splashForm;

        public static void Display(string ProgramName)
        {
            splashForm = new SplashForm();
            splashForm.lbName.Text = ProgramName;
            splashForm.Show();
        }

        public static void SetTextAndProgress(string str, int pro)
        {
            if (splashForm != null)
            {
                splashForm.lbTxt.Text = str;
                splashForm.progressBar1.Value = pro;
                splashForm.progressBar1.Refresh();
                splashForm.Refresh();
            }
        }

        public static void CloseDisplay()
        {
            if (splashForm != null)
            {
                splashForm.Close();
            }
        }

        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
