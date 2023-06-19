using PaymentContext.Shared.ValuesObjects;

namespace PaymentContext.Domain.ValuesObjects;

public class Addres : ValueObject
{
    public string Street { get; private set; }
    public string Number { get; private set; }
    public string Neighnorhood { get; private set; }
    public string City { get; private set; }
    public string State { get; private set; }
    public string Country { get; private set; }
    public string ZipCode { get; private set; }
}