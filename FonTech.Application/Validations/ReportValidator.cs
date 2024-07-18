namespace FonTech.Application.Validations;

using Domain.Entity;
using Domain.Enum;
using Domain.Interfaces.Validations;
using Domain.Result;
using Resorces;

public class ReportValidator : IReportValidator
{
    public BaseResult ValidateOnNull(Report? model)
    {
        if (model is null)
        {
            return new BaseResult()
            {
                ErrorMessage = ErrorMessage.ReportNotFound,
                ErrorCode = (int)ErrorCodes.ReportNotFound,
            };
        }

        return new BaseResult();
    }

    public BaseResult CreateValidator(Report? report, User? user)
    {
        if (report is not null)
        {
            return new BaseResult()
            {
                ErrorMessage = ErrorMessage.ReportAlreadyExists,
                ErrorCode = (int)ErrorCodes.ReportAlreadyExists,
            };
        }

        if (user is null)
        {
            return new BaseResult()
            {
                ErrorMessage = ErrorMessage.UserNotFound,
                ErrorCode = (int)ErrorCodes.UserNotFound,
            };
        }

        return new BaseResult();
    }
}