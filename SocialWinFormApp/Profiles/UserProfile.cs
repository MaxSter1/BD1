using AutoMapper;
using MongoDTO;
using SocialWinFormApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialWinFormApp.Profiles
{
    public class UserProfile:Profile
    {
        public UserProfile()
        {
            CreateMap<UserDTO, AppUserModel>().ReverseMap();
            CreateMap<List<UserDTO>, List<AppUserModel>>().ReverseMap();
        }
    }
}
