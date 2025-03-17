using API.Domain.Entity.Models;
using API.Infrastructure.Context;
using API.Infrastructure.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controller;

[Route("api/[controller]/[action]")]
[ApiController]
public class StaffController : ControllerBase
{
     private readonly StaffContext _context;

        // Injeção de dependência para o contexto do banco de dados
        public StaffController(StaffContext context)
        {
            _context = context;
        }

        // Get all staff members
        [HttpGet]
        public async Task<ActionResult<List<Staff>>> GetAllStaff()
        {
            try
            {
                var staffList = await _context.Staff.ToListAsync();
                return Ok(staffList);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        // Get staff by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> GetStaffById(Guid id)
        {
            try
            {
                var staffMember = await _context.Staff.FindAsync(id);

                if (staffMember == null)
                {
                    return NotFound($"Staff with ID {id} not found.");
                }

                return Ok(staffMember);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        // Get staff by name
        [HttpGet("name/{name}")]
        public async Task<ActionResult<List<Staff>>> GetStaffByName(string name)
        {
            try
            {
                var staffList = await _context.Staff
                    .Where(s => s.NameEStaff.Contains(name))
                    .ToListAsync();

                if (staffList == null || staffList.Count == 0)
                {
                    return NotFound($"No staff members found with the name {name}.");
                }

                return Ok(staffList);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }

        // Get staff by birthday
        [HttpGet("birthday/{birthday}")]
        public async Task<ActionResult<List<Staff>>> GetStaffByBirthday(DateTime birthday)
        {
            try
            {
                var staffList = await _context.Staff
                    .Where(s => s.BirthdayStaff.Date == birthday.Date)
                    .ToListAsync();

                if (staffList == null || staffList.Count == 0)
                {
                    return NotFound($"No staff members found with the birthday {birthday.ToShortDateString()}.");
                }

                return Ok(staffList);
            }
            catch (Exception ex)
            {
                return BadRequest($"An error occurred: {ex.Message}");
            }
        }
}