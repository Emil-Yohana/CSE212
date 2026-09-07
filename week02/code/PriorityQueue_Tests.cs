using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    // Scenario: Create a queue with the following people, turns & priorities: Bob (2, 1), Tim (5, 2), Sue (3, 3) and
    // run until the queue is empty
    // Expected Result: Bob, Tim, Sue, Bob, Tim, Sue, Tim, Sue, Tim, Tim
    // Defect(s) Found: The Personqueue class was using a List instead of a Queue. 
    public void TestTakingTurnsQueue_FiniteRepetition()
    {
        var bob = new PriorityQueue.PriorityItem("Bob", 2, 1);
        var tim = new PriorityQueue.PriorityItem("Tim", 5, 2);
        var sue = new PriorityQueue.PriorityItem("Sue", 3, 3);

        Person[] expectedResult = [bob, tim, sue, bob, tim, sue, tim, sue, tim, tim];

        var players = new TakingTurnsQueue();
        players.AddPerson(bob.Name, bob.Turns);
        players.AddPerson(tim.Name, tim.Turns);
        players.AddPerson(sue.Name, sue.Turns);

        int i = 0;
        while (players.Length > 0)
        {
            if (i >= expectedResult.Length)
            {
                Assert.Fail("Queue should have ran out of items by now.");
            }

            var person = players.GetNextPerson();
            Assert.AreEqual(expectedResult[i].Name, person.Name);
            i++;
        }
    }
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
}