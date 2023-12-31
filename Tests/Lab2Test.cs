using Lab2_Var7.Application.Services;
using Lab2_Var7.Domain.Models;
using Lab2_Var7.Domain.Repository;
using Lab2_Var7.Infrastructure.InAppDatabase;
using Lab2_Var7.Infrastructure.InAppDatabase.Repository;
using Xunit;

namespace Tests;

public class Lab2Test
{
    private MusicDatabase musicDatabase;
    private IMusicRepository musicRepository;
    private MusicService musicService;
    public Lab2Test()
    {
        musicDatabase = new MusicDatabase();
        musicRepository = new InAppMusicRepository(musicDatabase);
        musicService = new MusicService(musicRepository);
    }

    [Fact]
    public void TestAddMusic()
    {
        var music = new Music("ABC", "ABSSSS");
        musicService.AddMusic(music);

        Assert.Single(musicDatabase.MusicDb);
        Assert.Contains(music, musicDatabase.MusicDb);
    }

    [Fact]
    public void TestRemoveMusic()
    {
        var music = new Music("ABC", "ABSSSS");
        musicService.AddMusic(music);
        musicService.RemoveMusic(music);

        Assert.Empty(musicDatabase.MusicDb);
        Assert.DoesNotContain(music, musicDatabase.MusicDb);
    }

    [Fact]
    public void TestSearchMusic()
    {
        var music = new Music("ABC", "ABSSSS");
        musicService.AddMusic(music);

        string request = "ABC";
        var result = musicService.SearchMusic(request);

        Assert.Equal(result, new List<Music>() { music });
    }
}
