using System;
using System.Collections.Generic;

public class Photo
{
    public string Name { get; set; }

    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
            return false;

        Photo p = (Photo)obj;
        return (Name == p.Name);
    }

    public override int GetHashCode()
    {
        return Name.GetHashCode();
    }

    public override string ToString()
    {
        return $"Photo Name: {Name}";
    }
}

public class PhotoAlbum
{
    public List<Photo> Photos { get; set; } = new List<Photo>();

    public void AddPhoto(Photo photo)
    {
        Photos.Add(photo);
        Console.WriteLine($"Photo '{photo.Name}' has been added to the album.");
    }

    public void PrintNumberOfPhotos()
    {
        Console.WriteLine($"The photo album contains {Photos.Count} photos.");
    }
}

class Program
{
    static void Main(string[] args)
    {

        PhotoAlbum album = new PhotoAlbum();

        album.AddPhoto(new Photo { Name = "Photo 1" });
        album.AddPhoto(new Photo { Name = "Photo 2" });
        album.AddPhoto(new Photo { Name = "Photo 3" });

        album.PrintNumberOfPhotos();

        Console.ReadLine();
    }
}

