public class Constants {
    public static string[] first_background = new string[3] {"IMGS/far-buildings_rs_cyber.png", "IMGS/back-buildings_rs_cyber.png", "IMGS/foreground_rs_cyber.png"};

    public static string[] second_background = new string[3] {"IMGS/cyberpunk-street-files/Version 2/Layers/back.png", 
    "IMGS/cyberpunk-street-files/Version 2/Layers/middle.png", 
    "IMGS/cyberpunk-street-files/Version 2/Layers/foreground.png"};

    public static ParallaxBackground firstParallax = new ParallaxBackground(first_background);


    public static Song graveyard = new Song("GRAVEYARD PARADISE", 139.0f, "Songs/GRAVEYARD_PARADISE.mp3", "Cole Del Montey");

    public static Song itily = new Song("i think i like you", 165.0f, "Songs/i think i like you.mp3", "Cole Del Montey");

    public static Song scars = new Song("scars", 151.0f, "Songs/scars.mp3", "Cole Del Montey");

    public static Song Nerves = new Song("Nerves", 149.0f, "Songs/(FREE) XXXTENTACION X JOEY BADASS TYPE BEAT - NERVES.mp3", "Ludwig");

    public static Song pureImagination = new Song("Pure Imagination", 12.0f, "Songs/Shiloh Dynasty- Pure Imagination.mp3", "Shiloh Dynasty");

    public static Song ONETHOUSANDMILES = new Song("1000 MILES", 116.0f, "Songs/ARIES - 1000 MILES (full unreleased cover).mp3", "Aries");

    public static Song SNAKEEYES = new Song("SNAKE EYES", 132.0f, "Songs/Aries - SNAKE EYES [Extended].mp3", "Aries");

    public static Song SuicideBomber = new Song("Suicide Bomber", 121.0f, "Songs/Aries - Suicide Bomber (HQ).mp3", "Aries"); 

    public static Song GONEHOME = new Song("GONE HOME", 141.0f, "Songs/Nostaji - GONE HOME (Audio).mp3", "Nostaji");

    public static List<Song> availableSongs = new List<Song>() {graveyard, itily, scars, Nerves, pureImagination};
    public static List<Song> secondAvailableSongs = new List<Song>() {ONETHOUSANDMILES, SNAKEEYES, SuicideBomber, GONEHOME};

    public static Dictionary<string, int> analytics = new Dictionary<string, int>() 
    {{"GRAVEYARD PARADISE", 7}, {"scars", 12}, {"Pure Imagination", 3}, {"i think i like you", 8}, 
    {"Nerves", 9}, {"1000 MILES", 15}, {"SNAKE EYES", 4}, {"Suicide Bomber", 5}, {"GONE HOME", 20}};

    // Adding a comment here to see if it pushes right

    

}