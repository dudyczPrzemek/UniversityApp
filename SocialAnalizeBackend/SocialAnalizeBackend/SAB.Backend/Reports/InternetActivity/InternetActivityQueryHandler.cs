using GoldenEye.Backend.Core.DDD.Queries;
using SA.Backend.Repositories.Interfaces;
using SA.Contracts.Reports.InternetActivity;
using SA.Contracts.Reports.InternetActivity.Queries;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SA.Backend.Reports.InternetActivity
{
    public class InternetActivityQueryHandler : IAsyncQueryHandler<GetUserInternetActivity, InternetActivityData>
    {
        private IHashtagDetailsRepository hashtagDetailsRepository;
        private IHourActivityRepository hourActivityRepository;

        public InternetActivityQueryHandler(IHashtagDetailsRepository hashtagDetailsRepository, IHourActivityRepository hourActivityRepository)
        {
            this.hashtagDetailsRepository = hashtagDetailsRepository;
            this.hourActivityRepository = hourActivityRepository;
        }
        public async Task<InternetActivityData> Handle(GetUserInternetActivity userData)
        {
            var returnData = new InternetActivityData()
            {
                HashtagsDetails = hashtagDetailsRepository.GetByUserId(userData.UserId),
                HourActivityDetails = hourActivityRepository.GetByUserId(userData.UserId)
            };
            return returnData;
        }
    }
}
