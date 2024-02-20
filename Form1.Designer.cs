namespace WindowsFormsApp8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreatePadFootingButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SizeLabel1 = new System.Windows.Forms.Label();
            this.FootingSize = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.reinforcementCatalog1 = new Tekla.Structures.Dialog.UIControls.ReinforcementCatalog();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BendingRadiusTextBox = new System.Windows.Forms.TextBox();
            this.GradeTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ColumnsMaterialTextBox = new System.Windows.Forms.TextBox();
            this.MaterialButton = new System.Windows.Forms.Button();
            this.profileCatalog1 = new Tekla.Structures.Dialog.UIControls.ProfileCatalog();
            this.label5 = new System.Windows.Forms.Label();
            this.ColumnsProfileTextBox = new System.Windows.Forms.TextBox();
            this.saveLoad1 = new Tekla.Structures.Dialog.UIControls.SaveLoad();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePadFootingButton
            // 
            this.CreatePadFootingButton.Location = new System.Drawing.Point(370, 234);
            this.CreatePadFootingButton.Name = "CreatePadFootingButton";
            this.CreatePadFootingButton.Size = new System.Drawing.Size(126, 23);
            this.CreatePadFootingButton.TabIndex = 1;
            this.CreatePadFootingButton.Text = "Footings and Columns";
            this.CreatePadFootingButton.UseVisualStyleBackColor = true;
            this.CreatePadFootingButton.Click += new System.EventHandler(this.CreatePadFootingButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 286);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Create rebars";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SizeLabel1
            // 
            this.SizeLabel1.AutoSize = true;
            this.SizeLabel1.Location = new System.Drawing.Point(367, 199);
            this.SizeLabel1.Name = "SizeLabel1";
            this.SizeLabel1.Size = new System.Drawing.Size(65, 13);
            this.SizeLabel1.TabIndex = 6;
            this.SizeLabel1.Text = "Footing Size";
            // 
            // FootingSize
            // 
            this.FootingSize.Location = new System.Drawing.Point(438, 196);
            this.FootingSize.Name = "FootingSize";
            this.FootingSize.Size = new System.Drawing.Size(58, 20);
            this.FootingSize.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.reinforcementCatalog1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.BendingRadiusTextBox);
            this.groupBox1.Controls.Add(this.GradeTextBox);
            this.groupBox1.Controls.Add(this.SizeTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 186);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 108);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rebars";
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(238, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(2, 77);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // reinforcementCatalog1
            // 
            this.reinforcementCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.reinforcementCatalog1.ButtonText = "Select...";
            this.reinforcementCatalog1.Location = new System.Drawing.Point(247, 48);
            this.reinforcementCatalog1.Name = "reinforcementCatalog1";
            this.reinforcementCatalog1.SelectedRebarBendingRadius = 0D;
            this.reinforcementCatalog1.SelectedRebarGrade = "";
            this.reinforcementCatalog1.SelectedRebarSize = "";
            this.reinforcementCatalog1.Size = new System.Drawing.Size(88, 23);
            this.reinforcementCatalog1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Bending radius:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Size:";
            // 
            // BendingRadiusTextBox
            // 
            this.BendingRadiusTextBox.Location = new System.Drawing.Point(99, 75);
            this.BendingRadiusTextBox.Name = "BendingRadiusTextBox";
            this.BendingRadiusTextBox.Size = new System.Drawing.Size(131, 20);
            this.BendingRadiusTextBox.TabIndex = 8;
            this.BendingRadiusTextBox.Text = "40";
            // 
            // GradeTextBox
            // 
            this.GradeTextBox.Location = new System.Drawing.Point(99, 49);
            this.GradeTextBox.Name = "GradeTextBox";
            this.GradeTextBox.Size = new System.Drawing.Size(131, 20);
            this.GradeTextBox.TabIndex = 7;
            this.GradeTextBox.Text = "A500HW";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(99, 23);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(131, 20);
            this.SizeTextBox.TabIndex = 6;
            this.SizeTextBox.Text = "12";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ColumnsMaterialTextBox);
            this.groupBox2.Controls.Add(this.MaterialButton);
            this.groupBox2.Controls.Add(this.profileCatalog1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ColumnsProfileTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 83);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 81);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Columns";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Material:";
            // 
            // ColumnsMaterialTextBox
            // 
            this.ColumnsMaterialTextBox.Location = new System.Drawing.Point(99, 46);
            this.ColumnsMaterialTextBox.Name = "ColumnsMaterialTextBox";
            this.ColumnsMaterialTextBox.Size = new System.Drawing.Size(131, 20);
            this.ColumnsMaterialTextBox.TabIndex = 8;
            this.ColumnsMaterialTextBox.Text = "S235JR";
            // 
            // MaterialButton
            // 
            this.MaterialButton.Location = new System.Drawing.Point(247, 45);
            this.MaterialButton.Name = "MaterialButton";
            this.MaterialButton.Size = new System.Drawing.Size(88, 23);
            this.MaterialButton.TabIndex = 7;
            this.MaterialButton.Text = "Select...";
            this.MaterialButton.UseVisualStyleBackColor = true;
            // 
            // profileCatalog1
            // 
            this.profileCatalog1.BackColor = System.Drawing.Color.Transparent;
            this.profileCatalog1.ButtonText = "Select...";
            this.profileCatalog1.Location = new System.Drawing.Point(247, 19);
            this.profileCatalog1.Name = "profileCatalog1";
            this.profileCatalog1.SelectedProfile = "";
            this.profileCatalog1.Size = new System.Drawing.Size(88, 23);
            this.profileCatalog1.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profile:";
            // 
            // ColumnsProfileTextBox
            // 
            this.ColumnsProfileTextBox.Location = new System.Drawing.Point(99, 20);
            this.ColumnsProfileTextBox.Name = "ColumnsProfileTextBox";
            this.ColumnsProfileTextBox.Size = new System.Drawing.Size(131, 20);
            this.ColumnsProfileTextBox.TabIndex = 4;
            // 
            // saveLoad1
            // 
            this.saveLoad1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveLoad1.Dock = System.Windows.Forms.DockStyle.Top;
            this.saveLoad1.HelpFileType = Tekla.Structures.Dialog.UIControls.SaveLoad.HelpFileTypeEnum.General;
            this.saveLoad1.HelpKeyword = "";
            this.saveLoad1.HelpUrl = "";
            this.saveLoad1.Location = new System.Drawing.Point(0, 0);
            this.saveLoad1.Name = "saveLoad1";
            this.saveLoad1.SaveAsText = "";
            this.saveLoad1.Size = new System.Drawing.Size(553, 43);
            this.saveLoad1.TabIndex = 15;
            this.saveLoad1.UserDefinedHelpFilePath = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 354);
            this.Controls.Add(this.saveLoad1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SizeLabel1);
            this.Controls.Add(this.FootingSize);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreatePadFootingButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreatePadFootingButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SizeLabel1;
        private System.Windows.Forms.TextBox FootingSize;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private Tekla.Structures.Dialog.UIControls.ReinforcementCatalog reinforcementCatalog1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BendingRadiusTextBox;
        private System.Windows.Forms.TextBox GradeTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColumnsMaterialTextBox;
        private System.Windows.Forms.Button MaterialButton;
        private Tekla.Structures.Dialog.UIControls.ProfileCatalog profileCatalog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ColumnsProfileTextBox;
        private Tekla.Structures.Dialog.UIControls.SaveLoad saveLoad1;
    }
}

