﻿using Insania.Biology.Entities;

namespace Insania.Biology.Contracts.DataAccess;

/// <summary>
/// Интерфейс работы с данным наций
/// </summary>
public interface INationsDAO
{
    /// <summary>
    /// Метод получения списка наций
    /// </summary>
    /// <returns cref="List{Nation}">Список наций</returns>
    /// <exception cref="Exception">Исключение</exception>
    Task<List<Nation>> GetList();

    /// <summary>
    /// Метод получения списка наций
    /// </summary>
    /// <param cref="long?" name="raceId">Идентификатор расы</param>
    /// <returns cref="List{Nation}">Список наций</returns>
    /// <exception cref="Exception">Исключение</exception>
    Task<List<Nation>> GetList(long? raceId);
}