using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TestWebApi.Models;

namespace TestWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogController : ControllerBase
    {
        public List<Post> posts;
        public BlogController(){
            posts = new List<Post>{
                new Post{Id = 1, Time = "10:20", User = "andres", Message = "Prueba 1"},
                new Post{Id = 2, Time = "10:21", User = "ricardo", Message = "Prueba 2"},
                new Post{Id = 3, Time = "10:22", User = "steve", Message = "Prueba 3"},
                new Post{Id = 4, Time = "10:23", User = "tanner", Message = "Prueba 4"}
            };
        }

        [HttpGet]
        [Route("{id}")]
        public Post GetOne([FromRoute] long id){
            foreach(var post in posts){
                if(post.Id == id){
                    return post;
                }
            }

            return null;
        }

        [HttpGet]
        public List<Post> GetAll(){
            return posts;
        }

        [HttpPost]
        public List<Post> Create([FromForm] Post newPost){
            // var newPost = new Post{Id = 5, Time = "10:24", User = "bob", Message = "Prueba 5"};
            newPost.Id = posts.Count + 1;
            posts.Add(newPost);
            
            return posts;
        }

        [HttpPut]
        [Route("{id}")]
        public List<Post> Update([FromRoute] long id, [FromBody] Post updatedPost){
            foreach(var post in posts){
                if(post.Id == id){
                    post.Message = updatedPost.Message;
                    post.Time = updatedPost.Time;
                    post.User = updatedPost.User;
                }
            }

            return posts;
        }

        [HttpDelete]
        [Route("{id}")]
        public List<Post> Delete([FromRoute] long id){
            foreach(var post in posts){
                if(post.Id == id){
                    posts.Remove(post);
                    break;
                }
            }          

            return posts;
        }
    }
}