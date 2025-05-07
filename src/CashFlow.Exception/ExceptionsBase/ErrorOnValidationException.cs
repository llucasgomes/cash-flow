namespace CashFlow.Exception.ExceptionsBase;
public class ErrorOnValidationException : CashFlowException
{
    public List<string> ErrosMessage { get; set; } = [];
    public ErrorOnValidationException(List<string> errosMessage)
    {
    }
   
}
