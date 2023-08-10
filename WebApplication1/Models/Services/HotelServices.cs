using Lab12.Data;
using Lab12.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab12.Models.Services
{
    public class HotelService : IHotel
    {
        private AsyncInnContext _context;

        public HotelService(AsyncInnContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> DeleteHotel(int id)
        {
            return null;
        }
        Task<IActionResult> IHotel.DeleteHotel(int id)
        {
            throw new NotImplementedException();
        }

        async Task<ActionResult<IEnumerable<Hotel>>> IHotel.GetHotel()
        {
            return await _context.Hotel.ToListAsync();
        }

        Task<ActionResult<Hotel>> IHotel.GetHotel(int id)
        {
            throw new NotImplementedException();
        }

        public bool HotelExists(int id)
        {
            throw new NotImplementedException();
        }

        Task<ActionResult<Hotel>> IHotel.PostHotel(Hotel hotel)
        {
            throw new NotImplementedException();
        }

        Task<IActionResult> IHotel.PutHotel(int id, Hotel hotel)
        {
            throw new NotImplementedException();
        }
    }
}
