using System;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory music = new Directory("MUSIC");
            Directory scorpions = new Directory("SCORPIONS");
            Directory dio = new Directory("DIO");
            MusicFile track1 = new MusicFile("Don't wary, be happy.mp3");
            MusicFile track2 = new MusicFile("track2.m3u");
            MusicFile track3 = new MusicFile("Wind of change.mp3");
            MusicFile track4 = new MusicFile("Big city night.mp3");
            MusicFile track5 = new MusicFile("Rainbow in the dark.mp3");
            music.Add(track1);
            music.Add(scorpions);
            music.Add(track2);
            scorpions.Add(track3);
            scorpions.Add(track4);
            scorpions.Add(dio);
            dio.Add(track5);
            music.DisplayName();

            Console.ReadKey();
        }
    }
}
