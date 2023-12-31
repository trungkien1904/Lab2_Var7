using Lab2_Var7.Application.Interfaces;
using Lab2_Var7.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Presentation.Scenarios;

public class SearchMusic : IScenario
{
    private readonly IMusicService musicService;
    public SearchMusic(IMusicService musicService)
    {
        this.musicService = musicService;
    }

    public void Run()
    {
        Console.Write("Input author's name or title: ");
        string? input =  Console.ReadLine();

        if (input == null) throw new ArgumentNullException(nameof(input));

        IEnumerable<Music> output = musicService.SearchMusic(input);

        foreach ( var item in output )
        {
            Console.WriteLine($"{item.ArtistName} - {item.Title}");
        }
    }
}
