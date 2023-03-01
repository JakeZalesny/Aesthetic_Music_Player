using System; 
using Raylib_cs;
using static Constants;  
using static Raylib_cs.Raylib; 

public class Playlist {
    private Queue<Song> playlist = new Queue<Song>(Constants.availableSongs);

    public Playlist() {}

    public void addNewSong(Song newSong) {
        playlist.Enqueue(newSong);
    }

    public Song getCurrentSong() {
        //TODO 1: figure out a way to get the queue to return the first song in the queue
        //and then stick it in the back of the queue. 
        var currentSong = playlist.Dequeue();
        playlist.Enqueue(currentSong); 
        return currentSong; 
    } 

    public Queue<Song> getQueue() {
        return playlist; 
    }

    public bool isSongOver(float currentTime) {
        //TODO 2: Figure out if the song is done or not using the queue!
        // HINT: You may need to call a method in this class
        
        var currentSong = getCurrentSong(); 
        if(currentTime == currentSong.getSongLength()) {
            return true; 
        }

        else {
            return false; 
        }

    }
}