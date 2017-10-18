using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Webmilio.Utilities.AutoMP3Tagger.FileParsers;

namespace Webmilio.Utilities.AutoMP3Tagger
{
    public partial class FrmMain : Form
    {
        private readonly IList<string> _files = new List<string>();
        private IDictionary<string, MusicFile> _musicFiles = new Dictionary<string, MusicFile>();

        private readonly int _timeLength;
        private readonly string _path;

        public FrmMain() : this( null, null, -1 ) {
        }

        public FrmMain( string fileParser, string path, int timeLength ) {
            this._path = path;
            this._timeLength = timeLength;

            InitializeComponent();

            this.cmbFileParser.Items.AddRange( FileParser.fileParsers.ToArray() );
            this.cmbFileParser.SelectedIndex = FileParser.fileParsers.FindIndex( f => f.Name == fileParser );
        }

        private void FrmMain_Load( object sender, EventArgs e ) {
            if ( this._timeLength > -1 ) {
                this.txtFilePath.Text = this._path;
                this.nbrCreatedMinsAgo.Value = this._timeLength;

                this.btnSearchFiles_Click( sender, e );
                this.btnParseFiles_Click( sender, e );
                this.btnApplyTags_Click( sender, e );

                this.Close();
            }
        }

        private void btnBrowseFolder_Click( object sender, EventArgs e ) {
            if ( this.folderBrowserDialog.ShowDialog() == DialogResult.OK ) {
                this.txtFilePath.Text = this.folderBrowserDialog.SelectedPath;

                this._files.Clear();
                this._musicFiles.Clear();
            }
        }

        private void btnSearchFiles_Click( object sender, EventArgs e ) {
            this.listFilesFound.Items.Clear();

            this._files.Clear();
            this._musicFiles.Clear();

            if ( string.IsNullOrWhiteSpace( this.txtFilePath.Text ) ) return;
            string[] files = Directory.GetFiles( this.txtFilePath.Text, "*.mp3" );

            foreach ( string file in files )
                if ( File.GetCreationTime( file ) >= DateTime.Now - TimeSpan.FromMinutes( (int) this.nbrCreatedMinsAgo.Value ) ) {
                    this.listFilesFound.Items.Add( Path.GetFileName( file ) );
                    this._files.Add( file );
                }
        }

        private void listFilesFound_SelectedIndexChanged( object sender, EventArgs e ) {
            if ( this.listFilesFound.SelectedItem == null ) return;

            if ( this._musicFiles.Count == 0 ) {
                if ( MessageBox.Show( "You must parse the Music Files before you can show their attributes.\nWould you like to parse them now ?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning ) == DialogResult.Yes ) {

                    this.btnParseFiles_Click( sender, e );
                    this.listFilesFound_SelectedIndexChanged( sender, e );
                }
            }
            else
                MessageBox.Show( this._musicFiles[this.listFilesFound.SelectedItem.ToString()].ToString() );
        }

        private void btnParseFiles_Click( object sender, EventArgs e ) {
            this._musicFiles.Clear();

            if ( this._files.Count == 0 )
                MessageBox.Show( "You have no files to parse.", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
            else
                for ( int i = 0; i < this._files.Count; i++ )
                    this._musicFiles.Add( Path.GetFileName( this._files[i] ), ( (FileParser) this.cmbFileParser.SelectedItem ).ParseFile( this._files[i] ) );
        }

        private void btnApplyTags_Click(object sender, EventArgs e) {
            if ( this._musicFiles.Count == 0 ) return;

            foreach ( MusicFile musicFile in this._musicFiles.Values ) {
                try {
                    TagLib.File file = TagLib.File.Create( musicFile.FileName );
                    file.Tag.Title = musicFile.SongName;
                    file.Tag.AlbumArtists = musicFile.Authors;
                    file.Tag.Performers = musicFile.Featuring;
                    file.Save();
                }
                catch ( Exception ex ) {
                    MessageBox.Show( "Error while saving " + musicFile.FileName + ".", "", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }
    }
}
