﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Viaticos.Common.Interfaces
{
    public interface ILocalize
    {
        CultureInfo GetCurrentCultureInfo();

        void SetLocale(CultureInfo ci);
    }

}
