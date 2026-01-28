namespace IBTpresentationLayer
{
    partial class frmTransfer
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
            label1 = new Label();
            ctrlPersonCardWithFilter2 = new ctrlPersonCardWithFilter();
            label2 = new Label();
            tbAmount = new Guna.UI2.WinForms.Guna2TextBox();
            label3 = new Label();
            btnTransfer = new Guna.UI2.WinForms.Guna2Button();
            lblToBalance = new Label();
            label4 = new Label();
            lblFromBalance = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(245, 9);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(862, 497);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            ctrlPersonCardWithFilter1.OnPersonSelected += ctrlPersonCardWithFilter1_OnPersonSelected;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(-2, 9);
            label1.Name = "label1";
            label1.Size = new Size(241, 37);
            label1.TabIndex = 12;
            label1.Text = "Transfer From:";
            // 
            // ctrlPersonCardWithFilter2
            // 
            ctrlPersonCardWithFilter2.FilterEnabled = true;
            ctrlPersonCardWithFilter2.Location = new Point(255, 492);
            ctrlPersonCardWithFilter2.Name = "ctrlPersonCardWithFilter2";
            ctrlPersonCardWithFilter2.ShowAddPerson = true;
            ctrlPersonCardWithFilter2.Size = new Size(862, 497);
            ctrlPersonCardWithFilter2.TabIndex = 13;
            ctrlPersonCardWithFilter2.OnPersonSelected += ctrlPersonCardWithFilter2_OnPersonSelected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(8, 492);
            label2.Name = "label2";
            label2.Size = new Size(209, 37);
            label2.TabIndex = 14;
            label2.Text = "Transfer To:";
            // 
            // tbAmount
            // 
            tbAmount.AutoRoundedCorners = true;
            tbAmount.CustomizableEdges = customizableEdges1;
            tbAmount.DefaultText = "";
            tbAmount.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            tbAmount.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            tbAmount.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            tbAmount.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            tbAmount.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            tbAmount.Font = new Font("Segoe UI", 9F);
            tbAmount.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            tbAmount.Location = new Point(777, 916);
            tbAmount.Margin = new Padding(3, 4, 3, 4);
            tbAmount.Name = "tbAmount";
            tbAmount.PlaceholderText = "";
            tbAmount.SelectedText = "";
            tbAmount.ShadowDecoration.CustomizableEdges = customizableEdges2;
            tbAmount.Size = new Size(179, 40);
            tbAmount.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(675, 929);
            label3.Name = "label3";
            label3.Size = new Size(96, 27);
            label3.TabIndex = 16;
            label3.Text = "Amount:";
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
            btnTransfer.Font = new Font("Segoe UI", 9F);
            btnTransfer.ForeColor = Color.FromArgb(192, 57, 43);
            btnTransfer.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnTransfer.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnTransfer.Location = new Point(995, 924);
            btnTransfer.Name = "btnTransfer";
            btnTransfer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnTransfer.Size = new Size(88, 32);
            btnTransfer.TabIndex = 15;
            btnTransfer.Text = "Transfer";
            btnTransfer.Click += btnTransfer_Click;
            // 
            // lblToBalance
            // 
            lblToBalance.AutoSize = true;
            lblToBalance.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblToBalance.ForeColor = Color.Maroon;
            lblToBalance.Location = new Point(148, 551);
            lblToBalance.Name = "lblToBalance";
            lblToBalance.Size = new Size(36, 27);
            lblToBalance.TabIndex = 19;
            lblToBalance.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(12, 551);
            label4.Name = "label4";
            label4.Size = new Size(108, 27);
            label4.TabIndex = 18;
            label4.Text = "Balance:";
            // 
            // lblFromBalance
            // 
            lblFromBalance.AutoSize = true;
            lblFromBalance.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFromBalance.ForeColor = Color.Maroon;
            lblFromBalance.Location = new Point(148, 57);
            lblFromBalance.Name = "lblFromBalance";
            lblFromBalance.Size = new Size(36, 27);
            lblFromBalance.TabIndex = 21;
            lblFromBalance.Text = "00";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Maroon;
            label6.Location = new Point(12, 57);
            label6.Name = "label6";
            label6.Size = new Size(108, 27);
            label6.TabIndex = 20;
            label6.Text = "Balance:";
            // 
            // frmTransfer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 968);
            Controls.Add(lblFromBalance);
            Controls.Add(label6);
            Controls.Add(lblToBalance);
            Controls.Add(label4);
            Controls.Add(tbAmount);
            Controls.Add(label3);
            Controls.Add(btnTransfer);
            Controls.Add(label2);
            Controls.Add(ctrlPersonCardWithFilter2);
            Controls.Add(label1);
            Controls.Add(ctrlPersonCardWithFilter1);
            Name = "frmTransfer";
            Text = "frmTransfer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Label label1;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox tbAmount;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Button btnTransfer;
        private Label lblToBalance;
        private Label label4;
        private Label lblFromBalance;
        private Label label6;
    }
}