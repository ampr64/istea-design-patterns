using System.Collections.Generic;
using System.Linq;

namespace InvoiceTemplates
{
    public class InvoiceTemplator
    {
        private readonly Dictionary<string, Invoice> _templatePool = new();

        public void AddTemplate(string templateName, Invoice template)
        {
            if (_templatePool.ContainsKey(templateName))
            {
                _templatePool[templateName] = template.DeepClone();
                return;
            }

            _templatePool.Add(templateName, template.DeepClone());
        }

        public void AddTemplates(IEnumerable<KeyValuePair<string, Invoice>> entries)
        {
            if (entries.Any())
            {
                foreach (var namedTemplate in entries)
                {
                    AddTemplate(namedTemplate.Key, namedTemplate.Value);
                }
            }
        }

        public Invoice GetTemplate(string templateName) => _templatePool.GetValueOrDefault(templateName)?.DeepClone();
    }
}