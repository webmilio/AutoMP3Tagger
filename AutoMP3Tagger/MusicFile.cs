using System.IO;

namespace Webmilio.Utilities.AutoMP3Tagger
{
    public class MusicFile
    {
        public MusicFile( string fileName, string[] authors, string songName, string[] featuring ) {
            this.FileName = fileName;
            this.Authors = authors;
            this.SongName = songName;
            this.Featuring = featuring;
        }

        public override string ToString() =>
            $"FileName : {this.FileName}\nAuthor : {string.Join( ", ", this.Authors )}\nSong Name : {this.SongName}\nFeaturing : {string.Join( ", ", this.Featuring )}";

        public string FileName { get; }

        public string[] Authors { get; }

        public string SongName { get; }

        public string[] Featuring { get; }
    }
}
