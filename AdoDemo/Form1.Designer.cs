namespace AdoDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            tabControl1 = new TabControl();
            users_tab = new TabPage();
            properties_tab = new TabPage();
            dataGridView1 = new DataGridView();
            tabPage3 = new TabPage();
            properties_add_property_btn = new Button();
            tabControl1.SuspendLayout();
            properties_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(-132, 39);
            label1.Name = "label1";
            label1.Size = new Size(95, 24);
            label1.TabIndex = 1;
            label1.Text = "Properties";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(users_tab);
            tabControl1.Controls.Add(properties_tab);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1097, 643);
            tabControl1.TabIndex = 3;
            // 
            // users_tab
            // 
            users_tab.Location = new Point(4, 24);
            users_tab.Name = "users_tab";
            users_tab.Padding = new Padding(3);
            users_tab.Size = new Size(1089, 615);
            users_tab.TabIndex = 0;
            users_tab.Text = "Users";
            users_tab.UseVisualStyleBackColor = true;
            users_tab.Click += users_tab_Click;
            // 
            // properties_tab
            // 
            properties_tab.Controls.Add(properties_add_property_btn);
            properties_tab.Controls.Add(dataGridView1);
            properties_tab.Controls.Add(label1);
            properties_tab.Location = new Point(4, 24);
            properties_tab.Name = "properties_tab";
            properties_tab.Padding = new Padding(3);
            properties_tab.Size = new Size(1089, 615);
            properties_tab.TabIndex = 1;
            properties_tab.Text = "Properties";
            properties_tab.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1083, 374);
            dataGridView1.TabIndex = 4;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1089, 615);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // properties_add_property_btn
            // 
            properties_add_property_btn.Location = new Point(973, 209);
            properties_add_property_btn.Name = "properties_add_property_btn";
            properties_add_property_btn.Size = new Size(108, 23);
            properties_add_property_btn.TabIndex = 4;
            properties_add_property_btn.Text = "Add Property";
            properties_add_property_btn.UseVisualStyleBackColor = true;
            properties_add_property_btn.Click += properties_add_property_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 643);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Admin Panel";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            properties_tab.ResumeLayout(false);
            properties_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private TabControl tabControl1;
        private TabPage users_tab;
        private TabPage properties_tab;
        private DataGridView dataGridView1;
        private TabPage tabPage3;
        private Button properties_add_property_btn;
    }
}
