using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo1
{

    //<summary>
    //ce programme recopie à la demande le texte du champ TxtOriginal
    //vers le label LblResultat
    //Ecrit le 17 juillet 2018, par DamienL
    //</summary>

    public partial class FrmExo1 : Form
    {
        private String LeTexte;

        public FrmExo1()
        {
            InitializeComponent();
            // crée un handler d'événement pour la prise de focus sur la textbox
            this.TxtOriginal.GotFocus += new EventHandler(TxtOriginal_GotFocus);
            // initialisation texte invite
            this.LeTexte = "Entrer le texte initial";
            //permet d'initialiser la textbox au lancement 
            this.TxtOriginal.Text =this.LeTexte;
        }

       

        //<summary>
        //recopie le contenu de la textebox dans le label
        //</summary>
        //<param name = "sender" ></ param >
        //<param name="e"></param>

        private void BtnRecopier_Click(object sender, EventArgs e)
        {
            this.LblResultat.Text = this.TxtOriginal.Text;
        }

        //< summary >
        //remet à blanc le label de résultat et réinitialise la textbox
        //</ summary >
        //< param name = "sender" ></ param >
        //< param name = "e" ></ param >

        private void BtnEffacer_Click(object sender, EventArgs e)
        {
            this.TxtOriginal.Text ="Entrer le texte initial";
            this.LblResultat.Text ="";
        }

        

        //<summary>
        //méthode événementielle appelée pendant la fermeture du form
        //(aussi bien par Application.Exit() que par Alt-F4 ou case de fermeture
        //</summary>
        //<param name = "sender" ></ param >
        //< param name= "e" ></ param >

        private void BtnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); // stoppe l'application
        }
       

        
        //<summary>
        //remet à blanc le texte initial dès la prise de focus
        //</summary>
        //<param name = "sender" ></ param >
        //< param name= "e" ></ param >

        private void TxtOriginal_GotFocus(object sender, EventArgs e)
        {
            /* procédure événementielle entièrement écrite */
            this.TxtOriginal.Text ="";
        }
        
        
      
        
        

        
    }
}
