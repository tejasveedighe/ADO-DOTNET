namespace AdoDemo
{
    partial class AddPropertyForm
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
            label2 = new Label();
            propertyTitle_txt = new TextBox();
            label3 = new Label();
            propertyType_cb = new ComboBox();
            location_txt = new TextBox();
            label4 = new Label();
            price_txt = new TextBox();
            label5 = new Label();
            bedroom_txt = new TextBox();
            label6 = new Label();
            bathroom_txt = new TextBox();
            label7 = new Label();
            squareFeet_txt = new TextBox();
            label8 = new Label();
            description_txt = new TextBox();
            label9 = new Label();
            label10 = new Label();
            status_cb = new ComboBox();
            statusStrip1 = new StatusStrip();
            addProp_crossLabel = new ToolStripStatusLabel();
            button1 = new Button();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLight;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(178, 35);
            label1.Name = "label1";
            label1.Size = new Size(153, 29);
            label1.TabIndex = 0;
            label1.Text = "Add Property";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 93);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 1;
            label2.Text = "Property Title";
            // 
            // propertyTitle_txt
            // 
            propertyTitle_txt.Location = new Point(115, 90);
            propertyTitle_txt.Name = "propertyTitle_txt";
            propertyTitle_txt.Size = new Size(121, 23);
            propertyTitle_txt.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 259);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 3;
            label3.Text = "Property Type";
            // 
            // propertyType_cb
            // 
            propertyType_cb.FormattingEnabled = true;
            propertyType_cb.Items.AddRange(new object[] { "Bunglow", "House", "Flat", "Residence" });
            propertyType_cb.Location = new Point(115, 256);
            propertyType_cb.Name = "propertyType_cb";
            propertyType_cb.Size = new Size(121, 23);
            propertyType_cb.TabIndex = 4;
            // 
            // location_txt
            // 
            location_txt.Location = new Point(115, 142);
            location_txt.Name = "location_txt";
            location_txt.Size = new Size(121, 23);
            location_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 145);
            label4.Name = "label4";
            label4.Size = new Size(53, 15);
            label4.TabIndex = 5;
            label4.Text = "Location";
            // 
            // price_txt
            // 
            price_txt.Location = new Point(340, 145);
            price_txt.Name = "price_txt";
            price_txt.Size = new Size(121, 23);
            price_txt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 148);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 7;
            label5.Text = "Price";
            // 
            // bedroom_txt
            // 
            bedroom_txt.Location = new Point(115, 195);
            bedroom_txt.Name = "bedroom_txt";
            bedroom_txt.Size = new Size(121, 23);
            bedroom_txt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(48, 198);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 9;
            label6.Text = "Bedrooms";
            // 
            // bathroom_txt
            // 
            bathroom_txt.Location = new Point(340, 195);
            bathroom_txt.Name = "bathroom_txt";
            bathroom_txt.Size = new Size(121, 23);
            bathroom_txt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(269, 198);
            label7.Name = "label7";
            label7.Size = new Size(65, 15);
            label7.TabIndex = 11;
            label7.Text = "Bathrooms";
            // 
            // squareFeet_txt
            // 
            squareFeet_txt.Location = new Point(340, 90);
            squareFeet_txt.Name = "squareFeet_txt";
            squareFeet_txt.Size = new Size(121, 23);
            squareFeet_txt.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(266, 93);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 13;
            label8.Text = "Square Feet";
            // 
            // description_txt
            // 
            description_txt.Location = new Point(115, 331);
            description_txt.Multiline = true;
            description_txt.Name = "description_txt";
            description_txt.Size = new Size(346, 134);
            description_txt.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 334);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 15;
            label9.Text = "Description";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(295, 259);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 17;
            label10.Text = "Status";
            // 
            // status_cb
            // 
            status_cb.FormattingEnabled = true;
            status_cb.Items.AddRange(new object[] { "Sale", "Rent" });
            status_cb.Location = new Point(340, 256);
            status_cb.Name = "status_cb";
            status_cb.Size = new Size(121, 23);
            status_cb.TabIndex = 18;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.ControlLight;
            statusStrip1.Dock = DockStyle.Top;
            statusStrip1.Items.AddRange(new ToolStripItem[] { addProp_crossLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.RenderMode = ToolStripRenderMode.Professional;
            statusStrip1.RightToLeft = RightToLeft.Yes;
            statusStrip1.Size = new Size(513, 35);
            statusStrip1.SizingGrip = false;
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // addProp_crossLabel
            // 
            addProp_crossLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addProp_crossLabel.Name = "addProp_crossLabel";
            addProp_crossLabel.Size = new Size(25, 30);
            addProp_crossLabel.Text = "X";
            addProp_crossLabel.Click += addProp_crossLabel_Click;
            // 
            // button1
            // 
            button1.Location = new Point(204, 518);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 20;
            button1.Text = "Add Property";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddPropertyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(513, 562);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(status_cb);
            Controls.Add(label10);
            Controls.Add(description_txt);
            Controls.Add(label9);
            Controls.Add(squareFeet_txt);
            Controls.Add(label8);
            Controls.Add(bathroom_txt);
            Controls.Add(label7);
            Controls.Add(bedroom_txt);
            Controls.Add(label6);
            Controls.Add(price_txt);
            Controls.Add(label5);
            Controls.Add(location_txt);
            Controls.Add(label4);
            Controls.Add(propertyType_cb);
            Controls.Add(label3);
            Controls.Add(propertyTitle_txt);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Name = "AddPropertyForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPropertyForm";
            Load += AddPropertyForm_Load;
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox propertyTitle_txt;
        private Label label3;
        private ComboBox propertyType_cb;
        private TextBox location_txt;
        private Label label4;
        private TextBox price_txt;
        private Label label5;
        private TextBox bedroom_txt;
        private Label label6;
        private TextBox bathroom_txt;
        private Label label7;
        private TextBox squareFeet_txt;
        private Label label8;
        private TextBox description_txt;
        private Label label9;
        private Label label10;
        private ComboBox status_cb;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel addProp_crossLabel;
        private Button button1;
        private ErrorProvider errorProvider1;
    }
}