using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace PuntoDeVenta
{
    public partial class Productos : Form
    {
        public Productos()
        {
            InitializeComponent();
        }


        public class Producto
        {
            public string idNumber { get; set; }
            public string Name { get; set; }
            public string SellPrice { get; set; }
            public string Discount { get; set; }
            public string CompanyId { get; set; }
            public string LineId { get; set; }
            public string Current { get; set; }
            public string Active { get; set; }
            public object Description { get; set; }
        }
        // public string[] Sizes { get; set; } 


        private void button1_Click(object sender, EventArgs e)
        {
            string url = "http://localhost/botigaOnline/WebService/listadoproductos.php";

            WebClient wc = new WebClient();

            string datos = wc.DownloadString(url);

            var rs = JsonConvert.DeserializeObject<List<Producto>>(datos);

           
            // datos = datos.TrimStart('['); Aixo Són porves fetes quant no podia deserialitzar
            // datos = datos.TrimEnd(']');

            // Comprobación de cambio
        }
         
    }
}
