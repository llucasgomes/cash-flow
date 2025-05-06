using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

namespace CashFlow.Application.Usecases.Despesas.Register;
public class RegisterDespesaUseCase
{

    public ResponseRegisterDespesaJson Execute(RequestRegisterDespesaJson req)
    {
        return new ResponseRegisterDespesaJson
        {
            Title = req.Title,
            
            
        };
    }
}
