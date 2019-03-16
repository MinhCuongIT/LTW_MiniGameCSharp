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
    /// Màn hình hiển thị hướng dẫn
    /// </summary>
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Xử lí ẩn màn hình hướng dẫn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
