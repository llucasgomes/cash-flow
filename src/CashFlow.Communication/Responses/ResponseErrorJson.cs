namespace CashFlow.Communication.Responses;
public class ResponseErrorJson
{
    public List<string> ErrorMessages { get; set; } = [];


    /// Construtores para resposta erro em string
    public ResponseErrorJson(string errorMessage)
    {
        ErrorMessages = [errorMessage];

    }

    /// Construtores para resposta de erro em Lista de string
    public ResponseErrorJson(List<string> errorMessage)
    {
        ErrorMessages = errorMessage;
    }

  
}
