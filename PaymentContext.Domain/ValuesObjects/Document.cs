using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValuesObjects;

namespace PaymentContext.Domain.ValuesObjects;

public class Document : ValueObject
{
    public Document(string number, EDocumentType type)
    {
        Number = number;
        Type = type;
    }

    public string Number { get; private set; }
    public EDocumentType Type { get; set; }
}