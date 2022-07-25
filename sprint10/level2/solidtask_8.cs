public enum InvoiceType
{
    Final,
    Proposed,
    Recurring,
    Ordinary
}

class Invoice
{
    public InvoiceType InvoiceType { get; set; }

    public double GetDiscount(double amount)
    {
        return amount;
    }
}

class FinalInvoice : Invoice
{
    public double GetDiscount(double amount)
    {
        return amount - amount * 0.03;
    }
}

class ProposedInvoice : Invoice
{
    public double GetDiscount(double amount)
    {
        return amount - amount * 0.05;
    }
}

class RecurringInvoice : Invoice
{
    public double GetDiscount(double amount)
    {
        return amount - amount * 0.1;
    }
}

class OrdinaryInvoice : Invoice
{
    public double GetDiscount(double amount)
    {
        return amount - amount * 0.01;
    }
}
