namespace OpenGraph
{
    public class MetaTags
    {
        public string Title { get; set; } = "";

        public string Type { get; set; } = "";

        public string Url { get; set; } = "";

        public string Description { get; set; } = "";

        public string Image { get; set; } = "";

        public string Imagesecureurl { get; set; } = "";
        
        public string Imagewidth { get; set; } = "";

        public string Imageheight { get; set; } = "";

        public string Imagetype { get; set; } = "";

        public string Imagealt { get; set; } = "";

        // Add other relevant properties as needed
    }

}

//og: title - The title of your object as it should appear within the graph, e.g., "The Rock".
//og:type - The type of your object, e.g., "video.movie". Depending on the type you specify, other properties may also be required.
//og:image - An image URL which should represent your object within the graph.
//og:url - The canonical URL of your object that will be used as its permanent ID in the graph, e.g., "https://www.imdb.com/title/tt0117500/".