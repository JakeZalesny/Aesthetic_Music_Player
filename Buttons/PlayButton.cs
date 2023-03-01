using System; 
using Raylib_cs; 
using static Raylib_cs.Raylib; 

public class PlayPauseButton : Button {
    public static Texture2D UI = LoadTexture("IMGS/button UI.png");
    public Rectangle frameRec = new Rectangle(0.0f, 0.0f, (float)UI.width / 12, (float)UI.height / 12);
    public PlayPauseButton() {} 
    public override void onPress() {

    }
}