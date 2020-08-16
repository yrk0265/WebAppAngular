using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ModelPost> Get()
        {
            var rng = new Random();
            List<ModelPost> limodelPosts = new List<ModelPost>();
            ModelPost modelPost = new ModelPost();
            modelPost.HeadLine = "test 1 headline";
            modelPost.Content = "test 1 content";
            modelPost.CreatedDateTime = DateTime.Now;
            modelPost.IsDeleted = false;
            limodelPosts.Add(modelPost);
            modelPost = new ModelPost();
            modelPost.HeadLine = "test 2 headline";
            modelPost.Content = "test 2 content";
            modelPost.CreatedDateTime = DateTime.Now;
            modelPost.IsDeleted = false;
            limodelPosts.Add(modelPost);
            modelPost = new ModelPost();
            modelPost.HeadLine = "test 3 headline";
            modelPost.Content = "test 3 content";
            modelPost.CreatedDateTime = DateTime.Now;
            modelPost.IsDeleted = false;
            limodelPosts.Add(modelPost);
            return limodelPosts;
        }
    }
}
