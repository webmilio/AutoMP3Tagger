using System;
using System.Windows.Forms;
using Webmilio.Utilities.AutoMP3Tagger.FileParsers;

namespace Webmilio.Utilities.AutoMP3Tagger
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main( string[] args ) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );

            int timeLength = -1;
            string fileParser = null, path = null;
            args = string.Join( " ", args ).Split( '|' );

            if ( args.Length == 3 ) {
                fileParser = args[0];
                path = args[1];
                timeLength = int.Parse( args[2] );
            }

            new DefaultFileParser();
            new NewNormsFileParser();

            Application.Run( new FrmMain( fileParser, path, timeLength ) );
        }
    }
}
