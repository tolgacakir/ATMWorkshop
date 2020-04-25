using Castle.Core.Interceptor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using TFramework.Core.Utilities.Interceptors;
using TFramework.Core.Utilities.Messages;
using System.Linq;
using TFramework.Core.CrossCuttingConcerns.Validation.FluentValidation;

namespace TFramework.Core.Aspects.Autofac
{
    public class FluentValidationAspect :MethodInterception
    {
        Type _validatorType;
        public FluentValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception(AspectMessages.WrongValidationType);
            }
            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidatorTool.FluentValidate(validator, entity);
            }
        }
    }
}
