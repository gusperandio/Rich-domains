using PaymentContext.Domain.ValuesObjects;

namespace PaymentContext.Domain.Entities;

public class PayPalPayment : Payment
{
    public PayPalPayment(
        string trasactionCode,
        DateTime paidDate,
        DateTime expireDate,
        decimal total,
        decimal totalPaid,
        string owner,
        Document document,
        Addres address,
        Email email) : base(paidDate, expireDate, total, totalPaid, owner, document, address, email)
    {
        TrasactionCode = trasactionCode;
    }

    public string TrasactionCode { get; set; }
}