using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Domain.Models;

public class Music
{
    public Music(string artistName, string title)
    {
        ArtistName = artistName;
        Title = title;
    }
    public int Id { get; set; }
    [Required]
    public string ArtistName { get; set; }

    [Required]
    public string Title { get; set; }
}
