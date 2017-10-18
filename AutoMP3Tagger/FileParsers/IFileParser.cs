namespace Webmilio.Utilities.AutoMP3Tagger.FileParsers
{
    public interface IFileParser
    {

        MusicFile ParseFile( string fileName );

        string ToString();

    }
}