using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace ChessClock
{
    public partial class Form1 : Form
    {
        Color color_active1 = Color.LightPink;
        Color color_active2 = Color.LightCyan;
        Color color_passive = Color.LightGray;

        Clock clock1;
        Clock clock2;

        public Form1()
        {
            InitializeComponent();
            clock1 = new Clock(0, 0, 0);
            clock2 = new Clock(0, 0, 0);
        }

        private void label_clock1_MouseEnter(object sender, EventArgs e)
        {
            clock1.play_Clock();
            clock2.stop_Clock();
            label_clock1.BackColor = color_active1;
            label_clock2.BackColor = color_passive;
        }

        private void label_clock2_MouseEnter(object sender, EventArgs e)
        {
            clock2.play_Clock();
            clock1.stop_Clock();
            label_clock1.BackColor = color_passive;
            label_clock2.BackColor = color_active2;
        }

        private void label_clock1_MouseClick(object sender, MouseEventArgs e)
        {
            clock1.stop_Clock();
            clock2.stop_Clock();
            label_clock1.BackColor = color_passive;
            label_clock2.BackColor = color_passive;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label_clock1.Text = clock1.show_Clock();
            label_clock2.Text = clock2.show_Clock();
        }

        private void init_clocks (int h, int m)
            {
                 clock1.set_time(h, m, 0);
            clock2.set_time(h, m, 0);
            clock1.stop_Clock();
            clock2.stop_Clock();
            label_clock1.BackColor = color_passive;
            label_clock2.BackColor = color_passive;
        }


        private void menu_1hour_Click(object sender, EventArgs e)
        {
            init_clocks(1, 0);
        }

        private void menu_2min_Click(object sender, EventArgs e)
        {
            init_clocks(0, 2);
        }

        private void menu_5min_Click(object sender, EventArgs e)
        {
            init_clocks(0, 5);
        }

        private void menu_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
