using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppWorkWithJSONServer
{
    public partial class Form1 : Form
    {
        private ApiWorker apiWorker;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetOnePost_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textBoxPostId.Text);
            PostData postData = apiWorker.GetOnePost(id);

            dataGridViewPosts.Rows.Clear();
            dataGridViewPosts.Rows.Add(
                postData.UserId,
                postData.Id,
                postData.Title,
                postData.Body
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            apiWorker = new ApiWorker();
        }

        private void buttonGetListPosts_Click(object sender, EventArgs e)
        {
            List<PostData> postsData = apiWorker.GetListPosts();

            dataGridViewPosts.Rows.Clear();

            foreach (PostData postData in postsData)
            {
                dataGridViewPosts.Rows.Add(
                postData.UserId,
                postData.Id,
                postData.Title,
                postData.Body
                );
            }

        }

        private void buttonInsertOnePost_Click(object sender, EventArgs e)
        {
            PostData insertedPostData = new PostData()
            {
                Body = "ddddd",
                Title = "aaaaa",
                UserId = 1111
            };

            PostData postData = apiWorker.InsertOnePost(insertedPostData);

            string outputString = $"успешно добавлено:\n" +
                $"UserId = {postData.UserId}\n" +
                $"Id = {postData.Id}\n" +
                $"Title = {postData.Title}\n" +
                $"Body = {postData.Body}\n";

            MessageBox.Show(outputString);
        }
    }
}
