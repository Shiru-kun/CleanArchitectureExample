using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureExample.Application.Behavior
{
    public sealed class ValidationBehavior<T, R> : IPipelineBehavior<T, R> where T : IRequest<R>
    {
        private readonly IEnumerable<IValidator<T>> _validators;
        public ValidationBehavior(IEnumerable<IValidator<T>> validators) {
            _validators = validators;
        }
        public async Task<R> Handle(T request, RequestHandlerDelegate<R> next, CancellationToken cancellationToken)
        {
            if(!_validators.Any()) return await next();
            if (_validators.Any())
            {
                var context = new ValidationContext<T>(request);
                var results = await Task.WhenAll(_validators.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = results.SelectMany(r => r.Errors).Where(f => f is not null).ToList();
                if (failures.Count != 0) {
                    throw new FluentValidation.ValidationException(failures);
                }
            }
            return await next();
        }
    }
}
