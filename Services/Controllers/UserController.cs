using Business.Contracts;
using Core.Validators;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace Services.Controllers
{
    public class UserController : ApiControllerBase
    {
        private readonly IUserLogic userLogic;

        public UserController(IUserLogic userLogic)
        {
            this.userLogic = userLogic;
        }

     

        [HttpPost]
        [AllowAnonymous]
        [Route("api/users/login")]
        public IHttpActionResult Login(UserModel userModel)
        {
            return GetHttpResponse(() =>
            {
                try
                {
                    var user = this.userLogic.Login(userModel.Email);

                    UserModel model = new UserModel();

                    if (user != null)
                    {

                        FormUrlEncodedContent content = new FormUrlEncodedContent(new[]
                        {
                            new KeyValuePair<String, String>("grant_type", "password"),
                            new KeyValuePair<String, String>("username", user.email),
                            new KeyValuePair<String, String>("role", user.role),
        

                        });

                        string baseURL = HttpContext.Current.Request.Url.Authority;

                        HttpClient client = new HttpClient();
                        HttpRequestMessage tokenRequest = new HttpRequestMessage()
                        {
                            RequestUri = new Uri("http://" + baseURL + "/token"),
                            Method = HttpMethod.Post
                        };
                        tokenRequest.Content = content;

                        tokenRequest.Headers.Add("Accept", "application/json");

                        HttpResponseMessage responseToken = client.SendAsync(tokenRequest).Result;

                        if (responseToken.IsSuccessStatusCode)
                        {
                            var token = responseToken.Content.ReadAsAsync<TokenModel>().Result;
                            model.TokenAccess = token.AccessToken;
                            model.Email = user.email;
                            model.Role = user.role;
                            model.Name = user.name;

                        }
                        else
                        {
                            ResponseResult.Success = false;
                            ResponseResult.Errors.Add(new ValidatorResult() { Code = 0, Message = "Usuario y/o Contraseña incorrectos." });
                        }
                    }
                    else
                    {
                        ResponseResult.Success = false;
                        ResponseResult.Errors.Add(new ValidatorResult() { Code = 0, Message = "Usuario y/o Contraseña incorrectos." });
                    }

                    ResponseResult.Data = model;

                }
                catch (ValidationException e)
                {
                    ResponseResult.Success = false;
                    ResponseResult.Errors = e.ValidationResultsLog;
                }


                return Ok(ResponseResult);

            });


        }
    }
}