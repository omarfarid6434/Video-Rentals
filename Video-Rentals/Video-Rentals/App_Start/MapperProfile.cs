﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Video_Rentals.Models;
using Video_Rentals.Dtos;

namespace Video_Rentals.App_Start
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            Mapper.CreateMap<Customer, CustomersDto>();
            Mapper.CreateMap<Movie, MoviesDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();



            Mapper.CreateMap<CustomersDto, Customer>()
                .ForMember(c=>c.Id,opt=>opt.Ignore()); 
            Mapper.CreateMap<MoviesDto, Movie>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}