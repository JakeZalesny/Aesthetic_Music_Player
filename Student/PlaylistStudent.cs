using System; 
using Raylib_cs;
using static Constants;  
using static Raylib_cs.Raylib; 

public class PlaylistStudent {
    private Queue<Song> playlist = new Queue<Song>(Constants.availableSongs);

    public PlaylistStudent() {}

    public void addNewSong(Song newSong) {
        playlist.Enqueue(newSong);
    }

    //uncomment when ready
    //public Song getCurrentSong() {
        //TODO 1: figure out a way to get the queue to return the first song in the queue
        //and then stick it in the back of the queue. 
        //return currentSong; 
    //} 

    public Queue<Song> getQueue() {
        return playlist; 
    }

    public bool isSongOver(float currentTime) {
        //TODO 2: Figure out if the song is done or not using the queue!
        // HINT: You will need a song to do this, try calling a method in this class to get one
        return true; 
    }
}