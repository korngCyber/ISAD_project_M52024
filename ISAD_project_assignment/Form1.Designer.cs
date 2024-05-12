namespace ISAD_project_assignment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboCusSearch = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCusDelete = new Guna.UI2.WinForms.Guna2Button();
            this.btnCuspdate = new Guna.UI2.WinForms.Guna2Button();
            this.btnCusSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnCussave = new Guna.UI2.WinForms.Guna2Button();
            this.txtCusCon = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCusId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TableCus = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.TableCus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboCusSearch
            // 
            this.ComboCusSearch.BackColor = System.Drawing.Color.Transparent;
            this.ComboCusSearch.BorderRadius = 20;
            this.ComboCusSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ComboCusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCusSearch.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboCusSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ComboCusSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboCusSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ComboCusSearch.ItemHeight = 30;
            this.ComboCusSearch.Items.AddRange(new object[] {
            "ID",
            "NAME",
            "CONTACT"});
            this.ComboCusSearch.Location = new System.Drawing.Point(809, 429);
            this.ComboCusSearch.Name = "ComboCusSearch";
            this.ComboCusSearch.Size = new System.Drawing.Size(122, 36);
            this.ComboCusSearch.TabIndex = 28;
            // 
            // btnCusDelete
            // 
            this.btnCusDelete.AutoRoundedCorners = true;
            this.btnCusDelete.BorderRadius = 17;
            this.btnCusDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCusDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCusDelete.ForeColor = System.Drawing.Color.White;
            this.btnCusDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnCusDelete.Image")));
            this.btnCusDelete.Location = new System.Drawing.Point(687, 386);
            this.btnCusDelete.Name = "btnCusDelete";
            this.btnCusDelete.Size = new System.Drawing.Size(112, 37);
            this.btnCusDelete.TabIndex = 27;
            this.btnCusDelete.Text = "DELETE";
            this.btnCusDelete.Click += new System.EventHandler(this.btnCusDelete_Click);
            // 
            // btnCuspdate
            // 
            this.btnCuspdate.AutoRoundedCorners = true;
            this.btnCuspdate.BorderRadius = 17;
            this.btnCuspdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCuspdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCuspdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCuspdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCuspdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCuspdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCuspdate.ForeColor = System.Drawing.Color.White;
            this.btnCuspdate.Image = ((System.Drawing.Image)(resources.GetObject("btnCuspdate.Image")));
            this.btnCuspdate.Location = new System.Drawing.Point(563, 386);
            this.btnCuspdate.Name = "btnCuspdate";
            this.btnCuspdate.Size = new System.Drawing.Size(114, 37);
            this.btnCuspdate.TabIndex = 25;
            this.btnCuspdate.Text = "UPDATE";
            this.btnCuspdate.Click += new System.EventHandler(this.btnCuspdate_Click);
            // 
            // btnCusSearch
            // 
            this.btnCusSearch.AutoRoundedCorners = true;
            this.btnCusSearch.BorderRadius = 17;
            this.btnCusSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCusSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCusSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCusSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCusSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCusSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCusSearch.ForeColor = System.Drawing.Color.White;
            this.btnCusSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnCusSearch.Image")));
            this.btnCusSearch.Location = new System.Drawing.Point(809, 386);
            this.btnCusSearch.Name = "btnCusSearch";
            this.btnCusSearch.Size = new System.Drawing.Size(122, 37);
            this.btnCusSearch.TabIndex = 24;
            this.btnCusSearch.Text = "SEARCH";
            this.btnCusSearch.Click += new System.EventHandler(this.btnCusSearch_Click);
            // 
            // btnCussave
            // 
            this.btnCussave.AutoRoundedCorners = true;
            this.btnCussave.BorderRadius = 17;
            this.btnCussave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCussave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCussave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCussave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCussave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCussave.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCussave.ForeColor = System.Drawing.Color.White;
            this.btnCussave.Image = ((System.Drawing.Image)(resources.GetObject("btnCussave.Image")));
            this.btnCussave.Location = new System.Drawing.Point(435, 386);
            this.btnCussave.Name = "btnCussave";
            this.btnCussave.Size = new System.Drawing.Size(112, 37);
            this.btnCussave.TabIndex = 23;
            this.btnCussave.Text = "SAVE";
            this.btnCussave.Click += new System.EventHandler(this.btnCussave_Click);
            // 
            // txtCusCon
            // 
            this.txtCusCon.Animated = true;
            this.txtCusCon.AutoRoundedCorners = true;
            this.txtCusCon.BorderRadius = 20;
            this.txtCusCon.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusCon.DefaultText = "";
            this.txtCusCon.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusCon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusCon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusCon.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusCon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusCon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusCon.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusCon.Location = new System.Drawing.Point(689, 284);
            this.txtCusCon.Name = "txtCusCon";
            this.txtCusCon.PasswordChar = '\0';
            this.txtCusCon.PlaceholderText = "";
            this.txtCusCon.SelectedText = "";
            this.txtCusCon.Size = new System.Drawing.Size(322, 42);
            this.txtCusCon.TabIndex = 22;
            // 
            // txtCusName
            // 
            this.txtCusName.Animated = true;
            this.txtCusName.AutoRoundedCorners = true;
            this.txtCusName.BorderRadius = 20;
            this.txtCusName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusName.DefaultText = "";
            this.txtCusName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusName.Location = new System.Drawing.Point(689, 216);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.PasswordChar = '\0';
            this.txtCusName.PlaceholderText = "";
            this.txtCusName.SelectedText = "";
            this.txtCusName.Size = new System.Drawing.Size(322, 42);
            this.txtCusName.TabIndex = 20;
            // 
            // txtCusId
            // 
            this.txtCusId.Animated = true;
            this.txtCusId.AutoRoundedCorners = true;
            this.txtCusId.BorderRadius = 20;
            this.txtCusId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCusId.DefaultText = "";
            this.txtCusId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCusId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCusId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCusId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusId.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCusId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCusId.Location = new System.Drawing.Point(689, 138);
            this.txtCusId.Name = "txtCusId";
            this.txtCusId.PasswordChar = '\0';
            this.txtCusId.PlaceholderText = "";
            this.txtCusId.SelectedText = "";
            this.txtCusId.Size = new System.Drawing.Size(322, 42);
            this.txtCusId.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(447, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Customer ID";
            // 
            // TableCus
            // 
            this.TableCus.AllowUserToAddRows = false;
            this.TableCus.AllowUserToDeleteRows = false;
            this.TableCus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableCus.Location = new System.Drawing.Point(39, 471);
            this.TableCus.Name = "TableCus";
            this.TableCus.ReadOnly = true;
            this.TableCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableCus.Size = new System.Drawing.Size(1046, 319);
            this.TableCus.TabIndex = 16;
            this.TableCus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableCus_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Customer Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(447, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 29);
            this.label3.TabIndex = 29;
            this.label3.Text = "Customer Contact";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 29);
            this.label4.TabIndex = 30;
            this.label4.Text = "Customer Name";
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(39, 115);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(382, 337);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 32;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.AutoRoundedCorners = true;
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 17;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton1.Image")));
            this.guna2GradientButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton1.ImageSize = new System.Drawing.Size(35, 35);
            this.guna2GradientButton1.Location = new System.Drawing.Point(948, 386);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(125, 37);
            this.guna2GradientButton1.TabIndex = 33;
            this.guna2GradientButton1.Text = "logout";
            this.guna2GradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GradientButton1.UseTransparentBackground = true;
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1103, 802);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ComboCusSearch);
            this.Controls.Add(this.btnCusDelete);
            this.Controls.Add(this.btnCuspdate);
            this.Controls.Add(this.btnCusSearch);
            this.Controls.Add(this.btnCussave);
            this.Controls.Add(this.txtCusCon);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TableCus);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TableCus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox ComboCusSearch;
        private Guna.UI2.WinForms.Guna2Button btnCusDelete;
        private Guna.UI2.WinForms.Guna2Button btnCuspdate;
        private Guna.UI2.WinForms.Guna2Button btnCusSearch;
        private Guna.UI2.WinForms.Guna2Button btnCussave;
        private Guna.UI2.WinForms.Guna2TextBox txtCusCon;
        private Guna.UI2.WinForms.Guna2TextBox txtCusName;
        private Guna.UI2.WinForms.Guna2TextBox txtCusId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView TableCus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
    }
}

