using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Terminator
{
    public partial class MainForm : Form
    {
        Controller view;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                view.GameThread.Abort();
            }
            catch (NullReferenceException) { }
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 27)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(pictureBox1);
            view = new Controller();
            this.Controls.Add(view);
            view.Focus();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.OnPlay;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Play;
        }
    }
}
