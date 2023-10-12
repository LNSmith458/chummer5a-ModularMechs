namespace ModularMechs
{
    partial class ModularMechsPage
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
            this.ModularMechsTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.AddMechPartsButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MechPartsTree = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.CreatNewMechButton = new System.Windows.Forms.Button();
            this.MechsPageTree = new System.Windows.Forms.TreeView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ModularMechsTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ModularMechsTabControl
            // 
            this.ModularMechsTabControl.Controls.Add(this.tabPage1);
            this.ModularMechsTabControl.Controls.Add(this.tabPage2);
            this.ModularMechsTabControl.Controls.Add(this.tabPage3);
            this.ModularMechsTabControl.Location = new System.Drawing.Point(3, 3);
            this.ModularMechsTabControl.Name = "ModularMechsTabControl";
            this.ModularMechsTabControl.SelectedIndex = 0;
            this.ModularMechsTabControl.Size = new System.Drawing.Size(897, 594);
            this.ModularMechsTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.MechsPageTree);
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(889, 568);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mechs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.MechPartsTree);
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(889, 568);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mech Parts";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // AddMechPartsButton
            // 
            this.AddMechPartsButton.Location = new System.Drawing.Point(3, 3);
            this.AddMechPartsButton.Name = "AddMechPartsButton";
            this.AddMechPartsButton.Size = new System.Drawing.Size(75, 23);
            this.AddMechPartsButton.TabIndex = 1;
            this.AddMechPartsButton.Text = "Add Parts";
            this.AddMechPartsButton.UseVisualStyleBackColor = true;
            this.AddMechPartsButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddMechPartsButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(245, 30);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // MechPartsTree
            // 
            this.MechPartsTree.Location = new System.Drawing.Point(7, 43);
            this.MechPartsTree.Name = "MechPartsTree";
            this.MechPartsTree.Size = new System.Drawing.Size(241, 519);
            this.MechPartsTree.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.CreatNewMechButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(245, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // CreatNewMechButton
            // 
            this.CreatNewMechButton.Location = new System.Drawing.Point(3, 3);
            this.CreatNewMechButton.Name = "CreatNewMechButton";
            this.CreatNewMechButton.Size = new System.Drawing.Size(75, 23);
            this.CreatNewMechButton.TabIndex = 1;
            this.CreatNewMechButton.Text = "CreateNew";
            this.CreatNewMechButton.UseVisualStyleBackColor = true;
            // 
            // MechsPageTree
            // 
            this.MechsPageTree.Location = new System.Drawing.Point(6, 42);
            this.MechsPageTree.Name = "MechsPageTree";
            this.MechsPageTree.Size = new System.Drawing.Size(241, 519);
            this.MechsPageTree.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "Workshop";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 568);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Workshop";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ModularMechsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModularMechsTabControl);
            this.Name = "ModularMechsPage";
            this.Size = new System.Drawing.Size(1110, 681);
            this.ModularMechsTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl ModularMechsTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button AddMechPartsButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView MechPartsTree;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button CreatNewMechButton;
        private System.Windows.Forms.TreeView MechsPageTree;
        private System.Windows.Forms.TabPage tabPage3;
    }
}
