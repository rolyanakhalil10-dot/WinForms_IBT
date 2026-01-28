namespace IBTpresentationLayer
{
    partial class frmPermissions
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermissions));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            tcUsers = new TabControl();
            tbPersonInfo = new TabPage();
            btnNext = new Guna.UI2.WinForms.Guna2Button();
            ctrlPersonCardWithFilter1 = new ctrlPersonCardWithFilter();
            tpPermissions = new TabPage();
            guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbFullPermission = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            btnCancel = new Guna.UI2.WinForms.Guna2Button();
            btnSave = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            cbShowLoginRegistry = new Guna.UI2.WinForms.Guna2CheckBox();
            cbAccountSettings = new Guna.UI2.WinForms.Guna2CheckBox();
            cbCurrency = new Guna.UI2.WinForms.Guna2CheckBox();
            cbManagePermissions = new Guna.UI2.WinForms.Guna2CheckBox();
            cbTransactions = new Guna.UI2.WinForms.Guna2CheckBox();
            cbManageUsers = new Guna.UI2.WinForms.Guna2CheckBox();
            cbManageClients = new Guna.UI2.WinForms.Guna2CheckBox();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            tcUsers.SuspendLayout();
            tbPersonInfo.SuspendLayout();
            tpPermissions.SuspendLayout();
            SuspendLayout();
            // 
            // tcUsers
            // 
            tcUsers.Controls.Add(tbPersonInfo);
            tcUsers.Controls.Add(tpPermissions);
            tcUsers.Location = new Point(12, 72);
            tcUsers.Name = "tcUsers";
            tcUsers.SelectedIndex = 0;
            tcUsers.Size = new Size(878, 577);
            tcUsers.TabIndex = 2;
            // 
            // tbPersonInfo
            // 
            tbPersonInfo.Controls.Add(btnNext);
            tbPersonInfo.Controls.Add(ctrlPersonCardWithFilter1);
            tbPersonInfo.Location = new Point(4, 29);
            tbPersonInfo.Name = "tbPersonInfo";
            tbPersonInfo.Padding = new Padding(3);
            tbPersonInfo.Size = new Size(870, 544);
            tbPersonInfo.TabIndex = 0;
            tbPersonInfo.Text = "Person Info";
            tbPersonInfo.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            btnNext.BorderColor = Color.FromArgb(192, 57, 43);
            btnNext.BorderRadius = 7;
            btnNext.BorderThickness = 1;
            btnNext.CustomizableEdges = customizableEdges15;
            btnNext.DisabledState.BorderColor = Color.DarkGray;
            btnNext.DisabledState.CustomBorderColor = Color.DarkGray;
            btnNext.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnNext.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnNext.FillColor = Color.Transparent;
            btnNext.Font = new Font("Segoe UI", 9F);
            btnNext.ForeColor = Color.FromArgb(192, 57, 43);
            btnNext.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnNext.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnNext.Image = Properties.Resources.Next;
            btnNext.ImageAlign = HorizontalAlignment.Left;
            btnNext.Location = new Point(763, 503);
            btnNext.Name = "btnNext";
            btnNext.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnNext.Size = new Size(101, 32);
            btnNext.TabIndex = 8;
            btnNext.Text = "Next";
            btnNext.Click += btnNext_Click;
            // 
            // ctrlPersonCardWithFilter1
            // 
            ctrlPersonCardWithFilter1.FilterEnabled = true;
            ctrlPersonCardWithFilter1.Location = new Point(-4, 0);
            ctrlPersonCardWithFilter1.Name = "ctrlPersonCardWithFilter1";
            ctrlPersonCardWithFilter1.ShowAddPerson = true;
            ctrlPersonCardWithFilter1.Size = new Size(862, 506);
            ctrlPersonCardWithFilter1.TabIndex = 0;
            // 
            // tpPermissions
            // 
            tpPermissions.Controls.Add(guna2HtmlLabel2);
            tpPermissions.Controls.Add(cbFullPermission);
            tpPermissions.Controls.Add(btnCancel);
            tpPermissions.Controls.Add(btnSave);
            tpPermissions.Controls.Add(guna2HtmlLabel1);
            tpPermissions.Controls.Add(cbShowLoginRegistry);
            tpPermissions.Controls.Add(cbAccountSettings);
            tpPermissions.Controls.Add(cbCurrency);
            tpPermissions.Controls.Add(cbManagePermissions);
            tpPermissions.Controls.Add(cbTransactions);
            tpPermissions.Controls.Add(cbManageUsers);
            tpPermissions.Controls.Add(cbManageClients);
            tpPermissions.Location = new Point(4, 29);
            tpPermissions.Name = "tpPermissions";
            tpPermissions.Padding = new Padding(3);
            tpPermissions.Size = new Size(870, 544);
            tpPermissions.TabIndex = 1;
            tpPermissions.Text = "UserPermissions";
            tpPermissions.UseVisualStyleBackColor = true;
            // 
            // guna2HtmlLabel2
            // 
            guna2HtmlLabel2.BackColor = Color.Transparent;
            guna2HtmlLabel2.Font = new Font("Segoe UI", 12F);
            guna2HtmlLabel2.Location = new Point(90, 107);
            guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            guna2HtmlLabel2.Size = new Size(220, 30);
            guna2HtmlLabel2.TabIndex = 15;
            guna2HtmlLabel2.Text = "Give The User Full Access";
            // 
            // cbFullPermission
            // 
            cbFullPermission.BackColor = Color.Transparent;
            cbFullPermission.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbFullPermission.CheckedState.BorderRadius = 2;
            cbFullPermission.CheckedState.BorderThickness = 0;
            cbFullPermission.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbFullPermission.CustomizableEdges = customizableEdges9;
            cbFullPermission.Location = new Point(57, 107);
            cbFullPermission.Name = "cbFullPermission";
            cbFullPermission.ShadowDecoration.CustomizableEdges = customizableEdges10;
            cbFullPermission.Size = new Size(27, 30);
            cbFullPermission.TabIndex = 14;
            cbFullPermission.Text = "guna2CustomCheckBox1";
            cbFullPermission.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbFullPermission.UncheckedState.BorderRadius = 2;
            cbFullPermission.UncheckedState.BorderThickness = 0;
            cbFullPermission.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            cbFullPermission.Click += cbFullPermission_Click;
            // 
            // btnCancel
            // 
            btnCancel.BorderColor = Color.FromArgb(192, 57, 43);
            btnCancel.BorderRadius = 7;
            btnCancel.BorderThickness = 1;
            btnCancel.CustomizableEdges = customizableEdges11;
            btnCancel.DisabledState.BorderColor = Color.DarkGray;
            btnCancel.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCancel.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCancel.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCancel.FillColor = Color.Transparent;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.ForeColor = Color.FromArgb(192, 57, 43);
            btnCancel.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnCancel.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.ImageAlign = HorizontalAlignment.Left;
            btnCancel.Location = new Point(583, 447);
            btnCancel.Name = "btnCancel";
            btnCancel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnCancel.Size = new Size(114, 54);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            // 
            // btnSave
            // 
            btnSave.BorderColor = Color.FromArgb(192, 57, 43);
            btnSave.BorderRadius = 7;
            btnSave.BorderThickness = 1;
            btnSave.CustomizableEdges = customizableEdges13;
            btnSave.DisabledState.BorderColor = Color.DarkGray;
            btnSave.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSave.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSave.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSave.FillColor = Color.Transparent;
            btnSave.Font = new Font("Segoe UI", 9F);
            btnSave.ForeColor = Color.FromArgb(192, 57, 43);
            btnSave.HoverState.FillColor = Color.FromArgb(192, 57, 43);
            btnSave.HoverState.ForeColor = Color.FromArgb(224, 224, 224);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = HorizontalAlignment.Left;
            btnSave.Location = new Point(715, 447);
            btnSave.Name = "btnSave";
            btnSave.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnSave.Size = new Size(116, 54);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Abd Duhok", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            guna2HtmlLabel1.Location = new Point(185, 34);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(486, 39);
            guna2HtmlLabel1.TabIndex = 11;
            guna2HtmlLabel1.Text = "Set UserPermissions for the User";
            // 
            // cbShowLoginRegistry
            // 
            cbShowLoginRegistry.AutoSize = true;
            cbShowLoginRegistry.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbShowLoginRegistry.CheckedState.BorderRadius = 0;
            cbShowLoginRegistry.CheckedState.BorderThickness = 0;
            cbShowLoginRegistry.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbShowLoginRegistry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowLoginRegistry.Location = new Point(315, 284);
            cbShowLoginRegistry.Name = "cbShowLoginRegistry";
            cbShowLoginRegistry.Size = new Size(226, 32);
            cbShowLoginRegistry.TabIndex = 10;
            cbShowLoginRegistry.Text = "Show Login Registery ";
            cbShowLoginRegistry.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbShowLoginRegistry.UncheckedState.BorderRadius = 0;
            cbShowLoginRegistry.UncheckedState.BorderThickness = 0;
            cbShowLoginRegistry.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbAccountSettings
            // 
            cbAccountSettings.AutoSize = true;
            cbAccountSettings.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbAccountSettings.CheckedState.BorderRadius = 0;
            cbAccountSettings.CheckedState.BorderThickness = 0;
            cbAccountSettings.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbAccountSettings.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbAccountSettings.Location = new Point(95, 342);
            cbAccountSettings.Name = "cbAccountSettings";
            cbAccountSettings.Size = new Size(174, 32);
            cbAccountSettings.TabIndex = 9;
            cbAccountSettings.Text = "Account Setting";
            cbAccountSettings.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbAccountSettings.UncheckedState.BorderRadius = 0;
            cbAccountSettings.UncheckedState.BorderThickness = 0;
            cbAccountSettings.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbCurrency
            // 
            cbCurrency.AutoSize = true;
            cbCurrency.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbCurrency.CheckedState.BorderRadius = 0;
            cbCurrency.CheckedState.BorderThickness = 0;
            cbCurrency.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbCurrency.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCurrency.Location = new Point(95, 225);
            cbCurrency.Name = "cbCurrency";
            cbCurrency.Size = new Size(129, 32);
            cbCurrency.TabIndex = 8;
            cbCurrency.Text = "Currencies ";
            cbCurrency.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbCurrency.UncheckedState.BorderRadius = 0;
            cbCurrency.UncheckedState.BorderThickness = 0;
            cbCurrency.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbManagePermissions
            // 
            cbManagePermissions.AutoSize = true;
            cbManagePermissions.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbManagePermissions.CheckedState.BorderRadius = 0;
            cbManagePermissions.CheckedState.BorderThickness = 0;
            cbManagePermissions.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbManagePermissions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbManagePermissions.Location = new Point(95, 285);
            cbManagePermissions.Name = "cbManagePermissions";
            cbManagePermissions.Size = new Size(211, 32);
            cbManagePermissions.TabIndex = 7;
            cbManagePermissions.Text = "Manage Permissions";
            cbManagePermissions.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbManagePermissions.UncheckedState.BorderRadius = 0;
            cbManagePermissions.UncheckedState.BorderThickness = 0;
            cbManagePermissions.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbTransactions
            // 
            cbTransactions.AutoSize = true;
            cbTransactions.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbTransactions.CheckedState.BorderRadius = 0;
            cbTransactions.CheckedState.BorderThickness = 0;
            cbTransactions.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbTransactions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbTransactions.Location = new Point(315, 168);
            cbTransactions.Name = "cbTransactions";
            cbTransactions.Size = new Size(140, 32);
            cbTransactions.TabIndex = 6;
            cbTransactions.Text = "Transactions";
            cbTransactions.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbTransactions.UncheckedState.BorderRadius = 0;
            cbTransactions.UncheckedState.BorderThickness = 0;
            cbTransactions.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbManageUsers
            // 
            cbManageUsers.AutoSize = true;
            cbManageUsers.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbManageUsers.CheckedState.BorderRadius = 0;
            cbManageUsers.CheckedState.BorderThickness = 0;
            cbManageUsers.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbManageUsers.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbManageUsers.Location = new Point(315, 228);
            cbManageUsers.Name = "cbManageUsers";
            cbManageUsers.Size = new Size(157, 32);
            cbManageUsers.TabIndex = 5;
            cbManageUsers.Text = "Manage Users";
            cbManageUsers.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbManageUsers.UncheckedState.BorderRadius = 0;
            cbManageUsers.UncheckedState.BorderThickness = 0;
            cbManageUsers.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // cbManageClients
            // 
            cbManageClients.AutoSize = true;
            cbManageClients.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbManageClients.CheckedState.BorderRadius = 0;
            cbManageClients.CheckedState.BorderThickness = 0;
            cbManageClients.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            cbManageClients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbManageClients.Location = new Point(95, 168);
            cbManageClients.Name = "cbManageClients";
            cbManageClients.Size = new Size(168, 32);
            cbManageClients.TabIndex = 2;
            cbManageClients.Text = "Manage Clients";
            cbManageClients.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            cbManageClients.UncheckedState.BorderRadius = 0;
            cbManageClients.UncheckedState.BorderThickness = 0;
            cbManageClients.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Book Antiqua", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(192, 0, 0);
            guna2HtmlLabel3.Location = new Point(299, 12);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(339, 48);
            guna2HtmlLabel3.TabIndex = 3;
            guna2HtmlLabel3.Text = "Set UserPermissions ";
            // 
            // frmPermissions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 663);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(tcUsers);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPermissions";
            Text = "frmPermissions";
            Activated += frmPermissions_Activated;
            Load += frmPermissions_Load;
            tcUsers.ResumeLayout(false);
            tbPersonInfo.ResumeLayout(false);
            tpPermissions.ResumeLayout(false);
            tpPermissions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl tcUsers;
        private TabPage tbPersonInfo;
        private TabPage tpPermissions;
        private ctrlPersonCardWithFilter ctrlPersonCardWithFilter1;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2CheckBox cbManageClients;
        private Guna.UI2.WinForms.Guna2CheckBox cbShowLoginRegistry;
        private Guna.UI2.WinForms.Guna2CheckBox cbAccountSettings;
        private Guna.UI2.WinForms.Guna2CheckBox cbCurrency;
        private Guna.UI2.WinForms.Guna2CheckBox cbManagePermissions;
        private Guna.UI2.WinForms.Guna2CheckBox cbTransactions;
        private Guna.UI2.WinForms.Guna2CheckBox cbManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2CustomCheckBox cbFullPermission;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
    }
}