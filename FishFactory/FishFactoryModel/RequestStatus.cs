﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFactoryModel
{
    /// <summary>
    /// Статус заказа
    /// </summary>
    public enum RequestStatus
    {
        Принят = 0,
        Выполняется = 1,
        Готов = 2,
        Оплачен = 3
    }
}
