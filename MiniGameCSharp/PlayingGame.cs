using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace MiniGameCSharp
{
    /// <summary>
    /// Form hiện thị cửa số chơi game
    /// </summary>
    public partial class PlayingGame : Form
    {
        #region Variables
        /// <summary>
        /// Đối tượng lưu giữ các câu hỏi
        /// </summary>
        private MyFlag[] arrFlag = new MyFlag[10];

        /// <summary>
        /// Đối tượng tạo bộ sinh số ngẫu nhiên
        /// </summary>
        private Random random = new Random();

        /// <summary>
        /// Đối tượng lưu giữ giá trị của của lá cờ chọn đúng
        /// </summary>
        private int truePic;

        /// <summary>
        /// Đối tượng lưu giữ giá trị điểm của người chơi
        /// </summary>
        private int point;

        /// <summary>
        /// Biến hỗ trợ đếm ngược cho timer
        /// </summary>
        private int countDown;

        /// <summary>
        /// Đối tượng đếm ngược
        /// </summary>
        private Timer timer;
        #endregion

        #region Properties
        frmMain main;
        #endregion

        #region Constructor
        /// <summary>
        /// Hàm dựng mặc định
        /// </summary>
        public PlayingGame(frmMain _frmMain)
        {
            this.main = _frmMain;
            InitializeComponent();
            //Tải dữ liệu hình ảnh
            LoadData();

        }
        #endregion

        #region Events
        /// <summary>
        /// Xử lí khi Form vừa mới được load lên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PlayingGame_Load(object sender, EventArgs e)
        {
            RandomFlagsAndQuestion();
        }

        /// <summary>
        /// Xử lí khi button của lá cờ 1 được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPicA_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (truePic == 1)
            {
                //Trường hợp người dùng chọn đúng đáp án
                IncreatePoint();
                RandomFlagsAndQuestion();
            }
            else
            {
                //Trường hợp người dùng chọn sai đáp án
                MessageBox.Show("Your answer was wrong", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show("Your score: " + point);
                this.Hide();
                this.main.Show();
                SaveScore(this.point);
            }
        }

        /// <summary>
        /// Xử lí khi button của lá cờ 2 được chọn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectPicB_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (truePic == 2)
            {
                //Trường hợp người dùng chọn đúng đáp án
                IncreatePoint();
                RandomFlagsAndQuestion();
            }
            else
            {
                //Trường hợp người dùng chọn sai đáp án
                MessageBox.Show("Your answer was wrong\n", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                MessageBox.Show("Your score: "+ point);
                this.Hide();
                this.main.Show();
                SaveScore(this.point);
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Tải dữ liệu từ file: file hình và file câu hỏi
        /// </summary>
        private void LoadData()
        {
            //Đọc chuỗi từ tập tin
            String line = String.Empty;
            using (StreamReader streamReader = new StreamReader("Questions.dat"))
            {
                try
                {
                    int i = 0;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        MyFlag myFlag = new MyFlag(Application.StartupPath + @"\Flags\" + (i + 1) + ".png", line);
                        arrFlag[i] = myFlag;
                        i++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Has an error while loading data from file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Tạo phát sinh câu hỏi và lá cờ ngẫu nhiên
        /// </summary>
        private void RandomFlagsAndQuestion()
        {
            int iFlag = random.Next(0, 10);
            int iPic = random.Next(1, 3);
            if (iPic == 1)
            {
                this.truePic = 1;
                this.txtQuestion.Text = arrFlag[iFlag].Question;
                pictureBoxA.ImageLocation = arrFlag[iFlag].Path;
                while (true)
                {
                    int iFlag2 = random.Next(0, 10);
                    if (iFlag2 != iFlag)
                    {
                        pictureBoxB.ImageLocation = arrFlag[iFlag2].Path;
                        break;
                    }
                }

            }
            else
            {
                this.truePic = 2;
                this.txtQuestion.Text = arrFlag[iFlag].Question;
                pictureBoxB.ImageLocation = arrFlag[iFlag].Path;
                while (true)
                {
                    int iFlag2 = random.Next(0, 10);
                    if (iFlag2 != iFlag)
                    {
                        pictureBoxA.ImageLocation = arrFlag[iFlag2].Path;
                        break;
                    }
                }
            }
            countDown = 10;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        /// <summary>
        /// Xử lí sự kiện timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Tick(object sender, EventArgs e)
        {
            if (countDown <= 0)
            {
                timer.Stop();
                MessageBox.Show("Timer Over!");
                MessageBox.Show("Your score: " + point);
                this.Hide();
                this.main.Show();
                SaveScore(this.point);
            }
            this.lblTimer.Text = countDown + "";
            countDown--;
        }

        /// <summary>
        /// Xử lí tăng điểm khi người dùng chọn đúng lá cờ
        /// </summary>
        private void IncreatePoint()
        {
            this.point += 10;
            this.lblPoint.Text = this.point + "";
        }

        /// <summary>
        /// Lưu điểm cao
        /// </summary>
        /// <param name="point"></param>
        private void SaveScore(int point)
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
                    if (point < score[4])
                    {
                        return;
                    }
                    score[4] = point;
                    score = (from element in score orderby element descending select element).ToArray();
                }
                using (StreamWriter streamWriter = new StreamWriter("Score.dat"))
                {
                    for (int i = 0; i < 5; i++)
                    {
                        streamWriter.WriteLine(score[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Has an error while to save score!\n"+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
