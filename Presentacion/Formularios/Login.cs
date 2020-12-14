using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Modelo;
using Presentacion.Helpers;

namespace Presentacion.Formularios
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            //guardar los mensajes de error
            string errores = "";
            bool errorBool = false;
            string nombreUsuario = txtuser.Text.Trim();
            string password = txtpassword.Text.Trim();
            if (string.IsNullOrEmpty(nombreUsuario)){
                errores += "ingrese el nombre de usuario\n";
                errorBool = true;
            }
            if (string.IsNullOrEmpty(password)){
                errores += "ingrese el pasword\n";
                errorBool = true;
            }
            if (!errorBool)
            {
                //llamaria a login
                Usuario usr = new Usuario(nombreUsuario, password);//
                //usr.Ingresar(nombreUsuario, password, Variables.programa);
                bool ingreso = usr.Ingresar(nombreUsuario, password, Variables.programa);
                if (ingreso== true)
                {
                    FormInicio p = new FormInicio();
                    p.Show();
                    //p.ShowDialog();
                }
                else
                {
                    string title = "Close Window";                    
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("password incorrecto", title, buttons, MessageBoxIcon.Warning);
                }              
            }
            else
            {
                //muestro lo errores      
                //string message = "Do you want to abort this operation?";
                string title = "Close Window";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(errores, title, buttons, MessageBoxIcon.Warning);

            }
            //Usuario usr = new Negocio.Modelo.Usuario();
            
            
            /*if (checkrecordar.Checked == true)
            {
                Properties.Settings.Default.UserName = txtuser.Text;
                Properties.Settings.Default.password = txtpassword.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.UserName = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.Save();
            }*/

            
            
            //guardo los datos
            

        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            Chat chat1 = new Chat(1, 1);
            Chat chat2 = new Chat(3, 1);
            chat1.Show();
            chat2.Show();
        }
    }
}
