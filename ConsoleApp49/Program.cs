using System;
using System.Collections.Generic;

public class Blog
{
    public string BlogName { get; set; }
    public string BlogType { get; set; }
    public string BlogHeader { get; set; }
    public string Blogdescription { get; set; }
}

public class Post
{
    public string PostDescription { get; set; }
    public DateTime CreationDate { get; set; }
    public int BlogId { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Blog table data
        List<Blog> blogs = new List<Blog>()
        {
            new Blog { BlogName = "Vaishali", BlogType = "AA", BlogHeader = "pqr", Blogdescription = "This is my log" },
            new Blog { BlogName = "Nanda", BlogType = "BB", BlogHeader = "stu", Blogdescription = "This is my second log" }
        };

        // Post table data
        List<Post> posts = new List<Post>()
        {
            new Post { PostDescription = "abcd", CreationDate = new DateTime(2024, 6, 21), BlogId = 2 }
        };

        // Print blog table data
        Console.WriteLine("Blog table data:");
        foreach (Blog blog in blogs)
        {
            Console.WriteLine($"BlogName: {blog.BlogName} BlogType: {blog.BlogType} BlogHeader: {blog.BlogHeader} Blogdescription: {blog.Blogdescription}");
        }

        // Print post table data
        Console.WriteLine("Post table data:");
        foreach (Post post in posts)
        {
            Console.WriteLine($"PostDescription: {post.PostDescription} CreationDate: {post.CreationDate} BlogId: {post.BlogId}");
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}