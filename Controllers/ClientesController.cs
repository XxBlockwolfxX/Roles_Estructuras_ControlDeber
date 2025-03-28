﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Roles_Estructuras_Control.Data;
using Roles_Estructuras_Control.Models;

namespace Roles_Estructuras_Control.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Clientes.ToListAsync());
        }
        public List<ClientesModel> ListaClientes()
        {
            return _context.Clientes.ToList();
        }






        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientesModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientesModel == null)
            {
                return NotFound();
            }

            return View(clientesModel);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre,Direccion,Telefono,Email")] ClientesModel clientesModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientesModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientesModel);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientesModel = await _context.Clientes.FindAsync(id);
            if (clientesModel == null)
            {
                return NotFound();
            }
            return View(clientesModel);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre,Direccion,Telefono,Email")] ClientesModel clientesModel)
        {
            if (id != clientesModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientesModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientesModelExists(clientesModel.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(clientesModel);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var clientesModel = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientesModel == null)
            {
                return NotFound();
            }

            return View(clientesModel);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var clientesModel = await _context.Clientes.FindAsync(id);
            if (clientesModel != null)
            {
                _context.Clientes.Remove(clientesModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientesModelExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }


        //Procesos de crud
        [HttpPost]
        public async Task<IActionResult> CreateCliente([FromBody] ClientesModel cliente)
        {
            if (cliente == null)
                return BadRequest("Datos inválidos");

            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCliente(int id, [FromBody] ClientesModel cliente)
        {
            var clienteExistente = await _context.Clientes.FindAsync(id);
            if (clienteExistente == null)
                return NotFound();

            clienteExistente.Nombre = cliente.Nombre;
            clienteExistente.Email = cliente.Email;
            clienteExistente.Telefono = cliente.Telefono;

            await _context.SaveChangesAsync();
            return Ok(clienteExistente);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCliente(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente == null)
                return NotFound();

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();
            return Ok();
        }

    }
}
