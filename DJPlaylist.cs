using System; 
using Raylib_cs; 
using static Raylib_cs.Raylib; 

public class DJPlaylist {
    private HashSet<int> DJSet = new HashSet<int>();

    private List<Song> availableSongs;

    private Dictionary<int, Song> memory = new Dictionary<int, Song>();  

    public DJPlaylist(List<Song> newAvailableSongs) {
        availableSongs = newAvailableSongs; 
    }

    public void addToPlaylist() {
        //TODO 1: create a hashing algorithm for the sets and store the HashCode & Song in a dictionary!
        foreach(var song in availableSongs) {
            int index = song.GetHashCode() % 10;
            DJSet.Add(index);
            memory.Add(index, song);

        }
    }

    public HashSet<int> getDJSet() {
        return DJSet; 
    }

    public Song getCurrentSong() {
        foreach(var item in DJSet) {
            if(memory.Keys.Contains(item)) {
                var currentSong = memory[item];
                DJSet.Remove(item);
                memory.Remove(item);
                return currentSong; 
            }

            else {
                Console.WriteLine("HASH ERROR: Index not found");
                return memory[0];
            }
        }
        Console.WriteLine("ERROR: HashSet not looping");
        return memory[0];
    }

    public bool playDJSet() {
        if(IsKeyPressed(Raylib_cs.KeyboardKey.KEY_H)) {
            return true;
        }

        else {
            return false; 
        }
    }

}