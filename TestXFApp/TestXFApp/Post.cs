using System.Collections.Generic;

namespace TestXFApp
{
    class Post
    {
        public string Title { get; set; }
        public string TitleShort { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public int Id { get; set; }
        public override string ToString()
        {
            return Title;
        }
        public static Post GetPostById(int id)
        {
            List < Post> allPosts = Post.GetPostList();
            Post post = allPosts.Find(x => x.Id.Equals(id));
            
            return post;
        }
        public static List<Post> GetPostList()
        {
            var postList = new List<Post>();
            postList.Add(new Post
            {
                Id = 1,
                Title = "Building Cross Platform Apps with Xamarin Part 1",
                TitleShort = "Xamarin 1",
                Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque dolor orci, fermentum sit amet metus semper, pulvinar placerat dolor. Fusce pellentesque sed felis vitae ultrices. In hac habitasse platea dictumst. Ut ac sodales magna. Aliquam mattis enim ac ex vehicula suscipit. Nullam sed massa lacus. Mauris auctor aliquet mi, a lobortis ligula rhoncus eget. Nullam dictum sollicitudin eros et suscipit. Suspendisse potenti. Suspendisse scelerisque nisi consequat venenatis blandit",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Building Cross Platform Apps with Xamarin Part 2",
                TitleShort = "Xamarin 2",
                Description = "Learn how to use Xamarin to leverage your skills in Microsoft Visual Studio " +
                "and C# to build cross-platform apps that run on both Android and iOS, and embrace the features " +
                "and capabilities of each platform.",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Building Google Glass Apps with c# and Xamarin",
                TitleShort = "Xamarin Glass",
                Description = "Learn to develop apps for Google Glass with C# and Xamarin by building a " +
                "full-featured Scavenger Hunt game using the Xamarin Glass Development Kit component.",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_1",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_2",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_3",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_4",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_5",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_6",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_7",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_8",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_9",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_10",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });
            postList.Add(new Post
            {
                Title = "Android for .NET Developers_11",
                TitleShort = "Android",
                Description = "This course provides an overview of the tools used in the Android development " +
                "process including the newly released Android Studio. Topics are covered from the perspective of " +
                "someone with .NET experience but are appropriate for anyone with software development experience",
                Author = "Martin Bodin"
            });


            return postList;
        }

    }
}
