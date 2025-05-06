using CashFlow.Communication.Enums;

namespace CashFlow.Communication.Requests;
public class RequestRegisterDespesaJson
{
    public string Title { get; set; } = string.Empty;
    public string Descricao { get; set; } =string.Empty;
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }
    public PagamentoType Pagemento { get; set; }

}
