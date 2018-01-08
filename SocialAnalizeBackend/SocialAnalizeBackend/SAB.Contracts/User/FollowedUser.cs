using GoldenEye.Backend.Core.Entity;
using GoldenEye.Shared.Core.Objects.General;
using SA.Contracts.Reports.Character;
using SA.Contracts.Reports.InternetActivity;
using SA.Contracts.Reports.Localization;
using SA.Contracts.Reports.PersonalData;

namespace SA.Contracts.User
{
    public class FollowedUser : IEntity
    {
        public int Id { get; set; }
        object IHasId.Id => Id;
        public string FacebookId { get; set; }
        public string InstagramId { get; set; }
        public string TwitterId { get; set; }
        public CharacterData CharacterData { get; set; }
        public PersonalData PersonalData { get; set; }
        public Localization LocalizationData { get; set; }
        public InternetActivityData InternetActivityData { get; set; }
        public User User { get; set; }
    }
}
