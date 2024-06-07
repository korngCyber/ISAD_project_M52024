namespace ISAD_project_assignment
{
    partial class SupplierForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSupDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnsupExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuppdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnSupsave = new Guna.UI2.WinForms.Guna2Button();
            this.txtSupID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TableSup = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboSubAdd = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSupName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSubCon = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TableSup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 29);
            this.label4.TabIndex = 44;
            this.label4.Text = "Suplier Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Supplier Contact";
            // 
            // btnSupDelete
            // 
            this.btnSupDelete.AutoRoundedCorners = true;
            this.btnSupDelete.BorderRadius = 20;
            this.btnSupDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(7)))));
            this.btnSupDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSupDelete.ForeColor = System.Drawing.Color.White;
            this.btnSupDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnSupDelete.Image")));
            this.btnSupDelete.Location = new System.Drawing.Point(387, 707);
            this.btnSupDelete.Name = "btnSupDelete";
            this.btnSupDelete.Size = new System.Drawing.Size(122, 43);
            this.btnSupDelete.TabIndex = 41;
            this.btnSupDelete.Text = "DELETE";
            this.btnSupDelete.Click += new System.EventHandler(this.btnSupDelete_Click);
            // 
            // btnsupExit
            // 
            this.btnsupExit.Animated = true;
            this.btnsupExit.AutoRoundedCorners = true;
            this.btnsupExit.BackColor = System.Drawing.Color.Transparent;
            this.btnsupExit.BorderRadius = 20;
            this.btnsupExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsupExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsupExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsupExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsupExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(7)))));
            this.btnsupExit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupExit.ForeColor = System.Drawing.Color.White;
            this.btnsupExit.Image = ((System.Drawing.Image)(resources.GetObject("btnsupExit.Image")));
            this.btnsupExit.Location = new System.Drawing.Point(678, 708);
            this.btnsupExit.Name = "btnsupExit";
            this.btnsupExit.Size = new System.Drawing.Size(122, 43);
            this.btnsupExit.TabIndex = 40;
            this.btnsupExit.Text = "EXIT";
            this.btnsupExit.Click += new System.EventHandler(this.btnsupExit_Click);
            // 
            // btnSuppdate
            // 
            this.btnSuppdate.AutoRoundedCorners = true;
            this.btnSuppdate.BorderRadius = 20;
            this.btnSuppdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuppdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuppdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(7)))));
            this.btnSuppdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnSuppdate.ForeColor = System.Drawing.Color.White;
            this.btnSuppdate.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppdate.Image")));
            this.btnSuppdate.Location = new System.Drawing.Point(248, 707);
            this.btnSuppdate.Name = "btnSuppdate";
            this.btnSuppdate.Size = new System.Drawing.Size(122, 43);
            this.btnSuppdate.TabIndex = 39;
            this.btnSuppdate.Text = "UPDATE";
            this.btnSuppdate.Click += new System.EventHandler(this.btnSuppdate_Click);
            // 
            // btnSupsave
            // 
            this.btnSupsave.AutoRoundedCorners = true;
            this.btnSupsave.BorderRadius = 20;
            this.btnSupsave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSupsave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSupsave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSupsave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSupsave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(7)))));
            this.btnSupsave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupsave.ForeColor = System.Drawing.Color.White;
            this.btnSupsave.Image = ((System.Drawing.Image)(resources.GetObject("btnSupsave.Image")));
            this.btnSupsave.Location = new System.Drawing.Point(112, 708);
            this.btnSupsave.Name = "btnSupsave";
            this.btnSupsave.Size = new System.Drawing.Size(122, 43);
            this.btnSupsave.TabIndex = 37;
            this.btnSupsave.Text = "SAVE";
            this.btnSupsave.Click += new System.EventHandler(this.btnSupsave_Click);
            // 
            // txtSupID
            // 
            this.txtSupID.Animated = true;
            this.txtSupID.AutoRoundedCorners = true;
            this.txtSupID.BorderRadius = 18;
            this.txtSupID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupID.DefaultText = "";
            this.txtSupID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupID.Location = new System.Drawing.Point(647, 133);
            this.txtSupID.Name = "txtSupID";
            this.txtSupID.PasswordChar = '\0';
            this.txtSupID.PlaceholderText = "";
            this.txtSupID.SelectedText = "";
            this.txtSupID.Size = new System.Drawing.Size(245, 38);
            this.txtSupID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(434, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 33;
            this.label2.Text = "Suplier ID";
            // 
            // TableSup
            // 
            this.TableSup.AllowUserToAddRows = false;
            this.TableSup.AllowUserToDeleteRows = false;
            this.TableSup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableSup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableSup.DefaultCellStyle = dataGridViewCellStyle3;
            this.TableSup.Location = new System.Drawing.Point(42, 381);
            this.TableSup.Name = "TableSup";
            this.TableSup.ReadOnly = true;
            this.TableSup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableSup.ShowCellErrors = false;
            this.TableSup.Size = new System.Drawing.Size(850, 312);
            this.TableSup.TabIndex = 32;
            this.TableSup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableSup_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "Supplier Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(215, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Supplier Address";
            // 
            // comboSubAdd
            // 
            this.comboSubAdd.AutoRoundedCorners = true;
            this.comboSubAdd.BackColor = System.Drawing.Color.Transparent;
            this.comboSubAdd.BorderRadius = 17;
            this.comboSubAdd.BorderThickness = 0;
            this.comboSubAdd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboSubAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboSubAdd.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSubAdd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboSubAdd.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboSubAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboSubAdd.ItemHeight = 30;
            this.comboSubAdd.Items.AddRange(new object[] {
            "Phnom Penh",
            "Kompong cham ",
            "kondal"});
            this.comboSubAdd.Location = new System.Drawing.Point(647, 246);
            this.comboSubAdd.Name = "comboSubAdd";
            this.comboSubAdd.Size = new System.Drawing.Size(245, 36);
            this.comboSubAdd.TabIndex = 47;
            // 
            // txtSupName
            // 
            this.txtSupName.Animated = true;
            this.txtSupName.AutoRoundedCorners = true;
            this.txtSupName.BorderRadius = 18;
            this.txtSupName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSupName.DefaultText = "";
            this.txtSupName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSupName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSupName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSupName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSupName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSupName.Location = new System.Drawing.Point(647, 193);
            this.txtSupName.Name = "txtSupName";
            this.txtSupName.PasswordChar = '\0';
            this.txtSupName.PlaceholderText = "";
            this.txtSupName.SelectedText = "";
            this.txtSupName.Size = new System.Drawing.Size(245, 38);
            this.txtSupName.TabIndex = 48;
            // 
            // txtSubCon
            // 
            this.txtSubCon.Animated = true;
            this.txtSubCon.AutoRoundedCorners = true;
            this.txtSubCon.BorderRadius = 19;
            this.txtSubCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSubCon.DefaultText = "";
            this.txtSubCon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSubCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSubCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubCon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSubCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSubCon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSubCon.Location = new System.Drawing.Point(647, 300);
            this.txtSubCon.Name = "txtSubCon";
            this.txtSubCon.PasswordChar = '\0';
            this.txtSubCon.PlaceholderText = "";
            this.txtSubCon.SelectedText = "";
            this.txtSubCon.Size = new System.Drawing.Size(245, 41);
            this.txtSubCon.TabIndex = 49;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(62, 83);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(339, 292);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 50;
            this.guna2PictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            this.searchBox.Animated = true;
            this.searchBox.AutoRoundedCorners = true;
            this.searchBox.BorderRadius = 20;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "Search";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(169)))), ((int)(((byte)(7)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.White;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.Location = new System.Drawing.Point(527, 708);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(129, 42);
            this.searchBox.TabIndex = 51;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            this.searchBox.Enter += new System.EventHandler(this.searchBox_Enter);
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(227)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(954, 802);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtSubCon);
            this.Controls.Add(this.txtSupName);
            this.Controls.Add(this.comboSubAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSupDelete);
            this.Controls.Add(this.btnsupExit);
            this.Controls.Add(this.btnSuppdate);
            this.Controls.Add(this.btnSupsave);
            this.Controls.Add(this.txtSupID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableSup);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SupplierForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)(this.TableSup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnSupDelete;
        private Guna.UI2.WinForms.Guna2Button btnsupExit;
        private Guna.UI2.WinForms.Guna2Button btnSuppdate;
        private Guna.UI2.WinForms.Guna2Button btnSupsave;
        private Guna.UI2.WinForms.Guna2TextBox txtSupID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableSup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox comboSubAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtSupName;
        private Guna.UI2.WinForms.Guna2TextBox txtSubCon;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}