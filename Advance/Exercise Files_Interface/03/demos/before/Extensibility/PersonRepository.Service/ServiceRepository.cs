using Newtonsoft.Json;
using PersonRepository.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;

namespace PersonRepository.Service
{
    class ServiceRepository : IPersonRepository
    {
        WebClient client = new WebClient();
        string baseUrl = "http://localhost:9874/api/people";
        public IEnumerable<Person> GetPeople()
        {
            string result = client.DownloadString(baseUrl);
            IEnumerable<Person> people = JsonConvert.DeserializeObject<IEnumerable<Person>>(result);
            return people;
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public void AddPerson(Person newPerson)
        {
            throw new NotImplementedException();
        }

        public void DeletePerson(int id)
        {
            throw new NotImplementedException();
        }

    

        public void UpdatePerson(int id, Person updatedPerson)
        {
            throw new NotImplementedException();
        }
    }
}
