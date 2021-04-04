using AXA.Infrastructure.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace AXA.Infrastructure.Test.Repository
{
    [TestClass]
    public class RepositoryTest
    {
        [TestCleanup]
        public void CleanUp()
        {
            new Repository<int>().Clear();
        }

        [TestMethod]
        public void Should_Get_All_Entities()
        {
            var repository = new Repository<int>();
            repository.Add(1);
            repository.Add(2);
            repository.Add(3);
            repository.Add(4);

            var entities = repository.GetAll();


            Assert.AreEqual(entities.Count(), 4);
        }

        [TestMethod]
        public void Should_Add_Entity()
        {
            var repository = new Repository<int>();
            repository.Add(1);

            Assert.IsTrue(repository.GetAll().Any());
        }

        [TestMethod]
        public void Should_Find_First_Entity_That_Matches()
        {
            var repository = new Repository<int>();
            repository.Add(1);
            repository.Add(2);
            repository.Add(3);

            Assert.AreEqual(repository.FirstOrDefault(e => e == 2), 2);
        }

        [TestMethod]
        public void Should_Find_Entities()
        {
            var repository = new Repository<int>();
            repository.Add(1);
            repository.Add(2);
            repository.Add(3);

            var entities = repository.Find(e => e >= 2);

            Assert.AreEqual(entities.Count(), 2);
        }

        [TestMethod]
        public void Should_Remove_Entity()
        {
            var repository = new Repository<int>();
            repository.Add(1);
            repository.Add(2);
            repository.Add(3);

            repository.Remove(e => e == 1);

            var entities = repository.GetAll();

            Assert.AreEqual(entities.Count(), 2);
            Assert.IsFalse(entities.Any(e => e == 1));
        }
    }
}