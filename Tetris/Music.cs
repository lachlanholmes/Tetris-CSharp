using WMPLib;

namespace Tetris
{
    /// <summary>
    /// Plays music during a game.
    /// </summary>
    class Music
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Music(Board board)
        {
            player.settings.setMode("loop", true);
            player.URL = "Tetris Official Theme song.mp3";
            board.GameOver += (sender, args) => player.controls.stop();
        }
    }
}
