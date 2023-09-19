using FluxPlanner.Data;
using FluxPlanner.Interfaces.IRepository;
using FluxPlanner.Interfaces.IService;
using FluxPlanner.Models;
using Microsoft.AspNetCore.Mvc;

namespace FluxPlanner.Services
{
    public class DeskReservationService : IDeskReservationService
    {
        private readonly IDeskReservationRepository _deskReservationRepository;


        public DeskReservationService(IDeskReservationRepository deskReservationRepository)
        {
            _deskReservationRepository = deskReservationRepository;

        }

        public async Task<DeskReservation> CreateDeskReservation(DeskReservation reservation)
        {


            bool isDeskAvailable = _deskReservationRepository.IsDeskAvailableForReservation(reservation.DeskId, reservation.StartDate, reservation.EndDate);


            if (isDeskAvailable)
            {
                DeskReservation newReservation = new DeskReservation
                {
                    DeskId = reservation.DeskId,
                    UserId = reservation.UserId,
                    StartDate = reservation.StartDate,
                    EndDate = reservation.EndDate,
                    ReservationStatus = ReservationStatus.Reserved
                };

                await _deskReservationRepository.CreateDeskReservation(newReservation);
                return newReservation;
            }
            else
            {
                throw new Exception("The desk is not available.");
            }

        }

     //   public async Task<DeskReservation> GetReservationByUserId(int IdUser )
        
public Task<DeskReservation> GetReservationByUserId(int UserId)
        {
            throw new NotImplementedException();
        }

        //var existingReservation = await _deskReservationRepository.GetReservationByUserId(reservation.IdUser);

        //if (existingReservation != null)
        //{
        //    throw new InvalidOperationException("User already has a reserved desk.");
        //}

        //// Proceed to create a new reservation
        // return await _deskReservationRepository.CreateAsync(IdUser); }


        public async Task<ActionResult<IEnumerable<DeskReservation>>> GetReservations()
        {
            return await _deskReservationRepository.GetReservations();
        }
    }
}
