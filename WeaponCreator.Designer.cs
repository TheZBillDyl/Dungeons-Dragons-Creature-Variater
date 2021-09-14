
namespace DungeonsAndDragonsCreatureVariator
{
    partial class WeaponCreator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.weaponName = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadButton = new System.Windows.Forms.Button();
            this.amtOfDie = new System.Windows.Forms.NumericUpDown();
            this.typeOfDie = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modifierAmount = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amtOfDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifierAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.weaponName);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 46);
            this.panel1.TabIndex = 0;
            // 
            // weaponName
            // 
            this.weaponName.Location = new System.Drawing.Point(295, 10);
            this.weaponName.Name = "weaponName";
            this.weaponName.Size = new System.Drawing.Size(164, 20);
            this.weaponName.TabIndex = 0;
            this.weaponName.Text = "Weapon Name";
            this.weaponName.TextChanged += new System.EventHandler(this.weaponName_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.loadButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 381);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 57);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(84, 3);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // amtOfDie
            // 
            this.amtOfDie.Location = new System.Drawing.Point(255, 124);
            this.amtOfDie.Name = "amtOfDie";
            this.amtOfDie.Size = new System.Drawing.Size(47, 20);
            this.amtOfDie.TabIndex = 3;
            this.amtOfDie.ValueChanged += new System.EventHandler(this.amtOfDie_ValueChanged);
            // 
            // typeOfDie
            // 
            this.typeOfDie.Location = new System.Drawing.Point(332, 124);
            this.typeOfDie.Name = "typeOfDie";
            this.typeOfDie.Size = new System.Drawing.Size(47, 20);
            this.typeOfDie.TabIndex = 4;
            this.typeOfDie.ValueChanged += new System.EventHandler(this.typeOfDie_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "D";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(385, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "+";
            // 
            // modifierAmount
            // 
            this.modifierAmount.Location = new System.Drawing.Point(404, 124);
            this.modifierAmount.Name = "modifierAmount";
            this.modifierAmount.Size = new System.Drawing.Size(57, 20);
            this.modifierAmount.TabIndex = 7;
            this.modifierAmount.ValueChanged += new System.EventHandler(this.modifierAmount_ValueChanged);
            // 
            // WeaponCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modifierAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.typeOfDie);
            this.Controls.Add(this.amtOfDie);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "WeaponCreator";
            this.Text = "WeaponCreator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.amtOfDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeOfDie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modifierAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox weaponName;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown amtOfDie;
        private System.Windows.Forms.NumericUpDown typeOfDie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown modifierAmount;
    }
}