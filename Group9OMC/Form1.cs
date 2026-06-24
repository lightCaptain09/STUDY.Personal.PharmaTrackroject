using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group9OMC
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmLogIn newform = new frmLogIn();
            newform.Show();
        }
    }
}


public class RoundedButton : Button
{
    //Adjust this value to change how rounded the capsule looks
    public int BorderRadius { get; set; } = 25;

    public RoundedButton()
    {
        // Smooth out the edges and remove the default Windows borders
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        Size = new Size(180, 40);
        BackColor = Color.White;
        ForeColor = Color.Black;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Create the pill shape path
        Rectangle rect = new Rectangle(0, 0, Width, Height);
        using (GraphicsPath path = GetRoundPath(rect, BorderRadius))
        {
            this.Region = new Region(path);

            // Draw a thin outline to match your screenshot
            using (Pen pen = new Pen(Color.Black, 2.5f))
            {
                pevent.Graphics.DrawPath(pen, path);
            }
        }
    }

    private GraphicsPath GetRoundPath(Rectangle r, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        int diameter = radius * 2;

        path.AddArc(r.X, r.Y, diameter, diameter, 180, 90);
        path.AddArc(r.X + r.Width - diameter, r.Y, diameter, diameter, 270, 90);
        path.AddArc(r.X + r.Width - diameter, r.Y + r.Height - diameter, diameter, diameter, 0, 90);
        path.AddArc(r.X, r.Y + r.Height - diameter, diameter, diameter, 90, 90);
        path.CloseAllFigures();

        return path;
    }
}