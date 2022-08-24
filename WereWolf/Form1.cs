using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WereWolf.models;

namespace WereWolf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Account user = new Account();
        int creatureHealth = 300;
        int creatureMobility = 50;
        int creatureAttack = 20;
        private void btnChoose_Click(object sender, EventArgs e)
        {
            user.Health = 100;
            user.Mobility = 150;
            user.Damage = 17;
            user.userName = txtUserName.Text;
            user.Branch = cmbBrans.SelectedItem.ToString();
            user.Race = cmbRace.SelectedItem.ToString();
            user.Weapon = cmbWeapon.SelectedItem.ToString();
            btnChoose.Visible = false;
            lblBranch.Visible = false;
            lblRace.Visible = false;
            lblUserName.Visible = false;
            lblWeapon.Visible = false;
            txtUserName.Visible = false;
            cmbWeapon.Visible = false;
            cmbBrans.Visible = false;
            cmbRace.Visible = false;
            lblFight.Visible = true;
            lblCreatureHealth.Visible = true;
            pcbWolf.Visible = true;
            lblHealth.Visible = true;
            lblAccountUserName.Visible = true;
            lblAccountBranch.Visible = true;
            lblAccountRace.Visible = true;
            lblAccountWeapon.Visible = true;
            lblVs.Visible = true;
            lblAccountHealth.Visible = true;
            btnAttack.Visible = true;
            btnCreatureAttack.Visible = true;
            btnCreatureAttack.Enabled = false;
            lblAccountDamage.Visible = true;
            lblAccountMobility.Visible = true;
            lblCreatureAttack.Visible = true;
            lblCreatureName.Visible = true;
            lblCreatureMobility.Visible = true;
            lblCreatureTextHealth.Visible = true;
            user.decidePower();
            user.decideStrength();
            lblHealth.Width = Convert.ToInt32(user.Health);
            lblCreatureMobility.Text = $"Mobility: {creatureMobility}";
            lblCreatureTextHealth.Text = $"Health: {creatureHealth}";
            lblCreatureAttack.Text = $"Attack: {creatureAttack}";
            lblAccountMobility.Text = $"Mobility : {user.Mobility}";
            lblAccountDamage.Text = $"Damage : {user.Damage}";
            lblAccountHealth.Text = $"Health : {user.Health}";
            lblAccountUserName.Text = $"Kullanıcı adı : {user.userName}";
            lblAccountBranch.Text = $"Branş : {user.Branch}";
            lblAccountRace.Text = $"Irk : {user.Race}";
            lblAccountWeapon.Text = $"Kullandığı silah : {user.Weapon}";
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dodge = rnd.Next(1 * 200);
            if(dodge <= creatureMobility)
            {
                MessageBox.Show("Creature Dodged the attack");
            }
            else
            {
                MessageBox.Show($"Creature get attacked by {user.userName} Damage:{user.Damage}");
                
                creatureHealth = creatureHealth - user.Damage;
                lblCreatureHealth.Width = lblCreatureHealth.Width - user.Damage;
            }
            btnCreatureAttack.Enabled = true;
            btnAttack.Enabled = false;
            if (creatureHealth <= 0)
            {
                MessageBox.Show($"{user.userName} WON!!");
            }
        }

        private void btnCreatureAttack_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int dodge = rnd.Next(1 * 200);
            if (dodge <= user.Mobility)
            {
                MessageBox.Show($"{user.userName} Dodged the attack");
            }
            else
            {
                MessageBox.Show($"{user.userName} get attacked by Creature Damage:{creatureAttack}");
                user.Health = user.Health - creatureAttack;
                lblHealth.Width = lblHealth.Width - creatureAttack;
            }
            btnAttack.Enabled = true;
            btnCreatureAttack.Enabled = false;
            if (user.Health <= 0)
            {
                MessageBox.Show($"Creature WON!!");
            }

        }

        
    }
}
