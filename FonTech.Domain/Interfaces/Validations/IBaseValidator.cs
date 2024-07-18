namespace FonTech.Domain.Interfaces.Validations;

using Result;

public interface IBaseValidator<in T> where T : class
{
    BaseResult ValidateOnNull(T model);
}