using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace InvoiceTemplates
{
    public class Invoice : IDeepCloneable<Invoice>
    {
        public string Recipient { get; }

        public decimal Amount { get; }

        public DateTime? DueDate { get; set; }

        public InvoiceType Type { get; }

        public void PrintInformation() => Console.WriteLine($"--- Invoice ---\n{nameof(Recipient)}: {Recipient}\n{nameof(Amount)}: {Amount}\nDue: {DueDate}\n{nameof(Type)}: {Type}");

        public Invoice DeepClone() => JsonSerializer.Deserialize<Invoice>(JsonSerializer.Serialize(this));

        [JsonConstructor]
        public Invoice(string recipient, decimal amount, InvoiceType type) : this(recipient, amount, type, null) { }

        public Invoice(string recipient, decimal amount, InvoiceType type, DateTime? dueDate)
        {
            Recipient = recipient;
            Amount = amount;
            Type = type;
            DueDate = dueDate;
        }
    }
}