﻿using Microsoft.AspNetCore.Mvc;
using Svyaznoi.Context;
using Svyaznoi.Context.Contracts.Models;

namespace Svyaznoi.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IContext context1;
        public ClientController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllPlatelshik()
        {
            var platelshiklist = context1.Clients.ToList();
            return Ok(platelshiklist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var platelshiklist = context1.Clients.FirstOrDefault(x => x.Id == id);
            return Ok(platelshiklist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group1 = context1.Postavshiks.FirstOrDefault(x => x.Id == id);
            if (group1 != null)
            {
                context1.Postavshiks.Remove(group1);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Client model)
        {
            var item1 = new Client
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Address = model.Address,
                Email= model.Email,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Clients.Add(item1);
            context1.SaveChanges();
            return Ok(item1);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Client model)
        {
            var group1 = context1.Clients.FirstOrDefault(x => x.Id == Id);
            if (group1 != null)
            {
                return NotFound();
            }
            group1.Name = model.Name;
            group1.Address = model.Address;
            group1.Email = model.Email;
            group1.UpdatedAt = DateTime.Now;
            context1.SaveChanges();

            return Ok(group1);
        }
    }
}
