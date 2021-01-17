namespace VPsemesterProject
{
    partial class DeleteItemForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DeleteItembutton = new System.Windows.Forms.Button();
            this.DeleteBrandbutton = new System.Windows.Forms.Button();
            this.Deletecategorybutton = new System.Windows.Forms.Button();
            this.Edititembutton = new System.Windows.Forms.Button();
            this.Editbrandbutton = new System.Windows.Forms.Button();
            this.EditCategorybutton = new System.Windows.Forms.Button();
            this.additembutton = new System.Windows.Forms.Button();
            this.addbrandbutton = new System.Windows.Forms.Button();
            this.addcategorybutton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(200, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 199);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Peru;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Maroon;
            this.button1.Location = new System.Drawing.Point(552, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 34);
            this.button1.TabIndex = 11;
            this.button1.Text = "Preview";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Peru;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(311, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(171, 26);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Peru;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(203, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Peru;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(200, -6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 38);
            this.label2.TabIndex = 25;
            this.label2.Text = "Inventory Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Image = global::VPsemesterProject.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DeleteItembutton
            // 
            this.DeleteItembutton.BackColor = System.Drawing.Color.Peru;
            this.DeleteItembutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteItembutton.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteItembutton.Location = new System.Drawing.Point(-3, 322);
            this.DeleteItembutton.Name = "DeleteItembutton";
            this.DeleteItembutton.Size = new System.Drawing.Size(167, 30);
            this.DeleteItembutton.TabIndex = 23;
            this.DeleteItembutton.Text = "Delete Item";
            this.DeleteItembutton.UseVisualStyleBackColor = false;
            this.DeleteItembutton.Click += new System.EventHandler(this.DeleteItembutton_Click);
            // 
            // DeleteBrandbutton
            // 
            this.DeleteBrandbutton.BackColor = System.Drawing.Color.Peru;
            this.DeleteBrandbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBrandbutton.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteBrandbutton.Location = new System.Drawing.Point(-3, 286);
            this.DeleteBrandbutton.Name = "DeleteBrandbutton";
            this.DeleteBrandbutton.Size = new System.Drawing.Size(167, 30);
            this.DeleteBrandbutton.TabIndex = 22;
            this.DeleteBrandbutton.Text = "Delete Brand";
            this.DeleteBrandbutton.UseVisualStyleBackColor = false;
            this.DeleteBrandbutton.Click += new System.EventHandler(this.DeleteBrandbutton_Click);
            // 
            // Deletecategorybutton
            // 
            this.Deletecategorybutton.BackColor = System.Drawing.Color.Peru;
            this.Deletecategorybutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletecategorybutton.ForeColor = System.Drawing.Color.Maroon;
            this.Deletecategorybutton.Location = new System.Drawing.Point(-3, 251);
            this.Deletecategorybutton.Name = "Deletecategorybutton";
            this.Deletecategorybutton.Size = new System.Drawing.Size(167, 30);
            this.Deletecategorybutton.TabIndex = 21;
            this.Deletecategorybutton.Text = "Delete Category";
            this.Deletecategorybutton.UseVisualStyleBackColor = false;
            this.Deletecategorybutton.Click += new System.EventHandler(this.Deletecategorybutton_Click);
            // 
            // Edititembutton
            // 
            this.Edititembutton.BackColor = System.Drawing.Color.Peru;
            this.Edititembutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edititembutton.ForeColor = System.Drawing.Color.Maroon;
            this.Edititembutton.Location = new System.Drawing.Point(-3, 218);
            this.Edititembutton.Name = "Edititembutton";
            this.Edititembutton.Size = new System.Drawing.Size(167, 30);
            this.Edititembutton.TabIndex = 20;
            this.Edititembutton.Text = "Edit Item";
            this.Edititembutton.UseVisualStyleBackColor = false;
            this.Edititembutton.Click += new System.EventHandler(this.Edititembutton_Click);
            // 
            // Editbrandbutton
            // 
            this.Editbrandbutton.BackColor = System.Drawing.Color.Peru;
            this.Editbrandbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editbrandbutton.ForeColor = System.Drawing.Color.Maroon;
            this.Editbrandbutton.Location = new System.Drawing.Point(-3, 182);
            this.Editbrandbutton.Name = "Editbrandbutton";
            this.Editbrandbutton.Size = new System.Drawing.Size(167, 30);
            this.Editbrandbutton.TabIndex = 19;
            this.Editbrandbutton.Text = "Edit Brand";
            this.Editbrandbutton.UseVisualStyleBackColor = false;
            this.Editbrandbutton.Click += new System.EventHandler(this.Editbrandbutton_Click);
            // 
            // EditCategorybutton
            // 
            this.EditCategorybutton.BackColor = System.Drawing.Color.Peru;
            this.EditCategorybutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCategorybutton.ForeColor = System.Drawing.Color.Maroon;
            this.EditCategorybutton.Location = new System.Drawing.Point(-3, 146);
            this.EditCategorybutton.Name = "EditCategorybutton";
            this.EditCategorybutton.Size = new System.Drawing.Size(167, 30);
            this.EditCategorybutton.TabIndex = 18;
            this.EditCategorybutton.Text = "Edit Category";
            this.EditCategorybutton.UseVisualStyleBackColor = false;
            this.EditCategorybutton.Click += new System.EventHandler(this.EditCategorybutton_Click);
            // 
            // additembutton
            // 
            this.additembutton.BackColor = System.Drawing.Color.Peru;
            this.additembutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additembutton.ForeColor = System.Drawing.Color.Maroon;
            this.additembutton.Location = new System.Drawing.Point(-3, 113);
            this.additembutton.Name = "additembutton";
            this.additembutton.Size = new System.Drawing.Size(167, 30);
            this.additembutton.TabIndex = 17;
            this.additembutton.Text = "Add Item";
            this.additembutton.UseVisualStyleBackColor = false;
            this.additembutton.Click += new System.EventHandler(this.additembutton_Click);
            // 
            // addbrandbutton
            // 
            this.addbrandbutton.BackColor = System.Drawing.Color.Peru;
            this.addbrandbutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addbrandbutton.ForeColor = System.Drawing.Color.Maroon;
            this.addbrandbutton.Location = new System.Drawing.Point(-3, 77);
            this.addbrandbutton.Name = "addbrandbutton";
            this.addbrandbutton.Size = new System.Drawing.Size(167, 30);
            this.addbrandbutton.TabIndex = 16;
            this.addbrandbutton.Text = "Add Brand";
            this.addbrandbutton.UseVisualStyleBackColor = false;
            this.addbrandbutton.Click += new System.EventHandler(this.addbrandbutton_Click);
            // 
            // addcategorybutton
            // 
            this.addcategorybutton.BackColor = System.Drawing.Color.Peru;
            this.addcategorybutton.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcategorybutton.ForeColor = System.Drawing.Color.Maroon;
            this.addcategorybutton.Location = new System.Drawing.Point(-3, 41);
            this.addcategorybutton.Name = "addcategorybutton";
            this.addcategorybutton.Size = new System.Drawing.Size(167, 30);
            this.addcategorybutton.TabIndex = 15;
            this.addcategorybutton.Text = "Add Category";
            this.addcategorybutton.UseVisualStyleBackColor = false;
            this.addcategorybutton.Click += new System.EventHandler(this.addcategorybutton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Peru;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(354, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 27;
            this.label3.Text = "DELETE ITEM";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // DeleteItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPsemesterProject.Properties.Resources._7c678815c15bea1fbbb665cfa4ca1bbe__united_states_new_jersey_union_county_summit_springfield_avenue_784_kings_food_markets_37047;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(674, 360);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DeleteItembutton);
            this.Controls.Add(this.DeleteBrandbutton);
            this.Controls.Add(this.Deletecategorybutton);
            this.Controls.Add(this.Edititembutton);
            this.Controls.Add(this.Editbrandbutton);
            this.Controls.Add(this.EditCategorybutton);
            this.Controls.Add(this.additembutton);
            this.Controls.Add(this.addbrandbutton);
            this.Controls.Add(this.addcategorybutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "DeleteItemForm";
            this.Text = "DeleteItemForm";
            this.Load += new System.EventHandler(this.DeleteItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DeleteItembutton;
        private System.Windows.Forms.Button DeleteBrandbutton;
        private System.Windows.Forms.Button Deletecategorybutton;
        private System.Windows.Forms.Button Edititembutton;
        private System.Windows.Forms.Button Editbrandbutton;
        private System.Windows.Forms.Button EditCategorybutton;
        private System.Windows.Forms.Button additembutton;
        private System.Windows.Forms.Button addbrandbutton;
        private System.Windows.Forms.Button addcategorybutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}