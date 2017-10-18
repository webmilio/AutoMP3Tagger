using System.Collections.Generic;

namespace Webmilio.Utilities.AutoMP3Tagger.FileParsers
{
    public abstract class FileParser : IFileParser
    {

        protected FileParser() : this( null ) { }

        protected FileParser( string name ) {
            this.Name = name;

            fileParsers.Add( this );
        }

        //public static readonly Dictionary<string, IFileParser> fileParsers = new Dictionary<string, IFileParser>();
        public static readonly List<FileParser> fileParsers = new List<FileParser>();

        public abstract MusicFile ParseFile( string fileName );

        public override string ToString() => this.Name + $" ({this.GetType().Name})";

        public string Name { get; }
    }
}