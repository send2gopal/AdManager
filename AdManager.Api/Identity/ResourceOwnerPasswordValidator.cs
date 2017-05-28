using System;
using System.Threading.Tasks;
using IdentityServer4.Validation;

namespace AdManager.Api.Identity
{
    public class ResourceOwnerPasswordValidator : IResourceOwnerPasswordValidator
    {
        public Task ValidateAsync(ResourceOwnerPasswordValidationContext context)
        {
            throw new NotImplementedException();
        }
    }

}