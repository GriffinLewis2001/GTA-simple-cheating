using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;
using GTA.Native;
using System.Windows.Forms;
namespace TestScript
{

    public class TestScript:Script
    {
        public TestScript()
        {
            UI.ShowSubtitle("For Convenience");
        }
    }
}
public class Cxxy:Script
{

    bool a;
    public Cxxy()
    {

        KeyDown += Main_KeyDown;
    }

    private void Main_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.NumPad7)
        {
            if (Game.Player.WantedLevel == 0)
            {
                UI.ShowSubtitle("You are very safe");                            //按数字键7消除警星
            }
            else
            {
                Game.Player.WantedLevel = 0;
                UI.ShowSubtitle("Wanted level 0");

            }

        }
        if (e.KeyCode == Keys.NumPad9)
        {
            if (Game.Player.WantedLevel == 5)
            {
                UI.ShowSubtitle("It is what it is");                             //桉数字键5增加警星
            }
            else
            {
                Game.Player.WantedLevel = 5;

                UI.ShowSubtitle("You are in deep shit");
            }

        }
        if (e.KeyCode == Keys.NumPad1)
        {
            if(Game.Player.Character.Weapons.Current.Hash == WeaponHash.Unarmed) //按数字键1将武器模式切换为徒手模式
            {
                UI.ShowSubtitle("You are unarmed");
            }
            else
            {
                a=Game.Player.Character.Weapons.Select(WeaponHash.Unarmed);


            }
        }
    }
}
