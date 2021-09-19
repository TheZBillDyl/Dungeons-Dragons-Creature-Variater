
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
            this.openCreatureDialog = new System.Windows.Forms.OpenFileDialog();
            this.openCreatureButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.creatureSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.createWeapon = new System.Windows.Forms.Button();
            this.addWeapon = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.changeArmorButton = new System.Windows.Forms.Button();
            this.createArmorButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dexterityStat = new System.Windows.Forms.TextBox();
            this.constitutionStat = new System.Windows.Forms.TextBox();
            this.intelligenceStat = new System.Windows.Forms.TextBox();
            this.wisdomStat = new System.Windows.Forms.TextBox();
            this.charismaStat = new System.Windows.Forms.TextBox();
            this.dexMod = new System.Windows.Forms.Label();
            this.conMod = new System.Windows.Forms.Label();
            this.intMod = new System.Windows.Forms.Label();
            this.wisMod = new System.Windows.Forms.Label();
            this.charMod = new System.Windows.Forms.Label();
            this.strengthStat = new System.Windows.Forms.TextBox();
            this.strMod = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.creatureName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.acValue = new System.Windows.Forms.Label();
            this.ACLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.healthValue = new System.Windows.Forms.Label();
            this.healthMod = new System.Windows.Forms.Label();
            this.healthLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.weaponList = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.weaponSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.openWeaponDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel4 = new System.Windows.Forms.Panel();
            this.armorLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openArmorDialog = new System.Windows.Forms.OpenFileDialog();
            this.diceAmount = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.diceType = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceType)).BeginInit();
            this.SuspendLayout();
            // 
            // openCreatureDialog
            // 
            this.openCreatureDialog.FileName = "openCreatureDialog";
            this.openCreatureDialog.Filter = "Creature files (*.xml)|*.xml |All files (*.*)|*.*";
            this.openCreatureDialog.Title = "Select an Excel file";
            // 
            // openCreatureButton
            // 
            this.openCreatureButton.Location = new System.Drawing.Point(735, 3);
            this.openCreatureButton.Name = "openCreatureButton";
            this.openCreatureButton.Size = new System.Drawing.Size(116, 23);
            this.openCreatureButton.TabIndex = 0;
            this.openCreatureButton.Text = "Open Creature";
            this.openCreatureButton.UseVisualStyleBackColor = true;
            this.openCreatureButton.Click += new System.EventHandler(this.openCreatureFile_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(613, 3);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(116, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save Creature";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // creatureSaveDialog
            // 
            this.creatureSaveDialog.Filter = "Creature files (*.xml)|*.xml |All files (*.*)|*.*";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.openCreatureButton);
            this.flowLayoutPanel1.Controls.Add(this.saveButton);
            this.flowLayoutPanel1.Controls.Add(this.createWeapon);
            this.flowLayoutPanel1.Controls.Add(this.addWeapon);
            this.flowLayoutPanel1.Controls.Add(this.removeButton);
            this.flowLayoutPanel1.Controls.Add(this.changeArmorButton);
            this.flowLayoutPanel1.Controls.Add(this.createArmorButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 454);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(858, 38);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // createWeapon
            // 
            this.createWeapon.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createWeapon.Location = new System.Drawing.Point(490, 3);
            this.createWeapon.Name = "createWeapon";
            this.createWeapon.Size = new System.Drawing.Size(117, 23);
            this.createWeapon.TabIndex = 18;
            this.createWeapon.Text = "Create Weapon";
            this.createWeapon.UseVisualStyleBackColor = true;
            this.createWeapon.Click += new System.EventHandler(this.createWeapon_Click);
            // 
            // addWeapon
            // 
            this.addWeapon.Location = new System.Drawing.Point(379, 3);
            this.addWeapon.Name = "addWeapon";
            this.addWeapon.Size = new System.Drawing.Size(105, 23);
            this.addWeapon.TabIndex = 2;
            this.addWeapon.Text = "Add Weapon";
            this.addWeapon.UseVisualStyleBackColor = true;
            this.addWeapon.Click += new System.EventHandler(this.addWeapon_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(254, 3);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(119, 23);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "Remove Weapon";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // changeArmorButton
            // 
            this.changeArmorButton.Location = new System.Drawing.Point(134, 3);
            this.changeArmorButton.Name = "changeArmorButton";
            this.changeArmorButton.Size = new System.Drawing.Size(114, 23);
            this.changeArmorButton.TabIndex = 20;
            this.changeArmorButton.Text = "Change Armor";
            this.changeArmorButton.UseVisualStyleBackColor = true;
            this.changeArmorButton.Click += new System.EventHandler(this.changeArmorButton_Click);
            // 
            // createArmorButton
            // 
            this.createArmorButton.Location = new System.Drawing.Point(10, 3);
            this.createArmorButton.Name = "createArmorButton";
            this.createArmorButton.Size = new System.Drawing.Size(118, 23);
            this.createArmorButton.TabIndex = 21;
            this.createArmorButton.Text = "Create Armor";
            this.createArmorButton.UseVisualStyleBackColor = true;
            this.createArmorButton.Click += new System.EventHandler(this.createArmorButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
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
            this.tableLayoutPanel1.Controls.Add(this.dexMod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.conMod, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.intMod, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.wisMod, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.charMod, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.strengthStat, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.strMod, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(83, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.38461F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.61538F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 50);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // dexterityStat
            // 
            this.dexterityStat.Location = new System.Drawing.Point(71, 6);
            this.dexterityStat.Name = "dexterityStat";
            this.dexterityStat.Size = new System.Drawing.Size(56, 20);
            this.dexterityStat.TabIndex = 1;
            this.dexterityStat.Text = "10";
            this.dexterityStat.TextChanged += new System.EventHandler(this.dexterityStat_TextChanged);
            // 
            // constitutionStat
            // 
            this.constitutionStat.Location = new System.Drawing.Point(136, 6);
            this.constitutionStat.Name = "constitutionStat";
            this.constitutionStat.Size = new System.Drawing.Size(56, 20);
            this.constitutionStat.TabIndex = 2;
            this.constitutionStat.Text = "10";
            this.constitutionStat.TextChanged += new System.EventHandler(this.constitutionStat_TextChanged);
            // 
            // intelligenceStat
            // 
            this.intelligenceStat.Location = new System.Drawing.Point(201, 6);
            this.intelligenceStat.Name = "intelligenceStat";
            this.intelligenceStat.Size = new System.Drawing.Size(56, 20);
            this.intelligenceStat.TabIndex = 3;
            this.intelligenceStat.Text = "10";
            this.intelligenceStat.TextChanged += new System.EventHandler(this.intelligenceStat_TextChanged);
            // 
            // wisdomStat
            // 
            this.wisdomStat.Location = new System.Drawing.Point(266, 6);
            this.wisdomStat.Name = "wisdomStat";
            this.wisdomStat.Size = new System.Drawing.Size(56, 20);
            this.wisdomStat.TabIndex = 4;
            this.wisdomStat.Text = "10";
            this.wisdomStat.TextChanged += new System.EventHandler(this.wisdomStat_TextChanged);
            // 
            // charismaStat
            // 
            this.charismaStat.Location = new System.Drawing.Point(331, 6);
            this.charismaStat.Name = "charismaStat";
            this.charismaStat.Size = new System.Drawing.Size(59, 20);
            this.charismaStat.TabIndex = 5;
            this.charismaStat.Text = "10";
            this.charismaStat.TextChanged += new System.EventHandler(this.charismaStat_TextChanged);
            // 
            // dexMod
            // 
            this.dexMod.AutoSize = true;
            this.dexMod.Location = new System.Drawing.Point(71, 32);
            this.dexMod.Name = "dexMod";
            this.dexMod.Size = new System.Drawing.Size(13, 13);
            this.dexMod.TabIndex = 7;
            this.dexMod.Text = "0";
            // 
            // conMod
            // 
            this.conMod.AutoSize = true;
            this.conMod.Location = new System.Drawing.Point(136, 32);
            this.conMod.Name = "conMod";
            this.conMod.Size = new System.Drawing.Size(13, 13);
            this.conMod.TabIndex = 8;
            this.conMod.Text = "0";
            // 
            // intMod
            // 
            this.intMod.AutoSize = true;
            this.intMod.Location = new System.Drawing.Point(201, 32);
            this.intMod.Name = "intMod";
            this.intMod.Size = new System.Drawing.Size(13, 13);
            this.intMod.TabIndex = 9;
            this.intMod.Text = "0";
            // 
            // wisMod
            // 
            this.wisMod.AutoSize = true;
            this.wisMod.Location = new System.Drawing.Point(266, 32);
            this.wisMod.Name = "wisMod";
            this.wisMod.Size = new System.Drawing.Size(13, 13);
            this.wisMod.TabIndex = 10;
            this.wisMod.Text = "0";
            // 
            // charMod
            // 
            this.charMod.AutoSize = true;
            this.charMod.Location = new System.Drawing.Point(331, 32);
            this.charMod.Name = "charMod";
            this.charMod.Size = new System.Drawing.Size(13, 13);
            this.charMod.TabIndex = 11;
            this.charMod.Text = "0";
            // 
            // strengthStat
            // 
            this.strengthStat.Location = new System.Drawing.Point(6, 6);
            this.strengthStat.Name = "strengthStat";
            this.strengthStat.Size = new System.Drawing.Size(56, 20);
            this.strengthStat.TabIndex = 0;
            this.strengthStat.Text = "10";
            this.strengthStat.TextChanged += new System.EventHandler(this.strengthStat_TextChanged);
            // 
            // strMod
            // 
            this.strMod.AutoSize = true;
            this.strMod.Location = new System.Drawing.Point(6, 32);
            this.strMod.Name = "strMod";
            this.strMod.Size = new System.Drawing.Size(13, 13);
            this.strMod.TabIndex = 6;
            this.strMod.Text = "0";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.acValue);
            this.panel1.Controls.Add(this.ACLabel);
            this.panel1.Location = new System.Drawing.Point(83, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 57);
            this.panel1.TabIndex = 15;
            // 
            // acValue
            // 
            this.acValue.AutoSize = true;
            this.acValue.Location = new System.Drawing.Point(20, 25);
            this.acValue.Name = "acValue";
            this.acValue.Size = new System.Drawing.Size(19, 13);
            this.acValue.TabIndex = 1;
            this.acValue.Text = "10";
            // 
            // ACLabel
            // 
            this.ACLabel.AutoSize = true;
            this.ACLabel.Location = new System.Drawing.Point(20, 0);
            this.ACLabel.Name = "ACLabel";
            this.ACLabel.Size = new System.Drawing.Size(21, 13);
            this.ACLabel.TabIndex = 0;
            this.ACLabel.Text = "AC";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.diceType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.diceAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.healthValue);
            this.panel2.Controls.Add(this.healthMod);
            this.panel2.Controls.Add(this.healthLabel);
            this.panel2.Location = new System.Drawing.Point(412, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 57);
            this.panel2.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "+";
            // 
            // healthValue
            // 
            this.healthValue.AutoSize = true;
            this.healthValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthValue.Location = new System.Drawing.Point(41, 25);
            this.healthValue.Name = "healthValue";
            this.healthValue.Size = new System.Drawing.Size(27, 20);
            this.healthValue.TabIndex = 18;
            this.healthValue.Text = "99";
            // 
            // healthMod
            // 
            this.healthMod.AutoSize = true;
            this.healthMod.Location = new System.Drawing.Point(165, 3);
            this.healthMod.Name = "healthMod";
            this.healthMod.Size = new System.Drawing.Size(19, 13);
            this.healthMod.TabIndex = 1;
            this.healthMod.Text = "10";
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(3, 3);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(22, 13);
            this.healthLabel.TabIndex = 0;
            this.healthLabel.Text = "HP";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.weaponList);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(83, 160);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(195, 274);
            this.panel3.TabIndex = 17;
            // 
            // weaponList
            // 
            this.weaponList.BackColor = System.Drawing.SystemColors.Control;
            this.weaponList.Location = new System.Drawing.Point(-2, 16);
            this.weaponList.Name = "weaponList";
            this.weaponList.Size = new System.Drawing.Size(195, 256);
            this.weaponList.TabIndex = 18;
            this.weaponList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.weaponList_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weapons";
            // 
            // openWeaponDialog
            // 
            this.openWeaponDialog.FileName = "openWeaponDialog";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.armorLabel);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(287, 160);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(195, 58);
            this.panel4.TabIndex = 19;
            // 
            // armorLabel
            // 
            this.armorLabel.AutoSize = true;
            this.armorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorLabel.Location = new System.Drawing.Point(41, 16);
            this.armorLabel.Name = "armorLabel";
            this.armorLabel.Size = new System.Drawing.Size(0, 20);
            this.armorLabel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Armor";
            // 
            // diceAmount
            // 
            this.diceAmount.Location = new System.Drawing.Point(43, 1);
            this.diceAmount.Name = "diceAmount";
            this.diceAmount.Size = new System.Drawing.Size(41, 20);
            this.diceAmount.TabIndex = 20;
            this.diceAmount.ValueChanged += new System.EventHandler(this.diceAmount_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "D";
            // 
            // diceType
            // 
            this.diceType.Location = new System.Drawing.Point(103, 1);
            this.diceType.Name = "diceType";
            this.diceType.Size = new System.Drawing.Size(37, 20);
            this.diceType.TabIndex = 22;
            this.diceType.ValueChanged += new System.EventHandler(this.diceType_ValueChanged);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 497);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.diceAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diceType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openCreatureDialog;
        private System.Windows.Forms.Button openCreatureButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.SaveFileDialog creatureSaveDialog;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label acValue;
        private System.Windows.Forms.Label ACLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label healthMod;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createWeapon;
        private System.Windows.Forms.Button addWeapon;
        private System.Windows.Forms.TreeView weaponList;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.SaveFileDialog weaponSaveDialog;
        private System.Windows.Forms.OpenFileDialog openWeaponDialog;
        private System.Windows.Forms.Button changeArmorButton;
        private System.Windows.Forms.Button createArmorButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label armorLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openArmorDialog;
        private System.Windows.Forms.Label healthValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown diceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown diceAmount;
    }
}

