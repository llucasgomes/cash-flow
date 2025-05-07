using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.Usecases.Despesas.Register;
public class RegisterDespesaValidator: AbstractValidator<RequestRegisterDespesaJson>
{
    public RegisterDespesaValidator()
    {
        RuleFor(despesa => despesa.Title)
            .NotEmpty() //regra: nao estar vazio
            .WithName("O título é obrigatório."); //mensagem de erro

        RuleFor(despesa => despesa.Valor)
            .GreaterThan(0) //regra: maior que zero
            .WithName("O valor deve ser maior que zero."); //mensagem de erro


        RuleFor(despesa => despesa.Data)
            .LessThanOrEqualTo(DateTime.UtcNow) //regra: verifica se a data é menor ou igual a data atual
            .WithMessage("A data é obrigatória."); //mensagem de erro

        RuleFor(despesa => despesa.Pagemento)
            .IsInEnum() //regra: verifica se é um enum
            .WithMessage("O tipo de pagamento é inválido."); //mensagem de erro

    }
}
