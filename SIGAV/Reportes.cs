using EE;
using Servicios;
using SIGAV_BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SIGAV
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            dtpFechaInicio.Format = DateTimePickerFormat.Custom;
            dtpFechaInicio.CustomFormat = "yyyy";
            dtpFechaInicio.ShowUpDown = true;
            dtpFechaFin.Format = DateTimePickerFormat.Custom;
            dtpFechaFin.CustomFormat = "yyyy";
            dtpFechaFin.ShowUpDown = true;
            chart1.Series["Series1"].LegendText = "Cantidad de ofertas por mes";
        }
        BLL_Oferta bll_Oferta = new BLL_Oferta();
        S_Login log = S_Login.ObtenerSesion;
        int fecha_inicio;
        int fecha_fin;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void LoadDataChart2()
        {
            List<BE_Oferta> List = bll_Oferta.ListarOfertasXML();
            List<BE_Oferta> filtered_list = List.FindAll(x => x.empresa == log.Usuario.empresa);
            List<BE_Oferta> list_authorized = filtered_list.FindAll(item => item.autorizada_oferta == true);
            List<BE_Oferta> list_unauthorized = filtered_list.FindAll(item => item.autorizada_oferta == false);
            String[] serie = { "ofertas autorizadas", "ofertas no autorizadas" };
            int[] cantidad = { list_authorized.Count(), list_unauthorized.Count() };

            for (int i = 0; i < serie.Length; i++)
            {
                chart2.Series["Series1"].Points.AddXY(serie[i], cantidad[i]);
                chart2.Series["Series1"].XValueMember = cantidad[i].ToString();
            }
        }
        public void LoadDataChart1()
        {
            List<BE_Oferta> List = bll_Oferta.ListarOfertasXML();
            int[] months = new int[]{01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12};
            Dictionary<int, int> fechas_count = new Dictionary<int, int>();
            if (dtpFechaInicio.Value.Year != DateTime.Now.Year && dtpFechaFin.Value.Year != DateTime.Now.Year)
            {
                if (dtpFechaInicio.Value > dtpFechaFin.Value)
                {
                    MessageBox.Show("El año desde no puede ser mayor al año hasta");
                }
                else if (dtpFechaInicio.Value == dtpFechaFin.Value)
                {
                    MessageBox.Show("El año desde no puede ser igual al año hasta");
                }
                else
                {
                    fecha_inicio = dtpFechaInicio.Value.Year;
                    fecha_fin = dtpFechaFin.Value.Year;
                    List<BE_Oferta> filteredList = List.FindAll(x => x.precio_oferta > 0 && x.estado == "Oferta aceptada" && x.empresa == log.Usuario.empresa && DateTime.Parse(x.fecha_oferta).Year >= fecha_inicio && DateTime.Parse(x.fecha_oferta).Year <= fecha_fin);
                    if (filteredList.Count > 0)
                    {
                        foreach (var item in months)
                        {
                            int count_fecha = filteredList.Count((oferta) => {
                                DateTime fecha = DateTime.Parse(oferta.fecha_oferta);
                                int fecha_moth = fecha.Month;
                                return item == fecha_moth ? true : false;
                            }
                            );
                            fechas_count.Add(item, count_fecha);
                        }
                        if (fechas_count.Count != 0)
                        {
                            chart1.Series["Series1"].XValueMember = "Mes";
                            chart1.Series["Series1"].YValueMembers = "Cantidad de ventas";
                            foreach (KeyValuePair<int, int> item in fechas_count)
                            {
                                chart1.Series["Series1"].Points.AddXY(item.Key, item.Value);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron ofertas en los años seleccionados");
                    }
                }
            }
            else
            {
                fecha_inicio = DateTime.Now.Year;
                List<BE_Oferta> filteredList = List.FindAll(x => x.precio_oferta > 0 && x.estado == "Oferta aceptada" && x.empresa == log.Usuario.empresa && DateTime.Parse(x.fecha_oferta).Year == fecha_inicio);
                foreach (var item in months)
                {
                    int count_fecha = filteredList.Count((oferta) => {
                            DateTime fecha = DateTime.Parse(oferta.fecha_oferta);
                            int fecha_moth = fecha.Month;
                        return item == fecha_moth ? true : false;
                        }
                    );
                    fechas_count.Add(item, count_fecha);
                }
                if (fechas_count.Count != 0)
                {
                    chart1.Series["Series1"].XValueMember = "Mes";
                    chart1.Series["Series1"].YValueMembers = "Cantidad de ventas";
                    foreach (KeyValuePair<int, int> item in fechas_count)
                    {
                        chart1.Series["Series1"].Points.AddXY(item.Key, item.Value);
                    }
                }
            }
        }
        private void Reportes_Load(object sender, EventArgs e)
        {
            LoadDataChart2();
        }

        private void Btn_MostrarReporte_Click(object sender, EventArgs e)
        {
            LoadDataChart1();
        }
    }
}
