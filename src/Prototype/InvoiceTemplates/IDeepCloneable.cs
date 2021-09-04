namespace InvoiceTemplates
{
    public interface IDeepCloneable<T>
    {
        T DeepClone();
    }
}