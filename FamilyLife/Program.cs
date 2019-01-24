using System;

using System.Collections.Generic;
using StarWars.Model;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace FamilyLife
{
    class Program
    {
        private static string apiUrl = "https://swapi.co/api/people/";
        private static readonly HttpClient client = new HttpClient();

        static void Main(string[] args)
        {
            var people = GetPeople().Result;
            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
                foreach (string film in person.Films)
                {
                    Console.WriteLine(" - " + GetFilm(film).Result.Title);
                }
                Console.WriteLine();

            }
        }

        private static async Task<List<Person>> GetPeople()
        {
            List<Person> people = new List<Person>();
            int pageNumber = 1;
            int recordCount = 0;

            do
            {
                var serializer = new DataContractJsonSerializer(typeof(ModelItems<Person>));

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", "FamilyLife Star Wars reader.");

                UriBuilder uri = new UriBuilder(apiUrl);
                uri.Query = string.Format("page={0}", pageNumber);
                var streamTask = client.GetStreamAsync(uri.ToString());
                var modelItems = serializer.ReadObject(await streamTask) as ModelItems<Person>;

                recordCount = modelItems.Count;
                people.AddRange(modelItems.Results);
            } while (recordCount - 10 * pageNumber++ > 0);

            return people;
        }

        private static async Task<Film> GetFilm(string _apiURI)
        {
            var serializer = new DataContractJsonSerializer(typeof(Film));

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("User-Agent", "FamilyLife Star Wars reader.");

            var streamTask = client.GetStreamAsync(_apiURI);
            var film = serializer.ReadObject(await streamTask) as Film;

            return film;
        }

    }

}
