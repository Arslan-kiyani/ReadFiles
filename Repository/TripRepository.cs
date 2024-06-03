using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ReadFile_Mini.Context;
using ReadFile_Mini.Interface;
using ReadFile_Mini.Models;
using ReadFile_Mini.Requestes;
using ReadFile_Mini.Response;

namespace ReadFile_Mini.Repository
{
    public class TripRepository : ITripRepository
    {

        private readonly SeniorDb _context;

        public TripRepository(SeniorDb context)
        {
            _context = context;
        }

        public async Task AddTripAsync(TripRequest tripRequest)
        { 
            await _context.SaveChangesAsync();
        }

        public async Task<string> DeleteTripAsync(int tripId)
        {
            await _context.SaveChangesAsync();
            return (string.Empty);
        }

        public Task<IEnumerable<TripResponse>> GetAllTripsAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Trip> GetTripByIdAsync(int tripId)
        {
            return await _context.Trip.FindAsync(tripId);
        }
        public async Task<int> UpdateTripAsync(int tripId, TripRequest tripRequest)
        {
           return await _context.SaveChangesAsync();
        }

    }
}
