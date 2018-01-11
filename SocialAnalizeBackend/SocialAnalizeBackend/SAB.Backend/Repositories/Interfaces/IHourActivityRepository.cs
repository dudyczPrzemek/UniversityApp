using SA.Contracts.Reports.InternetActivity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SA.Backend.Repositories.Interfaces
{
    public interface IHourActivityRepository
    {
        IList<HourActivityDetails> GetByUserId(int userId);
    }
}
