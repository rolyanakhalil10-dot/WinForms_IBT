namespace IBTpresentationLayer
{
    partial class frmCurrencyCalculator
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCurrencyCalculator));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            cbCodeFrom = new Guna.UI2.WinForms.Guna2ComboBox();
            lblDW = new Label();
            label2 = new Label();
            label1 = new Label();
            cbCodeTo = new Guna.UI2.WinForms.Guna2ComboBox();
            tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            btnConvert = new Guna.UI2.WinForms.Guna2Button();
            tbExchangedAmountj = new Guna.UI2.WinForms.Guna2TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbCodeFrom
            // 
            cbCodeFrom.BackColor = Color.Transparent;
            cbCodeFrom.CustomizableEdges = customizableEdges11;
            cbCodeFrom.DrawMode = DrawMode.OwnerDrawFixed;
            cbCodeFrom.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodeFrom.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCodeFrom.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCodeFrom.Font = new Font("Segoe UI", 10F);
            cbCodeFrom.ForeColor = Color.FromArgb(68, 88, 112);
            cbCodeFrom.ItemHeight = 30;
            cbCodeFrom.Location = new Point(205, 103);
            cbCodeFrom.Name = "cbCodeFrom";
            cbCodeFrom.ShadowDecoration.CustomizableEdges = customizableEdges12;
            cbCodeFrom.Size = new Size(189, 36);
            cbCodeFrom.TabIndex = 11;
            // 
            // lblDW
            // 
            lblDW.AutoSize = true;
            lblDW.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDW.ForeColor = Color.FromArgb(192, 57, 43);
            lblDW.Location = new Point(52, 21);
            lblDW.Name = "lblDW";
            lblDW.Size = new Size(400, 45);
            lblDW.TabIndex = 18;
            lblDW.Text = "Currency Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(192, 57, 43);
            label2.Location = new Point(12, 103);
            label2.Name = "label2";
            label2.Size = new Size(168, 27);
            label2.TabIndex = 19;
            label2.Text = "Convert From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 57, 43);
            label1.Location = new Point(12, 177);
            label1.Name = "label1";
            label1.Size = new Size(144, 27);
            label1.TabIndex = 20;
            label1.Text = "Convert To:";
            // 
            // cbCodeTo
            // 
            cbCodeTo.BackColor = Color.Transparent;
            cbCodeTo.CustomizableEdges = customizableEdges13;
            cbCodeTo.DrawMode = DrawMode.OwnerDrawFixed;
            cbCodeTo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCodeTo.FocusedColor = Color.FromArgb(94, 148, 255);
            cbCodeTo.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCodeTo.Font = new Font("Segoe UI", 10F);
            cbCodeTo.ForeColor = Color.FromArgb(68, 88, 112);
            cbCodeTo.ItemHeight = 30;
            cbCodeTo.Location = new Point(205, 168);
            cbCodeTo.Name = "cbCodeTo";
            cbCodeTo.ShadowDecoration.CustomizableEdges = customizableEdges14;
            cbCodeTo.Size = new Size(189, 36);
            cbCodeTo.TabIndex = 21;
            // 
            // tbAmount
            // 
            tbAmount.BorderColor = Color.FromArgb(192, 0, 0);
            tbAmount.BorderRadius = 10;
            tbAmount.CustomizableEdges = customizableEdges15;
            tbAmount.DefaultText = "";
            tbAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbAmount.Font = new Font("Segoe UI", 9F);
            tbAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbAmount.Location = new Point(214, 241);
            tbAmount.Margin = new Padding(3, 4, 3, 4);
            tbAmount.Name = "tbAmount";
            tbAmount.PlaceholderText = "";
            tbAmount.SelectedText = "";
            tbAmount.ShadowDecoration.CustomizableEdges = customizableEdges16;
            tbAmount.Size = new Size(180, 39);
            tbAmount.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(192, 57, 43);
            label3.Location = new Point(60, 253);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 23;
            label3.Text = "Amount:";
            // 
            // btnConvert
            // 
            btnConvert.BackColor = SystemColors.Control;
            btnConvert.BorderColor = Color.FromArgb(192, 0, 0);
            btnConvert.BorderRadius = 7;
            btnConvert.BorderThickness = 1;
            btnConvert.CustomizableEdges = customizableEdges17;
            btnConvert.DisabledState.BorderColor = Color.DarkGray;
            btnConvert.DisabledState.CustomBorderColor = Color.DarkGray;
            btnConvert.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnConvert.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnConvert.FillColor = Color.Silver;
            btnConvert.Font = new Font("Segoe UI", 9F);
            btnConvert.ForeColor = Color.Black;
            btnConvert.Image = (Image)resources.GetObject("btnConvert.Image");
            btnConvert.ImageAlign = HorizontalAlignment.Left;
            btnConvert.Location = new Point(340, 376);
            btnConvert.Name = "btnConvert";
            btnConvert.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnConvert.Size = new Size(143, 36);
            btnConvert.TabIndex = 31;
            btnConvert.Text = "Convert";
            btnConvert.Click += btnConvert_Click;
            // 
            // tbExchangedAmountj
            // 
            tbExchangedAmountj.BorderColor = Color.FromArgb(192, 0, 0);
            tbExchangedAmountj.BorderRadius = 10;
            tbExchangedAmountj.CustomizableEdges = customizableEdges19;
            tbExchangedAmountj.DefaultText = "";
            tbExchangedAmountj.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbExchangedAmountj.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbExchangedAmountj.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbExchangedAmountj.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbExchangedAmountj.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbExchangedAmountj.Font = new Font("Segoe UI", 9F);
            tbExchangedAmountj.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbExchangedAmountj.Location = new Point(246, 301);
            tbExchangedAmountj.Margin = new Padding(3, 4, 3, 4);
            tbExchangedAmountj.Name = "tbExchangedAmountj";
            tbExchangedAmountj.PlaceholderText = "";
            tbExchangedAmountj.ReadOnly = true;
            tbExchangedAmountj.SelectedText = "";
            tbExchangedAmountj.ShadowDecoration.CustomizableEdges = customizableEdges20;
            tbExchangedAmountj.Size = new Size(180, 39);
            tbExchangedAmountj.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(192, 57, 43);
            label4.Location = new Point(-2, 313);
            label4.Name = "label4";
            label4.Size = new Size(228, 27);
            label4.TabIndex = 33;
            label4.Text = "Exchanged Amount: ";
            // 
            // frmCurrencyCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 424);
            Controls.Add(label4);
            Controls.Add(tbExchangedAmountj);
            Controls.Add(btnConvert);
            Controls.Add(label3);
            Controls.Add(tbAmount);
            Controls.Add(cbCodeTo);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lblDW);
            Controls.Add(cbCodeFrom);
            Name = "frmCurrencyCalculator";
            Text = "frmCurrencyCalculator";
            Load += frmCurrencyCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbCodeFrom;
        private Label lblDW;
        private Label label2;
        private Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cbCodeTo;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnConvert;
        private Guna.UI2.WinForms.Guna2TextBox tbExchangedAmountj;
        private Label label4;
    }
}