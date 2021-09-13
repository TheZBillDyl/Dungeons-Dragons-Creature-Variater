
namespace DungeonsAndDragonsCreatureVariator
{
    partial class mainWindow
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openCreatureButton = new System.Windows.Forms.Button();
            this.previousCreatureButton = new System.Windows.Forms.Button();
            this.nextCreatureButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dexterityStat = new System.Windows.Forms.TextBox();
            this.constitutionStat = new System.Windows.Forms.TextBox();
            this.intelligenceStat = new System.Windows.Forms.TextBox();
            this.wisdomStat = new System.Windows.Forms.TextBox();
            this.charismaStat = new System.Windows.Forms.TextBox();
            this.strMod = new System.Windows.Forms.Label();
            this.dexMod = new System.Windows.Forms.Label();
            this.conMod = new System.Windows.Forms.Label();
            this.intMod = new System.Windows.Forms.Label();
            this.wisMod = new System.Windows.Forms.Label();
            this.charMod = new System.Windows.Forms.Label();
            this.strengthStat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.creatureName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openCreatureDialog";
            this.openFileDialog1.Filter = "Creature files (*.xml)|*.xml |All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select an Excel file";
            // 
            // openCreatureButton
            // 
            this.openCreatureButton.Location = new System.Drawing.Point(955, 3);
            this.openCreatureButton.Name = "openCreatureButton";
            this.openCreatureButton.Size = new System.Drawing.Size(116, 23);
            this.openCreatureButton.TabIndex = 0;
            this.openCreatureButton.Text = "Open Creature";
            this.openCreatureButton.UseVisualStyleBackColor = true;
            this.openCreatureButton.Click += new System.EventHandler(this.openCreatureFile_Click);
            // 
            // previousCreatureButton
            // 
            this.previousCreatureButton.Location = new System.Drawing.Point(671, 3);
            this.previousCreatureButton.Name = "previousCreatureButton";
            this.previousCreatureButton.Size = new System.Drawing.Size(75, 23);
            this.previousCreatureButton.TabIndex = 2;
            this.previousCreatureButton.Text = "Previous";
            this.previousCreatureButton.UseVisualStyleBackColor = true;
            this.previousCreatureButton.Click += new System.EventHandler(this.previousCreatureButton_Click);
            // 
            // nextCreatureButton
            // 
            this.nextCreatureButton.Location = new System.Drawing.Point(752, 3);
            this.nextCreatureButton.Name = "nextCreatureButton";
            this.nextCreatureButton.Size = new System.Drawing.Size(75, 23);
            this.nextCreatureButton.TabIndex = 3;
            this.nextCreatureButton.Text = "Next";
            this.nextCreatureButton.UseVisualStyleBackColor = true;
            this.nextCreatureButton.Click += new System.EventHandler(this.nextCreatureButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(833, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Creature";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Creature files (*.xml)|*.xml |All files (*.*)|*.*";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.openCreatureButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.nextCreatureButton);
            this.flowLayoutPanel1.Controls.Add(this.previousCreatureButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 500);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1078, 100);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Controls.Add(this.dexterityStat, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.constitutionStat, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.intelligenceStat, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.wisdomStat, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.charismaStat, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.strMod, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dexMod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.conMod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.intMod, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.wisMod, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.charMod, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.strengthStat, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 100);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dexterityStat
            // 
            this.dexterityStat.Location = new System.Drawing.Point(70, 4);
            this.dexterityStat.Name = "dexterityStat";
            this.dexterityStat.Size = new System.Drawing.Size(59, 20);
            this.dexterityStat.TabIndex = 1;
            this.dexterityStat.Text = "10";
            this.dexterityStat.TextChanged += new System.EventHandler(this.dexterityStat_TextChanged);
            // 
            // constitutionStat
            // 
            this.constitutionStat.Location = new System.Drawing.Point(136, 4);
            this.constitutionStat.Name = "constitutionStat";
            this.constitutionStat.Size = new System.Drawing.Size(59, 20);
            this.constitutionStat.TabIndex = 2;
            this.constitutionStat.Text = "10";
            this.constitutionStat.TextChanged += new System.EventHandler(this.constitutionStat_TextChanged);
            // 
            // intelligenceStat
            // 
            this.intelligenceStat.Location = new System.Drawing.Point(202, 4);
            this.intelligenceStat.Name = "intelligenceStat";
            this.intelligenceStat.Size = new System.Drawing.Size(59, 20);
            this.intelligenceStat.TabIndex = 3;
            this.intelligenceStat.Text = "10";
            this.intelligenceStat.TextChanged += new System.EventHandler(this.intelligenceStat_TextChanged);
            // 
            // wisdomStat
            // 
            this.wisdomStat.Location = new System.Drawing.Point(268, 4);
            this.wisdomStat.Name = "wisdomStat";
            this.wisdomStat.Size = new System.Drawing.Size(59, 20);
            this.wisdomStat.TabIndex = 4;
            this.wisdomStat.Text = "10";
            this.wisdomStat.TextChanged += new System.EventHandler(this.wisdomStat_TextChanged);
            // 
            // charismaStat
            // 
            this.charismaStat.Location = new System.Drawing.Point(334, 4);
            this.charismaStat.Name = "charismaStat";
            this.charismaStat.Size = new System.Drawing.Size(59, 20);
            this.charismaStat.TabIndex = 5;
            this.charismaStat.Text = "10";
            this.charismaStat.TextChanged += new System.EventHandler(this.charismaStat_TextChanged);
            // 
            // strMod
            // 
            this.strMod.AutoSize = true;
            this.strMod.Location = new System.Drawing.Point(4, 50);
            this.strMod.Name = "strMod";
            this.strMod.Size = new System.Drawing.Size(13, 13);
            this.strMod.TabIndex = 6;
            this.strMod.Text = "0";
            // 
            // dexMod
            // 
            this.dexMod.AutoSize = true;
            this.dexMod.Location = new System.Drawing.Point(70, 50);
            this.dexMod.Name = "dexMod";
            this.dexMod.Size = new System.Drawing.Size(13, 13);
            this.dexMod.TabIndex = 7;
            this.dexMod.Text = "0";
            // 
            // conMod
            // 
            this.conMod.AutoSize = true;
            this.conMod.Location = new System.Drawing.Point(136, 50);
            this.conMod.Name = "conMod";
            this.conMod.Size = new System.Drawing.Size(13, 13);
            this.conMod.TabIndex = 8;
            this.conMod.Text = "0";
            // 
            // intMod
            // 
            this.intMod.AutoSize = true;
            this.intMod.Location = new System.Drawing.Point(202, 50);
            this.intMod.Name = "intMod";
            this.intMod.Size = new System.Drawing.Size(13, 13);
            this.intMod.TabIndex = 9;
            this.intMod.Text = "0";
            // 
            // wisMod
            // 
            this.wisMod.AutoSize = true;
            this.wisMod.Location = new System.Drawing.Point(268, 50);
            this.wisMod.Name = "wisMod";
            this.wisMod.Size = new System.Drawing.Size(13, 13);
            this.wisMod.TabIndex = 10;
            this.wisMod.Text = "0";
            // 
            // charMod
            // 
            this.charMod.AutoSize = true;
            this.charMod.Location = new System.Drawing.Point(334, 50);
            this.charMod.Name = "charMod";
            this.charMod.Size = new System.Drawing.Size(13, 13);
            this.charMod.TabIndex = 11;
            this.charMod.Text = "0";
            // 
            // strengthStat
            // 
            this.strengthStat.Location = new System.Drawing.Point(4, 4);
            this.strengthStat.Name = "strengthStat";
            this.strengthStat.Size = new System.Drawing.Size(59, 20);
            this.strengthStat.TabIndex = 0;
            this.strengthStat.Text = "10";
            this.strengthStat.TextChanged += new System.EventHandler(this.strengthStat_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Strength";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dexterity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Constitution";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Intelligence";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Wisdom";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Charisma";
            // 
            // creatureName
            // 
            this.creatureName.Location = new System.Drawing.Point(233, 30);
            this.creatureName.Name = "creatureName";
            this.creatureName.Size = new System.Drawing.Size(100, 20);
            this.creatureName.TabIndex = 13;
            this.creatureName.Text = "Creature Name";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.creatureName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "mainWindow";
            this.Text = "Creature Variator";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openCreatureButton;
        private System.Windows.Forms.Button previousCreatureButton;
        private System.Windows.Forms.Button nextCreatureButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox dexterityStat;
        private System.Windows.Forms.TextBox constitutionStat;
        private System.Windows.Forms.TextBox intelligenceStat;
        private System.Windows.Forms.TextBox wisdomStat;
        private System.Windows.Forms.TextBox charismaStat;
        private System.Windows.Forms.Label strMod;
        private System.Windows.Forms.Label dexMod;
        private System.Windows.Forms.Label conMod;
        private System.Windows.Forms.Label intMod;
        private System.Windows.Forms.Label wisMod;
        private System.Windows.Forms.Label charMod;
        private System.Windows.Forms.TextBox strengthStat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox creatureName;
    }
}

