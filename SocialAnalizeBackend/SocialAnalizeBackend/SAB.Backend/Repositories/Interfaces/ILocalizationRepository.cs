using SA.Contracts.Reports.Localization;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Backend.Repositories.Interfaces
{
    public interface ILocalizationRepository
    {
        IList<Localization> GetUserLocalization(int userId);
    }
}
