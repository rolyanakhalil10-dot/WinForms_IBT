namespace IBTpresentationLayer
{
    partial class frmTotalBalances
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            dgvLoigns = new Guna.UI2.WinForms.Guna2DataGridView();
            lblDW = new Label();
            lblBalance = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLoigns).BeginInit();
            SuspendLayout();
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
            dgvLoigns.Location = new Point(-5, 85);
            dgvLoigns.Name = "dgvLoigns";
            dgvLoigns.ReadOnly = true;
            dgvLoigns.RowHeadersVisible = false;
            dgvLoigns.RowHeadersWidth = 51;
            dgvLoigns.RowTemplate.DividerHeight = 5;
            dgvLoigns.RowTemplate.Height = 50;
            dgvLoigns.Size = new Size(952, 464);
            dgvLoigns.TabIndex = 16;
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
            dgvLoigns.DoubleClick += dgvLoigns_DoubleClick;
            // 
            // lblDW
            // 
            lblDW.AutoSize = true;
            lblDW.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDW.ForeColor = Color.FromArgb(192, 57, 43);
            lblDW.Location = new Point(320, 9);
            lblDW.Name = "lblDW";
            lblDW.Size = new Size(300, 45);
            lblDW.TabIndex = 17;
            lblDW.Text = "Total Balances";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.Maroon;
            lblBalance.Location = new Point(259, 552);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(49, 37);
            lblBalance.TabIndex = 20;
            lblBalance.Text = "00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(12, 552);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 19;
            label1.Text = "Total Balance:";
            // 
            // frmTotalBalances
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(949, 593);
            Controls.Add(lblBalance);
            Controls.Add(label1);
            Controls.Add(lblDW);
            Controls.Add(dgvLoigns);
            Name = "frmTotalBalances";
            Text = "frmTotalBalances";
            Load += frmTotalBalances_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLoigns).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvLoigns;
        private Label lblDW;
        private Label lblBalance;
        private Label label1;
    }
}