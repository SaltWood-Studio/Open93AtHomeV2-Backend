﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Open93AtHome.Modules.Database
{
    public class GitHubUser
    {
        public GitHubUser() { }

        [JsonProperty("login")]
        public string Login { get; set; } = string.Empty;

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; } = string.Empty;

        public static implicit operator UserEntity(GitHubUser user)
        {
            return new UserEntity()
            {
                Id = user.Id,
                UserName = user.Login,
                Photo = user.AvatarUrl
            };
        }

        public static implicit operator GitHubUser(UserEntity user)
        {
            return new GitHubUser()
            {
                Id = user.Id,
                Login = user.UserName,
                AvatarUrl = user.Photo
            };
        }
    }
}
