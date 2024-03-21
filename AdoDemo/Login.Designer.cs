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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            userEmail_txt = new TextBox();
            userPassword_txt = new TextBox();
            SignInBtn = new Button();
            forgetPass_label = new Label();
            register_label = new Label();
            pictureBox1 = new PictureBox();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1 = new StatusStrip();
            crossLabel = new ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumSeaGreen;
            label1.Location = new Point(123, 65);
            label1.Name = "label1";
            label1.Size = new Size(87, 29);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            // 
            // userEmail_txt
            // 
            userEmail_txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userEmail_txt.BorderStyle = BorderStyle.None;
            userEmail_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userEmail_txt.Location = new Point(50, 200);
            userEmail_txt.MinimumSize = new Size(233, 28);
            userEmail_txt.Name = "userEmail_txt";
            userEmail_txt.PlaceholderText = "User Email...";
            userEmail_txt.Size = new Size(233, 28);
            userEmail_txt.TabIndex = 1;
            userEmail_txt.Validating += userEmail_txt_Validating;
            // 
            // userPassword_txt
            // 
            userPassword_txt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            userPassword_txt.BorderStyle = BorderStyle.None;
            userPassword_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userPassword_txt.Location = new Point(50, 248);
            userPassword_txt.MinimumSize = new Size(233, 28);
            userPassword_txt.Name = "userPassword_txt";
            userPassword_txt.PlaceholderText = "Password...";
            userPassword_txt.Size = new Size(233, 28);
            userPassword_txt.TabIndex = 2;
            userPassword_txt.UseSystemPasswordChar = true;
            userPassword_txt.Validating += userPassword_txt_Validating;
            // 
            // SignInBtn
            // 
            SignInBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SignInBtn.BackColor = Color.MediumSeaGreen;
            SignInBtn.FlatAppearance.BorderColor = Color.White;
            SignInBtn.FlatAppearance.BorderSize = 0;
            SignInBtn.FlatStyle = FlatStyle.Flat;
            SignInBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SignInBtn.ForeColor = SystemColors.Control;
            SignInBtn.ImageAlign = ContentAlignment.TopRight;
            SignInBtn.Location = new Point(110, 339);
            SignInBtn.Name = "SignInBtn";
            SignInBtn.Size = new Size(100, 30);
            SignInBtn.TabIndex = 3;
            SignInBtn.Text = "Sign In";
            SignInBtn.UseVisualStyleBackColor = false;
            SignInBtn.Click += SignInBtn_Click;
            // 
            // forgetPass_label
            // 
            forgetPass_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            forgetPass_label.AutoSize = true;
            forgetPass_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            forgetPass_label.ForeColor = Color.MediumSeaGreen;
            forgetPass_label.Location = new Point(151, 283);
            forgetPass_label.Name = "forgetPass_label";
            forgetPass_label.Size = new Size(132, 21);
            forgetPass_label.TabIndex = 5;
            forgetPass_label.Text = "Forget Password?";
            forgetPass_label.Click += forgetPass_label_Click;
            // 
            // register_label
            // 
            register_label.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            register_label.AutoSize = true;
            register_label.BackColor = Color.Transparent;
            register_label.Cursor = Cursors.Hand;
            register_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_label.ForeColor = Color.MediumSeaGreen;
            register_label.Location = new Point(68, 448);
            register_label.Name = "register_label";
            register_label.Size = new Size(202, 21);
            register_label.TabIndex = 6;
            register_label.Text = "New User? Click To Register";
            register_label.Click += register_label_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = Resource1.pngwing_com;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.ErrorImage = Resource1.pngwing_com;
            pictureBox1.Image = Resource1.logo;
            pictureBox1.Location = new Point(135, 106);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 58);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.Items.AddRange(new ToolStripItem[] { crossLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(337, 30);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = " ";
            // 
            // crossLabel
            // 
            crossLabel.AutoSize = false;
            crossLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            crossLabel.Name = "crossLabel";
            crossLabel.RightToLeft = RightToLeft.No;
            crossLabel.Size = new Size(25, 25);
            crossLabel.Text = "X";
            crossLabel.Click += crossLabel_Click;
            // 
            // Login
            // 
            AcceptButton = SignInBtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(337, 479);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(register_label);
            Controls.Add(forgetPass_label);
            Controls.Add(SignInBtn);
            Controls.Add(userPassword_txt);
            Controls.Add(userEmail_txt);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox userEmail_txt;
        private TextBox userPassword_txt;
        private Button SignInBtn;
        private Label forgetPass_label;
        private Label register_label;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel crossLabel;
    }
}