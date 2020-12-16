using System.Windows.Forms;

namespace RussianRoulette
{
    partial class Form1
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
            this.ShootHead = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.Load = new System.Windows.Forms.Button();
            this.ShootAway = new System.Windows.Forms.Button();
            this.PlayAgain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShootHead
            // 
            this.ShootHead.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ShootHead.Font = new System.Drawing.Font("Comic Sans MS", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootHead.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShootHead.Location = new System.Drawing.Point(20, 190);
            this.ShootHead.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ShootHead.Name = "ShootHead";
            this.ShootHead.Size = new System.Drawing.Size(182, 134);
            this.ShootHead.TabIndex = 0;
            this.ShootHead.Text = "Shoot";
            this.ShootHead.UseVisualStyleBackColor = false;
            this.ShootHead.Click += new System.EventHandler(this.ShootHead_Click);
            // 
            // Spin
            // 
            this.Spin.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.Location = new System.Drawing.Point(5, 95);
            this.Spin.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(208, 63);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = true;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // Load
            // 
            this.Load.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(5, 25);
            this.Load.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(208, 58);
            this.Load.TabIndex = 2;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // ShootAway
            // 
            this.ShootAway.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAway.Location = new System.Drawing.Point(5, 352);
            this.ShootAway.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.ShootAway.Name = "ShootAway";
            this.ShootAway.Size = new System.Drawing.Size(208, 40);
            this.ShootAway.TabIndex = 3;
            this.ShootAway.Text = "Shoot Away";
            this.ShootAway.UseVisualStyleBackColor = true;
            this.ShootAway.Click += new System.EventHandler(this.ShootAway_Click);
            // 
            // PlayAgain
            // 
            this.PlayAgain.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayAgain.ForeColor = System.Drawing.Color.Red;
            this.PlayAgain.Location = new System.Drawing.Point(5, 404);
            this.PlayAgain.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.PlayAgain.Name = "PlayAgain";
            this.PlayAgain.Size = new System.Drawing.Size(208, 40);
            this.PlayAgain.TabIndex = 7;
            this.PlayAgain.Text = "Try Again";
            this.PlayAgain.UseVisualStyleBackColor = true;
            this.PlayAgain.Click += new System.EventHandler(this.PlayAgain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RussianRoulette.Properties.Resources.sniper;
            this.pictureBox1.Location = new System.Drawing.Point(219, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(745, 440);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 448);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PlayAgain);
            this.Controls.Add(this.ShootAway);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.ShootHead);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ShootHead;
        private System.Windows.Forms.Button Spin;
        private new System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button ShootAway;
        private object form1;

        public object GetForm1()
        {
            return form1;
        }

        private void SetForm1(object value)
        {
            form1 = value;
        }

        public Form1(Button load)
        {
            Load = load;
        }
        private Button PlayAgain;
        private PictureBox pictureBox1;
    }
}

