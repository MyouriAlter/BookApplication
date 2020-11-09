using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects.BusinessRules;

namespace BusinessObjects
{
    public abstract class BusinessObject
    {
        private List<BusinessRule> _rules = new List<BusinessRule>();

        public List<string> Errors { get; } = new List<string>();

        protected void AddRule(BusinessRule rule)
        {
            _rules.Add(rule);
        }
        public bool IsValid()
        {
            bool valid = true;

            Errors.Clear();

            foreach (var rule in _rules.Where(rule => !rule.Validate(this)))
            {
                valid = false;
                Errors.Add(rule.ErrorMessage);
            }
            return valid;
        }


    }

}
