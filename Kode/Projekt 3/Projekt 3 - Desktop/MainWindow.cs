﻿using Projekt_3___Desktop.Controller;
using Projekt_3___Desktop.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Projekt_3___Desktop
{
    public partial class MainWindow : Form
    {
        private DesktopController DC;


        public MainWindow()
        {
            InitializeComponent();
            DC = new DesktopController();
            GetData();
        }



        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            CreateMovie();

            //reset vinduet
            //spørge om vi er sikker
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void CreateMovie()
        {
            string title = txtTitle.Text;
            int genre_id = 0;
            string genre_name = "";
            int country_id = 0;
            string country_name = "";
            int language_id = 0;
            string language_name = "";

            try
            {
                ComboBoxItem comboBoxItem = (ComboBoxItem)cbBoxGenre.SelectedItem;
                genre_id = comboBoxItem.HiddenValue;
                genre_name = comboBoxItem.DisplayValue;
                lblGenreFault.Text = "";
            }
            catch (Exception)
            {
                genre_id = 0;
                lblGenreFault.Text = "Please choose a valid Genre";

            }
            
            try
            {
                ComboBoxItem comboBoxItem = (ComboBoxItem)cbBoxCountry.SelectedItem;
                country_id = comboBoxItem.HiddenValue;
                country_name = comboBoxItem.DisplayValue;
                lblCountryFault.Text = "";
            }
            catch (Exception)
            {
                country_id = 0;
                lblCountryFault.Text = "Please choose a valid Country";
            }
            
            try
            {
                ComboBoxItem comboBoxItem = (ComboBoxItem)cbBoxLanguage.SelectedItem;
                language_id = comboBoxItem.HiddenValue;
                language_name = comboBoxItem.DisplayValue;
                lblLanguageFault.Text = "";
            }
            catch (Exception)
            {
                language_id = 0;
                lblLanguageFault.Text = "Please choose a valid Language";
            }
            
            string storyline = txtStoryline.Text;
            string filmingLocation = txtFilmingLocation.Text;
            string information = txtInformation.Text;
            bool isMovie = true;
            if (title != "" && storyline != "" && information != "" && filmingLocation !="" && genre_id > 0 && country_id > 0 && language_id > 0)
            {
                try
                {
                    DateTime date = DateTime.ParseExact(txtReleaseDate.Text, "dd-MM-yyyy", null);

                    DC.InsertMovieIntoEntertainment(genre_id, genre_name, title, country_id, country_name, language_id, language_name, date, storyline, filmingLocation, information, isMovie);
                    ClearMovie();
                    MessageBox.Show("Your movie is saved!");
                }
                catch (Exception)
                {
                    lblDateFormat.Text = "Date format is not correctly written: dd-MM-yyyy";
                }
            }
            else
            {
                MessageBox.Show("Please fill all information!");
            }

        }


        private void ClearMovie()
        {
            txtTitle.Clear();
            cbBoxGenre.ResetText();
            cbBoxCountry.ResetText();
            cbBoxLanguage.ResetText();
            txtReleaseDate.Clear();
            txtStoryline.Clear();
            txtFilmingLocation.Clear();
            txtInformation.Clear();

        }


        private void GetData()
        {
            GetGenre();
            GetCountry();
            GetLanguage();
            //GetFilmingLocation();
        }

        private void GetGenre()
        {
            List<Genre> g = DC.GetGenre();
            if (g != null)
            {
                foreach (Genre item in g)
                {
                    int id = item.Id;
                    string name = item.Name;
                    cbBoxGenre.Items.Add(new ComboBoxItem(name, id));

                }
            }


        }

        private void GetCountry()
        {
            List<Country> c = DC.GetCountry();
            if (c != null)
            {
                foreach (Country country in c)
                {
                    int id = country.Id;
                    string name = country.Name;
                    cbBoxCountry.Items.Add(new ComboBoxItem(name, id));
                }
            }

        }

        private void GetLanguage()
        {
            List<Language> l = DC.GetLanguage();
            if (l != null)
            {
                foreach (Language language in l)
                {
                    int id = language.Id;
                    string name = language.Name;
                    cbBoxLanguage.Items.Add(new ComboBoxItem(name, id));
                }
            }

        }

        //private void GetFilmingLocation()
        //{
        //    List<FilmingLocation> f = DC.GetFilmingLocation();
        //    if (f != null)
        //    {
        //        foreach (FilmingLocation film in f)
        //        {
        //            int id = film.Id;
        //            string name = film.Name;
        //            cbBoxFilmingLocation.Items.Add(new ComboBoxItem(name, id));
        //        }
        //    }

        //}


    }
}
