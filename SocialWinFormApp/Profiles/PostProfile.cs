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
    public class PostProfile:Profile
    {
        public PostProfile()
        {
            CreateMap<PostDTO, AppPostModel>()
                .ForMember(dest => dest.Body, scr => scr.MapFrom(m => m.Body))
                .ForMember(dest => dest.Likes, scr => scr.MapFrom(m => m.Likes.Count()))
                .ForMember(dest => dest.Dislikes,scr => scr.MapFrom(m=>m.Dislikes.Count()))
                .ForMember(dest => dest.Title, scr => scr.MapFrom(m => m.Title))
                .ForMember(dest => dest.PostId,scr => scr.MapFrom(m => m.PostId))
                ;
        }
    }
}
