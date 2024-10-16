using System;
namespace AdminBlog.Models{

public class Blog{
    public int Id { get; set; }
    public string? Title { get; set; }= String.Empty;
    public string? Subtitle { get; set; }= String.Empty;
    public string? Content { get; set; }= String.Empty;
    public string? ImagePath { get; set; }= String.Empty;
    public bool IsPublish { get; set; }
    public DateTime CreatedTime { get; set; }=DateTime.Now;
    public Author? Author { get; set; }
    public int AuthorId { get; set; }
    public Category? Category { get; set; }
    public int CategoryId { get; set; }
  

}









}