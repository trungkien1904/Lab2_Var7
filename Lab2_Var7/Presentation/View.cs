using Lab2_Var7.Application.Interfaces;
using Lab2_Var7.Presentation.Scenarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Presentation;

public class View
{
    private readonly IMusicService musicService;
    public View(IMusicService musicService)
    {
        this.musicService = musicService;
    }
    public void Run()
    {
        bool running = true;
        PrintUsage();
        while (running)
        {
            Console.Write("> ");
            var input = Console.ReadLine();
            if (input == null) continue;
            input = input.Trim();

            IScenario? scenario = null;

            switch (input)
            {
                case "add":
                    scenario = new AddMusic(musicService);
                    break;
                case "del":
                    scenario = new RemoveMusic(musicService);
                    break;
                case "search":
                    scenario = new SearchMusic(musicService);
                    break;
                case "list":
                    scenario = new GetAllMusics(musicService);
                    break;
                case "quick":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }
            if (scenario != null) scenario.Run();
        }
    }

    private void PrintUsage()
    {
        string usage =
        """
        Usage:
            Type one of commands:
                'list' to display all item of catalog
                'search' to go find items in catalog
                'add' to add new item
                'del' to remove some item from list
                'quick' to exit
        """;
        Console.WriteLine(usage);
    }
}
