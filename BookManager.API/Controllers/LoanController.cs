using BookManager.API.Models;
using BookManager.Application.InputModels;
using BookManager.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoanController : ControllerBase
    {
        private readonly ILoanService _loanService;

        public LoanController(ILoanService loanService)
        {
            _loanService = loanService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loan = _loanService.GetById(id);

            if(loan == null) return NotFound();

            return Ok(loan);
        }


        [HttpPost]
        public IActionResult Post([FromBody] CreateLoanInputModel createRegisterLoan) 
        {
            if (createRegisterLoan.LoanDate == null) return BadRequest();

            var id = _loanService.Create(createRegisterLoan);

            return CreatedAtAction(nameof(GetById), new { id }, createRegisterLoan);
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            _loanService.Delete(id);

            return NoContent();
        }


    }
}
