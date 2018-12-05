﻿using Model___Layer.Model;
using Projekt_3___WCF.DB;
using Projekt_3___WCF.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace WCF___library.DB
{
    public class EntertainmentDB
    {
        //static void Main(string[] args)
        //{
        //    EntertainmentDB edb = new EntertainmentDB();
        //    edb.GetAllEntertainments();
        //    DBConnection dBConnection = DBConnection.GetInstance();
        //    dBConnection.CloseConnection();
        //}

        private readonly string sql_FIND_ALL_ENTERTAINMENT = "select Entertainment.id, Entertainment.title, Entertainment.releaseDate from Entertainment;";
        private readonly string sql_FIND_ALL_ENTERTAINMENT_ON_FAVORITELIST = "select Entertainment.id, Entertainment.title, Entertainment.releaseDate from Entertainment INNER JOIN EntertainmentFavoriteList on(EntertainmentFavoriteList.entertainment_id = Entertainment.id) where EntertainmentFavoriteList.favoriteList_id = @id;";

        private readonly string sql_FIND_ALL_GENRE = "select Genre.id, Genre.[name] from Genre;";
        private readonly string sql_FIND_ALL_FILMINLOCATION = "select FilmingLocation.id, FilmingLocation.[name] from FilmingLocation;";
        private readonly string sql_FIND_ALL_LANGUAGE = "select [Language].id, [Language].[name] from [Language];";
        private readonly string sql_FIND_ALL_COUNTRIES = "select Country.id, Country.[name] from Country;";

        private readonly string sql_INSERT_ENTERTAINMENT = "insert into Entertainment(title, country_id, language_id, releaseDate, storyline, information) output inserted.id values (@title, @country_id, @language_id, @releaseDate, @storyline, @information);";
        private readonly string sql_INSERT_MOVIE = "insert into Movie(entertainment_id) values (@entertainment_id);";
        private readonly string sql_INSERT_ENTERTAINMENTGENRE = "insert into EntertainmentGenre (entertainment_id, genre_id) values (@entertainment_id, @genre_id);";
        private readonly string sql_INSERT_ENTERTAINMENTFILMINGLOCATION = "insert into EntertainmentFilmingLocation (entertainment_id, filmingLocation_id) values (@entertainment_id, @filmingLocation_id);";

        

        //private readonly string sql_FIND_MOVIE_ENTERTAINMENT = "select * from Entertainment, Movie where Movie.entertainment_id = Entertainment.id;";
        //private readonly string sql_FIND_SERIES_ENTERTAINMENT = "select * from Entertainment, Series where Series.entertainment_id = Entertainment.id;";

        private SqlCommand findAllEntertainments;
        private SqlCommand findAllPrivateEntertainments;
        private SqlCommand findAllGenres;
        private SqlCommand findAllFilmingLocations;
        private SqlCommand findAllLanguages;
        private SqlCommand findAllCountries;
        private SqlCommand insertEntertainment;
        private SqlCommand insertMovie;
        private SqlCommand insertEntertainmentGenre;
        private SqlCommand insertEntertainmentFilmingLocation;
        

        private SqlConnection con;

        public EntertainmentDB()
        {
            con = DBConnection.GetInstance().GetConnection();
            findAllEntertainments = con.CreateCommand();
            findAllPrivateEntertainments = con.CreateCommand();
            findAllGenres = con.CreateCommand();
            findAllFilmingLocations = con.CreateCommand();
            findAllLanguages = con.CreateCommand();
            findAllCountries = con.CreateCommand();
            insertEntertainment = con.CreateCommand();
            insertMovie = con.CreateCommand();
            insertEntertainmentGenre = con.CreateCommand();
            insertEntertainmentFilmingLocation = con.CreateCommand();
        }

        public List<Entertainment> GetAllEntertainments()
        {
            findAllEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT;
            List<Entertainment> temp = GetEntertainments(findAllEntertainments);
            return temp;
        }

        public List<Entertainment> GetPersonalEntertainments(int id)
        {
            SqlParameter parameter = new SqlParameter
            {
                ParameterName = "@id",
                Value = id
            };

            findAllPrivateEntertainments.Parameters.Add(parameter);
            findAllPrivateEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT_ON_FAVORITELIST;
            List<Entertainment> temp = GetEntertainments(findAllPrivateEntertainments);
            return temp;
        }

        private List<Entertainment> GetEntertainments(SqlCommand sqlCommand)
        {
            List<Entertainment> temp = new List<Entertainment>();

            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Entertainment e = new Entertainment
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Title = reader.GetString(reader.GetOrdinal("title")),
                    ReleaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate")),
                };

                temp.Add(e);

            }
            Console.WriteLine(temp.Count() + " This is tested in EntertainmentDB");
            reader.Close();
            return temp;
        }

        public List<Genre> GetAllGenres()
        {
            findAllGenres.CommandText = sql_FIND_ALL_GENRE;
            List<Genre> temp = new List<Genre>();
            SqlDataReader reader = findAllGenres.ExecuteReader();
            while (reader.Read())
            {
                Genre g = new Genre
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id)")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(g);
            }

            return temp;
        }

        public List<FilmingLocation> GetALLFilmingLocations()
        {
            findAllFilmingLocations.CommandText = sql_FIND_ALL_FILMINLOCATION;
            List<FilmingLocation> temp = new List<FilmingLocation>();
            SqlDataReader reader = findAllFilmingLocations.ExecuteReader();
            while (reader.Read())
            {
                FilmingLocation fL = new FilmingLocation
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id)")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(fL);
            }
            return temp;
        }

        public List<Language> GetAllLanguages()
        {
            findAllLanguages.CommandText = sql_FIND_ALL_LANGUAGE;
            List<Language> temp = new List<Language>();
            SqlDataReader reader = findAllLanguages.ExecuteReader();
            while (reader.Read())
            {
                Language l = new Language
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id)")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(l);
            }
            return temp;
        }

        public List<Country> GetAllCountries()
        {
            findAllCountries.CommandText = sql_FIND_ALL_COUNTRIES;
            List<Country> temp = new List<Country>();
            SqlDataReader reader = findAllCountries.ExecuteReader();
            while (reader.Read())
            {
                Country c = new Country
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id)")),
                    Name = reader.GetString(reader.GetOrdinal("name")),
                };
                temp.Add(c);
            }
            return temp;
        }

        public void StartInsertMovieTransaction(Movie m)
        {
            TransactionOptions to = new TransactionOptions
            {
                IsolationLevel = IsolationLevel.ReadUncommitted
            };
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew, to))
            {
                int insertedId = InsertEntertainment(m);
                InsertMovie(insertedId, m);
                InsertEntertainmentGenre(insertedId, m);
                InsertEntertainmentFilmingLocation(insertedId, m);

                scope.Complete();
            }
            
        }

        private int InsertEntertainment(Movie m)
        {
            int insertedId = -1;
            //insert Entertainment - (title, country_id, language_id, releaseDate, storyline, information)
            insertEntertainment.CommandText = sql_INSERT_ENTERTAINMENT;
            insertEntertainment.Parameters.AddWithValue("@title", m.title);
            insertEntertainment.Parameters.AddWithValue("@country_id", m.country);
            insertEntertainment.Parameters.AddWithValue("@language_id", m.language);
            insertEntertainment.Parameters.AddWithValue("@releasDate", m.releaseDate);
            insertEntertainment.Parameters.AddWithValue("@storyline", m.storyline);
            insertEntertainment.Parameters.AddWithValue("@information", m.information);
            insertedId = (int)insertEntertainment.ExecuteScalar();
            return insertedId;
        }

        private void InsertMovie(int insertedId, Movie m)
        {
            //insert Movie - (entertainment_id)
            insertMovie.CommandText = sql_INSERT_MOVIE;
            insertMovie.Parameters.AddWithValue("@entertainment_id", insertedId);
            insertMovie.ExecuteNonQuery();
        }

        private void InsertEntertainmentGenre(int insertedId, Movie m)
        {
            //insert EntertainmentGenre - (entertainment_id, genre_id)
            insertEntertainmentGenre.CommandText = sql_INSERT_ENTERTAINMENTGENRE;
            insertEntertainmentGenre.Parameters.AddWithValue("@entertainment_id", insertedId);
            insertEntertainmentGenre.Parameters.AddWithValue("@genre_id", m.genre);
            insertEntertainmentGenre.ExecuteNonQuery();
        }

        private void InsertEntertainmentFilmingLocation(int insertedId, Movie m)
        {
            //insert EntertainmentFilmingLocation - (entertainment_id, filmingLocation_id)
            insertEntertainmentFilmingLocation.CommandText = sql_INSERT_ENTERTAINMENTFILMINGLOCATION;
            insertEntertainmentFilmingLocation.Parameters.AddWithValue("@entertainment_id", insertedId);
            insertEntertainmentFilmingLocation.Parameters.AddWithValue("@filmingLocation_id", m.filmingLocation);
            insertEntertainmentFilmingLocation.ExecuteNonQuery();
        }

        

        //public List<Entertainment> GetEntertainments()
        //{
        //    List<Entertainment> temp = new List<Entertainment>();
        //    findAllEntertainments.CommandText = sql_FIND_ALL_ENTERTAINMENT;
        //    SqlDataReader reader = findAllEntertainments.ExecuteReader();
        //    while (reader.Read())
        //    {
        //        Entertainment e = new Entertainment
        //        {
        //            //genre = reader.GetString(reader.GetOrdinal("genre")),
        //            genre = "Action",
        //            title = reader.GetString(reader.GetOrdinal("title")),
        //            country = reader.GetString(reader.GetOrdinal("country")),
        //            language = reader.GetString(reader.GetOrdinal("language")),
        //            releaseDate = reader.GetDateTime(reader.GetOrdinal("releaseDate")),
        //            storyLine = reader.GetString(reader.GetOrdinal("storyLine")),
        //            //filmingLocation = reader.GetString(reader.GetOrdinal("filmingLocation")),
        //            filmingLocation = "Some place in the desert",
        //            information = reader.GetString(reader.GetOrdinal("information"))
        //        };

        //        temp.Add(e);

        //    }
        //    Console.WriteLine(temp.Count());
        //    Console.ReadLine();
        //    reader.Close();
        //    return temp;
        //}


        // Setup connection to database
        // Instantiate SqlConnection object with connectionstringcon = new SqlConnection(connectionString);
        // Write SQL query
        // Instantiate SqlCommand object with query string and SqlConnection objectstring queryString = "select * from tblProduct Order by name";SqlCommand readCommand = new SqlCommand(queryString, con);
        // Open connection con.Open();
        // Execure SqlCommand and assign read data to a SqlDataReader objectSqlDataReader productReader = readCommand.ExecuteReader();
        // Use data for the reader
        // E.g. convert read "rows" to domain objectint foundRows = PopulateProductList(productReader);
        // Close used resourcesproductReader.Close();

    }
}