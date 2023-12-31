using Lab2_Var7.Application.Interfaces;
using Lab2_Var7.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Presentation.Scenarios;

public class AddMusic : IScenario
{
    private readonly IMusicService musicService;
    public AddMusic(IMusicService musicService)
    {
        this.musicService = musicService;
    }

    public void Run()
    {
        Console.Write("Input author's name: ");
        string? authorName = Console.ReadLine();
        if (authorName == null) throw new ArgumentNullException(nameof(authorName));

        Console.Write("Input title: ");
        string? title = Console.ReadLine();
        if (title == null) throw new ArgumentNullException(nameof(title));


        musicService.AddMusic(new Music(authorName, title));
    }
}
