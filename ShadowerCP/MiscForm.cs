using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Compression;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using ShadowerCP.Misc;

namespace ShadowerCP
{
    public partial class MiscForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
          (
              int nLeftRect,     // x-coordinate of upper-left corner
              int nTopRect,      // y-coordinate of upper-left corner
              int nRightRect,    // x-coordinate of lower-right corner
              int nBottomRect,   // y-coordinate of lower-right corner
              int nWidthEllipse, // width of ellipse
              int nHeightEllipse // height of ellipse
          );

        public MiscForm()
        {
            InitializeComponent();
            cmbOps.SelectedIndex = 0;
        }

        private void btnGetResult_Click(object sender, EventArgs e)
        {
            if (rtInput.Text.Trim().Length > 0)
            {
                ACtionOnInput(cmbOps.SelectedIndex);
            }else
            {
                rtInput.Text = "Please try with some input !!";
            }
        }

        private void ACtionOnInput(int iUserSelection)
        {
            switch (iUserSelection)
            {
                case 0:
                    byte[] input = Encoding.UTF8.GetBytes(rtInput.Text);
                    rtOutput.Text = Convert.ToBase64String(input);
                    break;
                case 1:
                    byte[] output = Convert.FromBase64String(rtInput.Text);
                    rtOutput.Text = Encoding.UTF8.GetString(output);
                    break;
                case 2:
                    rtOutput.Text = Misc.EncodeActions.CompressInput(rtInput.Text);
                    break;
                case 3:
                    rtOutput.Text = Misc.EncodeActions.Decompress(rtInput.Text);
                    break;
                default:
                    break;
            }
        }

        private string Unzip(byte[] bytes)
        {
            using (var msi = new MemoryStream(bytes))
            using (var mso = new MemoryStream())
            {
                using (var gs = new GZipStream(msi, CompressionMode.Decompress))
                {
                    CopyTo(gs, mso);
                }
                return System.Text.Encoding.UTF8.GetString(mso.ToArray());
            }
        }

        private void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }

      

       

       

        private void MiscForm_Load(object sender, EventArgs e)
        {
            //btnGetResult.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, 150, 150, 20, 20));

        }

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
