﻿using Application.Common.Interfaces;
using Application.Reservation.Commands.CreateReservation;
using Application.Reservation.Queries.GetReservation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Restaurant.Controllers
{
    [Route("api/[controller]")]
    [Authorize(Policy = "NeedContentManagerRole")]
    [ApiController]
    public class ReservationController : ApiControllerBase
    {
        private readonly IApplicationDbContext _dbContext;

        public ReservationController(IApplicationDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
        // GET: api/<ReservationController>
        [HttpGet]
        public async Task<IActionResult> GetAllReservations()
        {
            var result = await _mediator.Send(new GetAllReservationsQuery());
            return Ok(result);
        }

        // GET api/<ReservationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ReservationController>
        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
        {
            var id = await _mediator.Send(command);
            return CreatedAtAction(nameof(GetAllReservations), new { id }, command);
        }

        // PUT api/<ReservationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReservationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
