﻿using Microsoft.AspNetCore.Mvc;

using Insania.Shared.Models.Responses.Base;

using Insania.Biology.Contracts.BusinessLogic;

using ErrorMessagesShared = Insania.Shared.Messages.ErrorMessages;

using ErrorMessagesBiology = Insania.Biology.Messages.ErrorMessages;

namespace Insania.Biology.ApiRead.Controllers;

/// <summary>
/// Контроллер работы с нациями
/// </summary>
/// <param cref="ILogger" name="logger">Сервис логгирования</param>
/// <param cref="INationsBL" name="nationsService">Сервис работы с бизнес-логикой наций</param>
[Route("nations")]
public class NationsController(ILogger<NationsController> logger, INationsBL nationsService) : Controller
{
    #region Зависимости
    /// <summary>
    /// Сервис логгирования
    /// </summary>
    private readonly ILogger<NationsController> _logger = logger;

    /// <summary>
    /// Сервис работы с бизнес-логикой наций
    /// </summary>
    private readonly INationsBL _nationsService = nationsService;
    #endregion

    #region Методы
    /// <summary>
    /// Метод получения списка наций
    /// </summary>
    /// <param cref="long" name="race_id">Идентификатор расы</param>
    /// <returns cref="OkResult">Список наций</returns>
    /// <returns cref="BadRequestResult">Ошибка</returns>
    [HttpGet]
    [Route("list")]
    public async Task<IActionResult> GetList([FromQuery] long? race_id)
    {
        try
        {
            //Проверки
            if (race_id == null) throw new Exception(ErrorMessagesBiology.EmptyRace);

            //Получение результата проверки логина
            BaseResponse? result = await _nationsService.GetList(race_id);

            //Возврат ответа
            return Ok(result);
        }
        catch (Exception ex)
        {
            //Логгирование
            _logger.LogError("{text} {ex}", ErrorMessagesShared.Error, ex);

            //Возврат ошибки
            return BadRequest(new BaseResponseError(ex.Message));
        }
    }
    #endregion
}