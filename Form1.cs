using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio.Wave;
using NAudio;



namespace VERICEL_Dorian
{
  
    public partial class MusicBox : Form
    {
       
        public MusicBox()
        {
            InitializeComponent();
        }
       
        //Methode pour changer le chemin absolue => chemin relatif 
        public static string Redirect(string redirection)
        {
            var currentDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent?.FullName;
            string ressourcesPath = Path.Combine(currentDir, "ressources");
            ressourcesPath = Path.Combine(currentDir, "ressources");
            return Path.Combine(ressourcesPath, redirection);
        }
        //Déclaration des sons de l'aplication
        WaveOutEvent waveOut = new WaveOutEvent();
        
        WaveFileReader SongA = new WaveFileReader(Redirect("bdrum.wav"));
        WaveFileReader SongZ = new WaveFileReader(Redirect("bell.wav"));
        WaveFileReader SongE = new WaveFileReader(Redirect("clap.wav"));
        WaveFileReader SongR = new WaveFileReader(Redirect("click.wav"));
        WaveFileReader SongT = new WaveFileReader(Redirect("Clikkick.wav"));
        WaveFileReader SongG = new WaveFileReader(Redirect("dbass.wav"));
        WaveFileReader SongF = new WaveFileReader(Redirect("flute.wav"));
        WaveFileReader SongD = new WaveFileReader(Redirect("guitar.wav"));
        WaveFileReader SongS = new WaveFileReader(Redirect("harp.wav"));
        WaveFileReader SongQ = new WaveFileReader(Redirect("icechime.wav"));
        WaveFileReader SongW = new WaveFileReader(Redirect("Kick.wav"));
        WaveFileReader SongX = new WaveFileReader(Redirect("pling.wav"));
        WaveFileReader SongC = new WaveFileReader(Redirect("sdrum.wav"));
        WaveFileReader SongV = new WaveFileReader(Redirect("Tap.wav"));
        WaveFileReader SongB = new WaveFileReader(Redirect("xylobone.wav"));
       
        //liste de son 
        List<WaveFileReader> SongList = new List<WaveFileReader>();
        //Méthode pour jouer un son
        private void Playsong(WaveFileReader song)
        {
            waveOut.Init(song);
            waveOut.Play();
            song.Position = 0;
        }
        //Méthode qui verifie quelle touche en maj en apuyée 
        private void KeyChecked(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.A)
            {
                waveOut.Init(SongA);
                waveOut.Play();
                SongA.Position = 0;
            }
            if (e.KeyChar == (char)Keys.Z)
            {
                waveOut.Init(SongZ);
                waveOut.Play();
                SongZ.Position = 0;
            }
            if (e.KeyChar == (char)Keys.E)
            {
                waveOut.Init(SongE);
                waveOut.Play();
                SongE.Position = 0;
            }
            if (e.KeyChar == (char)Keys.R)
            {
                waveOut.Init(SongR);
                waveOut.Play();
                SongR.Position = 0;
            }
            if (e.KeyChar == (char)Keys.T)
            {
                waveOut.Init(SongT);
                waveOut.Play();
                SongT.Position = 0;
            }
            if (e.KeyChar == (char)Keys.Q)
            {
                waveOut.Init(SongQ);
                waveOut.Play();
                SongQ.Position = 0;
            }
            if (e.KeyChar == (char)Keys.S)
            {
                waveOut.Init(SongS);
                waveOut.Play();
                SongS.Position = 0;
            }
            if (e.KeyChar == (char)Keys.D)
            {
                waveOut.Init(SongD);
                waveOut.Play();
                SongD.Position = 0;
            }
            if (e.KeyChar == (char)Keys.F)
            {
                waveOut.Init(SongF);
                waveOut.Play();
                SongF.Position = 0;
            }
            if (e.KeyChar == (char)Keys.G)
            {
                waveOut.Init(SongG);
                waveOut.Play();
                SongG.Position = 0;
            }
            if (e.KeyChar == (char)Keys.W)
            {
                waveOut.Init(SongW);
                waveOut.Play();
                SongW.Position = 0;
            }
            if (e.KeyChar == (char)Keys.X)
            {
                waveOut.Init(SongX);
                waveOut.Play();
                SongX.Position = 0;
            }
            if (e.KeyChar == (char)Keys.C)
            {
                waveOut.Init(SongC);
                waveOut.Play();
                SongC.Position = 0;
            }
            if (e.KeyChar == (char)Keys.V)
            {
                waveOut.Init(SongV);
                waveOut.Play();
                SongV.Position = 0;
            }
            if (e.KeyChar == (char)Keys.B)
            {
                waveOut.Init(SongB);
                waveOut.Play();
                SongB.Position = 0;
            }
        }
        //sons au click sur le bouttonA
        private void ButtonSoundA_Click(object sender, EventArgs e)
        {
            Playsong(SongA);
        }
        //sons      au click sur le buttonZ
        private void ButtonSoundZ_Click(object sender, EventArgs e)
        {
            Playsong(SongZ);
        }
        //sons      au click sur le buttonE 
        private void ButtonSoundE_Click(object sender, EventArgs e)
        {
            Playsong(SongE);
        }
        //sons      au click sur le buttonR 
        private void ButtonSoundR_Click(object sender, EventArgs e)
        {
            Playsong(SongR);
        }
        //sons      au click sur le buttonT
        private void ButtonSoundT_Click(object sender, EventArgs e)
        {
            Playsong(SongT);
        }
        //sons      au click sur le buttonG
        private void ButtonSoundG_Click(object sender, EventArgs e)
        {
            Playsong(SongG);
        }
        //sons      au click sur le buttonB
        private void ButtonSoundB_Click(object sender, EventArgs e)
        {
            Playsong(SongB);
        }
       
        //sons      au click sur le buttonV
        private void ButtonSoundV_Click(object sender, EventArgs e)
        {
            Playsong(SongV);
        }
        //sons      au click sur le buttonF
        private void ButtonSoundF_Click(object sender, EventArgs e)
        {
            Playsong(SongF);
        }
        //sons      au click sur le buttonC 
        private void ButtonSoundC_Click(object sender, EventArgs e)
        {
            Playsong(SongC);
        }
        //sons      au click sur le buttonD
        private void ButtonSoundD_Click(object sender, EventArgs e)
        {
            Playsong(SongD);
        }
        //sons      au click sur le buttonS 
        private void ButtonSoundS_Click(object sender, EventArgs e)
        {
            Playsong(SongS);
        }
        //sons      au click sur le buttonQ 
        private void ButtonSoundQ_Click(object sender, EventArgs e)
        {
            Playsong(SongQ);
        }
        //sons      au click sur le buttonW
        private void ButtonSoundW_Click(object sender, EventArgs e)
        {
            Playsong(SongW);
        }
        //sons      au click sur le buttonX 
        private void ButtonSoundX_Click(object sender, EventArgs e)
        {
            Playsong(SongX);
        }

        //Button pour enregistrer une liste de sons
        private void RecordSounds_Click(object sender, EventArgs e)
        {
            //création du fichier d'enregistrement 
            var outputFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Enregistrement_Naudio");
            Directory.CreateDirectory(outputFolder);
            var outputFilePath = Path.Combine(outputFolder, "Enregistrement.wav");
            //création de l'evenement d'enregistrement
            var waveIn = new WaveInEvent();
            WaveFileWriter writer = null;
            writer = new WaveFileWriter(outputFilePath, waveIn.WaveFormat);
            waveIn.StartRecording();


            
        }
        //Button pour jouer la liste de sons
        private void PlaySound_Click(object sender, EventArgs e)
        {
           /* waveOut.Init(writer);
            waveOut.Play();
           writer.Position = 0;*/
        }

        //a l'appui sur la touche A en majuscule 
        private void ButtonSoundA_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);           
        }
        //a l'appui sur la touche Z en majuscule
        private void ButtonSoundZ_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche E en majuscule
        private void ButtonSoundE_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche R en majuscule
        private void ButtonSoundR_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche T en majuscule
        private void ButtonSoundT_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche Q en majuscule
        private void ButtonSoundQ_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche S en majuscule
        private void ButtonSoundS_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche D en majuscule
        private void ButtonSoundD_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche F en majuscule
        private void ButtonSoundF_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche G en majuscule
        private void ButtonSoundG_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche W en majuscule
        private void ButtonSoundW_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche X en majuscule
        private void ButtonSoundX_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche C en majuscule
        private void ButtonSoundC_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche V en majuscule
        private void ButtonSoundV_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }
        //a l'appui sur la touche B en majuscule
        private void ButtonSoundB_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender, e);
        }       
        //evenement dans l'application 
        private void MusicBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeyChecked(sender,e);
        }
        
       
    }



   

}
