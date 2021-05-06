using PersonRepository.Interface;
using System;
using System.Configuration;

namespace PersonRepository.Factory
{
    public static class RepositoryFactory
    {
        public static IPersonRepository GetRepository()
        {
            string RepositoryTypeName = ConfigurationManager.AppSettings["RepositoryType"];
            Type RepositoryType = Type.GetType(RepositoryTypeName);            //?
            IPersonRepository repository = (IPersonRepository)Activator.CreateInstance(RepositoryType);
            //IPersonRepository personRepository = repository;
            return repository;
        }
    }
}
