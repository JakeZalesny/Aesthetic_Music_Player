using System; 
using Raylib_cs; 
using static Raylib_cs.Raylib; 

public class ParallaxBackground {
    public ParallaxBackground(string[] backgroundContainer ) {
        backgrounds = backgroundContainer; 
    }

    private string[] backgrounds {get; set;}

    private Texture2D foreground; 

    private Texture2D background; 

    private Texture2D farground; 

    private float scrollingFar = 0.0f; 
    private float scrollingBack = 0.0f; 
    private float scrollingFore = 0.0f; 

    public void loadTextures() {
        farground = LoadTexture(backgrounds[0]);
        background = LoadTexture(backgrounds[1]);
        foreground = LoadTexture(backgrounds[2]);
    }

    public Texture2D getFarground() {
        return farground; 
    }

    public Texture2D getBackground() {
        return background; 
    }

    public Texture2D getForeground() {
        return foreground; 
    }

    public float getScrollingFar() {
        return scrollingFar;
    }

    public float getScrollingBack() {
        return scrollingBack; 
    }

    public float getScrollingFore() {
        return scrollingFore; 
    }

    public void calculateParallax() {
        scrollingFar -= 0.1f;
        scrollingBack -= 0.5f; 
        scrollingFore -= 1.0f; 

        if(scrollingFar <= -farground.width * 2) {
            scrollingFar = 0.0f; 
        } 

        if(scrollingBack <= -background.width * 2) {
            scrollingBack = 0.0f; 
        }

        if(scrollingFore <= -foreground.width * 2) {
            scrollingFore = 0.0f; 
        }
    }


}