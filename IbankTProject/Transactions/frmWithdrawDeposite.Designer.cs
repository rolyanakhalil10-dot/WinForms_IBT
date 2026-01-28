namespace IBTpresentationLayer
{
    partial class frmWithdrawDeposite
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ctrlPersonCardWithFilter1 = new ctrlPersonCardWithFilter();
            lblDW = new Label();
            btnWD = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            lblBalance = new Label();
            label2 = new Label();
            tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(0, 63);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(873, 499);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // lblDW
            // 
            lblDW.AutoSize = true;
            lblDW.Font = new Font("Cascadia Code", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDW.ForeColor = Color.FromArgb(192, 57, 43);
            lblDW.Location = new Point(279, 9);
            lblDW.Name = "lblDW";
            lblDW.Size = new Size(300, 45);
            lblDW.TabIndex = 2;
            lblDW.Text = "Deposite Money";
            lblDW.Click += lblDW_Click;
            // 
            // btnWD
            // 
            btnWD.BorderColor = Color.FromArgb(192, 57, 43);
            btnWD.BorderRadius = 7;
            btnWD.BorderThickness = 1;
            btnWD.CustomizableEdges = customizableEdges1;
            btnWD.DisabledState.BorderColor = Color.DarkGray;
            btnWD.DisabledState.CustomBorderColor = Color.DarkGray;
            btnWD.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnWD.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnWD.FillColor = Color.Transparent;
            btnWD.Font = new Font("Segoe UI", 9F);
            btnWD.ForeColor = Color.FromArgb(192, 57, 43);
            btnWD.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnWD.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnWD.Location = new Point(769, 572);
            btnWD.Name = "btnWD";
            btnWD.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnWD.Size = new Size(88, 32);
            btnWD.TabIndex = 4;
            btnWD.Text = "Deposite";
            btnWD.Click += btnWD_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(38, 565);
            label1.Name = "label1";
            label1.Size = new Size(108, 27);
            label1.TabIndex = 6;
            label1.Text = "Balance:";
            // 
            // lblBalance
            // 
            lblBalance.AutoSize = true;
            lblBalance.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBalance.ForeColor = Color.Maroon;
            lblBalance.Location = new Point(266, 565);
            lblBalance.Name = "lblBalance";
            lblBalance.Size = new Size(36, 27);
            lblBalance.TabIndex = 7;
            lblBalance.Text = "00";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(391, 565);
            label2.Name = "label2";
            label2.Size = new Size(96, 27);
            label2.TabIndex = 9;
            label2.Text = "Amount:";
            // 
            // tbAmount
            // 
            tbAmount.AutoRoundedCorners = true;
            tbAmount.CustomizableEdges = customizableEdges3;
            tbAmount.DefaultText = "";
            tbAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbAmount.Font = new Font("Segoe UI", 9F);
            tbAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbAmount.Location = new Point(493, 552);
            tbAmount.Margin = new Padding(3, 4, 3, 4);
            tbAmount.Name = "tbAmount";
            tbAmount.PlaceholderText = "";
            tbAmount.SelectedText = "";
            tbAmount.ShadowDecoration.CustomizableEdges = customizableEdges4;
            tbAmount.Size = new Size(179, 40);
            tbAmount.TabIndex = 10;
            // 
            // frmWithdrawDeposite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 616);
            Controls.Add(tbAmount);
            Controls.Add(label2);
            Controls.Add(lblBalance);
            Controls.Add(label1);
            Controls.Add(btnWD);
            Controls.Add(lblDW);
            Controls.Add(ctrlPersonCardWithFilter1);
            Name = "frmWithdrawDeposite";
            Text = "frmWithdrawDeposite";
            Activated += frmWithdrawDeposite_Activated;
            Load += frmWithdrawDeposite_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Label lblDW;
        private Guna.UI2.WinForms.Guna2Button btnWD;
        private Label label1;
        private Label lblBalance;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
    }
}