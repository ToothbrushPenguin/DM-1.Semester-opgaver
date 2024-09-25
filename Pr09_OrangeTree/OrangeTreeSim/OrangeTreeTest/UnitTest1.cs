using OrangeTreeSim;

namespace OrangeTreeTest
{
    [TestClass]
    public class UnitTest1
    {
        private OrangeTree orangeTree;

        [TestInitialize]
        public void SetupForTest()
        {
            // Start an orange tree
            orangeTree = new OrangeTree();
            orangeTree.SetAge(0);
            orangeTree.SetHeight(6);
            orangeTree.SetTreeAlive(true);
        }

        [TestMethod]
        public void ShouldIncrementTheTreesAgeWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(1, orangeTree.GetAge());
        }
        [TestMethod]
        public void ShouldIncrementTheTreesHeightByTwoWithEachPassingYear()
        {
            //Act
            orangeTree.OneYearPasses();

            //Assert
            Assert.AreEqual(8, orangeTree.GetHeight());
        }
        [TestMethod]
        public void ShouldDieAfter80Years()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.GetTreeAlive());
        }

        [TestMethod]
        public void ShouldProduceFruitAfter2Years()
        {
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.GetNumOranges());

            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.GetNumOranges());

        }
        [TestMethod]
        public void ShouldIncreaseFruitProductionBy5PiecesEachYearAfterMaturity()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            Assert.AreEqual(5, orangeTree.GetNumOranges());

            orangeTree.OneYearPasses();
            Assert.AreEqual(10, orangeTree.GetNumOranges());

        }
        [TestMethod]
        public void ShouldCountNumberOfOrangesEatenThisYear()
        {
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);

            Assert.AreEqual(1, orangeTree.GetOrangesEaten());

            orangeTree.EatOrange(3);
            Assert.AreEqual(4, orangeTree.GetOrangesEaten());

            Assert.AreEqual(1, orangeTree.GetNumOranges());
        }
        [TestMethod]
        public void OrangesEatenOneYearPasses()
        {
            //Act
            orangeTree.OneYearPasses();
            orangeTree.OneYearPasses();
            orangeTree.EatOrange(1);
            orangeTree.EatOrange(3);
            orangeTree.OneYearPasses();
            //Assert
            Assert.AreEqual(0, orangeTree.GetOrangesEaten());
            Assert.AreEqual(10, orangeTree.GetNumOranges());
        }

        [TestMethod]
        public void DeadTreeDoNotGrowAndProduceFruit()
        {
            //Act
            for (int i = 1; i <= 80; i++)
            {
                orangeTree.OneYearPasses();
            }

            //Assert
            Assert.AreEqual(false, orangeTree.GetTreeAlive());
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(164, orangeTree.GetHeight());
            Assert.AreEqual(81, orangeTree.GetAge());
            orangeTree.OneYearPasses();
            Assert.AreEqual(0, orangeTree.GetNumOranges());
            Assert.AreEqual(164, orangeTree.GetHeight());
            Assert.AreEqual(82, orangeTree.GetAge());

        }
    }
}