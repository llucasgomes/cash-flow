using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Exception.ExceptionsBase;

namespace CashFlow.Application.Usecases.Despesas.Register;
public class RegisterDespesaUseCase
{

    public ResponseRegisterDespesaJson Execute(RequestRegisterDespesaJson req)
    {

        Validate(req);
        return new ResponseRegisterDespesaJson
        {
            Title = req.Title,
            
            
        };
    }

    //funcao de validaçõs
    private void Validate(RequestRegisterDespesaJson req)
    {
        var validator = new RegisterDespesaValidator();
        var result = validator.Validate(req);


        
        if (result.IsValid ==false)
        {
            // ira receber um fucao lambda
            var erroMessages = result.Errors.Select(f => f.ErrorMessage).ToList();
            throw new ErrorOnValidationException(erroMessages);
        }



    }
}
