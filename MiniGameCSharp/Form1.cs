using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGameCSharp
{
    /// <summary>
    /// Màn hình chính
    /// </summary>
    public partial class frmMain : Form
    {
        #region Variables

        #endregion

        #region Properties

        #endregion

        #region Constructor
        //Hàm dựng mặc định
        public frmMain()
        {
            //Hàm khởi tạo mặc định
            InitializeComponent();
        }
        #endregion

        #region Events
        /// <summary>
        /// Xử lí sự kiện button Start click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            PlayingGame playingGame = new PlayingGame(this);
            playingGame.Show();
            this.Hide();
        }
        /// <summary>
        /// Xử lí sự kiện button HighScore được Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHighScore_Click(object sender, EventArgs e)
        {
            HighScore highScore = new HighScore();
            highScore.ShowDialog();
        }
        /// <summary>
        /// Xử lí sự kiện khi button Instruction được click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInstuction_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.ShowDialog();
        }
        /// <summary>
        /// Xử lí button About: Thực chất là hiện thông tin của chương trình
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbout_Click(object sender, EventArgs e)
        {
            //Hiện hộp thoại show ra thông tin của chương trình này
            MessageBox.Show("Student Name: Trần Minh Cường\n" +
                "Student ID: 1512054\n" +
                "subject: Windows Programming\n" +
                "Teacher: Trần Duy Quang\n" +
                "Mini Game with C#", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Methods

        #endregion
    }
}
