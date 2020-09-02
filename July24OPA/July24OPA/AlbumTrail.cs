namespace Solution
{
    // Create class Album as per given specification
    #region solution2
    class AlbumTrail
    {
        private int albumID;
        private static int hold = 1001;
        private string albumName;
        private string albumArtist;
        private string status;
        private int unitsSold = -1;

        public int AlbumID { get => albumID; set => albumID = value; }
        public static int Hold { get => hold; set => hold = value; }
        public string AlbumName { get => albumName; set => albumName = value; }
        public string AlbumArtist { get => albumArtist; set => albumArtist = value; }
        public string Status { get => status; set => status = value; }
        public int UnitsSold { get => unitsSold; set => unitsSold = value; }

        public AlbumTrail(int albumID, string albumName, string albumArtist, string status, int unitsSold)
        {
            AlbumID = hold++;
            AlbumName = albumName;
            AlbumArtist = albumArtist;
            Status = status;
            UnitsSold = unitsSold;
           
        }
    }



    #endregion
}