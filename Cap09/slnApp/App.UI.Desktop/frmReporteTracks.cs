using App.Data.DataAccess;
using App.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Data.Repository;
using App.Data.Repository.Interface;

namespace App.UI.Desktop
{
    public partial class frmReporteTracks : Form
    {
        public frmReporteTracks()
        {
            InitializeComponent();

            InicializarValores();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
            
        }

        #region "Procedimientos propios"
        private void Buscar()
        {
            IAppUnitofWork uw = new AppUnitofWork();

            var listado = uw.TrackRepository.ReporteTracks
                (txtNombre.Text.Trim());

            gvListado.DataSource = listado;
            gvListado.Refresh();

            //Libera los recursos
            uw.Dispose();

        }

        private void InicializarValores()
        {
            //Obteniendo información de géneros
            IAppUnitofWork uw = new AppUnitofWork();

            var genreListado = uw.GenreRepository.GetAll();              

            genreListado.Insert(0,new
                Genre()
            {
                GenreId=0,
                Name="Todos"
            });
           

            cboGeneros.DataSource = genreListado;
            cboGeneros.Refresh();

            //Obteniendo información de Media Type
            uw = new AppUnitofWork();

            var mediatypeListado = uw.MediaTypeRepository.GetAll();


            mediatypeListado.Insert(0, new
                MediaType()
            {
                MediaTypeId = 0,
                Name = "Todos"
            });

            //Libera los recursos
            uw.Dispose();

            cboMediaType.DataSource = mediatypeListado;
            cboMediaType.Refresh();
                       
        }

        #endregion

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
