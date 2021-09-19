
namespace DungeonsAndDragonsCreatureVariator
{
    partial class ArmorCreator
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
            this.armorNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stealthDisAdvBox = new System.Windows.Forms.CheckBox();
            this.baseACVal = new System.Windows.Forms.NumericUpDown();
            this.maxACVal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadArmorButton = new System.Windows.Forms.Button();
            this.saveArmorButton = new System.Windows.Forms.Button();
            this.openArmorDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveArmorDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.baseACVal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxACVal)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // armorNameTextBox
            // 
            this.armorNameTextBox.Location = new System.Drawing.Point(100, 25);
            this.armorNameTextBox.Name = "armorNameTextBox";
            this.armorNameTextBox.Size = new System.Drawing.Size(195, 20);
            this.armorNameTextBox.TabIndex = 0;
            this.armorNameTextBox.TextChanged += new System.EventHandler(this.armorNameTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Armor Name";
            // 
            // stealthDisAdvBox
            // 
            this.stealthDisAdvBox.AutoSize = true;
            this.stealthDisAdvBox.Location = new System.Drawing.Point(134, 66);
            this.stealthDisAdvBox.Name = "stealthDisAdvBox";
            this.stealthDisAdvBox.Size = new System.Drawing.Size(128, 17);
            this.stealthDisAdvBox.TabIndex = 2;
            this.stealthDisAdvBox.Text = "Stealth Disadvantage";
            this.stealthDisAdvBox.UseVisualStyleBackColor = true;
            this.stealthDisAdvBox.CheckedChanged += new System.EventHandler(this.stealthDisAdvBox_CheckedChanged);
            // 
            // baseACVal
            // 
            this.baseACVal.Location = new System.Drawing.Point(100, 114);
            this.baseACVal.Name = "baseACVal";
            this.baseACVal.Size = new System.Drawing.Size(56, 20);
            this.baseACVal.TabIndex = 3;
            this.baseACVal.ValueChanged += new System.EventHandler(this.baseACVal_ValueChanged);
            // 
            // maxACVal
            // 
            this.maxACVal.Location = new System.Drawing.Point(239, 114);
            this.maxACVal.Name = "maxACVal";
            this.maxACVal.Size = new System.Drawing.Size(56, 20);
            this.maxACVal.TabIndex = 4;
            this.maxACVal.ValueChanged += new System.EventHandler(this.maxACVal_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Base AC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Max AC";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.loadArmorButton);
            this.flowLayoutPanel1.Controls.Add(this.saveArmorButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 185);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 42);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // loadArmorButton
            // 
            this.loadArmorButton.Location = new System.Drawing.Point(3, 3);
            this.loadArmorButton.Name = "loadArmorButton";
            this.loadArmorButton.Size = new System.Drawing.Size(128, 23);
            this.loadArmorButton.TabIndex = 0;
            this.loadArmorButton.Text = "Load Armor";
            this.loadArmorButton.UseVisualStyleBackColor = true;
            this.loadArmorButton.Click += new System.EventHandler(this.loadArmorButton_Click);
            // 
            // saveArmorButton
            // 
            this.saveArmorButton.Location = new System.Drawing.Point(137, 3);
            this.saveArmorButton.Name = "saveArmorButton";
            this.saveArmorButton.Size = new System.Drawing.Size(130, 23);
            this.saveArmorButton.TabIndex = 1;
            this.saveArmorButton.Text = "Save Armor";
            this.saveArmorButton.UseVisualStyleBackColor = true;
            this.saveArmorButton.Click += new System.EventHandler(this.saveArmorButton_Click);
            // 
            // openArmorDialog
            // 
            this.openArmorDialog.FileName = "openFileDialog1";
            // 
            // ArmorCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 231);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.maxACVal);
            this.Controls.Add(this.baseACVal);
            this.Controls.Add(this.stealthDisAdvBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.armorNameTextBox);
            this.Name = "ArmorCreator";
            this.Text = "ArmorCreator";
            ((System.ComponentModel.ISupportInitialize)(this.baseACVal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxACVal)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox armorNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox stealthDisAdvBox;
        private System.Windows.Forms.NumericUpDown baseACVal;
        private System.Windows.Forms.NumericUpDown maxACVal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadArmorButton;
        private System.Windows.Forms.Button saveArmorButton;
        private System.Windows.Forms.OpenFileDialog openArmorDialog;
        private System.Windows.Forms.SaveFileDialog saveArmorDialog;
    }
}