using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DungeonsAndDragonsCreatureVariator
{
    public partial class ArmorCreator : Form
    {
        Armor armor = new Armor();
        public ArmorCreator()
        {
            InitializeComponent();
            armorNameTextBox.Text = armor.Name;
            baseACVal.Text = armor.AC.ToString();
            maxACVal.Text = armor.MaxAC.ToString();
            stealthDisAdvBox.Checked = armor.StealthDisadvantage;
        }

        private void armorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            armor.Name = armorNameTextBox.Text;
        }

        private void stealthDisAdvBox_CheckedChanged(object sender, EventArgs e)
        {
            armor.StealthDisadvantage = stealthDisAdvBox.Checked;
        }

        private void baseACVal_ValueChanged(object sender, EventArgs e)
        {
            armor.AC = (int)baseACVal.Value;
        }

        private void maxACVal_ValueChanged(object sender, EventArgs e)
        {
            armor.MaxAC = (int)maxACVal.Value;
        }

        private void loadArmorButton_Click(object sender, EventArgs e)
        {
            if(openArmorDialog.ShowDialog() == DialogResult.OK)
            {
                LoadArmor(openArmorDialog.FileName);
            }
            
        }

        private void saveArmorButton_Click(object sender, EventArgs e)
        {
            if (saveArmorDialog.ShowDialog() == DialogResult.OK)
            {
                SaveArmor(saveArmorDialog.FileName);
            }
        }

        private void LoadArmor(string fileName)
        {
            XmlDocument armorFile = new XmlDocument();
            armorFile.Load(fileName);
            XmlNode node = armorFile.DocumentElement;


            //Get Name of Armor
            armor.Name = node.SelectSingleNode("Name").InnerText;

            //Get Stats of Armor
            armor.FilePath = node.SelectSingleNode("FilePath").InnerText;
            armor.AC = int.Parse(node.SelectSingleNode("AC").InnerText);
            armor.MaxAC = int.Parse(node.SelectSingleNode("MaxAC").InnerText);
            armor.StealthDisadvantage = bool.Parse(node.SelectSingleNode("StealthDisAdv").InnerText);

            //Have Modifiers get updated
            armorNameTextBox.Text = armor.Name;
            maxACVal.Value = armor.MaxAC;
            baseACVal.Value = armor.AC;
            stealthDisAdvBox.Checked = armor.StealthDisadvantage;
        }
        public Armor LoadArmorFromFilePath(string fileName)
        {
            LoadArmor(fileName);
            return armor;
        }

        private void SaveArmor(string fileName)
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();

            //Save Armor Name
            xmlTextWriter.WriteStartElement("Armor");
            xmlTextWriter.WriteElementString("Name", armor.Name);

            //Save file path
            xmlTextWriter.WriteElementString("FilePath", fileName);
            
            //Start Saving Stats
            xmlTextWriter.WriteElementString("AC", armor.AC.ToString());
            xmlTextWriter.WriteElementString("MaxAC", armor.MaxAC.ToString());
            xmlTextWriter.WriteElementString("StealthDisAdv", armor.StealthDisadvantage.ToString());
            xmlTextWriter.WriteEndElement();

            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
        }
    }
}
