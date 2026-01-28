namespace IBTpresentationLayer
{
    partial class frmTransferLogg
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            dtpLogin = new Guna.UI2.WinForms.Guna2DateTimePicker();
            tbFilter = new MaskedTextBox();
            cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            label2 = new Label();
            label1 = new Label();
            lblNumOfClients = new Label();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            dgvLoigns = new Guna.UI2.WinForms.Guna2DataGridView();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoigns).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(dtpLogin);
            guna2Panel1.Controls.Add(tbFilter);
            guna2Panel1.Controls.Add(cbFilter);
            guna2Panel1.Controls.Add(label2);
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblNumOfClients);
            guna2Panel1.CustomBorderColor = Color.Silver;
            guna2Panel1.CustomBorderThickness = new Padding(0, 0, 0, 1);
            guna2Panel1.CustomizableEdges = customizableEdges5;
            guna2Panel1.Dock = DockStyle.Top;
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2Panel1.Size = new Size(949, 78);
            guna2Panel1.TabIndex = 13;
            // 
            // dtpLogin
            // 
            dtpLogin.BorderRadius = 7;
            dtpLogin.Checked = true;
            dtpLogin.CustomizableEdges = customizableEdges1;
            dtpLogin.FillColor = Color.Silver;
            dtpLogin.Font = new Font("Segoe UI", 9F);
            dtpLogin.Format = DateTimePickerFormat.Long;
            dtpLogin.Location = new Point(306, 19);
            dtpLogin.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpLogin.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpLogin.Name = "dtpLogin";
            dtpLogin.ShadowDecoration.CustomizableEdges = customizableEdges2;
            dtpLogin.Size = new Size(217, 37);
            dtpLogin.TabIndex = 15;
            dtpLogin.Value = new DateTime(2025, 7, 12, 18, 29, 21, 327);
            dtpLogin.ValueChanged += dtpLogin_ValueChanged;
            // 
            // tbFilter
            // 
            tbFilter.Font = new Font("Segoe UI", 10F);
            tbFilter.Location = new Point(293, 22);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(166, 30);
            tbFilter.TabIndex = 1;
            tbFilter.MaskInputRejected += tbFilter_MaskInputRejected;
            tbFilter.TextChanged += tbFilter_TextChanged;
            tbFilter.KeyPress += tbFilter_KeyPress;
            // 
            // cbFilter
            // 
            cbFilter.BackColor = Color.FromArgb(242, 245, 250);
            cbFilter.CustomizableEdges = customizableEdges3;
            cbFilter.DrawMode = DrawMode.OwnerDrawFixed;
            cbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilter.FillColor = Color.FromArgb(242, 245, 250);
            cbFilter.FocusedColor = Color.FromArgb(94, 148, 255);
            cbFilter.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFilter.Font = new Font("Segoe UI", 8F);
            cbFilter.ForeColor = Color.FromArgb(68, 88, 112);
            cbFilter.ItemHeight = 30;
            cbFilter.Items.AddRange(new object[] { "None", "Transfer ID", "Sender FullName", "Receiver FullName", "Transfer Date", "Amount" });
            cbFilter.Location = new Point(92, 18);
            cbFilter.Name = "cbFilter";
            cbFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
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
            label2.Location = new Point(13, 27);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 2;
            label2.Text = "Filter By:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(866, 23);
            label1.Name = "label1";
            label1.Size = new Size(92, 42);
            label1.TabIndex = 1;
            label1.Text = "Transfers";
            // 
            // lblNumOfClients
            // 
            lblNumOfClients.AutoSize = true;
            lblNumOfClients.Font = new Font("Gabriola", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumOfClients.ForeColor = Color.FromArgb(192, 57, 43);
            lblNumOfClients.Location = new Point(811, -6);
            lblNumOfClients.Name = "lblNumOfClients";
            lblNumOfClients.Size = new Size(75, 87);
            lblNumOfClients.TabIndex = 1;
            lblNumOfClients.Text = "70";
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // dgvLoigns
            // 
            dgvLoigns.AllowUserToAddRows = false;
            dgvLoigns.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvLoigns.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(242, 245, 250);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvLoigns.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvLoigns.ColumnHeadersHeight = 40;
            dgvLoigns.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.DimGray;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 57, 43);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvLoigns.DefaultCellStyle = dataGridViewCellStyle3;
            dgvLoigns.GridColor = Color.FromArgb(242, 245, 250);
            dgvLoigns.Location = new Point(-3, 76);
            dgvLoigns.Name = "dgvLoigns";
            dgvLoigns.ReadOnly = true;
            dgvLoigns.RowHeadersVisible = false;
            dgvLoigns.RowHeadersWidth = 51;
            dgvLoigns.RowTemplate.DividerHeight = 5;
            dgvLoigns.RowTemplate.Height = 50;
            dgvLoigns.Size = new Size(952, 595);
            dgvLoigns.TabIndex = 14;
            dgvLoigns.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.LightGrid;
            dgvLoigns.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvLoigns.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvLoigns.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvLoigns.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvLoigns.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvLoigns.ThemeStyle.BackColor = Color.White;
            dgvLoigns.ThemeStyle.GridColor = Color.FromArgb(242, 245, 250);
            dgvLoigns.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(242, 245, 250);
            dgvLoigns.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvLoigns.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 8F);
            dgvLoigns.ThemeStyle.HeaderStyle.ForeColor = Color.Black;
            dgvLoigns.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvLoigns.ThemeStyle.HeaderStyle.Height = 40;
            dgvLoigns.ThemeStyle.ReadOnly = true;
            dgvLoigns.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvLoigns.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvLoigns.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvLoigns.ThemeStyle.RowsStyle.ForeColor = Color.DimGray;
            dgvLoigns.ThemeStyle.RowsStyle.Height = 50;
            dgvLoigns.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(192, 57, 43);
            dgvLoigns.ThemeStyle.RowsStyle.SelectionForeColor = Color.White;
            // 
            // frmTransferLogg
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 675);
            Controls.Add(guna2Panel1);
            Controls.Add(dgvLoigns);
            Name = "frmTransferLogg";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTransferLogg";
            Load += frmTransferLogg_Load;
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoigns).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpLogin;
        private MaskedTextBox tbFilter;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Label label2;
        private Label label1;
        private Label lblNumOfClients;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoigns;
    }
}