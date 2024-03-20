namespace AdoDemo
{
    partial class Login
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
            label1 = new Label();
            userEmail_txt = new TextBox();
            userPassword_txt = new TextBox();
            SignInBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(123, 29);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // userEmail_txt
            // 
            userEmail_txt.BorderStyle = BorderStyle.None;
            userEmail_txt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userEmail_txt.Location = new Point(53, 170);
            userEmail_txt.Name = "userEmail_txt";
            userEmail_txt.Size = new Size(233, 32);
            userEmail_txt.TabIndex = 1;
            // 
            // userPassword_txt
            // 
            userPassword_txt.BorderStyle = BorderStyle.None;
            userPassword_txt.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            userPassword_txt.Location = new Point(53, 236);
            userPassword_txt.Name = "userPassword_txt";
            userPassword_txt.Size = new Size(233, 32);
            userPassword_txt.TabIndex = 2;
            // 
            // SignInBtn
            // 
            SignInBtn.BackColor = Color.MediumSeaGreen;
            SignInBtn.FlatAppearance.BorderColor = Color.Black;
            SignInBtn.FlatStyle = FlatStyle.Popup;
            SignInBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignInBtn.ForeColor = Color.Cornsilk;
            SignInBtn.ImageAlign = ContentAlignment.TopRight;
            SignInBtn.Location = new Point(113, 326);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(100, 30);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(154, 271);
            label2.Name = "label2";
            label2.Size = new Size(132, 21);
            label2.TabIndex = 5;
            label2.Text = "Forget Password?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(68, 414);
            label3.Name = "label3";
            label3.Size = new Size(202, 21);
            label3.TabIndex = 6;
            label3.Text = "New User? Click To Register";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Resource1.pngwing_com;
            pictureBox1.ErrorImage = Resource1.pngwing_com;
            pictureBox1.Image = Resource1.pngwing_com;
            pictureBox1.Location = new Point(53, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 78);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 444);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SignInBtn);
            Controls.Add(userPassword_txt);
            Controls.Add(userEmail_txt);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userEmail_txt;
        private TextBox userPassword_txt;
        private Button SignInBtn;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox1;
    }
}