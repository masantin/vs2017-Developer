﻿using App.Data.DataAccess;
using App.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Data.Repository
{
    public class AppUnitofWork : IAppUnitofWork
    {
        private readonly DbContext _context;

        public AppUnitofWork()
        {
            _context = new DBModel();

            this.ArtistRepository = new ArtistRepository(_context);
            this.AlbumRepository = new AlbumRepository(_context);
            this.TrackRepository = new TrackRepository(_context);
            this.MediaTypeRepository = new MediaTypeRepository(_context);
            this.GenreRepository = new GenreRepository(_context);
            this.CustomerRepository = new CustomerRepository(_context);
            this.EmployeeRepository = new EmployeeRepository(_context);
            this.InvoiceRepository = new InvoiceRepository(_context);
            this.InvoiceLineRepository = new InvoiceLineRepository(_context);
            this.PlaylistRepository = new PlaylistRepository(_context);
        }
        public IArtistRepository ArtistRepository { get; set; }
        public IAlbumRepository AlbumRepository { get; set; }
        public ITrackRepository TrackRepository { get; set; }
        public IMediaTypeRepository MediaTypeRepository { get; set; }
        public IGenreRepository GenreRepository { get; set; }
        public ICustomerRepository CustomerRepository { get; set; }
        public IEmployeeRepository EmployeeRepository { get; set; }
        public IInvoiceRepository InvoiceRepository { get; set; }
        public IInvoiceLineRepository InvoiceLineRepository { get; set; }
        public IPlaylistRepository PlaylistRepository { get; set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
