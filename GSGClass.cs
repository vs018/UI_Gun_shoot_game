using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace UI_Gun_shoot_game
{
    public class GSGClass
    {


        // background sound for each step 
        SoundPlayer Load = new SoundPlayer(UI_Gun_shoot_game.Properties.Resources.Reload);
        SoundPlayer spinsound = new SoundPlayer(UI_Gun_shoot_game.Properties.Resources.spinner);
        SoundPlayer firesound = new SoundPlayer(UI_Gun_shoot_game.Properties.Resources.Fire);
        SoundPlayer blanksound = new SoundPlayer(UI_Gun_shoot_game.Properties.Resources.blank);
        SoundPlayer shootawaysound = new SoundPlayer(UI_Gun_shoot_game.Properties.Resources.shootaway);
        SoundPlayer background = new SoundPlayer(UI_Gun_shoot_game.Properties.Resources.Background);

        // show result for each step in msgbox
        string msg;


        // Spin Chamber for load the bullet in random place 
        int[] spinner =
              { 0,
                0,
                0,
                0,
                0,
                0 };
        

        public void backgrnd()
        {
            background.Play();
        }


        // first step for load the gun (load a bullet in chamber )
        public string LoadGun( out int chance)

        {
            chance = 2; // shootaway chance 
           
            
            spinner[0] = 1;
            Load.Play();
            
            msg = "Gun Is Reloaded ...Ready For Spin the Chamber";

            return msg; 


        }
        //second step for spin the chamber for select the random place for a bullet
        public string spinchamber(out int num)

        {// random number 
            Random rndm = new Random();
            num = rndm.Next(0, 6);


            if (num != 0)
            {
                spinner[0] = 0;
                spinner[num] = 1;
            }
            //spin sound
            spinsound.Play();

            msg = "Bullet is in the Chamber ....Ready for Fire";
            // chamber
            num++;
          

            return msg;
        }
        // shoot button 
        public string fireathead(int awaychance, out int shootawychance, int sspinner, out int nspinner,out int point) 
        {
            point = 0;
            sspinner = sspinner - 1;

            if (spinner[sspinner] == 0)
            {
                msg = "You lose the game..... Play Again";
                firesound.Play();
             
            }
            else
            {
                msg = " Good Luck.....Fire";
                point = +10;

                blanksound.Play();
            }


            nspinner = sspinner;
            shootawychance = awaychance;

            return msg;

        }
        //shootaway chance when click on shoot away btn , chance deduct until 0 nd show message
        public string shootawaychance(int awaychance, out int shootawychance ,out int points)
        {

            points = 0;
           
            awaychance = awaychance - 1;
            shootawaysound.Play();
            if (awaychance == 0)
            {

                points = -5;
                msg = "Game over... no more shoot away chance ";


            }
             
            shootawychance = awaychance;
           

            return msg;

        }

        //winning message
        public string shootawaywin(  int sspinner, out int nspinner)
        {
            
            
            if (spinner[sspinner] == 1)
            { //If bullet is fired

                msg = " you win";

                shootawaysound.Play();
            }
            nspinner = sspinner;
            return msg;
            

        }
        // exit button ,two button showing when click on yes game exit.
        public void exit()
        {

            DialogResult dialog = MessageBox.Show("Do you really want to quit this game?",
              "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit(); // exit application 
            }
            else if (dialog == DialogResult.No)
            {

            }

        }
    }
}

