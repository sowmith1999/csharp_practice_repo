namespace Solution
{
    #region solution2
    class Album
    {
        private int albumID;
        private static int hold = 1001;
        private string albumName;
        private string albumArtist;
        private string status;
        private int unitsSold = -1;

        public int ALBumID { get => albumID; set => albumID = value; }
        public string AlbumNAME { get => albumName; set => albumName = value; }
        public string AlbumARTIST { get => albumArtist; set => albumArtist = value; }
        public string STATUs { get => status; set => status = value; }
        public int UniTSSold { get => unitsSold; set => unitsSold = value; }

        public Album(string albumname, string albumartist, string status, int unitssold)
        {
            this.ALBumID = hold;
            this.AlbumNAME = albumname;
            this.AlbumARTIST = albumartist;
            this.STATUs = status;
            this.UniTSSold = unitssold;
            hold = hold + 1;


        }

    }

#endregion
#region solution3



    #endregion

    // Other miscellaneous code, if required
    #region miscellaneous



    #endregion
}