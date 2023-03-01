using System; 
using Raylib_cs;
using static Raylib_cs.Raylib; 


public class Song {  

    public Song(string newSongTitle, float newSongLength, string newFilePath, string newArtist) {
        songTitle = newSongTitle; 
        songLength = newSongLength;
        filePath = newFilePath; 
        artist = newArtist; 
    }
    
    private string songTitle {get; set;}  
    private float songLength {get; set;}

    private int plays {get; set;} 

    private string artist {get; set;} 
    private string filePath {get; set;}

    public string getSongTitle() {
        return songTitle; 
    }

    public string getFilePath() {
        return filePath; 
    }

    public float getSongLength() {
        return songLength;
    }

    public string getArtist() {
        return artist; 
    }

}