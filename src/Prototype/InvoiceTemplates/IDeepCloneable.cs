using System.Text.Json;

namespace InvoiceTemplates
{
    public interface IDeepCloneable<T>
    {
        T DeepClone();
    }
}