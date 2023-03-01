using System; 
using Raylib_cs; 
using static Raylib_cs.Raylib; 

namespace final_project_JakeZalesny.Services {
    public class OutputServices {
        private int screenWidth = 3200;
        private int screenHeight = 1800;

        private Queue<ParallaxBackground> parallaxBackgroundQueue = new Queue<ParallaxBackground>();  
        public OutputServices() {}
        public void openWindow() {
            InitWindow(screenWidth, screenHeight, "Lofi - Magic");
            SetTargetFPS(60);
        
        }

        public void beginDrawing() {
            BeginDrawing(); 
            ClearBackground(Color.RAYWHITE);
            EndDrawing(); 
        }

        public void loadTexturesOut(ParallaxBackground parallax) {
            parallax.loadTextures();
        }

        public void drawParallax(ParallaxBackground parallax) { 
            parallax.calculateParallax(); 

            DrawTextureEx(parallax.getFarground(), new System.Numerics.Vector2(parallax.getScrollingFar(), 20), 0.0f, 2.0f, Raylib_cs.Color.WHITE);
            DrawTextureEx(parallax.getFarground(), new System.Numerics.Vector2(parallax.getFarground().width * 2 + parallax.getScrollingFar(), 20), 0.0f, 2.0f, Raylib_cs.Color.WHITE);
            
            DrawTextureEx(parallax.getBackground(), new System.Numerics.Vector2(parallax.getScrollingBack(), 20), 0.0f, 2.0f, Raylib_cs.Color.WHITE);
            DrawTextureEx(parallax.getBackground(), new System.Numerics.Vector2(parallax.getBackground().width * 2 + parallax.getScrollingBack(), 20), 0.0f, 2.0f, Raylib_cs.Color.WHITE);

            DrawTextureEx(parallax.getForeground(), new System.Numerics.Vector2(parallax.getScrollingFore(), 20), 0.0f, 2.0f, Raylib_cs.Color.WHITE);
            DrawTextureEx(parallax.getForeground(), new System.Numerics.Vector2(parallax.getForeground().width * 2 + parallax.getScrollingFore(), 20), 0.0f, 2.0f, Raylib_cs.Color.WHITE);
        }

        public void drawSongTitle(Song currentSong) {
            DrawText("Now Playing: " + currentSong.getSongTitle(), 1250, 1650, 40, Raylib_cs.Color.LIGHTGRAY);
        }

        public void drawArtistName(Song currentSong) {
            DrawText("By: " + currentSong.getArtist(), 1350, 1700, 40, Raylib_cs.Color.LIGHTGRAY);
        }

        public void drawAnalytics(BinarySearchTree tree) {
            int yPosition = 200; 
            foreach(var key in Constants.analytics.Keys) {
                if(tree.Contains(Constants.analytics[key])) {
                    DrawText($"{key}: {Constants.analytics[key]}", 2900, yPosition, 20, Raylib_cs.Color.LIGHTGRAY);
                    yPosition += 20; 
                }

                else {
                    DrawText($"{key}: {Constants.analytics[key]}", 2900, yPosition, 20, Raylib_cs.Color.LIGHTGRAY);
                    yPosition += 20; 
                }
            }
        }

        public void drawInstructions() {
            DrawText("Press 'H' to listen to a song from the DJ Playlist. ", 1250, 1750, 40, Raylib_cs.Color.LIGHTGRAY);
        }
        public void closePlayer() {
            EndDrawing(); 
            CloseWindow(); 
        }
    }
}