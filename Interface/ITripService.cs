﻿using Microsoft.AspNetCore.Mvc;
using ReadFile_Mini.Models;
using ReadFile_Mini.Requestes;
using ReadFile_Mini.Response;


namespace ReadFile_Mini.Interface
{
    public interface ITripService
    {
        Task AddTripAsync(TripRequest tripRequest);
        Task<Trip> GetTripByIdAsync(int tripId);
        Task<IEnumerable<TripResponse>> GetAllTripsAsync();
        Task<int> UpdateTripAsync(int tripId, TripRequest tripRequest);
        Task<string> DeleteTripAsync(int tripId);
    }
}
