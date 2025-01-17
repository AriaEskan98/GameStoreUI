﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using GameStore.Frontend.Converters;
using StringConverter = GameStore.Frontend.Converters.StringConverter;


namespace GameStore.Frontend.Models
{
    public class GameDetails
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public required string Name { get; set; }
        [Required(ErrorMessage ="The Genre Field is required")]
        [JsonConverter(typeof(StringConverter))]
        public string? GenreId { get; set; }
        [Required]
        [Range(1, 200)]
        public decimal Price { get; set; }
        public DateOnly ReleaseDate { get; set; }


    }
}
