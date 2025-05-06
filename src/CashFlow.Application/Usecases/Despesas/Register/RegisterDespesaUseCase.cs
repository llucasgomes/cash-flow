using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;

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
        if (string.IsNullOrEmpty(req.Title))
            throw new ArgumentException("O título é obrigatório.");

        if (req.Valor < 0)
            throw new ArgumentException("O valor deve ser maior que zero.");

        if (req.Data == DateTime.MinValue)
            throw new ArgumentException("A data é obrigatória.");

       

        var pagamentoValido = Enum.IsDefined(typeof(PagamentoType), req.Pagemento);
        if (!pagamentoValido)
            throw new ArgumentException("O tipo de pagamento é inválido.");
    }
}
