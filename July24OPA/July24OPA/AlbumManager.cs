using System.Collections.Generic;

namespace Solution
{

    // Create class AlbumManager as per given specification
    // Write code for methods that would perform operations handled in solution1
    #region solution3
    class AlbumManager
    {
        public List<Album> albums = new List<Album>();
        public int AddAlbum(string albumname, string albumartist, string status, int unitsSold)
        {
            var album = new Album(albumname, albumartist, status, unitsSold);
            albums.Add(album);
            return album.ALBumID;

        }
        public long TotalUnitsSold()
        {
            long total = 0;
            foreach (var k in albums)
            {
                if (k.UniTSSold > 0)
                {
                    total = total + k.UniTSSold;
                }
            }
            return total;
        }
        public int ArtistAlbumsSold(string artistname)
        {
            var Sum = 0;
            foreach (var k in albums)
            {
                if (k.AlbumARTIST == artistname)
                {
                    if (k.UniTSSold > 0)
                    {
                        Sum = Sum + k.UniTSSold;
                    }
                }
            }

            return Sum;
        }



    }



    #endregion

    // Other miscellaneous code, if required
    #region miscellaneous



    #endregion
}