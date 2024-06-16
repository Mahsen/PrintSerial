using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using PrintSerial.Properties;
using System.Threading;

namespace PrintSerial
{
    public partial class Form1 : Form
    {
        private PrintDocument printDocument1 = new PrintDocument();
        Bitmap memoryImage;

        public Form1(string[] args)
        {
            InitializeComponent();

            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

            CaptureScreen(args);

            printDocument1.Print();
            System.Environment.Exit(0);
        }

        private void CaptureScreen(string[] args)
        {
            Box.Image = memoryImage;

            String Serial = "";
            String Date = "";
            String Pass = "";
            
            try
            {
                Serial = args[0];
                Date = args[1];
                Pass = args[2];
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                System.Environment.Exit(0);
            }
            
            /*
            Serial = "21001018";
            Date = "1402/02/24";
            Pass = "0";
            */

            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Box.Size;

            memoryImage = new Bitmap(Resources.lable);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            try
            {
                BarcodeLib.Barcode b = new BarcodeLib.Barcode();
                Image img = b.Encode(BarcodeLib.TYPE.CODE128, Serial, Color.Black, Color.White, 90, 20);

                memoryGraphics.DrawImage(img, 35, 4);
                memoryGraphics.DrawString(Serial, new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular), Brushes.Black, 38, 21);
                memoryGraphics.DrawString(Date, new Font("Franklin Gothic Medium Cond", 12, FontStyle.Regular), Brushes.Black, 32, 41);
                memoryGraphics.DrawString("Err " + Pass, new Font("Arial", 10, FontStyle.Regular), Brushes.Black, 2, 65);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            Box.Image = memoryImage;
        }

        private void printDocument1_PrintPage(System.Object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void Box_Click(object sender, EventArgs e)
        {

        }
    }
}
