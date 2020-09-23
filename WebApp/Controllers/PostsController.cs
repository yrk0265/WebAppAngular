using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebAppAngular.Models;

namespace WebApp.Controllers
{
    [EnableCors("AllowOrigin")]
    [ApiController]
    [Route("[controller]")]
    public class PostsController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<PostsController> _logger;

        public PostsController(ILogger<PostsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ModelPost> Get()
        { 
            var rng = new Random();
            List<ModelPost> limodelPosts = new List<ModelPost>();
            ModelPost modelPost = new ModelPost();
            modelPost.HeadLine = "Tech ";
            modelPost.Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis aliquid atque, nulla? Quos cum ex quis soluta, a laboriosam. Dicta expedita corporis animi vero voluptate voluptatibus possimus, veniam magni quis!";
            modelPost.CreatedDateTime = DateTime.Now;
            modelPost.IsDeleted = false;
            limodelPosts.Add(modelPost);
            modelPost = new ModelPost();
            modelPost.HeadLine = "Tech 2";
            modelPost.Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis aliquid atque, nulla? Quos cum ex quis soluta, a laboriosam. Dicta expedita corporis animi vero voluptate voluptatibus possimus, veniam magni quis!";
            modelPost.CreatedDateTime = DateTime.Now;
            modelPost.IsDeleted = false;
            limodelPosts.Add(modelPost);
            modelPost = new ModelPost();
            modelPost.HeadLine = "Tech 3";
            modelPost.Content = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Reiciendis aliquid atque, nulla? Quos cum ex quis soluta, a laboriosam. Dicta expedita corporis animi vero voluptate voluptatibus possimus, veniam magni quis!";
            modelPost.CreatedDateTime = DateTime.Now;
            modelPost.IsDeleted = false;
            limodelPosts.Add(modelPost);
            return limodelPosts;
        }
        [HttpGet]
        [Route("{SearchText}")]
        public IEnumerable<ModelPost> Search(string SearchText)
        {
            IEnumerable<ModelPost> PostList = Get();
            List<ModelPost> modelPosts = PostList.Where(x => x.Content.Contains(SearchText)).ToList();
            return modelPosts;
        }
    }
}
