using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }
    }
}
