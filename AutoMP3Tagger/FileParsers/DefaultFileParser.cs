using System.IO;

namespace Webmilio.Utilities.AutoMP3Tagger.FileParsers
{
    internal class DefaultFileParser : FileParser
    {

        public DefaultFileParser() : base( "Old Norms" ) { }

        public override MusicFile ParseFile( string fileName ) {
            string songName = "";
            string[] authors = new string[] { }, featurings = new string[] { };

            string strippedFileName = Path.GetFileNameWithoutExtension( fileName );

            string[] authorSplit = strippedFileName.Split( '-' );
            authors = authorSplit[0].Trim( ' ' ).Split( ',' );

            if ( authors.Length > 0 )
                for ( int i = 0; i < authors.Length; i++ )
                    authors[i] = authors[i].Trim( ' ' );


            if ( authorSplit.Length <= 1 ) songName = strippedFileName;
            else {

                string[] featSplit = authorSplit[1].Split( '(' );

                bool features = authorSplit[1].Contains( "feat." );
                if ( features )
                    songName = featSplit[0].Trim( ' ' );
                else
                    songName = authorSplit[1];

                if ( features && featSplit.Length > 1 )
                    featurings = featSplit[1].Remove( 0, "feat.".Length ).TrimStart( ' ' ).Trim( ')' ).Split( ',' );

                if ( featurings.Length > 0 )
                    for ( int i = 0; i < featurings.Length; i++ )
                        featurings[i] = featurings[i].Trim( ' ' );
            }

            return new MusicFile( fileName, authors, songName, featurings );
        }
    }
}
