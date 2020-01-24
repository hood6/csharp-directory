using Directory_Project.Linked_List;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Directory_Project.UnitTests
{
    [TestClass]
    public class LLTests
    {
        [TestMethod]
        public void add_Adding3Nodes_LengthShouldBe3()
        {
            //Arrange
            var list = new LL<int>();

            //Act
            for(int i = 0; i < 3; i++)
            {
                list.add(i + 1);
            }

            //Assert
            Assert.AreEqual(list.Length, 3);
        }
    }
}
