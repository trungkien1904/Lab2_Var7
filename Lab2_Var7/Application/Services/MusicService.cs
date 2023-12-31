using Lab2_Var7.Application.Interfaces;
using Lab2_Var7.Domain.Models;
using Lab2_Var7.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Application.Services;

public class MusicService : IMusicService
{
    private readonly IMusicRepository musicRepository;
    public MusicService(IMusicRepository musicRepository)
    {
        this.musicRepository = musicRepository;
    }

    public void AddMusic(Music music)
    {
        musicRepository.AddMusic(music);
    }

    public void RemoveMusic(Music music)
    {
        musicRepository.DeleteMusic(music);
    }

    public IEnumerable<Music> SearchMusic(string request)
    {
        return musicRepository.SearchMusic(request);
    }

    public IEnumerable<Music> GetAllMusics()
    {
        return musicRepository.GetAllMusics();
    }
}
