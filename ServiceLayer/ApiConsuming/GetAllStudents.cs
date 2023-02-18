using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace ServiceLayer.ApiConsuming
{
    public class StudentApiConsume
    {
        HttpClient Client = new HttpClient();

        public List<Student> GetAllStudents()
        {
            List<Student> list = new List<Student>();
            Client.BaseAddress = new Uri("https://localhost:44351/api/Student");
            var Response = Client.GetAsync("Student");
            Response.Wait();
            var test = Response.Result;


            if (test.IsSuccessStatusCode)
            {
                var Display = test.Content.ReadAsAsync<List<Student>>();
                Display.Wait();
                list = Display.Result;
            }

            return list;
        }


        public Student GetById(int id)
        {
            Student student = new Student();

            Client.BaseAddress = new Uri("https://localhost:44351/api/Student");
            var response = Client.GetAsync("Student?id=" + id.ToString());

            response.Wait();
            var test = response.Result;


            if (test.IsSuccessStatusCode)
            {
                var Display = test.Content.ReadAsAsync<Student>();
                Display.Wait();
                student = Display.Result;
            }

            return student;
        }

        public bool UpdateStudent(Student std)
        {
            Client.BaseAddress = new Uri("https://localhost:44351/api/Student");
            var response = Client.PutAsJsonAsync<Student>("Student", std);

            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}