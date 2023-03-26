public class PhotoAlbum
{
    private int numberOfPages;
 
    public PhotoAlbum()
    {
        numberOfPages = 16;
    }

    public PhotoAlbum(int numberOfPages)
    {
        this.numberOfPages = numberOfPages;
    }

    public int GetNumberOfPages()
    {
        return numberOfPages;
    }
}