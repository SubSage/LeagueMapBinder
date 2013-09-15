/* Luis Martinez ; Subsage
 * Project to create an out-of-game key binder for League of Legends.
 * Started on 9/4/2013
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace LeagueMapBinder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void button8_Click(object sender, EventArgs e)//Publish
        {
            string[] lines = new string[77];
            // WriteAllLines creates a file, writes a collection of strings to the file, 
            // and then closes the file.
            
            lines[0]  = "[GameEvents]";
            lines[1]  = getText("evtCastSpell1", comboBox1.Text, textBox6.Text);
            lines[2]  = getText("evtCastSpell2", comboBox2.Text, textBox7.Text);
            lines[3]  = getText("evtCastSpell3", comboBox3.Text, textBox8.Text);
            lines[4]  = getText("evtCastSpell4", comboBox4.Text, textBox9.Text);
            lines[5]  = getText("evtCastAvatarSpell1", comboBox12.Text, textBox25.Text);
            lines[6]  = getText("evtCastAvatarSpell2", comboBox11.Text, textBox24.Text);
            lines[7]  = getText("evtLevelSpell1", comboBox8.Text, textBox17.Text);
            lines[8]  = getText("evtLevelSpell2", comboBox7.Text, textBox16.Text);
            lines[9]  = getText("evtLevelSpell3", comboBox6.Text, textBox15.Text);
            lines[10] = getText("evtLevelSpell4", comboBox5.Text, textBox14.Text);
            lines[11] = getText("evtSelfCastSpell1", comboBox14.Text, textBox12.Text);
            lines[12] = getText("evtSelfCastSpell2", comboBox13.Text, textBox11.Text);
            lines[13] = getText("evtSelfCastSpell3", comboBox10.Text, textBox10.Text);
            lines[14] = getText("evtSelfCastSpell4", comboBox9.Text, textBox1.Text);
            lines[15] = getText("evtSelfCastAvatarSpell1", comboBox16.Text, textBox30.Text);
            lines[16] = getText("evtSelfCastAvatarSpell2", comboBox15.Text, textBox27.Text);
            lines[17] = getText("evtSmartCastSpell1", comboBox20.Text, textBox36.Text);
            lines[18] = getText("evtSmartCastSpell2", comboBox19.Text, textBox35.Text);
            lines[19] = getText("evtSmartCastSpell3", comboBox18.Text, textBox34.Text);
            lines[20] = getText("evtSmartCastSpell4", comboBox17.Text, textBox33.Text);
            lines[21] = getText("evtSmartCastAvatarSpell1", comboBox16.Text, textBox42.Text);
            lines[22] = getText("evtSmartCastAvatarSpell2", comboBox15.Text, textBox41.Text);
            lines[23] = getText("evtUseItem1", comboBox26.Text, textBox48.Text);
            lines[24] = getText("evtUseItem2", comboBox25.Text, textBox47.Text);
            lines[25] = getText("evtUseItem3", comboBox24.Text, textBox46.Text);
            lines[26] = getText("evtUseItem4", comboBox23.Text, textBox45.Text);
            lines[27] = getText("evtUseItem5", comboBox27.Text, textBox65.Text);
            lines[28] = getText("evtUseItem6", comboBox28.Text, textBox66.Text);
            lines[29] = getText("evtSmartCastItem1", comboBox34.Text, textBox61.Text);
            lines[30] = getText("evtSmartCastItem2", comboBox33.Text, textBox60.Text);
            lines[31] = getText("evtSmartCastItem3", comboBox32.Text, textBox59.Text);
            lines[32] = getText("evtSmartCastItem4", comboBox31.Text, textBox58.Text);
            lines[33] = getText("evtSmartCastItem5", comboBox30.Text, textBox67.Text);
            lines[34] = getText("evtSmartCastItem6", comboBox29.Text, textBox68.Text);
            lines[35] = getText("evtShowCharacterMenu", comboBox36.Text, textBox70.Text);
            lines[36] = getText("evtShowScoreBoard", comboBox35.Text, textBox69.Text);
            lines[37] = getText("evtOpenShop", comboBox37.Text, textBox74.Text);
            lines[38] = getText("evtShowConsole", comboBox40.Text, textBox84.Text);
            lines[39] = getText("evtShowAllConsole", comboBox39.Text, textBox77.Text);
            lines[40] = getText("evtChatHistory", comboBox38.Text, textBox78.Text);
            lines[41] = getText("evtCameraLockToggle", comboBox41.Text, textBox75.Text);
            lines[42] = getText("evtCameraSnap", comboBox42.Text, textBox83.Text);
            lines[43] = getText("evtSelectSelf", comboBox47.Text, textBox85.Text);
            lines[44] = getText("evtSelectAlly1", comboBox46.Text, textBox91.Text);
            lines[45] = getText("evtSelectAlly2", comboBox45.Text, textBox92.Text);
            lines[46] = getText("evtSelectAlly3", comboBox44.Text, textBox89.Text);
            lines[47] = getText("evtSelectAlly4", comboBox43.Text, textBox86.Text);
            lines[48] = getText("evntPlayerPingCursor", comboBox52.Text, textBox95.Text);
            lines[49] = getText("evntPlayerPing", comboBox51.Text, textBox101.Text);
            lines[50] = getText("evntPlayerPingCursorDanger", comboBox50.Text, textBox102.Text);
            lines[51] = getText("evntPlayerPingDanger", comboBox49.Text, textBox92.Text);
            lines[52] = getText("evtPlayerAttackMoveClick", comboBox55.Text, textBox96.Text);
            lines[53] = getText("evtPlayerAttackMove", comboBox54.Text, textBox107.Text);
            lines[54] = getText("evtPlayerHoldPosition", comboBox53.Text, textBox108.Text);
            lines[55] = getText("evtPlayerStopPosition", comboBox48.Text, textBox105.Text);
            lines[56] = getText("evtPetMoveClick", comboBox57.Text, textBox112.Text);
            lines[57] = getText("evtPetReturn", comboBox56.Text, textBox111.Text);
            lines[58] = getText("evtPlayerMoveClick", comboBox59.Text, textBox116.Text);
            lines[59] = getText("evtOnUIMouse4Pan", comboBox58.Text, textBox115.Text);
            lines[60] = getText("evtEmoteJoke", comboBox62.Text, textBox122.Text);
            lines[61] = getText("evtEmoteTaunt", comboBox61.Text, textBox121.Text);
            lines[62] = getText("evtEmoteDance", comboBox60.Text, textBox119.Text);
            lines[63] = getText("evtEmoteLaugh", comboBox63.Text, textBox126.Text);
            lines[64] = getText("evtShowHealthBars", comboBox67.Text, textBox132.Text);
            lines[65] = getText("evtToggleMinionHealthBars", comboBox66.Text, textBox131.Text);
            lines[66] = getText("evtShowSummonerNames", comboBox65.Text, textBox129.Text);
            lines[67] = getText("evtDrawHud", comboBox64.Text, textBox127.Text);
            lines[68] = getText("evtScrollUp", comboBox71.Text, textBox140.Text);
            lines[69] = getText("evtScrollDown", comboBox70.Text, textBox139.Text);
            lines[70] = getText("evtScrollLeft", comboBox69.Text, textBox137.Text);
            lines[71] = getText("evtScrollRight", comboBox68.Text, textBox135.Text);
            lines[72] = "[MouseSettings]";
            lines[73] = getText("PointerSpeed", comboBox73.Text, textBox144.Text);
            lines[74] = getText("RollerButtonSpeed", comboBox72.Text, textBox143.Text);
            lines[75] = "[HUDEvents]";
            lines[76] = getText("evtToggleFPSAndLatency", comboBox75.Text, textBox148.Text);
            System.IO.File.WriteAllLines(@"C:\Riot Games\League of Legends\Config\input.ini", lines);
            
        }



        private string getText(string starting, string mod, string command)
        {
            string text = starting;
            if (!(command.Contains("Arrow") || command.Contains("Button")))
                command.Replace(" ", string.Empty);
            text += "=";

            if (command.Equals(string.Empty))
            {
                return text + "[<Unbound>]";
            }
            else if (command.Equals("Enter") || command.Equals("Return") || command.Equals("NumEnter"))
            {
                if (mod.Equals(string.Empty))
                    return text + "[Return],[NumEnter]";
                return text + "[" + mod + "]" + "[Return]" + "," + "[" + mod + "]" + "[NumEnter]";
            }
            else if(mod.Equals(string.Empty))
                return text + "[" + command + "]";
            return text + "[" + mod + "]" +"[" + command + "]";
        }

        private void button3_Click(object sender, System.EventArgs e)//Global Reset
        {
            if (checkBox1.Checked)
            {
                button1_Click(sender, e);
                button25_Click(sender, e);
                button29_Click(sender, e);
                button37_Click(sender, e);
                button10_Click(sender, e);
                button14_Click(sender, e);
                button4_Click(sender, e);
                button12_Click(sender, e);
                button16_Click(sender, e);
                button2_Click(sender, e);
                button20_Click(sender, e);
                button33_Click(sender, e);
                button45_Click(sender, e);
                button22_Click(sender, e);
                button27_Click(sender, e);
                button31_Click(sender, e);
                button43_Click(sender, e);
                button35_Click(sender, e);
                button41_Click(sender, e);
                button39_Click(sender, e);
                button18_Click(sender, e);
            }
            
        }
        private void button46_Click(object sender, EventArgs e)//Global Clear
        {
            if (checkBox1.Checked)
                {
                    button5_Click(sender, e);
                    button24_Click(sender, e);
                    button28_Click(sender, e);
                    button36_Click(sender, e);
                    button9_Click(sender, e);
                    button13_Click(sender, e);
                    button7_Click(sender, e);
                    button11_Click(sender, e);
                    button15_Click(sender, e);
                    button6_Click(sender, e);
                    button19_Click(sender, e);
                    button32_Click(sender, e);
                    button44_Click(sender, e);
                    button21_Click(sender, e);
                    button26_Click(sender, e);
                    button30_Click(sender, e);
                    button43_Click(sender, e);
                    button34_Click(sender, e);
                    button40_Click(sender, e);
                    button38_Click(sender, e);
                    button17_Click(sender, e);
                }
        }

        //Resets
        private void button1_Click(object sender, EventArgs e)//Abilities
        {
            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
            comboBox3.SelectedItem = "";
            comboBox4.SelectedItem = "";
            textBox6.Text = "q";
            textBox7.Text = "w";
            textBox8.Text = "e";
            textBox9.Text = "r";
        }
        private void button25_Click(object sender, EventArgs e)//Chat + Camera
        {
            comboBox40.Text = "";
            comboBox39.Text = "Shift";
            comboBox38.Text = "";
            comboBox41.Text = "";
            comboBox42.Text = "";
            textBox84.Text = "Return";
            textBox77.Text = "Return";
            textBox78.Text = "z";
            textBox75.Text = "y";
            textBox83.Text = "Space";
        }
        private void button29_Click(object sender, EventArgs e)//Pings
        {
            comboBox52.Text = "";
            comboBox51.Text = "Alt";
            comboBox50.Text = "";
            comboBox49.Text = "Ctrl";
            textBox95.Text = "g";
            textBox101.Text = "Button 1";
            textBox102.Text = "g";
            textBox99.Text = "Button 1";
        }
        private void button37_Click(object sender, EventArgs e)//Emots
        {
            comboBox62.SelectedItem = "Ctrl";
            comboBox61.SelectedItem = "Ctrl";
            comboBox60.SelectedItem = "Ctrl";
            comboBox63.SelectedItem = "Ctrl";
            textBox122.Text = "1";
            textBox121.Text = "2";
            textBox119.Text = "3";
            textBox126.Text = "4";
        }
        private void button10_Click(object sender, EventArgs e)//Self Abilities
        {
            comboBox14.SelectedItem = "Alt";
            comboBox13.SelectedItem = "Alt";
            comboBox10.SelectedItem = "Alt";
            comboBox9.SelectedItem  = "Alt";
            textBox12.Text = "q";
            textBox11.Text = "w";
            textBox10.Text = "e";
            textBox1.Text = "r";
        }
        private void button14_Click(object sender, EventArgs e)//Smart Abilities
        {
            comboBox20.SelectedItem = "Shift";
            comboBox19.SelectedItem = "Shift";
            comboBox18.SelectedItem = "Shift";
            comboBox17.SelectedItem = "Shift";
            textBox36.Text = "q";
            textBox35.Text = "w";
            textBox34.Text = "e";
            textBox33.Text = "r";
        }
        private void button4_Click(object sender, EventArgs e)//Summoners
        {
            comboBox12.SelectedItem = "";
            comboBox11.SelectedItem = "";
            textBox25.Text = "d";
            textBox24.Text = "f";
        }
        private void button12_Click(object sender, EventArgs e)//Self Summoners
        {
            comboBox16.SelectedItem = "Alt";
            comboBox15.SelectedItem = "Alt";
            textBox30.Text = "d";
            textBox27.Text = "f";
        }
        private void button16_Click(object sender, EventArgs e)//Smart Summoners
        {
            comboBox22.SelectedItem = "Shift";
            comboBox21.SelectedItem = "Shift";
            textBox42.Text = "d";
            textBox41.Text = "f";
        }
        private void button2_Click(object sender, EventArgs e)//Level Abilities
        {
            comboBox8.SelectedItem = "Ctrl";
            comboBox7.SelectedItem = "Ctrl";
            comboBox6.SelectedItem = "Ctrl";
            comboBox5.SelectedItem = "Ctrl";
            textBox17.Text = "q";
            textBox16.Text = "w";
            textBox15.Text = "e";
            textBox14.Text = "r";
        }
        private void button20_Click(object sender, EventArgs e)//Smart Items
        {
            comboBox34.SelectedItem = "Shift";
            comboBox33.SelectedItem = "Shift";
            comboBox32.SelectedItem = "Shift";
            comboBox31.SelectedItem = "Shift";
            comboBox30.SelectedItem = "Shift";
            comboBox29.SelectedItem = "Shift";
            textBox61.Text = "1";
            textBox60.Text = "2";
            textBox59.Text = "3";
            textBox58.Text = "4";
            textBox67.Text = "5";
            textBox68.Text = "6";
        }
        private void button33_Click(object sender, EventArgs e)//Pet Control
        {
            comboBox57.SelectedItem = "Alt";
            comboBox56.SelectedItem = "Alt";
            textBox112.Text = "Button 2";
            textBox111.Text = "Button 1";
        }
        private void button45_Click(object sender, EventArgs e)//Latency View
        {
            comboBox75.SelectedItem = "Ctrl";
            textBox148.Text = "f";
        }
        private void button22_Click(object sender, EventArgs e)//Relavent Menus
        {
            comboBox36.SelectedItem = "";
            comboBox35.SelectedItem = "";
            comboBox37.SelectedItem = "";
            textBox70.Text = "c";
            textBox69.Text = "o";
            textBox74.Text = "p";
        }
        private void button27_Click(object sender, EventArgs e)//Select Allies
        {
            comboBox47.SelectedItem = "";
            comboBox46.SelectedItem = "";
            comboBox45.SelectedItem = "";
            comboBox44.SelectedItem = "";
            comboBox43.SelectedItem = "";
            textBox85.Text = "F1";
            textBox91.Text = "F2";
            textBox92.Text = "F3";
            textBox89.Text = "F4";
            textBox86.Text = "F5";
        }
        private void button31_Click(object sender, EventArgs e)//Player Stances
        {
            comboBox55.SelectedItem = "Shift";
            comboBox54.SelectedItem = "";
            comboBox53.SelectedItem = "";
            comboBox48.SelectedItem = "";
            textBox96.Text = "Button 2";
            textBox107.Text = "a";
            textBox108.Text = "h";
            textBox105.Text = "s";
        }
        private void button43_Click(object sender, EventArgs e)//Mouse Sets
        {
            comboBox73.SelectedItem = "";
            comboBox72.SelectedItem = "";
            textBox144.Text = "2";
            textBox143.Text = "1";   
        }
        private void button35_Click(object sender, EventArgs e)//Something
        {
            comboBox59.SelectedItem = "";
            comboBox58.SelectedItem = "";
            textBox116.Text = "Button 2";
            textBox115.Text = "Button 3";
        }
        private void button41_Click(object sender, EventArgs e)//Scrolling
        {
            comboBox71.SelectedItem = "";
            comboBox70.SelectedItem = "";
            comboBox69.SelectedItem = "";
            comboBox68.SelectedItem = "";
            textBox140.Text = "Up Arrow";
            textBox139.Text = "Down Arrow";
            textBox137.Text = "Left Arrow";
            textBox135.Text = "Right Arrow";
        }
        private void button39_Click(object sender, EventArgs e)//HUD
        {
            comboBox67.SelectedItem = "Shift";
            comboBox66.SelectedItem = "Ctrl";
            comboBox65.SelectedItem = "Shift";
            comboBox64.SelectedItem = "";
            textBox132.Text = "l";
            textBox131.Text = "l";
            textBox129.Text = "k";
            textBox127.Text = "F5";
        }
        private void button18_Click(object sender, EventArgs e)//Items
        {
            comboBox26.SelectedItem = "";
            comboBox25.SelectedItem = "";
            comboBox24.SelectedItem = "";
            comboBox23.SelectedItem = "";
            comboBox27.SelectedItem = "";
            comboBox28.SelectedItem = "";
            textBox48.Text = "1";
            textBox47.Text = "2";
            textBox46.Text = "3";
            textBox45.Text = "4";
            textBox65.Text = "5";
            textBox66.Text = "6";
        }

        //Clears
        private void button5_Click(object sender, EventArgs e)//Abilities
        {
            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
            comboBox3.SelectedItem = "";
            comboBox4.SelectedItem = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }
        private void button24_Click(object sender, EventArgs e)//Chat + Camera
        {
            comboBox40.Text = "";
            comboBox39.Text = "";
            comboBox38.Text = "";
            comboBox41.Text = "";
            comboBox42.Text = "";
            textBox84.Text = "";
            textBox77.Text = "";
            textBox78.Text = "";
            textBox75.Text = "";
            textBox83.Text = "";
        }
        private void button28_Click(object sender, EventArgs e)//Pings
        {
            comboBox52.Text = "";
            comboBox51.Text = "";
            comboBox50.Text = "";
            comboBox49.Text = "";
            textBox95.Text = "";
            textBox101.Text = "";
            textBox102.Text = "";
            textBox99.Text = "";
        }
        private void button36_Click(object sender, EventArgs e)//Emots
        {
            comboBox62.SelectedItem = "";
            comboBox61.SelectedItem = "";
            comboBox60.SelectedItem = "";
            comboBox63.SelectedItem = "";
            textBox122.Text = "";
            textBox121.Text = "";
            textBox119.Text = "";
            textBox126.Text = "";
        }
        private void button9_Click(object sender, EventArgs e)//Self Abilities
        {
            comboBox14.SelectedItem = "";
            comboBox13.SelectedItem = "";
            comboBox10.SelectedItem = "";
            comboBox9.SelectedItem = "";
            textBox12.Text = "";
            textBox11.Text = "";
            textBox10.Text = "";
            textBox1.Text = "";
        }
        private void button13_Click(object sender, EventArgs e)//Smart Abilities
        {
            comboBox20.SelectedItem = "";
            comboBox19.SelectedItem = "";
            comboBox18.SelectedItem = "";
            comboBox17.SelectedItem = "";
            textBox36.Text = "";
            textBox35.Text = "";
            textBox34.Text = "";
            textBox33.Text = "";
        }
        private void button7_Click(object sender, EventArgs e)//Summoners
        {
            comboBox12.SelectedItem = "";
            comboBox11.SelectedItem = "";
            textBox25.Text = "";
            textBox24.Text = "";
        }
        private void button11_Click(object sender, EventArgs e)//Self Summoners
        {
            comboBox16.SelectedItem = "";
            comboBox15.SelectedItem = "";
            textBox30.Text = "";
            textBox27.Text = "";
        }
        private void button15_Click(object sender, EventArgs e)//Smart Summoners
        {
            comboBox22.SelectedItem = "";
            comboBox21.SelectedItem = "";
            textBox42.Text = "";
            textBox41.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)//Level Abilities
        {
            comboBox8.SelectedItem = "";
            comboBox7.SelectedItem = "";
            comboBox6.SelectedItem = "";
            comboBox5.SelectedItem = "";
            textBox17.Text = "";
            textBox16.Text = "";
            textBox15.Text = "";
            textBox14.Text = "";
        }
        private void button19_Click(object sender, EventArgs e)//Smart Items
        {
            comboBox34.SelectedItem = "";
            comboBox33.SelectedItem = "";
            comboBox32.SelectedItem = "";
            comboBox31.SelectedItem = "";
            comboBox30.SelectedItem = "";
            comboBox29.SelectedItem = "";
            textBox61.Text = "";
            textBox60.Text = "";
            textBox59.Text = "";
            textBox58.Text = "";
            textBox67.Text = "";
            textBox68.Text = "";
        }
        private void button32_Click(object sender, EventArgs e)//Pet Control
        {
            comboBox57.SelectedItem = "";
            comboBox56.SelectedItem = "";
            textBox112.Text = "";
            textBox111.Text = "";
        }
        private void button44_Click(object sender, EventArgs e)//Latency View
        {
            comboBox75.SelectedItem = "";
            textBox148.Text = "";
        }
        private void button21_Click(object sender, EventArgs e)//Relavent Menus
        {
            comboBox36.SelectedItem = "";
            comboBox35.SelectedItem = "";
            comboBox37.SelectedItem = "";
            textBox70.Text = "";
            textBox69.Text = "";
            textBox74.Text = "";
        }
        private void button26_Click(object sender, EventArgs e)//Select Allies
        {
            comboBox47.SelectedItem = "";
            comboBox46.SelectedItem = "";
            comboBox45.SelectedItem = "";
            comboBox44.SelectedItem = "";
            comboBox43.SelectedItem = "";
            textBox85.Text = "";
            textBox91.Text = "";
            textBox92.Text = "";
            textBox89.Text = "";
            textBox86.Text = "";
        }
        private void button30_Click(object sender, EventArgs e)//Player Stances
        {
            comboBox55.SelectedItem = "";
            comboBox54.SelectedItem = "";
            comboBox53.SelectedItem = "";
            comboBox48.SelectedItem = "";
            textBox96.Text = "";
            textBox107.Text = "";
            textBox108.Text = "";
            textBox105.Text = "s";
        }
        private void button42_Click(object sender, EventArgs e)//Mouse Sets
        {
            comboBox73.SelectedItem = "";
            comboBox72.SelectedItem = "";
            textBox144.Text = "";
            textBox143.Text = "";
        }
        private void button34_Click(object sender, EventArgs e)//Something
        {
            comboBox59.SelectedItem = "";
            comboBox58.SelectedItem = "";
            textBox116.Text = "";
            textBox115.Text = "";
        }
        private void button40_Click(object sender, EventArgs e)//Scrolling
        {
            comboBox71.SelectedItem = "";
            comboBox70.SelectedItem = "";
            comboBox69.SelectedItem = "";
            comboBox68.SelectedItem = "";
            textBox140.Text = "";
            textBox139.Text = "";
            textBox137.Text = "";
            textBox135.Text = "";
        }
        private void button38_Click(object sender, EventArgs e)//HUD
        {
            comboBox67.SelectedItem = "";
            comboBox66.SelectedItem = "";
            comboBox65.SelectedItem = "";
            comboBox64.SelectedItem = "";
            textBox132.Text = "";
            textBox131.Text = "";
            textBox129.Text = "";
            textBox127.Text = "";
        }
        private void button17_Click(object sender, EventArgs e)//Items
        {
            comboBox26.SelectedItem = "";
            comboBox25.SelectedItem = "";
            comboBox24.SelectedItem = "";
            comboBox23.SelectedItem = "";
            comboBox27.SelectedItem = "";
            comboBox28.SelectedItem = "";
            textBox48.Text = "";
            textBox47.Text = "";
            textBox46.Text = "";
            textBox45.Text = "";
            textBox65.Text = "";
            textBox66.Text = "";
        }

        
    }
}
