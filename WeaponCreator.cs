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
    public partial class WeaponCreator : Form
    {
        Weapon weapon = new Weapon();
        public WeaponCreator()
        {
            InitializeComponent();
        }

        private void weaponName_TextChanged(object sender, EventArgs e)
        {
            weapon.Name = weaponName.Text;
        }

        private void amtOfDie_ValueChanged(object sender, EventArgs e)
        {
            weapon.DamageDieAmount = (int)amtOfDie.Value;
        }

        private void typeOfDie_ValueChanged(object sender, EventArgs e)
        {
            weapon.DamageDie = (int)typeOfDie.Value;
        }

        private void modifierAmount_ValueChanged(object sender, EventArgs e)
        {
            weapon.Modifier = (int)modifierAmount.Value;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
                SaveWeapon(saveFileDialog1.FileName);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
                LoadWeapon(openFileDialog1.FileName);
        }

        private void SaveWeapon(string fileName)
        {
            
            XmlTextWriter xmlTextWriter = new XmlTextWriter(fileName, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;
            xmlTextWriter.WriteStartDocument();

            //Save Weapon Name
            xmlTextWriter.WriteStartElement("Weapon");
            xmlTextWriter.WriteElementString("Name", weapon.Name);

            //Save file path
            xmlTextWriter.WriteElementString("FilePath", fileName);
            //Start Saving Stats
            xmlTextWriter.WriteElementString("DamageDiceAmount", weapon.DamageDieAmount.ToString());
            xmlTextWriter.WriteElementString("DamageDice", weapon.DamageDie.ToString());
            xmlTextWriter.WriteElementString("ExtraModifier", weapon.Modifier.ToString());
            xmlTextWriter.WriteEndElement();

            xmlTextWriter.WriteEndDocument();
            xmlTextWriter.Flush();
            xmlTextWriter.Close();
        }
        private void LoadWeapon(string fileName)
        {
            XmlDocument weaponFile = new XmlDocument();
            weaponFile.Load(fileName);
            XmlNode node = weaponFile.DocumentElement;


            //Get Name of Weapon
            weapon.Name = node.SelectSingleNode("Name").InnerText;

            //Get Stats of Weapon
            weapon.DamageDie = int.Parse(node.SelectSingleNode("DamageDice").InnerText);
            weapon.DamageDieAmount = int.Parse(node.SelectSingleNode("DamageDiceAmount").InnerText);
            weapon.Modifier = int.Parse(node.SelectSingleNode("ExtraModifier").InnerText);
            weapon.FilePath = node.SelectSingleNode("FilePath").InnerText;
            
            //Have Modifiers get updated
            weaponName.Text = weapon.Name;
            typeOfDie.Value = weapon.DamageDie;
            amtOfDie.Value = weapon.DamageDieAmount;
        }

        public Weapon LoadWeaponFromFilePath(string fileName)
        {
            LoadWeapon(fileName);
            return weapon;
        }
    }
}
