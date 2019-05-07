﻿using MetroFramework;
using MetroFramework.Forms;
using Proyecto1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ventas
{
    public partial class CrudProductos : MetroForm
    {
        sql s = new sql();

        public CrudProductos(string nombre)
        {
            InitializeComponent();
            s.dgrid(dgvinfo, "select v.id , v.nombre,v.porcion,c.Nombre as Unidad,v.Cantidad,v.precio,v.Existencia from productos as v inner join Porcion as c on v.TipoPorcion = c.id");
            s.populate(cbUnidad, "select * from Porcion", "Nombre");
            cbdisponible.Items.Add("No");
            cbdisponible.Items.Add("Si");
            lblnombre.Text = nombre.ToString();
        }

        private void dgvinfo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           lblid.Text = dgvinfo.CurrentRow.Cells[0].Value.ToString();
            txtnombre.Text = dgvinfo.CurrentRow.Cells[1].Value.ToString();
            txtporcion.Text = dgvinfo.CurrentRow.Cells[2].Value.ToString();
            cbUnidad.Text = dgvinfo.CurrentRow.Cells[3].Value.ToString();
            numericUpDown1.Text = dgvinfo.CurrentRow.Cells[4].Value.ToString();
            txtprecio.Text = dgvinfo.CurrentRow.Cells[5].Value.ToString();
            cbdisponible.SelectedIndex = int.Parse(dgvinfo.CurrentRow.Cells[6].Value.ToString());
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            string upd = string.Format("update productos set nombre = '{0}' ,TipoPorcion = '{1}',Porcion = '{2}',Cantidad = '{3}',precio = '{4}',Existencia='{5}' where id = '{6}'",txtnombre.Text,(cbUnidad.SelectedIndex + 1),txtporcion.Text,numericUpDown1.Value,txtprecio.Text,cbdisponible.SelectedIndex,lblid.Text);
            s.Exe(upd);
            s.dgrid(dgvinfo, "select v.id , v.nombre,v.porcion,c.Nombre as Unidad,v.Cantidad,v.precio,v.Existencia from productos as v inner join Porcion as c on v.TipoPorcion = c.id");
            txtnombre.Text = string.Empty;
            txtporcion.Text = string.Empty;
            txtprecio.Text = string.Empty;
            MessageBox.Show("Se modifico el producto");
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            string del = string.Format("delete from productos where id = '{0}'",lblid.Text);
            s.Exe(del);
            string dels = string.Format("delete from Recetas where Nombre = '{0}'",txtnombre.Text);
            s.Exe(dels);
            s.dgrid(dgvinfo, "select v.id , v.nombre,v.porcion,c.Nombre as Unidad,v.Cantidad,v.precio,v.Existencia from productos as v inner join Porcion as c on v.TipoPorcion = c.id");
            txtnombre.Text = string.Empty;
            txtporcion.Text = string.Empty;
            txtprecio.Text = string.Empty;
            cbdisponible.Text = null;
            cbUnidad.Text = null;
            lblid.Text = null;
            MessageBox.Show("Se elimino el producto");
            
        }

        private void btnregresar_Click(object sender, EventArgs e)
        {
            MENU m = new MENU(lblnombre.Text);
            m.Show();
            this.Hide();
        }

        private void CrudProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnayuda_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this,"Para Editar un producto da doble click a la tabla en la columna deseada","Ayuda");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            txtnombre.Text = string.Empty;
            txtporcion.Text = string.Empty;
            txtprecio.Text = string.Empty;
            cbdisponible.Text = null;
            cbUnidad.Text = null;
            lblid.Text = null;
        }

        private void txtporcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
     (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
