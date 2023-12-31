using Lab2_Var7.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Application.Interfaces;

public interface IMusicService
{
    void AddMusic(Music music);
    void RemoveMusic(Music music);
    IEnumerable<Music> SearchMusic(string request);
    IEnumerable<Music> GetAllMusics();
}
