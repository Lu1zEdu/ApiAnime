using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using API.Domain.Enum;

namespace API.DTO;

[Table("Anime")]
public class AnimeDto
{
    
    public Guid IdAnime { get; set; }
    public string NameJapanese { get; set; }
    public string NameEnglish { get; set; }
    public string NamePortugues { get; set; }
    public string Synopsis { get; set; }
    public string Synonyms { get; set; }
    public int Episodes { get; set; }
    public int DurationEps { get; set; }
    public DateTime DateStar { get; set; }
    public DateTime DateEnd { get; set; }
    public List<Genres> Genres { get; set; }
    public List<Studios> Producers { get; set; }
    public List<string> Studios { get; set; }
    public Demographic Demographic { get; set; }
    public Source Source { get; set; }
    public Rating Rating { get; set; }
    public Status Status { get; set; }
    public Season Season { get; set; }
    public TypeDisplay TypeDisplay { get; set; }
}