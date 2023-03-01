using System;
using Raylib_cs; 
using static Raylib_cs.Raylib;  
using final_project_JakeZalesny.Services; 

public class Director {
    OutputServices output = new OutputServices();
    AudioServices audio = new AudioServices(); 

    Playlist playlist = new Playlist(); 

    BinarySearchTree tree = new BinarySearchTree();

    DJPlaylist dj = new DJPlaylist(Constants.secondAvailableSongs); 

    private bool analytics = true; 
    public Director() {}

    public void run() { 
        output.openWindow();
        var currentSong = playlist.getCurrentSong(); 
        audio.initDevices();
        audio.setMusicStream(currentSong.getFilePath());
        output.loadTexturesOut(Constants.firstParallax);
        dj.addToPlaylist(); 
        foreach(var key in Constants.analytics.Keys) {
            tree.Insert(Constants.analytics[key]);
            Console.WriteLine(key);
        }

        Console.WriteLine(tree.ToString());

        while(!WindowShouldClose()) {
            output.beginDrawing();
            output.drawParallax(Constants.firstParallax);
            output.drawSongTitle(currentSong);
            output.drawArtistName(currentSong);
            output.drawInstructions();
            audio.updateMusicStream(currentSong.getFilePath());
            audio.playSong(); 
            
            var timePlayed = audio.getTimePlayed();
            if(dj.playDJSet()) {
                Console.WriteLine("Now Playing: ");
                audio.stopSong();
                audio.resetTimePlayed();
                currentSong = dj.getCurrentSong(); 
                audio.setMusicStream(currentSong.getFilePath());
                audio.updateMusicStream(currentSong.getFilePath());
                audio.playSong();
            }

            if(timePlayed >= currentSong.getSongLength() && dj.playDJSet()) {
                Console.WriteLine("Next Song: ");
                audio.stopSong(); 
                currentSong = dj.getCurrentSong();
                audio.setMusicStream(currentSong.getFilePath());
                audio.updateMusicStream(currentSong.getFilePath());
                audio.playSong();
                audio.resetTimePlayed();
            } 
            
            else if(timePlayed >= currentSong.getSongLength() && !dj.playDJSet()) {
                audio.stopSong(); 
                currentSong = playlist.getCurrentSong();
                audio.setMusicStream(currentSong.getFilePath());
                audio.updateMusicStream(currentSong.getFilePath());
                audio.playSong();
                audio.resetTimePlayed();  
            }

            if(analytics) {
                output.drawAnalytics(tree);
            }
        }
    }   
        //output.shouldClose();
        //InitAudioDevice(); 
        //Music music = LoadMusicStream("C:/Users/jrzal/Desktop/CSE-212/final-project-JakeZalesny/Songs/GRAVEYARD_PARADISE.mp3");
        //PlayMusicStream(music);
}