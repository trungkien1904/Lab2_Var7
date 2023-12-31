using Lab2_Var7.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Var7.Infrastructure.InAppDatabase;

public class MusicDatabase
{
    public List<Music> MusicDb { get; }
    public MusicDatabase()
    {
        MusicDb = new List<Music>();
    }
}
