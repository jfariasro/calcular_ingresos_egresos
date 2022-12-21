using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ingre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CalcularExtras();
        }

        private void CalcularValor()
        {
            txtSueldo.Clear();
            txtIngresos.Clear();
            txtEgreso.Clear();
            txtSeguro.Clear();
            txtNeto.Clear();
            if (txtHoras.Text.Length == 0)
            { txtValor.Clear(); }
            else
            {
                int horas = int.Parse(txtHoras.Text);

                if(horas < 41)
                { txtValor.Text = "5"; }

                else if(horas >= 41 && horas <= 80)
                { txtValor.Text = "7"; }

                else if (horas >= 81 && horas <= 120)
                { txtValor.Text = "8"; }

                else
                { txtValor.Text = "10"; }
            }
        }

        private void CalcularExtras()
        {
            txtIngresos.Clear();
            txtNeto.Clear();
            if (textBox5.Text.Length == 0)
            {
                txtExtra.Clear();
            }
            if (rdbDiurno.Checked == true)
            {
                txtExtra.Text = "4";
            }
            else if (rdbNocturno.Checked == true)
            {
                txtExtra.Text = "8";
            }
        }

        private void rdbDiurno_CheckedChanged(object sender, EventArgs e)
        {
            CalcularExtras();
        }

        private void rdbNocturno_CheckedChanged(object sender, EventArgs e)
        {
            CalcularExtras();
        }

        private void btnSueldo_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            if(txtTrabajador.Text.Length == 0)
            { mensaje += "Debes Ingresar el Trabajador\n"; }

            if (txtHoras.Text.Length == 0)
            { mensaje += "Debes Ingresar las Horas Trabajadas\n"; }

            if(txtValor.Text.Length == 0)
            { mensaje += "No Hay Valor Por Hora\n"; }

            if(mensaje.Length != 0)
            { MessageBox.Show(mensaje, "FALTA INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            else
            {
                int horas = int.Parse(txtHoras.Text);
                float valor = float.Parse(txtValor.Text);
                txtSueldo.Text = (valor * horas).ToString();

                float seguro = float.Parse(txtSueldo.Text) * 0.0945f;
                txtSeguro.Text = seguro.ToString();
            }
        }

        private void txtHoras_TextChanged(object sender, EventArgs e)
        {
            CalcularValor();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            if(txtSueldo.Text.Length == 0)
            { mensaje += "Debes Ingresar el Sueldo\n"; }

            if (textBox5.Text.Length == 0)
            { mensaje += "Debes Ingresar las Horas Extras\n"; }

            if(rdbDiurno.Checked == false && rdbNocturno.Checked == false)
            { mensaje += "Debes Seleccionar un Turno (Diurno/Nocturno)\n"; }

            if(txtExtra.Text.Length == 0)
            { mensaje += "No hay Total de las Horas Extras\n"; }

            if(mensaje.Length != 0)
            { MessageBox.Show(mensaje, "FALTA INGRESAR", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            else
            {
                float sueldo = float.Parse(txtSueldo.Text);
                int horas = int.Parse(textBox5.Text);
                float extra = float.Parse(txtExtra.Text);

                txtIngresos.Text = (sueldo + (extra * horas)).ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            chbCarga.Checked = false;
            rdbDiurno.Checked = false;
            txtTrabajador.Clear();
            txtHoras.Clear();
            txtValor.Clear();
            txtSueldo.Clear();
            textBox5.Clear();
            txtExtra.Clear();
            txtIngresos.Clear();
            txtSeguro.Clear();
            txtHijos.Clear();
            txtHijos.ReadOnly = true;
            txtEgreso.Clear();
            txtNeto.Clear();
            txtTrabajador.Focus();
        }

        private void chbCarga_CheckedChanged(object sender, EventArgs e)
        {
            txtHijos.Clear();
            txtEgreso.Clear();
            txtNeto.Clear();
            if(chbCarga.Checked == false)
            { txtHijos.ReadOnly = true; }
            else
            { txtHijos.ReadOnly = false; }
        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            if (txtIngresos.Text.Length == 0)
            { mensaje += "No hay Ingresos\n"; }

            if (txtSeguro.Text.Length == 0)
            { mensaje += "No hay Seguro Social\n"; }

            if(chbCarga.Checked == true && txtHijos.Text.Length == 0)
            { mensaje += "Debes Ingresar el Número de Hijos\n"; }

            if(mensaje.Length != 0)
            { MessageBox.Show(mensaje, "ERROR DE INGRESOS", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                float seguro = float.Parse(txtSeguro.Text);
                if(txtHijos.Text.Length != 0)
                {
                    int hijos = int.Parse(txtHijos.Text);
                    float sueldo = float.Parse(txtSueldo.Text);
                    txtEgreso.Text = (seguro + (sueldo * (hijos * 0.02))).ToString();
                }
                else
                {
                    txtEgreso.Text = seguro.ToString();
                }
            }
        }

        private void btnNeto_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            if (txtIngresos.Text.Length == 0)
            { mensaje += "No hay Ingresos\n"; }

            if (txtSeguro.Text.Length == 0)
            { mensaje += "No hay Seguro Social\n"; }

            if (txtEgreso.Text.Length == 0)
            { mensaje += "No hay Egresos\n"; }

            if (mensaje.Length != 0)
            { MessageBox.Show(mensaje, "ERROR DE INGRESOS", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            else
            {
                float ingresos = float.Parse(txtIngresos.Text);
                float egresos = float.Parse(txtEgreso.Text);

                txtNeto.Text = (ingresos - egresos).ToString();
            }
        }
    }
}
