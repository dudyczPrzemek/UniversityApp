using InstaSharp;
using InstaSharp.Models.Responses;
using InstaSharp.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;
using FreeImageAPI;
using LinqToTwitter;

namespace SocialTest.Services
{
    public class InstagramAuthService
    {
        public static async Task<JsonResult> GetInstaAuth(string code) {

            var client = new HttpClient();
            var clientId = "9e2868731b544ed39a731c2111f4bfd2";
            var clientSecretId = "fa72e90415eb479a9c25185f15d7c79a";
            var returnUrl = @"http://localhost:51621/api/instagram";
            var postValues = new List<KeyValuePair<string, string>>
                             {
                                 new KeyValuePair<string, string>
                                     ("client_id",
                                      clientId),
                                 new KeyValuePair<string, string>
                                     ("client_secret",
                                      clientSecretId),
                                 new KeyValuePair<string, string>
                                     ("grant_type",
                                      "authorization_code"),
                                 new KeyValuePair<string, string>
                                     ("redirect_uri",
                                      returnUrl),
                                 new KeyValuePair<string, string>("code", code)
                             };

            // now encode the values
            var content = new FormUrlEncodedContent(postValues);
            var authLinkUri = new Uri(@"https://api.instagram.com/oauth/access_token");
            // make request for auth token
            var response = await client.PostAsync(authLinkUri, content);

            var parsedResponse = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(parsedResponse);
            var accessToken = json["access_token"].ToString();

            var searchUri = new Uri(@"https://api.instagram.com/v1/users/search?q=djanuszka&access_token=" + accessToken);
            var selfUri = new Uri(@"https://api.instagram.com/v1/users/self/?access_token=" + accessToken);
            var mediaUri = new Uri(@"https://api.instagram.com/v1/users/4046304216/media/recent/?access_token=" + accessToken);
            //var apiResponse = await client.GetAsync(mediaUri);

            //var dianaId = "4046304216";

            //var parsedResponse2 = await apiResponse.Content.ReadAsStringAsync();
            
            return new JsonResult("");
        }

        public static async Task<JsonResult> GetFaceAuth(string code)
        {
            var applicationId = "1578280192264123";
            var applicationSecret = "9993276c6b0cc628133d7c397a178305";
            var redirectUri2 = @"http://localhost:51621/api/facebook";
            var requestUrl = @"https://graph.facebook.com/v2.10/oauth/access_token?"+
                                "client_id="+applicationId +
                                "&redirect_uri=" + redirectUri2 +
                                "&client_secret=" + applicationSecret + 
                                "&code="+code;
            var client = new HttpClient();
            var response = await client.GetAsync(requestUrl);
            var parsedResponse = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(parsedResponse);
            var accessToken = json["access_token"].ToString();

            var searchUrl = @"https://graph.facebook.com/search?q=jazienicka&type=user&access_token=" + accessToken;
            var userUrl = @"https://graph.facebook.com/10155796287978498?fields=first_name,last_name,picture,age_range,gender&access_token=" + accessToken;
            var friendListUrl = @"https://graph.facebook.com/10155796287978498/friendlists?access_token=" + accessToken;
            var response2 = await client.GetAsync(userUrl);
            var parsedResponse2 = response2.Content.ReadAsStringAsync();

            return new JsonResult(parsedResponse2);
        }

        public static async Task<JsonResult> GetTwitterAuth(string oauth_verifier)
        {
            //var consKey = "WdraGJz5UUR2l8Y35g9zBrwOw";
            //var consSecret = "oxurh7hr5HxkCUChNwnshmCjNjOhdhE5r307AOEhZtxYKbPbyd";
            //var auth = new ApplicationOnlyAuthorizer
            //{
            //    CredentialStore = new InMemoryCredentialStore()
            //    {
            //        ConsumerKey = consKey,
            //        ConsumerSecret = consSecret
            //    }
            //};

            //await auth.AuthorizeAsync();

            //var twitterCtx = new TwitterContext(auth);

            //var twitterUrl = @"https://api.twitter.com/1.1/users/search.json?q=oskar_at_net";
            //var client = new HttpClient();
            //var response = await client.GetAsync(twitterUrl);
            //var parsedResponse = await response.Content.ReadAsStringAsync();

            //var srch =
            //await
            //(from search in twitterCtx.Search
            // where search.Type == SearchType.Search &&
            //       search.Query == "LINQ to Twitter"
            // select search)
            //.SingleOrDefaultAsync();

            //var foundUsers =
            //    await
            //    (from user in twitterCtx.User
            //     where user.Type == UserType.Search &&
            //           user.Query == "oskar_at_net"
            //     select user)
            //    .ToListAsync();

            //return new JsonResult(srch.Statuses[0].Text);
            var client = new HttpClient();
            var postValues = new List<KeyValuePair<string, string>>
                             {
                                 new KeyValuePair<string, string>
                                     ("oauth_verifier",
                                      oauth_verifier)
                             };

            var content = new FormUrlEncodedContent(postValues);
            var authLinkUri = new Uri(@"https://api.twitter.com/oauth/access_token");
            // make request for auth token
            var response = await client.PostAsync(authLinkUri, content);

            var parsedResponse = await response.Content.ReadAsStringAsync();

            return new JsonResult("");
        }
    }
}
