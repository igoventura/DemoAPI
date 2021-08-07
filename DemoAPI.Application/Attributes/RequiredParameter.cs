using System;
using System.ComponentModel.DataAnnotations;

namespace DemoAPI.Application.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter, Inherited = false, AllowMultiple = true)]
    public class RequiredParameterAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("parameter");
            }

            return true;
        }
    }
}
