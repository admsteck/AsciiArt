using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BBIS.ASCIIArt
{
    public partial class Form1 : Form
    {
        private static readonly string[] ShadesOfGray = new String[] { "M", "W", "B","R", "G", "e", "o", "c", "+", ":", ".", " " };

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            StringBuilder html = new StringBuilder();
            html.Append("<html><head><style>.ascii_art{font-family:monospace;line-height:.6em;}</style></head><body>");
            Bitmap bmp = null;
            int scale = int.Parse(this.numericUpDownScale.Value.ToString());
            try
            {
                // Create a bitmap from the image
                bmp = new Bitmap(this.textBoxPath.Text);

                // The text will be enclosed in a paragraph tag with the class
                // ascii_art so that we can apply CSS styles to it.
                html.Append("<pre class='ascii_art'>");

                // Loop through each pixel in the bitmap
                for (int y = 0; y < bmp.Height; y += scale)
                {
                    for (int x = 0; x < bmp.Width; x += scale)
                    {
                        // Get the color of the current pixel
                        Color col = bmp.GetPixel(x, y);

                        html.Append(getStringRepresentation(col));

                        // If we're at the width, insert a line break
                        if (x >= bmp.Width - scale)
                            html.Append("<br/>");
                    }
                }

                // Close the paragraph tag, and return the html string.
                html.Append("</pre></body></html>");
                string path = "C:\\Documents and Settings\\kltq0377\\My Documents\\test\\test.html";
                path = Application.UserAppDataPath + "\\temp.html";
                StreamWriter file = File.CreateText(path);
                file.Write(html.ToString());
                file.Close();
                Uri page = new Uri(path);
                this.webBrowser1.Url = page;
            }
            catch (Exception exc)
            {
                Console.Write(exc.ToString());
            }
            finally
            {
                bmp.Dispose();
            }

        }

        private static string getStringRepresentation(Color color)
        {
            double value = color.GetBrightness() * (ShadesOfGray.Length - 1);
            return ShadesOfGray[Convert.ToInt32(value)];
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.textBoxPath.Text = this.openFileDialog1.FileName;
        }

        private void geterateValues()
        {
            String test = "zxcvbnm,./ZXCVBNM<>?asdfghjkl;'ASDFGHJKL:qwertyuiop[]QWERTYUIOP{}|`1234567890-=~!@#$%^&*()_+";
            char[] chars = test.ToCharArray();
            StreamWriter file = File.CreateText("C:\\Documents and Settings\\kltq0377\\My Documents\\test\\test.csv");

            foreach (char c in chars)
            {
                Bitmap b = new Bitmap(24, 24, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                Graphics g = Graphics.FromImage(b);
                GraphicsUnit gu = GraphicsUnit.Pixel;
                g.FillRectangle(new SolidBrush(Color.White), b.GetBounds(ref gu));
                g.DrawString(c.ToString(), new Font("Terminal", 12, FontStyle.Regular), new SolidBrush(Color.Black), 0, 0);
                double value = 0;
                for (int i = 0; i < b.Width; i++)
                {
                    for (int j = 0; j < b.Height; j++)
                    {
                        Color col = b.GetPixel(i, j);
                        value += col.GetBrightness();
                    }
                }
                file.WriteLine(string.Format("{0},{1}", c.ToString(), value.ToString()));
                b.Dispose();
            }
            file.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            File.Copy(Application.UserAppDataPath + "\\temp.html", this.saveFileDialog1.FileName);
        }
    }
}
