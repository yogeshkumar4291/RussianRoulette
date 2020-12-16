using RussianRoulette.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace RussianRoulette
{
    public partial class Form1 : Form
    {
        LogicClass Logic = new LogicClass();

        public object LoadGun { get; private set; }
        public object LoadImg { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // disable rolle, tryagain, shoot button and load button on MainForm Load
            Spin.Enabled = false;
           ShootHead.Enabled = false;
            ShootAway.Enabled = false;
           

        }

        private void Load_Click(object sender, EventArgs e)
        {
            
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.Load);
            sp.Play();//sound effect to the load button
            Load.Enabled = false;
            ShootAway.Enabled = false;
            ShootHead.Enabled = false;
            PlayAgain.Enabled = false;
            Spin.Enabled = true;// Rolle button is disable unless the gun is loaded
            Logic.Load();//calling the load functiotion
           
        }

        private void ShootHead_Click(object sender, EventArgs e)
        {

            Spin.Enabled = false;
            Load.Enabled = false;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.GunShoot);
            sp.Play();
            Logic.ShootAtHead();//calling the shootaway 
            
            
        }

        private void Spin_Click(object sender, EventArgs e)
        {
            Load.Enabled = false;// After load the bullet once it will disable
            Spin.Enabled = false;
            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.Spin);
            sp.Play();
            ShootHead.Enabled = true;// Shoot is disabled until the chamber spinned
            ShootAway.Enabled = true;//shootaway is disabled until the chamber spinned
            Logic.Spin();//calling the spin
        }

        private void ShootAway_Click(object sender, EventArgs e)
        {
            Spin.Enabled = false;
            Load.Enabled = false;

            SoundPlayer sp = new SoundPlayer(RussianRoulette.Resource1.GunShoot);
            sp.Play();
            Logic.ShootAway();//calling the shootaway
            
        }

        private void PlayAgain_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootAway.Enabled = false;
            ShootHead.Enabled = false;
           
           
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
