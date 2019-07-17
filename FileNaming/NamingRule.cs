using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileNaming
{
    class NamingRule
    {
        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private int NameLen;

        private string FileName;

        private string NewFname;

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileinfo"></param>
        public NamingRule( FileInfo fileinfo, string[ ] rulines )
        {
            this.NameLen = this.Strlen( fileinfo.Name );

            this.FileName = fileinfo.Name;

            this.ReplaceUsingRules( rulines );

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rulines"></param>
        private void ReplaceUsingRules( string[ ] rulines )
        {
            this.NewFname = this.FileName;

            int idx = -1;

            string title = " ";
            foreach ( string rule in rulines )
            {
                idx++;
                if ( string.IsNullOrEmpty( rule.Trim( ) ) ) continue;

                string[ ] tokens = rule.Split( ";".ToCharArray( ),
                                               StringSplitOptions.RemoveEmptyEntries 
                                               );

                string srcTAG = tokens[ 0 ].Trim( );
                string dstTAG = ( tokens.Length > 1 ) ? tokens[ 1 ].Trim( ) 
                                                      : "";

                if ( idx == 0 ) title = srcTAG;

                this.NewFname = this.NewFname.Replace( srcTAG, dstTAG );
            }

            this.NewFname = title.Trim( ) + this.NewFname;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        private void LengthenName( int length )
        {
            string spaces = string.Empty;

            int delta = length - this.NameLen;

            if ( delta > 0 ) spaces = "".PadLeft( length - this.NameLen );

            this.FileName =  this.FileName + spaces;

            return;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ToTxt( int namelen )
        {
            this.LengthenName( namelen );

            return this.FileName + ";  " + this.NewFname;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rootpath"></param>
        /// <param name="line"></param>
        public static bool Rename( DirectoryInfo rootpath, string line )
        {
            if ( string.IsNullOrEmpty( line.Trim( ) ) ) return false;

            string[ ] tokens = line.Split( ";".ToCharArray( ),
                                           StringSplitOptions.RemoveEmptyEntries );

            if ( tokens.Length < 2 ) return false;

            string srcname = tokens[ 0 ].Trim( );
            string dstname = rootpath.FullName + "\\" + tokens[ 1 ].Trim( );

            FileInfo[ ] filelist = rootpath.GetFiles( srcname );
            if ( filelist.Length < 1 ) return false;

            filelist[ 0 ].MoveTo( dstname );

            return true;
        }

        //.....................................................................
        /// <summary>
        /// 
        /// </summary>
        /// <param name="line"></param>
        /// <returns></returns>
        private int Strlen( string line )
        {
            int len = 0;

            foreach ( char lett in line )
            {
                byte[ ] bytelist = Encoding.UTF8.GetBytes( lett.ToString( ) );

                int bytelen = bytelist.Length;

                len += ( bytelen == 1 ) ? 1 : 2;

            }

            return len;
        }

        //.....................................................................
    }
}
