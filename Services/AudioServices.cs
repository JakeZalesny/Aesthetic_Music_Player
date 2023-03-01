using System; 
using Raylib_cs; 
using static Raylib_cs.Raylib; 

class AudioServices {
    private bool pause = false; 
    private bool play = true; 
    private bool skip; 

    private Music music; 

    float timePlayed = 0.0f; 

    public AudioServices() {}
    public void pauseSong() {
        pause = true;
        play = false; 
        PauseMusicStream(music); 
    }

    public void resumeSong() {
        pause = false; 
        play = true;
        ResumeMusicStream(music);
    }

    public void initDevices() {
        InitAudioDevice(); 

        //music = LoadMusicStream(filePath);
        //PlayMusicStream(music);
    }

    public void setMusicStream(string filePath) {
        music = LoadMusicStream(filePath);
    }

    public float getTimePlayed() {
        return timePlayed; 
    }

    public void resetTimePlayed() {
        timePlayed = 0.0f; 
    }

    public void updateMusicStream(string filePath) {
        UpdateMusicStream(music);
    }

    public void playSong() {
        //UpdateMusicStream(music);
        PlayMusicStream(music);
        timePlayed += (float)(1.0f / 60.0f);
        //Console.WriteLine(timePlayed); 
    }

    public void stopSong() {
        StopMusicStream(music);
    }

}