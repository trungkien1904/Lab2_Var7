using Lab2_Var7.Domain.Models;
using Lab2_Var7.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Infrastructure.InAppDatabase.Repository;

public class InAppMusicRepository : IMusicRepository
{
    private readonly MusicDatabase musicDatabase;
    public InAppMusicRepository(MusicDatabase musicDatabase)
    {
        this.musicDatabase = musicDatabase;
    }

    public void AddMusic(Music music)
    {
        musicDatabase.MusicDb.Add(music);
    }

    public void DeleteMusic(Music music)
    {
        var removedMusic = musicDatabase.MusicDb.Where(m => m.ArtistName == music.ArtistName && m.Title == music.Title).First();
        if (removedMusic != null)
        {
            musicDatabase.MusicDb.Remove(removedMusic);
        }
    }

    public IEnumerable<Music> GetAllMusics()
    {
        return musicDatabase.MusicDb;
    }

    public IEnumerable<Music> SearchMusic(string request)
    {
        return musicDatabase.MusicDb.Where(music => music.ArtistName == request || music.Title == request);
    }
}
