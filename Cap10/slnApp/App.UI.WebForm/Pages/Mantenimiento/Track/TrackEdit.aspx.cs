﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Data.Repository;
using App.Data.Repository.Interface;
using App.UI.WebForm.Common;
using log4net;
using Etrack = App.Entities.Base;

namespace App.UI.WebForm.Pages.Mantenimiento.Track
{
    public partial class TrackEdit : System.Web.UI.Page
    {
        private ILog _logger = LogManager.GetLogger(typeof(TrackEdit));

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitValues();
                GetTrack();
            }
           
        }
        private void GetTrack()
        {
            var codigo = Request.QueryString["cod"];
            if (codigo != null)
            {
                var trackId = Convert.ToInt32(codigo);

                IAppUnitofWork uw = new AppUnitofWork();
                var track = uw.TrackRepository.GetById(trackId);
                if (track != null)
                {
                    hdfCodigo.Value = track.TrackId.ToString();
                    txtNombre.Text = track.Name;
                    txtCompositor.Text = track.Composer;
                    txtDuracion.Text = track.Milliseconds.ToString();
                    txtPeso.Text = track.Bytes.ToString();
                    txtPrecio.Text = track.UnitPrice.ToString();
                    ddlAlbum.SelectedValue = track.AlbumId.ToString();
                    ddlGenero.SelectedValue = track.GenreId.ToString();
                    ddlMedia.SelectedValue = track.MediaTypeId.ToString(); 
                }
                uw.Dispose();
            }
        }
        private void InitValues()
        {
            try {
                IAppUnitofWork uw = new AppUnitofWork();

                //Configurando el combo Album
                _logger.Info("Antes de obtener la lista de album");
                var albums = uw.AlbumRepository.GetAll();
                Helpers.ConfigurarCombo(ddlAlbum, "Title", "AlbumId", albums);
                _logger.Info($"Despues de obtener la lista de album: Número registros { albums.Count}");

                //Configurando el combo Media
                var medias = uw.MediaTypeRepository.GetAll();
                Helpers.ConfigurarCombo(ddlMedia, "Name", "MediaTypeId", medias);


                //Configurando los géneros
                var generos = uw.GenreRepository.GetAll();
                Helpers.ConfigurarCombo(ddlGenero, "Name", "GenreId", generos);

                uw.Dispose(); //Liberando el UW
            } catch(Exception ex)
            {
                _logger.Info("Error al obtener datos iniciales en la pantalla TrackEdit");
                throw ex;
            }
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        } 

        private void Guardar()
        {
            var entity = new Etrack.Track();
            if (!String.IsNullOrWhiteSpace(hdfCodigo.Value))
            {
                entity.TrackId = Convert.ToInt32(hdfCodigo.Value);
            }         
            entity.Name = txtNombre.Text;
            entity.AlbumId = Convert.ToInt32(ddlAlbum.SelectedValue);
            entity.MediaTypeId = Convert.ToInt32(ddlMedia.SelectedValue);
            entity.GenreId = Convert.ToInt32(ddlGenero.SelectedValue);
            entity.Composer = txtCompositor.Text;
            entity.Milliseconds = Convert.ToInt32(txtDuracion.Text);
            entity.Bytes = Convert.ToInt32(txtPeso.Text);
            entity.UnitPrice = Convert.ToDecimal(txtPrecio.Text);

            IAppUnitofWork uw = new AppUnitofWork();

            if (entity.TrackId == 0)//Cuando es nuevo
                uw.TrackRepository.Add(entity);
            else //cuando es una edición
                uw.TrackRepository.Update(entity);
            uw.Complete();            
            uw.Dispose(); //Liberando conexión
        }
        //public void Page_Error(object obj, EventArgs e)
        //{
        //    Exception ex = Server.GetLastError();

        //    _logger.Error(ex);
        //}

    }
}