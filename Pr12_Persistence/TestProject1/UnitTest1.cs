using System;
using Pr12_Persistence;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void CheckPersonConstructor()
        {
            // #### ARRANGE ####
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            // #### ACT ####
            string title = person.MakeTitle();

            // #### ASSERT ####
            Assert.AreEqual("Anders Andersen;24-08-1975 00:00:00;175,9;True;3", title);
        }

        [TestMethod]
        public void CheckDataHandlerConstructor()
        {
            // #### ARRANGE ####
            DataHandler handler = new DataHandler("Data.txt");

            // #### ACT ####

            // #### ASSERT ####
            Assert.AreEqual("Data.txt", handler.DataFileName);
        }

        [TestMethod]
        public void CheckDataHandlerSaveAndLoad()
        {
            // #### ARRANGE ####
            DataHandler handler = new DataHandler("Data.txt");
            Person person = new Person("Anders Andersen", new DateTime(1975, 8, 24), 175.9, true, 3);

            // #### ACT ####
            handler.SavePerson(person);
            Person loadedPerson = handler.LoadPerson();

            // #### ASSERT ####
            Assert.AreEqual("Anders Andersen", loadedPerson.Name);
            Assert.AreEqual(1975, loadedPerson.BirthDate.Year);
            Assert.AreEqual(8, loadedPerson.BirthDate.Month);
            Assert.AreEqual(24, loadedPerson.BirthDate.Day);
            Assert.AreEqual(175.9, loadedPerson.Height);
            Assert.AreEqual(true, loadedPerson.IsMarried);
            Assert.AreEqual(3, loadedPerson.NoOfChildren);
        }
    }

    
}