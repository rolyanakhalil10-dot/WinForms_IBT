namespace IBTpresentationLayer
{
    partial class frmShowPersonInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowPersonInfo));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ctrlPersonInfoCard1 = new ctrlPersonInfoCard();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // ctrlPersonInfoCard1
            // 
            ctrlPersonInfoCard1.Location = new Point(-8, 49);
            ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            ctrlPersonInfoCard1.Size = new Size(863, 367);
            ctrlPersonInfoCard1.TabIndex = 0;
            ctrlPersonInfoCard1.Load += ctrlPersonInfoCard1_Load;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = SystemColors.Control;
            guna2Button1.BorderColor = Color.FromArgb(192, 0, 0);
            guna2Button1.BorderRadius = 7;
            guna2Button1.BorderThickness = 1;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.Silver;
            guna2Button1.Font = new Font("Segoe UI", 9F);
            guna2Button1.ForeColor = Color.Black;
            guna2Button1.Image = (Image)resources.GetObject("guna2Button1.Image");
            guna2Button1.ImageAlign = HorizontalAlignment.Left;
            guna2Button1.Location = new Point(727, 409);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(115, 36);
            guna2Button1.TabIndex = 1;
            guna2Button1.Text = "Close";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Yu Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.ForeColor = Color.FromArgb(192, 0, 0);
            guna2HtmlLabel1.Location = new Point(317, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(174, 41);
            guna2HtmlLabel1.TabIndex = 2;
            guna2HtmlLabel1.Text = "Person Info";
            // 
            // frmShowPersonInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 459);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(guna2Button1);
            Controls.Add(ctrlPersonInfoCard1);
            Name = "frmShowPersonInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmShowPersonInfo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ctrlPersonInfoCard ctrlPersonInfoCard1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}