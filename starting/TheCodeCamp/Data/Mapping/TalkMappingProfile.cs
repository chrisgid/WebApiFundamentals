using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TheCodeCamp.Models;

namespace TheCodeCamp.Data.Mapping
{
    public class TalkMappingProfile : Profile
    {
        public TalkMappingProfile()
        {
            CreateMap<Talk, TalkModel>();
        }
    }
}