namespace IBTpresentationLayer
{
    partial class frmManageUsers
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageUsers));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            tbFilter = new MaskedTextBox();
            btnAddUSre = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblNumOfClients = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            dgvUsers = new Guna.UI2.WinForms.Guna2DataGridView();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(tbFilter);
            guna2Panel1.Controls.Add(btnAddUSre);
            guna2Panel1.Controls.Add(btnSearch);
            guna2Panel1.Controls.Add(cbFilter);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblNumOfClients);
            guna2Panel1.CustomBorderColor = Color.Silver;
            guna2Panel1.CustomBorderThickness = new Padding(0, 0, 0, 1);
            guna2Panel1.CustomizableEdges = customizableEdges7;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Panel1.Size = new Size(940, 78);
            guna2Panel1.TabIndex = 5;
            // 
            // tbFilter
            // 
            tbFilter.Font = new Font("Segoe UI", 10F);
            tbFilter.Location = new Point(486, 21);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(166, 30);
            tbFilter.TabIndex = 1;
            tbFilter.MaskInputRejected += tbFilter_MaskInputRejected;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // btnAddUSre
            // 
            btnAddUSre.BorderColor = Color.Silver;
            btnAddUSre.BorderRadius = 10;
            btnAddUSre.BorderThickness = 1;
            btnAddUSre.CustomizableEdges = customizableEdges1;
            btnAddUSre.DisabledState.BorderColor = Color.DarkGray;
            btnAddUSre.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddUSre.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddUSre.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddUSre.FillColor = Color.Transparent;
            btnAddUSre.Font = new Font("Segoe UI", 9F);
            btnAddUSre.ForeColor = Color.DimGray;
            btnAddUSre.Image = (Image)resources.GetObject("btnAddUSre.Image");
            btnAddUSre.ImageSize = new Size(30, 30);
            btnAddUSre.Location = new Point(821, 22);
            btnAddUSre.Name = "btnAddUSre";
            btnAddUSre.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddUSre.Size = new Size(50, 47);
            btnAddUSre.TabIndex = 4;
            btnAddUSre.Click += btnAddUSre_Click;
            // 
            // btnSearch
            // 
            btnSearch.BorderColor = Color.Silver;
            btnSearch.BorderRadius = 10;
            btnSearch.BorderThickness = 1;
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.Transparent;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.DimGray;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.ImageSize = new Size(30, 30);
            btnSearch.Location = new Point(878, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(50, 47);
            btnSearch.TabIndex = 3;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.FromArgb(242, 245, 250);
            cbFilter.CustomizableEdges = customizableEdges5;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FillColor = Color.FromArgb(242, 245, 250);
            cbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilter.Font = new Font("Segoe UI", 8F);
            cbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "None", "User ID", "Person ID", "User Name", "Full Name", "Phone", "Email", "Country", "Gender" });
            cbFilter.Location = new Point(285, 17);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            cbFilter.Size = new Size(195, 36);
            cbFilter.StartIndex = 0;
            cbFilter.TabIndex = 0;
            cbFilter.TextOffset = new Point(2, 0);
            cbFilter.SelectedIndexChanged += cbFilter_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(206, 30);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 2;
            label2.Text = "Filter By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(80, 30);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 1;
            label1.Text = "Users";
            // 
            // lblNumOfClients
            // 
            lblNumOfClients.AutoSize = true;
            lblNumOfClients.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOfClients.ForeColor = Color.FromArgb(192, 57, 43);
            lblNumOfClients.Location = new Point(12, 11);
            lblNumOfClients.Name = "lblNumOfClients";
            lblNumOfClients.Size = new Size(62, 42);
            lblNumOfClients.TabIndex = 1;
            lblNumOfClients.Text = "70";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUsers.ColumnHeadersHeight = 40;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUsers.GridColor = Color.FromArgb(242, 245, 250);
            dgvUsers.Location = new Point(0, 81);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersVisible = false;
            dgvUsers.RowHeadersWidth = 51;
            dgvUsers.RowTemplate.DividerHeight = 5;
            dgvUsers.RowTemplate.Height = 50;
            dgvUsers.Size = new Size(940, 576);
            dgvUsers.TabIndex = 8;
            dgvUsers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvUsers.ThemeStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dgvUsers.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            dgvUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvUsers.ThemeStyle.HeaderStyle.Height = 40;
            dgvUsers.ThemeStyle.ReadOnly = true;
            dgvUsers.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvUsers.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            dgvUsers.ThemeStyle.RowsStyle.Height = 50;
            dgvUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(192, 57, 43);
            dgvUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvUsers.DoubleClick += dgvUsers_DoubleClick;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.FromArgb(192, 57, 43);
            btnDelete.BorderRadius = 7;
            btnDelete.BorderThickness = 1;
            btnDelete.CustomizableEdges = customizableEdges9;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.FromArgb(192, 57, 43);
            btnDelete.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnDelete.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnDelete.Location = new Point(736, 663);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDelete.Size = new Size(88, 32);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BorderColor = Color.FromArgb(192, 57, 43);
            btnEdit.BorderRadius = 7;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges11;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.ForeColor = Color.FromArgb(192, 57, 43);
            btnEdit.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnEdit.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnEdit.Location = new Point(840, 663);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnEdit.Size = new Size(88, 32);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "Edit ";
            btnEdit.Click += btnEdit_Click;
            // 
            // frmManageUsers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 701);
            Controls.Add(guna2Panel1);
            Controls.Add(dgvUsers);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmManageUsers";
            Text = "frmManageUsers";
            Load += frmManageUsers_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private MaskedTextBox tbFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddUSre;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Label label2;
        private Label label1;
        private Label lblNumOfClients;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvUsers;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
    }
}