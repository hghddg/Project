﻿using Project.Shared.Domains;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.IRepository
{
    public class IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Attraction> Attractions { get; }

        IGenericRepository<Booking> Bookings { get; }

        IGenericRepository<Country> Countries { get; }

        IGenericRepository<Customer> Customers { get; }

        IGenericRepository<Hotel> Hotels { get; }

        IGenericRepository<Itenary> Itineraries { get; }

        IGenericRepository<ItenaryItem> ItenaryItems { get; }

        IGenericRepository<Location> Locations { get; }

        IGenericRepository<Payment> Payments { get;}

    }
}
