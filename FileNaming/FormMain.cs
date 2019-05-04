using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;

namespace FileNaming
{
    public partial class FormMain : Form
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        public FormMain( )
        {
            InitializeComponent( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonExit_Click( object sender, EventArgs e )
        {
            this.Close( );
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRuleMaking_Click( object sender, EventArgs e )
        {
            if ( this.DialogFile.ShowDialog( ) != DialogResult.OK ) return;

            string filename = this.DialogFile.FileName;
            string[ ] datalines = File.ReadAllLines( filename, Encoding.Default );

            FileInfo fileinfo = new FileInfo( filename );
            string pathname = fileinfo.DirectoryName;

            DirectoryInfo rootpath = fileinfo.Directory;

            StringBuilder buffer = new StringBuilder( );
            foreach ( FileInfo file in rootpath.GetFiles( ) )
            {
                NamingRule batch = new NamingRule( file, datalines );

                buffer.AppendLine( batch.ToTxt( 60 ) );
            }

            string result = pathname + "\\file-new-name-listing.txt";
            File.WriteAllText( result, buffer.ToString( ), Encoding.Default );

            Process.Start( "explorer.exe", pathname );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRuleNaming_Click( object sender, EventArgs e )
        {
            if ( this.DialogFile.ShowDialog( ) != DialogResult.OK ) return;

            string filename = this.DialogFile.FileName;
            string[] datalines = File.ReadAllLines( filename, Encoding.Default);

            FileInfo fileinfo = new FileInfo( filename );
            string pathname = fileinfo.DirectoryName;

            DirectoryInfo rootpath = fileinfo.Directory;

            foreach ( string line in datalines )
            {
                NamingRule.Rename( rootpath, line );
            }

            Process.Start( "explorer.exe", pathname );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load( object sender, EventArgs e )
        {
        }

        //.....................................................................
    }
}
