﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WyszukiwarkaLotówDR.Loty
{
    public class Lot
    {
        
        public int idLotu { get; set; }
        [Display(Name="Czas wylotu")]
        public DateTime czasWylotu { get; set; }
        public DateTime czasPrzylotu { get; set; }
        [Display(Name = "Miejsce wylotu")]
        public string miejsceWylotu { get; set; }
        public string miejscePrzylotu { get; set; }
        public string kodLotniskaWylotu { get; set; }
        public string kodLotniskaPrzylotu { get; set; }
        [Display(Name = "Cena biletu")]
        public double cenaBiletu { get; set; }
        public int iloscMiejsc { get; set; }
        public Lot() { }
        public Lot(int id, DateTime czasW, DateTime czaP, string miejsceW, string miejsceP, string kodLW, string kodLP, double cena, int ilosc)
        {
            this.idLotu = id;
            this.czasWylotu = czasW;
            this.czasPrzylotu = czaP;
            this.miejsceWylotu = miejsceW;
            this.miejscePrzylotu = miejsceP;
            this.kodLotniskaWylotu = kodLW;
            this.kodLotniskaPrzylotu = kodLP;
            this.cenaBiletu = cena;
            this.iloscMiejsc = ilosc;

        }
    }
}
