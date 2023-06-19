using PaymentContext.Shared.ValuesObjects;

namespace PaymentContext.Domain.ValuesObjects;

public class Email : ValueObject
{
    public Email(string address)
    {
        Address = address;
    }

    public string Address { get; set; }
}