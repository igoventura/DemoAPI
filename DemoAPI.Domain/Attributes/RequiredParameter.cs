using DemoAPI.Domain.Entities.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Domain.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
    public class RequiredParameterAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("entity");
            }

            return true;
        }
    }
}
