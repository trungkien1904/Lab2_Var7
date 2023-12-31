using Lab2_Var7.Application.Interfaces;
using Lab2_Var7.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Presentation.Scenarios;

internal class GetAllMusics : IScenario
{
    private readonly IMusicService musicService;
    public GetAllMusics(IMusicService musicService)
    {
        this.musicService = musicService;
    }

    public void Run()
    {
        IEnumerable<Music> output = musicService.GetAllMusics();
        foreach (Music item in output)
        {
            Console.WriteLine($"{item.ArtistName} - {item.Title}");
        }
    }
}

