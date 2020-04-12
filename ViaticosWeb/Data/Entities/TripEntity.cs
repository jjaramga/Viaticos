﻿using Soccer.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ViaticosWeb.Data.Entities
{
    public class TripEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Start Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime StartDateLocal => StartDate.ToLocalTime();

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "End Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = false)]
        public DateTime EndDateLocal => EndDate.ToLocalTime();

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public CityEntity City { get; set; }

        public ICollection<TripDetailEntity> TripDetails { get; set; }

        [DataType(DataType.Currency)]
        public decimal TotalAmount => TripDetails.Sum(x => x.Amount);

        public UserEntity User { get; set; }


    }
}
