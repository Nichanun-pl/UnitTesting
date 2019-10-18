using System.Collections.Generic;

namespace TestNinja.Mocking
{
    public class VideoRepository
    {
        public IEnumerable<Video> GetUnprocessedVideos()
        {
            var videos =
            (from video in context.Videos
                where !video.IsProcessed
                select video).ToList();
        }
    }
}
