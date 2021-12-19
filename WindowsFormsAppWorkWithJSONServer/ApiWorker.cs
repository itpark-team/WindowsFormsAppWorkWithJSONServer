using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WindowsFormsAppWorkWithJSONServer
{
    class ApiWorker
    {
        private WebClient webClient;

        public ApiWorker()
        {
            webClient = new WebClient();
            webClient.Encoding = Encoding.UTF8;
            webClient.Headers.Add("Content-type", "application/json; charset=UTF-8");
        }

        public PostData GetOnePost(int id)
        {
            string jsonResponse = webClient.DownloadString($"https://jsonplaceholder.typicode.com/posts/{id}");

            PostData postData = JsonConvert.DeserializeObject<PostData>(jsonResponse);

            return postData;
        }

        public List<PostData> GetListPosts()
        {
            string jsonResponse = webClient.DownloadString("https://jsonplaceholder.typicode.com/posts");

            List<PostData> postsData = JsonConvert.DeserializeObject<List<PostData>>(jsonResponse);

            return postsData;
        }

        public PostData InsertOnePost(PostData insertedPostData)
        {
            string jsonRequest = JsonConvert.SerializeObject(insertedPostData);

            string jsonResponse = webClient.UploadString("https://jsonplaceholder.typicode.com/posts/", jsonRequest);

            PostData postData = JsonConvert.DeserializeObject<PostData>(jsonResponse);

            return postData;
        }

    }
}
