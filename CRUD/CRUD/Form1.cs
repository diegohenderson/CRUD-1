using CRUD.Clases;
using CRUD.Database;
using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
namespace CRUD
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FotoProducto.Image = null;
            using (DB db = new DB())
            {
                productoBindingSource.DataSource = db.ProdList.ToList();
            }
            metroPanel.Enabled = false;
            Producto obj = productoBindingSource.Current as Producto;
            if (obj != null)
            {
                FotoProducto.Image = Image.FromFile(obj.ImageUrl);
            }
        }

        private void BtBrowser_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPEG|*.jpg" };
            using (ofd) ;
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    FotoProducto.Image = Image.FromFile(ofd.FileName);
                    Producto obj = productoBindingSource.Current as Producto;
                    if (obj != null)
                    {
                        obj.ImageUrl = ofd.FileName;
                    }
                }
            }
        }

        private void BtAgregar_Click(object sender, EventArgs e)
        {
            FotoProducto.Image = null;
            metroPanel.Enabled = true;
            productoBindingSource.Add(new Producto());
            productoBindingSource.MoveLast();
            txtNombreProd.Focus();
        }

        private void BtEditar_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = true;
            txtNombreProd.Focus();
            Producto obj = productoBindingSource.Current as Producto;
        }

        private void BtCancel_Click(object sender, EventArgs e)
        {
            metroPanel.Enabled = false;
            productoBindingSource.ResetBindings(false);
            Form1_Load(sender, e);
        }

        private void MetroGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Producto obj = productoBindingSource.Current as Producto;
            if (obj != null)
            {
                FotoProducto.Image = Image.FromFile(obj.ImageUrl);

            }
        }

        private void BtBorrar_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Estas Seguro de borrar este producto?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (DB db = new DB())
                {
                    Producto obj = productoBindingSource.Current as Producto;
                    if (obj != null)
                    {
                        if (db.Entry<Producto>(obj).State == EntityState.Detached)
                        {
                            db.Set<Producto>().Attach(obj);
                            db.Entry<Producto>(obj).State = EntityState.Deleted;
                            db.SaveChanges();
                            MetroFramework.MetroMessageBox.Show(this, "Se Borro Efectivamente");
                            productoBindingSource.RemoveCurrent();
                            metroPanel.Enabled = false;
                            FotoProducto.Image = null;
                        }
                    }
                }
            }
        }

        public void BtGuardar_Click(object sender, EventArgs e)
        {
            using (DB db= new DB())
            {
                Producto obj = productoBindingSource.Current as Producto;
                if (obj!=null)
                {
                    if (db.Entry<Producto>(obj).State == EntityState.Detached)
                    {
                        db.Set<Producto>().Attach(obj);
                        
                    }
                    else if (obj.ID == 0)
                    {
                        db.Entry<Producto>(obj).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry<Producto>(obj).State = EntityState.Modified;

                    }
                    db.SaveChanges();
                    MetroFramework.MetroMessageBox.Show(this, "Guardado Exitosamente");
                    metroGrid1.Refresh();
                    metroPanel.Enabled=false;
                }
            }
        }
    }
}
