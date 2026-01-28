namespace IBTpresentationLayer
{
    partial class frmShowClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowClients));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            tbFilter = new MaskedTextBox();
            btnAddClient = new Guna.UI2.WinForms.Guna2Button();
            btnSearchClient = new Guna.UI2.WinForms.Guna2Button();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblNumOfClients = new Label();
            btnEdit = new Guna.UI2.WinForms.Guna2Button();
            btnDelete = new Guna.UI2.WinForms.Guna2Button();
            dgvClients = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            SuspendLayout();
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(tbFilter);
            guna2Panel1.Controls.Add(btnAddClient);
            guna2Panel1.Controls.Add(btnSearchClient);
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
            guna2Panel1.TabIndex = 0;
            // 
            // tbFilter
            // 
            tbFilter.Font = new Font("Segoe UI", 10F);
            tbFilter.Location = new Point(486, 21);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(166, 30);
            tbFilter.TabIndex = 1;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // btnAddClient
            // 
            btnAddClient.BorderColor = Color.Silver;
            btnAddClient.BorderRadius = 10;
            btnAddClient.BorderThickness = 1;
            btnAddClient.CustomizableEdges = customizableEdges1;
            btnAddClient.DisabledState.BorderColor = Color.DarkGray;
            btnAddClient.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddClient.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddClient.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddClient.FillColor = Color.Transparent;
            btnAddClient.Font = new Font("Segoe UI", 9F);
            btnAddClient.ForeColor = Color.DimGray;
            btnAddClient.Image = (Image)resources.GetObject("btnAddClient.Image");
            btnAddClient.ImageSize = new Size(30, 30);
            btnAddClient.Location = new Point(821, 22);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddClient.Size = new Size(50, 47);
            btnAddClient.TabIndex = 4;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnSearchClient
            // 
            btnSearchClient.BorderColor = Color.Silver;
            btnSearchClient.BorderRadius = 10;
            btnSearchClient.BorderThickness = 1;
            btnSearchClient.CustomizableEdges = customizableEdges3;
            btnSearchClient.DisabledState.BorderColor = Color.DarkGray;
            btnSearchClient.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearchClient.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearchClient.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearchClient.FillColor = Color.Transparent;
            btnSearchClient.Font = new Font("Segoe UI", 9F);
            btnSearchClient.ForeColor = Color.DimGray;
            btnSearchClient.Image = Properties.Resources.search;
            btnSearchClient.ImageSize = new Size(30, 30);
            btnSearchClient.Location = new Point(887, 21);
            btnSearchClient.Name = "btnSearchClient";
            btnSearchClient.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearchClient.Size = new Size(50, 47);
            btnSearchClient.TabIndex = 3;
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
            cbFilter.Items.AddRange(new object[] { "None", "Client ID", "Person ID", "Full Name", "Phone", "Email", "Country", "PinCode", "Gender" });
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
            label1.Size = new Size(59, 21);
            label1.TabIndex = 1;
            label1.Text = "Clients";
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
            // btnEdit
            // 
            btnEdit.BorderColor = Color.FromArgb(192, 57, 43);
            btnEdit.BorderRadius = 7;
            btnEdit.BorderThickness = 1;
            btnEdit.CustomizableEdges = customizableEdges9;
            btnEdit.DisabledState.BorderColor = Color.DarkGray;
            btnEdit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnEdit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnEdit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnEdit.FillColor = Color.Transparent;
            btnEdit.Font = new Font("Segoe UI", 9F);
            btnEdit.ForeColor = Color.FromArgb(192, 57, 43);
            btnEdit.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnEdit.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnEdit.Location = new Point(840, 657);
            btnEdit.Name = "btnEdit";
            btnEdit.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnEdit.Size = new Size(88, 32);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit ";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BorderColor = Color.FromArgb(192, 57, 43);
            btnDelete.BorderRadius = 7;
            btnDelete.BorderThickness = 1;
            btnDelete.CustomizableEdges = customizableEdges11;
            btnDelete.DisabledState.BorderColor = Color.DarkGray;
            btnDelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDelete.FillColor = Color.Transparent;
            btnDelete.Font = new Font("Segoe UI", 9F);
            btnDelete.ForeColor = Color.FromArgb(192, 57, 43);
            btnDelete.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnDelete.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnDelete.Location = new Point(736, 657);
            btnDelete.Name = "btnDelete";
            btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnDelete.Size = new Size(88, 32);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvClients
            // 
            dgvClients.AllowUserToAddRows = false;
            dgvClients.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvClients.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClients.ColumnHeadersHeight = 40;
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvClients.DefaultCellStyle = dataGridViewCellStyle3;
            dgvClients.GridColor = Color.FromArgb(242, 245, 250);
            dgvClients.Location = new Point(0, 75);
            dgvClients.Name = "dgvClients";
            dgvClients.ReadOnly = true;
            dgvClients.RowHeadersVisible = false;
            dgvClients.RowHeadersWidth = 51;
            dgvClients.RowTemplate.DividerHeight = 5;
            dgvClients.RowTemplate.Height = 50;
            dgvClients.Size = new Size(940, 576);
            dgvClients.TabIndex = 4;
            dgvClients.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            dgvClients.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvClients.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvClients.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvClients.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvClients.ThemeStyle.BackColor = Color.White;
            dgvClients.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvClients.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvClients.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvClients.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dgvClients.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            dgvClients.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvClients.ThemeStyle.HeaderStyle.Height = 40;
            dgvClients.ThemeStyle.ReadOnly = true;
            dgvClients.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvClients.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvClients.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvClients.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            dgvClients.ThemeStyle.RowsStyle.Height = 50;
            dgvClients.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(192, 57, 43);
            dgvClients.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            dgvClients.CellDoubleClick += dgvClients_CellDoubleClick;
            // 
            // frmShowClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 701);
            Controls.Add(dgvClients);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(guna2Panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmShowClients";
            Text = "frmShowClients";
            Load += frmShowClients_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblNumOfClients;
        private Label label1;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2Button btnSearchClient;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button btnAddClient;
        private MaskedTextBox tbFilter;
        private Guna.UI2.WinForms.Guna2Button btnEdit;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClients;
    }
}