namespace FonTech.Application.DependencyInjection;

using Domain.Dto.Report;
using Domain.Interfaces.Services;
using Domain.Interfaces.Validations;
using FluentValidation;
using Mapping;
using Microsoft.Extensions.DependencyInjection;
using Services;
using Validations;
using Validations.FluentValidation.Report;

public static class DependencyInjection
{
    public static void AddApplication(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(ReportMapping));
        InitServices(services);
    }

    private static void InitServices(this IServiceCollection services)
    {
        services.AddScoped<IReportValidator, ReportValidator>();
        services.AddScoped<IValidator<CreateReportDto>, CreateReportValidator>();
        services.AddScoped<IValidator<UpdateReportDto>, UpdateReportValidator>();
        services.AddScoped<IReportService, ReportService>();
    }
}