namespace MiniGameCSharp
{
    partial class PlayingGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayingGame));
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectPicA = new System.Windows.Forms.Button();
            this.btnSelectPicB = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.Location = new System.Drawing.Point(38, 125);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(220, 153);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxA.TabIndex = 0;
            this.pictureBoxA.TabStop = false;
            // 
            // pictureBoxB
            // 
            this.pictureBoxB.Location = new System.Drawing.Point(333, 125);
            this.pictureBoxB.Name = "pictureBoxB";
            this.pictureBoxB.Size = new System.Drawing.Size(220, 153);
            this.pictureBoxB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxB.TabIndex = 1;
            this.pictureBoxB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Question:";
            // 
            // btnSelectPicA
            // 
            this.btnSelectPicA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectPicA.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPicA.Location = new System.Drawing.Point(86, 284);
            this.btnSelectPicA.Name = "btnSelectPicA";
            this.btnSelectPicA.Size = new System.Drawing.Size(100, 53);
            this.btnSelectPicA.TabIndex = 3;
            this.btnSelectPicA.Text = "Select";
            this.btnSelectPicA.UseVisualStyleBackColor = false;
            this.btnSelectPicA.Click += new System.EventHandler(this.btnSelectPicA_Click);
            // 
            // btnSelectPicB
            // 
            this.btnSelectPicB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSelectPicB.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectPicB.Location = new System.Drawing.Point(400, 284);
            this.btnSelectPicB.Name = "btnSelectPicB";
            this.btnSelectPicB.Size = new System.Drawing.Size(100, 53);
            this.btnSelectPicB.TabIndex = 3;
            this.btnSelectPicB.Text = "Select";
            this.btnSelectPicB.UseVisualStyleBackColor = false;
            this.btnSelectPicB.Click += new System.EventHandler(this.btnSelectPicB_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.AutoSize = true;
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(135, 22);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(0, 20);
            this.txtQuestion.TabIndex = 4;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("UTM Gille Classic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.Red;
            this.lblPoint.Location = new System.Drawing.Point(506, 13);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(41, 38);
            this.lblPoint.TabIndex = 5;
            this.lblPoint.Text = "0";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Red;
            this.lblTimer.Location = new System.Drawing.Point(280, 304);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(0, 33);
            this.lblTimer.TabIndex = 6;
            // 
            // PlayingGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(603, 416);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnSelectPicB);
            this.Controls.Add(this.btnSelectPicA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxB);
            this.Controls.Add(this.pictureBoxA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PlayingGame";
            this.Text = "PlayingGame";
            this.Load += new System.EventHandler(this.PlayingGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectPicA;
        private System.Windows.Forms.Button btnSelectPicB;
        private System.Windows.Forms.Label txtQuestion;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblTimer;
    }
}