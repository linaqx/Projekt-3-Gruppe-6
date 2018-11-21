﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projekt_3___WCF.Model
{
    public class Entertainment
    {
        //private string genre;
        //private string title;
        //private string country;
        //private string language;
        //private DateTime releaseDate;
        //private string storyLine;
        //private string filmingLocation;
        //private string information;

        public Entertainment(string genre, string title, string country, string language, DateTime realeaseDate, string storyLine, string filmingLocation, string information)
        {
            this.genre = genre;
            this.title = title;
            this.country = country;
            this.language = language;
            this.releaseDate = realeaseDate;
            this.storyLine = storyLine;
            this.filmingLocation = filmingLocation;
            this.information = information;

        }

        public Entertainment()
        {

        }

        public string genre { get; set; }
        public string title { get; set; }
        public string country { get; set; }
        public string language { get; set; }
        public DateTime releaseDate { get; set; }
        public string storyLine { get; set; }
        public string filmingLocation { get; set; }
        public string information { get; set; }

        

        



    }
}