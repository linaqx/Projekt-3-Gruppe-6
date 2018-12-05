﻿using System;
using System.Collections.Generic;
using System.Linq;
using BusinessLogic___Layer.BusinessLogic;
using Model___Layer.Model;
using Projekt_3___WCF.Model;
using WCF___library.DB;

namespace Projekt_3___WCF.BusinessLogic
{
    public class EntertainmentController : EntertainmentControllerIF
    {
        private EntertainmentDB edb;

        public EntertainmentController()
        {
            edb = new EntertainmentDB();
        }

        //Search metode!!
        public Entertainment FindEntertainmentByName(List<Entertainment> e)
        {
            return null;
        }

        public List<Entertainment> FindAllEntertainments()
        {
            return edb.GetAllEntertainments();
        }

        public List<Entertainment> FindPersonalEntertainments(int id)
        {
            return edb.GetPersonalEntertainments(id);
        }

        public List<Genre> GetAllGenres()
        { 
            return edb.GetAllGenres();
        }

        public List<FilmingLocation> GetALLFilmingLocations()
        {
            return edb.GetALLFilmingLocations();
        }

        public List<Language> GetAllLanguages()
        {
            return edb.GetAllLanguages();
        }

        public List<Country> GetAllCountries()
        {
            return edb.GetAllCountries();
        }

        public void StartInsertMovieTransaction(Movie m)
        {
            edb.StartInsertMovieTransaction(m);
        }
    }
}