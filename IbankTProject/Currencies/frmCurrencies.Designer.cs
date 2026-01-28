namespace IBTpresentationLayer
{
    partial class frmCurrencies
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            dgvLoigns = new Guna.UI2.WinForms.Guna2DataGridView();
            lblDW = new Label();
            guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)dgvLoigns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).BeginInit();
            SuspendLayout();
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
            dgvLoigns.Location = new Point(-3, 203);
            dgvLoigns.Name = "dgvLoigns";
            dgvLoigns.ReadOnly = true;
            dgvLoigns.RowHeadersVisible = false;
            dgvLoigns.RowHeadersWidth = 51;
            dgvLoigns.RowTemplate.DividerHeight = 5;
            dgvLoigns.RowTemplate.Height = 50;
            dgvLoigns.Size = new Size(940, 498);
            dgvLoigns.TabIndex = 13;
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
            dgvLoigns.CellContentClick += dgvLoigns_CellContentClick;
            // 
            // lblDW
            // 
            lblDW.AutoSize = true;
            lblDW.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDW.ForeColor = Color.FromArgb(192, 57, 43);
            lblDW.Location = new Point(384, 101);
            lblDW.Name = "lblDW";
            lblDW.Size = new Size(220, 45);
            lblDW.TabIndex = 18;
            lblDW.Text = "Currencies";
            // 
            // guna2PictureBox1
            // 
            guna2PictureBox1.CustomizableEdges = customizableEdges1;
            guna2PictureBox1.Image = Properties.Resources.icons8_currencies_100;
            guna2PictureBox1.ImageRotate = 0F;
            guna2PictureBox1.Location = new Point(237, 27);
            guna2PictureBox1.Name = "guna2PictureBox1";
            guna2PictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2PictureBox1.Size = new Size(126, 143);
            guna2PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            guna2PictureBox1.TabIndex = 19;
            guna2PictureBox1.TabStop = false;
            // 
            // btnTransfer
            // 
            btnTransfer.BorderColor = Color.FromArgb(192, 57, 43);
            btnTransfer.BorderRadius = 7;
            btnTransfer.BorderThickness = 1;
            btnTransfer.CustomizableEdges = customizableEdges3;
            btnTransfer.DisabledState.BorderColor = Color.DarkGray;
            btnTransfer.DisabledState.CustomBorderColor = Color.DarkGray;
            btnTransfer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnTransfer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnTransfer.FillColor = Color.Transparent;
            btnTransfer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnTransfer.ForeColor = Color.FromArgb(192, 57, 43);
            btnTransfer.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnTransfer.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnTransfer.Image = Properties.Resources.icons8_currencies_1001;
            btnTransfer.Location = new Point(727, 157);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTransfer.Size = new Size(201, 40);
            btnTransfer.TabIndex = 20;
            btnTransfer.Text = "Currency Calculator";
            btnTransfer.Click += btnTransfer_Click;
            // 
            // frmCurrencies
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 701);
            Controls.Add(btnTransfer);
            Controls.Add(guna2PictureBox1);
            Controls.Add(lblDW);
            Controls.Add(dgvLoigns);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCurrencies";
            Text = "frmCurrencies";
            Load += frmCurrencies_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoigns).EndInit();
            ((System.ComponentModel.ISupportInitialize)guna2PictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvLoigns;
        private Label lblDW;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
    }
}