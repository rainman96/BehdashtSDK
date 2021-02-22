namespace Ditas.SDK.IServices
{
    internal interface IValidation
    {
         (bool State, string Message, string FieldName) IsValid();
    }

}