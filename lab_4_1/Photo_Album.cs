using System;
using System.Collections.Generic;

namespace lab_4_1
{
    public class PhotoAlbum
    {
        public List<Photo> Photos { get; set; } = new List<Photo>();

        public PhotoAlbum(List<Photo> photos)
        {
            Photos = photos;
        }

        public void AddPhoto(Photo photo)
        {
            Photos.Add(photo);
            Console.WriteLine($"Photo '{photo.Name}' has been added to the album.");
        }

        public void PrintPhotos()
        {
            Console.WriteLine("Photos in the album:");
            foreach (var photo in Photos)
            {
                Console.WriteLine(photo.Name);
            }
        }

        public void PrintNumberOfPhotos()
        {
            Console.WriteLine($"The photo album contains {Photos.Count} photos.");
        }
    }
}
