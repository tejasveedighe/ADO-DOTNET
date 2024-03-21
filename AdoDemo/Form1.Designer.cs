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
            desc_txt = new TextBox();
            update_btn = new Button();
            type_cb = new ComboBox();
            status_cb = new ComboBox();
            contact_txt = new TextBox();
            squareFeet_txt = new TextBox();
            bathroom_Txt = new TextBox();
            bedroom_txt = new TextBox();
            price_txt = new TextBox();
            property_location_txt = new TextBox();
            property_title_txt = new TextBox();
            refreshBtn = new Button();
            label2 = new Label();
            properties_add_property_btn = new Button();
            dataGridView1 = new DataGridView();
            delete_btn = new Button();
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
            properties_tab.Controls.Add(delete_btn);
            properties_tab.Controls.Add(desc_txt);
            properties_tab.Controls.Add(update_btn);
            properties_tab.Controls.Add(type_cb);
            properties_tab.Controls.Add(status_cb);
            properties_tab.Controls.Add(contact_txt);
            properties_tab.Controls.Add(squareFeet_txt);
            properties_tab.Controls.Add(bathroom_Txt);
            properties_tab.Controls.Add(bedroom_txt);
            properties_tab.Controls.Add(price_txt);
            properties_tab.Controls.Add(property_location_txt);
            properties_tab.Controls.Add(property_title_txt);
            properties_tab.Controls.Add(refreshBtn);
            properties_tab.Controls.Add(label2);
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
            // desc_txt
            // 
            desc_txt.Location = new Point(390, 12);
            desc_txt.Multiline = true;
            desc_txt.Name = "desc_txt";
            desc_txt.PlaceholderText = "Description";
            desc_txt.Size = new Size(199, 147);
            desc_txt.TabIndex = 17;
            // 
            // update_btn
            // 
            update_btn.Location = new Point(254, 176);
            update_btn.Name = "update_btn";
            update_btn.Size = new Size(108, 23);
            update_btn.TabIndex = 16;
            update_btn.Text = "Update Property";
            update_btn.UseVisualStyleBackColor = true;
            update_btn.Click += update_btn_Click;
            // 
            // type_cb
            // 
            type_cb.FormattingEnabled = true;
            type_cb.Items.AddRange(new object[] { "Bunglow", "Flat", "Residence", "House" });
            type_cb.Location = new Point(201, 136);
            type_cb.Name = "type_cb";
            type_cb.Size = new Size(161, 23);
            type_cb.TabIndex = 15;
            // 
            // status_cb
            // 
            status_cb.FormattingEnabled = true;
            status_cb.Items.AddRange(new object[] { "Sale", "Rent" });
            status_cb.Location = new Point(201, 94);
            status_cb.Name = "status_cb";
            status_cb.Size = new Size(161, 23);
            status_cb.TabIndex = 14;
            // 
            // contact_txt
            // 
            contact_txt.Location = new Point(201, 51);
            contact_txt.Name = "contact_txt";
            contact_txt.PlaceholderText = "Contact Number";
            contact_txt.Size = new Size(161, 23);
            contact_txt.TabIndex = 13;
            // 
            // squareFeet_txt
            // 
            squareFeet_txt.Location = new Point(201, 12);
            squareFeet_txt.Name = "squareFeet_txt";
            squareFeet_txt.PlaceholderText = "Square Feet";
            squareFeet_txt.Size = new Size(161, 23);
            squareFeet_txt.TabIndex = 12;
            // 
            // bathroom_Txt
            // 
            bathroom_Txt.Location = new Point(18, 176);
            bathroom_Txt.Name = "bathroom_Txt";
            bathroom_Txt.PlaceholderText = "No of Bathroom";
            bathroom_Txt.Size = new Size(161, 23);
            bathroom_Txt.TabIndex = 11;
            // 
            // bedroom_txt
            // 
            bedroom_txt.Location = new Point(18, 136);
            bedroom_txt.Name = "bedroom_txt";
            bedroom_txt.PlaceholderText = "No of Bedroom";
            bedroom_txt.Size = new Size(161, 23);
            bedroom_txt.TabIndex = 10;
            // 
            // price_txt
            // 
            price_txt.Location = new Point(18, 94);
            price_txt.Name = "price_txt";
            price_txt.PlaceholderText = "Price";
            price_txt.Size = new Size(161, 23);
            price_txt.TabIndex = 9;
            // 
            // property_location_txt
            // 
            property_location_txt.Location = new Point(18, 51);
            property_location_txt.Name = "property_location_txt";
            property_location_txt.PlaceholderText = "Property Location";
            property_location_txt.Size = new Size(161, 23);
            property_location_txt.TabIndex = 8;
            // 
            // property_title_txt
            // 
            property_title_txt.Location = new Point(18, 12);
            property_title_txt.Name = "property_title_txt";
            property_title_txt.PlaceholderText = "Property Title";
            property_title_txt.Size = new Size(161, 23);
            property_title_txt.TabIndex = 7;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(859, 209);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(108, 23);
            refreshBtn.TabIndex = 6;
            refreshBtn.Text = "Refresh";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 217);
            label2.Name = "label2";
            label2.Size = new Size(77, 15);
            label2.TabIndex = 5;
            label2.Text = "All Properties";
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(3, 238);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1083, 374);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // delete_btn
            // 
            delete_btn.Location = new Point(390, 175);
            delete_btn.Name = "delete_btn";
            delete_btn.Size = new Size(108, 23);
            delete_btn.TabIndex = 18;
            delete_btn.Text = "Delete Property";
            delete_btn.UseVisualStyleBackColor = true;
            delete_btn.Click += delete_btn_Click;
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
        private Button properties_add_property_btn;
        private Label label2;
        private Button refreshBtn;
        private TextBox price_txt;
        private TextBox property_location_txt;
        private TextBox property_title_txt;
        private ComboBox type_cb;
        private ComboBox status_cb;
        private TextBox contact_txt;
        private TextBox squareFeet_txt;
        private TextBox bathroom_Txt;
        private TextBox bedroom_txt;
        private Button update_btn;
        private TextBox desc_txt;
        private Button delete_btn;
    }
}
