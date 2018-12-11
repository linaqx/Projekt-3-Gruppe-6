﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Projekt_3___WCF.Model
{
    [DataContract]
    public class FavoriteList
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Author { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public List<Entertainment> Entertainments { get; set; }

        public FavoriteList()
        {

        }
        
        public void AddEntertainment(Entertainment e)
        {
            Entertainments.Add(e);
        }
    }
}