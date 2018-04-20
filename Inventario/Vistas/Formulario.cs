using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventario;
namespace Inventario.Vistas
{
    public partial class Formulario : Form
    {
        public Formulario()
        {
            InitializeComponent();
        }
        
        private void limpiar2()
        {
            tbxNom.Text = "";
            tbxApellidos.Text = "";
            tbxTipo.Text = "";
            tbxPuesto.Text = "";
            tbxUsuario.Text = "";
            tbxPass.Text = "";
            tbxEdad.Text = "";
            tbxSex.Text = "";
            tbxCorreo.Text = "";
            tbxTelefono.Text = "";
            tbxDireccion.Text = "";
            tbxCP.Text = "";
        }

        private void enabledCRUD(bool estado)
        {
            tbxNom.Enabled = estado;
            tbxApellidos.Enabled = estado;
            tbxTipo.Enabled = estado;
            tbxPuesto.Enabled = estado;
            tbxUsuario.Enabled = estado;
            tbxPass.Enabled = estado;
            tbxEdad.Enabled = estado;
            tbxSexo.Enabled = estado;
            tbxCorreo.Enabled = estado;
            tbxTelefono.Enabled = estado;
            tbxDireccion.Enabled = estado;
            tbxCP.Enabled = estado;
        }


        private void Formulario_Load(object sender, EventArgs e)
        {
            enabledCRUD(false);
        }

        private void btnConfig_Click(object sender, EventArgs e)
        {
            pnlConfig.Visible = true;
        }

        private void btnProduc_Click(object sender, EventArgs e)
        {
            pnlConfig.Visible = false;
        }

        private void bunifuMaterialTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

       

        private void label13_Click(object sender, EventArgs e)
        {

        }

        

        private void buscador_TextChanged(object sender, EventArgs e)
        {
            limpiar2();
            if (buscador.Text != "")
                if (Modelos.M_Usuarios.read(buscador.Text).nombre == null)
                    tbxNom.Text = "";
                else
                {
                    tbxNom.Text = Modelos.M_Usuarios.read(buscador.Text).nombre.ToString();
                    tbxApellidos.Text = Modelos.M_Usuarios.read(buscador.Text).apellidos.ToString();
                    tbxTipo.Text = Modelos.M_Usuarios.read(buscador.Text).id_tipo_usuario.ToString();
                    tbxPuesto.Text = Modelos.M_Usuarios.read(buscador.Text).id_puesto.ToString();
                    tbxUsuario.Text = Modelos.M_Usuarios.read(buscador.Text).usuario.ToString();
                    tbxPass.Text = Modelos.M_Usuarios.read(buscador.Text).password.ToString();
                    tbxEdad.Text = Modelos.M_Usuarios.read(buscador.Text).edad.ToString();
                    tbxSex.Text = Modelos.M_Usuarios.read(buscador.Text).sexo.ToString();
                    tbxTelefono.Text = Modelos.M_Usuarios.read(buscador.Text).telefono.ToString();
                    tbxCorreo.Text = Modelos.M_Usuarios.read(buscador.Text).e_mail.ToString();
                    tbxDireccion.Text = Modelos.M_Usuarios.read(buscador.Text).direccion.ToString();
                    tbxCP.Text = Modelos.M_Usuarios.read(buscador.Text).cp.ToString();

                }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            enabledCRUD(true);
        }

        private void pnlCRUD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("¿Está seguro de querer eliminar?, ya que es una acción que no se podrá revertir.","ADVERTENCIA",MessageBoxButtons.OKCancel);
            if (msj == DialogResult.OK)
            {
                //Elimina
            }
            
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }
    }
}
