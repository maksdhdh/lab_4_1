using System;
using System.Collections.Generic;
using lab_4_1;

class Program
{
    static void Main(string[] args)
    {
        Photo photo1 = new Photo { Name = "Photo 1" };
        Photo photo2 = new Photo { Name = "Photo 2" };
        Photo photo3 = new Photo { Name = "Photo 3" };

        List<Photo> photos = new List<Photo> { photo1, photo2, photo3 };

        PhotoAlbum album = new PhotoAlbum(photos);

        album.PrintNumberOfPhotos();
        album.PrintPhotos();

        Console.ReadLine();
    }
}
