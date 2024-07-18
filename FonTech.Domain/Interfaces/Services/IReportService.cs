namespace FonTech.Domain.Interfaces.Services;

using Dto;
using Dto.Report;
using Entity;
using Result;
/// <summary>
/// Сервис отвечающий за работу с доменной части отчёта.
/// </summary>
public interface IReportService
{
    /// <summary>
    /// Получение всех отчётов пользователя.
    /// </summary>
    /// <param name="userId"></param>
    /// <returns></returns>
    Task<CollectionResult<ReportDto>> GetReportsAsync(long userId);
    
    /// <summary>
    /// Получение отчёта по id.
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<BaseResult<ReportDto>> GetReportByIdAsync(long id);
    
    /// <summary>
    /// Создание отчёта c базовыми параметрами.
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    Task<BaseResult<ReportDto>> CreateReportAsync(CreateReportDto dto);
    
    /// <summary>
    /// Обновление отчёта
    /// </summary>
    /// <param name="updateReportDto"></param>
    /// <returns></returns>
    Task<BaseResult<ReportDto>> UpdateReportAsync(UpdateReportDto updateReportDto);
    
    /// <summary>
    /// Удаление отчёта по id
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    Task<BaseResult<ReportDto>> DeleteReportAsync(long id);
}