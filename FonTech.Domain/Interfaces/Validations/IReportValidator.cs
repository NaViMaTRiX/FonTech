namespace FonTech.Domain.Interfaces.Validations;

using Entity;
using Result;

public interface  IReportValidator : IBaseValidator<Report>
{
    /// <summary>
    /// Проверяется наличия отчёта, если отчёт с переданным названием есть в БД, то создать точно такой же нельзя.
    /// Проверятеся пользователь если с UserId пользователь не найден, то такого пользователя нет.
    /// </summary>
    /// <param name="report"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    BaseResult CreateValidator(Report report, User user);
}