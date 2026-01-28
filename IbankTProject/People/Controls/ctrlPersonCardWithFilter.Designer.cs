namespace IBTpresentationLayer
{
    partial class ctrlPersonCardWithFilter
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

        #region Component Designer generated code

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlPersonCardWithFilter));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            ctrlPersonInfoCard1 = new ctrlPersonInfoCard();
            gbFilter = new Guna.UI2.WinForms.Guna2GroupBox();
            btnAddPerson = new Guna.UI2.WinForms.Guna2Button();
            btnSearch = new Guna.UI2.WinForms.Guna2Button();
            tbFilter = new MaskedTextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // ctrlPersonInfoCard1
            // 
            ctrlPersonInfoCard1.Location = new Point(6, 114);
            ctrlPersonInfoCard1.Name = "ctrlPersonInfoCard1";
            ctrlPersonInfoCard1.Size = new Size(850, 375);
            ctrlPersonInfoCard1.TabIndex = 0;
            ctrlPersonInfoCard1.Load += ctrlPersonInfoCard1_Load;
            // 
            // gbFilter
            // 
            gbFilter.Controls.Add(btnAddPerson);
            gbFilter.Controls.Add(btnSearch);
            gbFilter.Controls.Add(tbFilter);
            gbFilter.Controls.Add(label1);
            gbFilter.CustomBorderColor = Color.DarkRed;
            gbFilter.CustomizableEdges = customizableEdges5;
            gbFilter.FillColor = SystemColors.Control;
            gbFilter.Font = new Font("Segoe UI", 9F);
            gbFilter.ForeColor = Color.LightGray;
            gbFilter.Location = new Point(3, 3);
            gbFilter.Name = "gbFilter";
            gbFilter.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbFilter.Size = new Size(861, 116);
            gbFilter.TabIndex = 1;
            gbFilter.Text = "Filter";
            // 
            // btnAddPerson
            // 
            btnAddPerson.AutoRoundedCorners = true;
            btnAddPerson.BackColor = SystemColors.Control;
            btnAddPerson.CustomizableEdges = customizableEdges1;
            btnAddPerson.DisabledState.BorderColor = Color.DarkGray;
            btnAddPerson.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAddPerson.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAddPerson.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAddPerson.FillColor = Color.Maroon;
            btnAddPerson.Font = new Font("Segoe UI", 9F);
            btnAddPerson.ForeColor = Color.White;
            btnAddPerson.Image = (Image)resources.GetObject("btnAddPerson.Image");
            btnAddPerson.Location = new Point(616, 50);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnAddPerson.Size = new Size(40, 40);
            btnAddPerson.TabIndex = 4;
            btnAddPerson.Click += btnAddPerson_Click_1;
            // 
            // btnSearch
            // 
            btnSearch.AutoRoundedCorners = true;
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.CustomizableEdges = customizableEdges3;
            btnSearch.DisabledState.BorderColor = Color.DarkGray;
            btnSearch.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSearch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSearch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSearch.FillColor = Color.Maroon;
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.White;
            btnSearch.Image = Properties.Resources.search;
            btnSearch.Location = new Point(559, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSearch.Size = new Size(40, 40);
            btnSearch.TabIndex = 3;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbFilter
            // 
            tbFilter.Font = new Font("Segoe UI", 10F);
            tbFilter.Location = new Point(288, 60);
            tbFilter.Name = "tbFilter";
            tbFilter.Size = new Size(195, 30);
            tbFilter.TabIndex = 2;
            tbFilter.KeyPress += tbFilter_KeyPress;
            tbFilter.Validating += tbFilter_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 57, 43);
            label1.Location = new Point(44, 59);
            label1.Name = "label1";
            label1.Size = new Size(216, 27);
            label1.TabIndex = 1;
            label1.Text = "Find By PersonID:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // ctrlPersonCardWithFilter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gbFilter);
            Controls.Add(ctrlPersonInfoCard1);
            Name = "ctrlPersonCardWithFilter";
            Size = new Size(867, 510);
            Load += ctrlPersonCardWithFilter_Load;
            gbFilter.ResumeLayout(false);
            gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ctrlPersonInfoCard ctrlPersonInfoCard1;
        private Guna.UI2.WinForms.Guna2GroupBox gbFilter;
        private Label label1;
        private MaskedTextBox tbFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddPerson;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private ErrorProvider errorProvider1;
    }
}
