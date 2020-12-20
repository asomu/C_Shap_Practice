using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncFileIOWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async Task<long> CopyAsync(string FromPath, string ToPath)
        {
            btnSyncCopy.Enabled = false;
            long totalCopied = 0;

            using (FileStream fromStream =
                new FileStream(FromPath, FileMode.Open))
            {
                using (FileStream ToStream =
                new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while((nRead = 
                        await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await ToStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;

                        pbCopy.Value = (int)(((double)totalCopied / (double)fromStream.Length) * pbCopy.Maximum);
                    }
                     
                }
            }
            btnSyncCopy.Enabled = true;
            return totalCopied;
        }

        private long CopySync(string FromPath, string ToPath)
        {
            btnAsyncCopy.Enabled = false;
            long totalCopied = 0;
            using (FileStream fromStream =
                new FileStream(FromPath, FileMode.Open))
            {
                using(var toStream =
                    new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024 * 1024];
                    int nRead = 0;
                    while((nRead =
                        fromStream.Read(buffer, 0, buffer.Length))!=0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;
                        pbCopy.Value = (int)(((double)totalCopied / (double)fromStream.Length) * pbCopy.Maximum);
                    }
                     
                }
            }
            btnAsyncCopy.Enabled = true;
            return totalCopied;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtSource.Text = dlg.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dlg = new SaveFileDialog();
            if(dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textTarget.Text = dlg.FileName;
            }
        }

        private async void btnAsyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = await CopyAsync(txtSource.Text, textTarget.Text);
        }

        private void btnSyncCopy_Click(object sender, EventArgs e)
        {
            long totalCopied = CopySync(txtSource.Text, textTarget.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("UI 반응 테스트 성공.");

        }
    }
}
