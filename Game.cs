namespace Modul10_103022400117
{
    public class Game
    {
        public string Nama { get; set; } = string.Empty;
        public string Developer {  get; set; } = string.Empty;
        public int TahunRilis { get; set; } = int.MaxValue;
        public string Genre {  get; set; } = string.Empty;
        public double Rating {  get; set; } = double.MaxValue;
        public string[] Platform { get; set; } = new string[0];
        public string[] Mode { get; set; } = new string[0];
        public bool IsOnline { get; set; } = false;
        public int Harga { get; set; } = 0;

        public Game() { }
    }
}
