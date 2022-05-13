using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prueba_simulacion
{
    public partial class Editar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            _Default objeto = new _Default();
            objeto.LeerDatos();
            if (!IsPostBack)
            {
                foreach (var item in _Default.albumes)
                {
                    DropDownList1.Items.Add(item.Titulo);

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _Default objeto = new _Default();
            _Default.albumes.Find(a => a.Titulo == DropDownList1.Text).Fechapublicacion = Calendar1.SelectedDate;
            _Default.albumes.Find(a => a.Titulo == DropDownList1.Text).Artista = TextBox1.Text;
            _Default.albumes.Find(a => a.Titulo == DropDownList1.Text).Titulo = TextBox2.Text;

            objeto.GuardarDatos();

        }
    }
}