using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace UI_Gun_shoot_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // class initialize 
        GSGClass myclass = new GSGClass();
        // load form and background sound 
        private void Form1_Load(object sender, EventArgs e)
        {
            myclass.backgrnd();// caling method

        }
        // btn load gun 
        private void btnLoadGun_Click(object sender, EventArgs e)
        {

            msgBox.Text = myclass.LoadGun(out int chance); // show value in textbox
            
            txtChances.Text = Convert.ToString(chance);
            // btn click and enable
            btnSpin.Enabled = true;
            btnLoadGun.Enabled = false;

        }
        // spin btn , spin the chamber and randopm value

        private void btnSpin_Click(object sender, EventArgs e)
        {
            msgBox.Text = myclass.spinchamber(out int num);

            txtChamber.Text = Convert.ToString(num);
            // btn click and enable
            btnSpin.Enabled = true;
            btnLoadGun.Enabled = false;
            btnFire.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtFire_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
         // fire button  
        private void btnFire_Click(object sender, EventArgs e)
        {
            msgBox.Text = myclass.fireathead(Convert.ToInt32(txtChances.Text),out int away , Convert.ToInt32(txtChamber.Text), out int nspin,out int point);

            txtChances.Text = Convert.ToString(away);
            txtChamber.Text = Convert.ToString(nspin);
           txtPoints.Text = Convert.ToString(point);

            // btn click and enable
            btnSpin.Enabled = true;
            btnLoadGun.Enabled = false;

            if (txtChamber.Text == "0")
            {
                // btn click and enable
                btnFire.Enabled = false;
                btnShootAway.Enabled = false;
            }
        }
        // shootawy button 
        private void btnShootAway_Click(object sender, EventArgs e)
        {
             msgBox.Text = myclass.shootawaychance(Convert.ToInt32(txtChances.Text), out int shootawychance,out int points);
             txtChances.Text = Convert.ToString(shootawychance);
            txtPoints.Text = Convert.ToString(points);
            
            if (txtChances.Text == "0")
            {
                // btn click and enable
                btnFire.Enabled = false;
                btnShootAway.Enabled = false;

            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            {
                
            }
        }

        private void txtPoints_TextChanged(object sender, EventArgs e)
        {

        }

        private void plHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnPoints_Click(object sender, EventArgs e)
        {

        }

        private void lblLogo_Click(object sender, EventArgs e)
        {

        }

        private void pbJoker_Click(object sender, EventArgs e)
        {

        }
        //restart button 
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            // exit button
            myclass.exit();

        }
    }
}





    

