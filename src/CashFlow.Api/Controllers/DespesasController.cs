using CashFlow.Application.Usecases.Despesas.Register;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionsBase;
using Microsoft.AspNetCore.Mvc;

namespace CashFlow.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class DespesasController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterDespesaJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ResponseErrorJson), StatusCodes.Status500InternalServerError)]
    public IActionResult Register([FromBody] RequestRegisterDespesaJson req)
    {
        try
        {
            var useCase = new RegisterDespesaUseCase();
            var response = useCase.Execute(req);

            return Created(string.Empty, response);
        }
        catch (ErrorOnValidationException ex)
        {
            var errorResponse = new ResponseErrorJson(ex.Errors); // Fixed property name

            return BadRequest(errorResponse);
        }
        catch
        {
            var errorResponse = new ResponseErrorJson("Erro Desconhecido");

            return StatusCode(StatusCodes.Status500InternalServerError, errorResponse);
        }
    }
}
