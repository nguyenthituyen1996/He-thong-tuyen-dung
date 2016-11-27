using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FrmMain
{
    public partial class FrmDrawText : Form
    {
        public FrmDrawText()
        {
            InitializeComponent();
        }

        private void FrmDrawText_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics; // lấy graphics để ve
            string str = "HELLO";
            HatchBrush hatchBr = new HatchBrush(HatchStyle.DarkVertical, Color.Yellow, Color.Red);
            // load hinh de tao texture brush
            Image img = Image.FromFile(Application.StartupPath + @"\image2.jpg");
            //file roes.jpg dat trong thu muc debug
            TextureBrush textureBr = new TextureBrush(img);

            LinearGradientBrush linearBr = new LinearGradientBrush(
                new Rectangle(10, 10, 10, 10),
                Color.DarkBlue, Color.White, LinearGradientMode.ForwardDiagonal);

             Font font = new Font("Arial", 48, FontStyle.Bold);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far; // canh le phai
            g.DrawString(str, font, Brushes.Green, ClientRectangle, format);

            format.Alignment = StringAlignment.Near; // canh le trai
            format.LineAlignment = StringAlignment.Far; // canh le duoi
            g.DrawString(str, font, textureBr, ClientRectangle, format);

            format.FormatFlags = StringFormatFlags.DirectionVertical; // hướng đứng
            format.LineAlignment = StringAlignment.Near;
            format.Alignment = StringAlignment.Near;
            g.DrawString(str, font, hatchBr, ClientRectangle, format);

            format.LineAlignment = StringAlignment.Far;
            format.Alignment = StringAlignment.Far;
            g.DrawString(str, font, linearBr, ClientRectangle, format); 
        }

      }
    }

