namespace AdoDemo
{
    partial class Register
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
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            crossLabel = new ToolStripStatusLabel();
            label2 = new Label();
            register_name_txt = new TextBox();
            register_email_txt = new TextBox();
            label3 = new Label();
            register_phone_txt = new TextBox();
            label4 = new Label();
            register_pass_txt = new TextBox();
            label5 = new Label();
            register_repass_txt = new TextBox();
            label6 = new Label();
            register_buyer_radio = new RadioButton();
            register_seller_radio = new RadioButton();
            label7 = new Label();
            register_user_btn = new Button();
            label8 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 450);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Resource1.logo;
            pictureBox1.Image = Resource1.logo;
            pictureBox1.Location = new Point(85, 145);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(56, 26);
            label1.Name = "label1";
            label1.Size = new Size(181, 31);
            label1.TabIndex = 0;
            label1.Text = "Register User";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLight;
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.Items.AddRange(new ToolStripItem[] { crossLabel });
            statusStrip1.Location = new Point(292, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(508, 37);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // crossLabel
            // 
            crossLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            crossLabel.Name = "crossLabel";
            crossLabel.RightToLeft = RightToLeft.Yes;
            crossLabel.Size = new Size(28, 32);
            crossLabel.Text = "X";
            crossLabel.Click += crossLabel_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumSeaGreen;
            label2.Location = new Point(376, 96);
            label2.Name = "label2";
            label2.Size = new Size(97, 24);
            label2.TabIndex = 2;
            label2.Text = "Full Name";
            // 
            // register_name_txt
            // 
            register_name_txt.BorderStyle = BorderStyle.None;
            register_name_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_name_txt.Location = new Point(479, 96);
            register_name_txt.MinimumSize = new Size(203, 28);
            register_name_txt.Name = "register_name_txt";
            register_name_txt.PlaceholderText = "Full Name";
            register_name_txt.Size = new Size(203, 28);
            register_name_txt.TabIndex = 3;
            register_name_txt.Validating += register_repass_txt_Validating;
            // 
            // register_email_txt
            // 
            register_email_txt.BorderStyle = BorderStyle.None;
            register_email_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_email_txt.Location = new Point(479, 145);
            register_email_txt.MinimumSize = new Size(203, 28);
            register_email_txt.Name = "register_email_txt";
            register_email_txt.PlaceholderText = "Email";
            register_email_txt.Size = new Size(203, 28);
            register_email_txt.TabIndex = 5;
            register_email_txt.Validating += register_repass_txt_Validating;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumSeaGreen;
            label3.Location = new Point(411, 143);
            label3.Name = "label3";
            label3.Size = new Size(57, 24);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // register_phone_txt
            // 
            register_phone_txt.BorderStyle = BorderStyle.None;
            register_phone_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_phone_txt.Location = new Point(479, 194);
            register_phone_txt.MinimumSize = new Size(203, 28);
            register_phone_txt.Name = "register_phone_txt";
            register_phone_txt.PlaceholderText = "Phone No";
            register_phone_txt.Size = new Size(203, 28);
            register_phone_txt.TabIndex = 7;
            register_phone_txt.Validating += register_repass_txt_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumSeaGreen;
            label4.Location = new Point(372, 194);
            label4.Name = "label4";
            label4.Size = new Size(96, 24);
            label4.TabIndex = 6;
            label4.Text = "Phone No";
            // 
            // register_pass_txt
            // 
            register_pass_txt.BorderStyle = BorderStyle.None;
            register_pass_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_pass_txt.Location = new Point(479, 242);
            register_pass_txt.MinimumSize = new Size(203, 28);
            register_pass_txt.Name = "register_pass_txt";
            register_pass_txt.PlaceholderText = "Password";
            register_pass_txt.Size = new Size(203, 28);
            register_pass_txt.TabIndex = 9;
            register_pass_txt.Validating += register_repass_txt_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumSeaGreen;
            label5.Location = new Point(376, 242);
            label5.Name = "label5";
            label5.Size = new Size(92, 24);
            label5.TabIndex = 8;
            label5.Text = "Password";
            label5.UseMnemonic = false;
            // 
            // register_repass_txt
            // 
            register_repass_txt.BorderStyle = BorderStyle.None;
            register_repass_txt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            register_repass_txt.Location = new Point(479, 286);
            register_repass_txt.MinimumSize = new Size(203, 28);
            register_repass_txt.Name = "register_repass_txt";
            register_repass_txt.PlaceholderText = "Re-password";
            register_repass_txt.Size = new Size(203, 28);
            register_repass_txt.TabIndex = 11;
            register_repass_txt.Validating += register_repass_txt_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumSeaGreen;
            label6.Location = new Point(346, 284);
            label6.Name = "label6";
            label6.Size = new Size(122, 24);
            label6.TabIndex = 10;
            label6.Text = "Re-Password";
            // 
            // register_buyer_radio
            // 
            register_buyer_radio.AutoSize = true;
            register_buyer_radio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            register_buyer_radio.ForeColor = Color.MediumSeaGreen;
            register_buyer_radio.Location = new Point(479, 334);
            register_buyer_radio.Name = "register_buyer_radio";
            register_buyer_radio.Size = new Size(77, 28);
            register_buyer_radio.TabIndex = 12;
            register_buyer_radio.TabStop = true;
            register_buyer_radio.Text = "Buyer";
            register_buyer_radio.UseVisualStyleBackColor = true;
            register_buyer_radio.Validating += register_seller_radio_Validating;
            // 
            // register_seller_radio
            // 
            register_seller_radio.AutoSize = true;
            register_seller_radio.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            register_seller_radio.ForeColor = Color.MediumSeaGreen;
            register_seller_radio.Location = new Point(605, 334);
            register_seller_radio.Name = "register_seller_radio";
            register_seller_radio.Size = new Size(76, 28);
            register_seller_radio.TabIndex = 13;
            register_seller_radio.TabStop = true;
            register_seller_radio.Text = "Seller";
            register_seller_radio.UseVisualStyleBackColor = true;
            register_seller_radio.Validating += register_seller_radio_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Underline, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumSeaGreen;
            label7.Location = new Point(364, 37);
            label7.Name = "label7";
            label7.Size = new Size(344, 31);
            label7.TabIndex = 1;
            label7.Text = "Enter the Following Details ";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // register_user_btn
            // 
            register_user_btn.BackColor = Color.MediumSeaGreen;
            register_user_btn.FlatStyle = FlatStyle.Flat;
            register_user_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            register_user_btn.ForeColor = SystemColors.Control;
            register_user_btn.Location = new Point(572, 377);
            register_user_btn.Name = "register_user_btn";
            register_user_btn.Size = new Size(110, 38);
            register_user_btn.TabIndex = 2;
            register_user_btn.Text = "Register";
            register_user_btn.UseVisualStyleBackColor = false;
            register_user_btn.Click += register_user_btn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.MediumSeaGreen;
            label8.Location = new Point(346, 395);
            label8.Name = "label8";
            label8.Size = new Size(162, 20);
            label8.TabIndex = 14;
            label8.Text = "Already a user? Sign In.";
            label8.Click += label8_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(register_user_btn);
            Controls.Add(label7);
            Controls.Add(register_seller_radio);
            Controls.Add(register_buyer_radio);
            Controls.Add(register_repass_txt);
            Controls.Add(label6);
            Controls.Add(register_pass_txt);
            Controls.Add(label5);
            Controls.Add(register_phone_txt);
            Controls.Add(label4);
            Controls.Add(register_email_txt);
            Controls.Add(label3);
            Controls.Add(register_name_txt);
            Controls.Add(label2);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            MaximizeBox = false;
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel crossLabel;
        private Label label2;
        private TextBox register_name_txt;
        private TextBox register_email_txt;
        private Label label3;
        private TextBox register_phone_txt;
        private Label label4;
        private TextBox register_pass_txt;
        private Label label5;
        private TextBox register_repass_txt;
        private Label label6;
        private RadioButton register_buyer_radio;
        private RadioButton register_seller_radio;
        private Label label7;
        private PictureBox pictureBox1;
        private Button register_user_btn;
        private Label label8;
        private ErrorProvider errorProvider1;
    }
}