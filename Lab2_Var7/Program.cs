using Lab2_Var7.Application.Interfaces;
using Lab2_Var7.Application.Services;
using Lab2_Var7.Domain.Repository;
using Lab2_Var7.Infrastructure.InAppDatabase;
using Lab2_Var7.Infrastructure.InAppDatabase.Repository;
using Lab2_Var7.Presentation;

public static class Program
{
    public static void Main(String[] args)
    {
        IMusicRepository musicRepository = new InAppMusicRepository(new MusicDatabase());

        IMusicService musicService = new MusicService(musicRepository);

        View view = new(musicService);

        view.Run();
    }
}