using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WereWolf.models
{
    public class Account
    {
        public string userName { get; set; }
        public string Race { get; set; }
        public string Branch { get; set; }
        public string Weapon { get; set; }
        public int Damage { get; set; }
        public int Health { get; set; }
        public int Mobility { get; set; }
        //if brach is warior health will increase 100
        //if brach is mage health will increase 50
        //if brach is archer health will increase 10
        //if brach is rogue health willnot increase
        //if brach is Brusier health will increase 300
        //if Race is Human health will increase 50
        //if Race is Elf health will increase 70
        //if Race is Cüce health willnot increase
        //if Race is Ork health will increase 200
        //if Race is Lizard health will increase 100
        //if Race is Undeath health will increase 10
        public void decideStrength()
        {
            if(Race=="Human" && Branch == "Warior")
            {
                Mobility += 20;
                Health += 150;
            }
            else if(Race=="Human"&& Branch == "Mage")
            {
                Mobility += 20;
                Health += 100;
            }
            else if (Race == "Human" && Branch == "Archer")
            {
                Mobility += 20;
                Health += 60;
            }
            else if (Race == "Human" && Branch == "Rogue")
            {
                Mobility += 20;
                Health += 50;
            }
            else if (Race == "Human" && Branch == "Brusier")
            {
                Mobility += 20;
                Health += 350;
            }
            //xxxxxxxxxxxxxxxxxxxxx
            else if (Race == "Elf" && Branch == "Warior")
            {
                Mobility += 40;
                Health += 170;
            }
            else if (Race == "Elf" && Branch == "Mage")
            {
                Mobility += 40;
                Health += 120;
            }
            else if (Race == "Elf" && Branch == "Archer")
            {
                Mobility += 40;
                Health += 80;
            }
            else if (Race == "Elf" && Branch == "Rogue")
            {
                Mobility += 40;
                Health += 70;
            }
            else if (Race == "Elf" && Branch == "Brusier")
            {
                Mobility += 40;
                Health += 370;
            }
            //xxxxxxxxxxxxxxxxxxxxxxx
            else if (Race == "Cüce" && Branch == "Warior")
            {
                Mobility -= 60;
                Health += 100;
            }
            else if (Race == "Cüce" && Branch == "Mage")
            {
                Mobility -= 60;
                Health += 50;
            }
            else if (Race == "Cüce" && Branch == "Archer")
            {
                Mobility -= 60;
                Health += 10;
            }
            else if (Race == "Cüce" && Branch == "Rogue")
            {
                Mobility -= 60;
                Health += 0;
            }
            else if (Race == "Cüce" && Branch == "Brusier")
            {
                Mobility -= 60;
                Health += 300;
            }
            //xxxxxxxxxxxxxxxxxxxxx
            else if (Race == "Ork" && Branch == "Warior")
            {
                Mobility -= 50;
                Health += 300;
            }
            else if (Race == "Ork" && Branch == "Mage")
            {
                Mobility -= 50;
                Health += 250;
            }
            else if (Race == "Ork" && Branch == "Archer")
            {
                Mobility -= 50;
                Health += 210;
            }
            else if (Race == "Ork" && Branch == "Rogue")
            {
                Mobility -= 50;
                Health += 200;
            }
            else if (Race == "Ork" && Branch == "Brusier")
            {
                Health += 500;
                Mobility -= 50;
            }
            //xxxxxxxxxxx
            else if (Race == "Lizard" && Branch == "Warior")
            {
                Mobility += 80;
                Health += 200;
            }
            else if (Race == "Lizard" && Branch == "Mage")
            {
                Mobility += 80;
                Health += 150;
            }
            else if (Race == "Lizard" && Branch == "Archer")
            {
                Mobility += 80;
                Health += 110;
            }
            else if (Race == "Lizard" && Branch == "Rogue")
            {
                Mobility += 80;
                Health += 100;
            }
            else if (Race == "Lizard" && Branch == "Brusier")
            {
                Mobility += 80;
                Health += 400;
            }
            //xxxxxxxxx
            else if (Race == "Undeath" && Branch == "Warior")
            {
                Mobility += 30;
                Health += 110;
            }
            else if (Race == "Undeath" && Branch == "Mage")
            {
                Mobility += 30;
                Health += 60;
            }
            else if (Race == "Undeath" && Branch == "Archer")
            {
                Mobility += 30;
                Health += 20;
            }
            else if (Race == "Undeath" && Branch == "Rogue")
            {
                Mobility += 30;
                Health += 10;
            }
            else if (Race == "Undeath" && Branch == "Brusier")
            {
                Mobility += 30;
                Health += 310;
            }
        }
        public void decidePower()
        {
            if(Branch=="Rogue" && (Weapon=="Dagger" || Weapon=="Throwable Knife"))
            {
                Damage += 40;
            }
            else
            {
                if (Weapon == "Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage = Damage;
            }
            if (Branch=="Mage" && (Weapon == "Staff" || Weapon == "Wand"))
            {
                Damage += 30;
            }
            else
            {
                if (Weapon == "Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage = Damage;
            }
            if (Branch == "Brusier" && (Weapon == "Mace" || Weapon == "Bat" || Weapon == "Long Sword" || Weapon == "Balyoz"))
            {
                if(Weapon=="Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage += 20;
            }
            else
            {
                if (Weapon == "Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage = Damage;
            }
            if (Branch == "Warior" && (Weapon == "Mace" || Weapon == "Short Sword" || Weapon == "Long Sword" || Weapon == "Balyoz"))
            {
                if (Weapon == "Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage += 25;
            }
            else
            {
                if (Weapon == "Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage = Damage;
            }
            if (Branch == "Archer" && Weapon=="Bow")
            {
                Damage += 10;
            }
            else
            {
                if (Weapon == "Long Sword")
                {
                    Mobility -= 10;
                }
                else if (Weapon == "Balyoz")
                {
                    Mobility -= 20;
                }
                Damage = Damage;
            }
        }


    }
}
