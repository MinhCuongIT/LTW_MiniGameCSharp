using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniGameCSharp
{
    /// <summary>
    /// Màn hình hiển thị điểm cao
    /// </summary>
    public partial class HighScore : Form
    {
        public HighScore()
        {
            InitializeComponent();
        }

        #region Events
        /// <summary>
        /// Xử lí đóng màn hình này lại
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Xử lí sự kiện load form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HighScore_Load(object sender, EventArgs e)
        {
            try
            {
                int[] score = new int[5];
                using (StreamReader streamReader = new StreamReader("Score.dat"))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        score[i] = int.Parse(streamReader.ReadLine());
                    }
                }
                String txtScore = String.Empty;
                for (int j = 0; j < 5; j++)
                {
                    txtScore += (j + 1) + ". " + score[j] + "\r\n";
                }
                this.txtHighScore.Text = txtScore;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
