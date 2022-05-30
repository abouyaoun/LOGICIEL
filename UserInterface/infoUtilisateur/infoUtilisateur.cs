using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LLWS.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using LLWS.Core;
using Flurl.Http;

namespace LLWS.UserInterface.infoUtilisateur
{
    public partial class infoUtilisateur : Form
    {
        public infoUtilisateur()
        {
            InitializeComponent();
            chargerUtilisateur();
        }

        private void chargerUtilisateur()
        {
            this.lbl_prenom.Text = "Prenom : " + User.first_name.ToString();
            this.lbl_nom.Text = "Nom : " + User.last_name.ToString();
            //this.lbl_mail.Text = "Mail : " + User.email.ToString();
            this.lbl_dateinscri.Text = "Date d'inscription : " + User.register_date.ToString();
            //-Grade-// this.lbl_prenom.Text = "Prenom : " + User.first_name.ToString();
            this.lbl_budget.Text = "Mon budget : " + User.budget.ToString() + "€";

        }
    }
}
