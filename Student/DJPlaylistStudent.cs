using System; 
using Raylib_cs; 
using static Raylib_cs.Raylib; 

public class DJPlaylistStudent {
    private HashSet<int> DJSet = new HashSet<int>();

    private List<Song> availableSongs;

    private Dictionary<int, Song> memory = new Dictionary<int, Song>();  

    public DJPlaylistStudent(List<Song> newAvailableSongs) {
        availableSongs = newAvailableSongs; 
    }

    public void addToPlaylist() {
        //TODO 1: create a hashing algorithm for the sets and store the HashCode in the Hash set 
        //as well as the HashCode & Song in a dictionary!
    }


    public HashSet<int> getDJSet() {
        return DJSet; 
    }

    //public Song getCurrentSong() {
        //TODO 2: Get the current song!
        // HINT: You will need to iterate through the HashSet and identify the song through the Dictionary!
    //}

    public bool playDJSet() {
        if(IsKeyPressed(Raylib_cs.KeyboardKey.KEY_H)) {
            return true;
        }

        else {
            return false; 
        }
    }

}