using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]

public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following value & priorities: Jimmy (3), Tim (1), Sue (2) Remove the items from the queue and verify that they are returned in order of priority (highest to lowest).
    // Expected Result: Jimmy, Sue, Tim
    // Defect(s) Found: Incorrect Loop to find the highest priority item
    public void TestPriorityQueue()
    {
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 2);
        var jimmy = new PriorityItem("Jimmy", 3);

        PriorityItem[] expectedResult = [jimmy, sue, tim];

        var players = new PriorityQueue();
        players.Enqueue("Tim", 1);
        players.Enqueue("Sue", 2);
        players.Enqueue("Jimmy", 3);

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var actual = players.Dequeue();
            var expected = expectedResult[i].Value;
            Assert.AreEqual(expected, actual);
        }
    }
    [TestMethod]
    // Scenario: Create a queue with the following value & priorities: Jimmy (3), Bob (1), Tim (1), Sue (2) Remove the items from the queue and verify that they are returned in order of priority (highest to lowest).  If two items have the same priority then the one that was added first should be returned first.
    // Expected Result: Jimmy, Sue, Bob, Tim
    // Defect(s) Found: none
    public void TestPriorityQueue_MorethanOneItem()
    {
        var bob = new PriorityItem("Bob", 1);
        var tim = new PriorityItem("Tim", 1);
        var sue = new PriorityItem("Sue", 2);
        var jimmy = new PriorityItem("Jimmy", 3);

        PriorityItem[] expectedResult = [jimmy, sue, bob, tim];

        var players = new PriorityQueue();
        players.Enqueue("Bob", 1);
        players.Enqueue("Tim", 1);
        players.Enqueue("Sue", 2);
        players.Enqueue("Jimmy", 3);

        for (int i = 0; i < expectedResult.Length; i++)
        {
            var actual = players.Dequeue();
            var expected = expectedResult[i].Value;
            Assert.AreEqual(expected, actual);
        }
    }
    [TestMethod]
    // Scenario: Empty queue.  Call Dequeue and verify that an exception is thrown.
    // Expected Result: InvalidOperationException
    // Defect(s) Found: 
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected InvalidOperationException was not thrown.");
        }
        catch (InvalidOperationException e)
        {
           Assert.AreEqual("The queue is empty.", e.Message);
        }
    }

    // Add more test cases as needed below.
}