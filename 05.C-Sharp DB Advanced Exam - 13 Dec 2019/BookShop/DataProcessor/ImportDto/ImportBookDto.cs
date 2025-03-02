﻿using BookShop.Data.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;

namespace BookShop.DataProcessor.ImportDto
{
    [XmlType("Book")]
    public class ImportBookDto
    {
        [Required]
        [XmlElement("Name")]
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }

        [EnumDataType(typeof(Genre))]
        [XmlElement("Genre")]
        [Range(1, 3)]
        public int Genre { get; set; }

        [XmlElement("Price")]
        [Range(typeof(decimal), "0.01", "79228162514264337593543950335")]
        public decimal Price { get; set; }

        [XmlElement("Pages")]
        [Range(50, 5000)]
        public int Pages { get; set; }

        [Required]
        [XmlElement("PublishedOn")]
        public string PublishedOn { get; set; }
    }
}
//Id - integer, Primary Key
//Name - text with length [3, 30]. (required)
//Genre - enumeration of type Genre, with possible values (Biography = 1, Business = 2, Science = 3) (required)
//Price - decimal in range between 0.01 and max value of the decimal
//Pages – integer in range between 50 and 5000
//PublishedOn - date and time (required)
//AuthorsBooks - collection of type AuthorBook