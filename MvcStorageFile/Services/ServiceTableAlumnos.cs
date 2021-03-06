using Microsoft.Azure.Cosmos.Table;
using MvcStorage.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MvcStorage.Services
{
    public class ServiceTableAlumnos
    {
        //METODO ASYNC PARA PODER CONSUMIR EL TOKEN
        public async Task<string> GetTokenAsync(string curso)
        {
            string request = "api/access/token/" + curso;
            string url = "https://localhost:44366/";
            using (WebClient client = new WebClient())
            {
                client.Headers["content-type"] = "application/json";
                string content = await client.DownloadStringTaskAsync(new Uri(url + request));
                JObject jobject = JObject.Parse(content);
                return jobject.GetValue("token").ToString();
            }
        }

        public List<Alumno> GetAlumnos(string token)
        {
            string uristorage = "http://127.0.0.1:10002/devstoreaccount1/";
            StorageCredentials credentials = new StorageCredentials(token);
            CloudTableClient client = new CloudTableClient(new Uri(uristorage), credentials);
            CloudTable tabla = client.GetTableReference("tablaalumnos");
            TableQuery<Alumno> query = new TableQuery<Alumno>();
            return tabla.ExecuteQuery(query).ToList();
        }
    }
}
