using GoldenEye.Backend.Core.DDD.Queries;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Reports.Localization.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Reports.Localization
{
    public class LocalizationQueryHandler : IAsyncQueryHandler<GetUserLocalization, IList<SA.Contracts.Reports.Localization.Localization>>
    {
        private readonly ILocalizationRepository localizationRepository;

        public LocalizationQueryHandler(ILocalizationRepository localizationRepository)
        {
            this.localizationRepository = localizationRepository;
        }
        public async Task<IList<SA.Contracts.Reports.Localization.Localization>> Handle(GetUserLocalization userLocalizationData)
        {
            return localizationRepository.GetUserLocalization(userLocalizationData.UserId);
        }
    }
}
