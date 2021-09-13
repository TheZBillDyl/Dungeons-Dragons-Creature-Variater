
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
            this.selectedCreature = new System.Windows.Forms.Label();
            this.previousCreatureButton = new System.Windows.Forms.Button();
            this.nextCreatureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openCreatureDialog";
            this.openFileDialog1.Filter = "Excel files (*.xsfx)|*.xsfx|All files (*.*)|*.*";
            this.openFileDialog1.Title = "Select an Excel file";
            // 
            // openCreatureButton
            // 
            this.openCreatureButton.Location = new System.Drawing.Point(492, 520);
            this.openCreatureButton.Name = "openCreatureButton";
            this.openCreatureButton.Size = new System.Drawing.Size(128, 23);
            this.openCreatureButton.TabIndex = 0;
            this.openCreatureButton.Text = "Open Creature";
            this.openCreatureButton.UseVisualStyleBackColor = true;
            this.openCreatureButton.Click += new System.EventHandler(this.openCreatureFile_Click);
            // 
            // selectedCreature
            // 
            this.selectedCreature.AutoSize = true;
            this.selectedCreature.Location = new System.Drawing.Point(384, 88);
            this.selectedCreature.Name = "selectedCreature";
            this.selectedCreature.Size = new System.Drawing.Size(37, 13);
            this.selectedCreature.TabIndex = 1;
            this.selectedCreature.Text = "Goblin";
            // 
            // previousCreatureButton
            // 
            this.previousCreatureButton.Location = new System.Drawing.Point(387, 460);
            this.previousCreatureButton.Name = "previousCreatureButton";
            this.previousCreatureButton.Size = new System.Drawing.Size(75, 23);
            this.previousCreatureButton.TabIndex = 2;
            this.previousCreatureButton.Text = "Previous";
            this.previousCreatureButton.UseVisualStyleBackColor = true;
            this.previousCreatureButton.Click += new System.EventHandler(this.previousCreatureButton_Click);
            // 
            // nextCreatureButton
            // 
            this.nextCreatureButton.Location = new System.Drawing.Point(668, 460);
            this.nextCreatureButton.Name = "nextCreatureButton";
            this.nextCreatureButton.Size = new System.Drawing.Size(75, 23);
            this.nextCreatureButton.TabIndex = 3;
            this.nextCreatureButton.Text = "Next";
            this.nextCreatureButton.UseVisualStyleBackColor = true;
            this.nextCreatureButton.Click += new System.EventHandler(this.nextCreatureButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 612);
            this.Controls.Add(this.nextCreatureButton);
            this.Controls.Add(this.previousCreatureButton);
            this.Controls.Add(this.selectedCreature);
            this.Controls.Add(this.openCreatureButton);
            this.Name = "mainWindow";
            this.Text = "Creature Variator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openCreatureButton;
        private System.Windows.Forms.Label selectedCreature;
        private System.Windows.Forms.Button previousCreatureButton;
        private System.Windows.Forms.Button nextCreatureButton;
    }
}

