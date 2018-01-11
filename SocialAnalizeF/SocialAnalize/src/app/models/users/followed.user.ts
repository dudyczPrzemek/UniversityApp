import { PersonalData } from './personal.data';
import { CharacterData } from './character.data';

export class FollowedUser {
    public id: number;
    public facebookId: string;
    public instagramId: string;
    public twitterId: string;
    public personalData: PersonalData;
    public characterData: CharacterData;
}
