using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue and Dequeue elements with different priorities
    // Expected Result: Element with highest priority is dequeued first
    public void TestPriorityQueue_EnqueueDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 3);
        priorityQueue.Enqueue("C", 2);

        Assert.AreEqual("B", priorityQueue.Dequeue()); // Highest priority
        Assert.AreEqual("C", priorityQueue.Dequeue()); // Next Highest
        Assert.AreEqual("A", priorityQueue.Dequeue()); // The last
    }

    [TestMethod]
    // Scenario: Enqueue elements with same priority, check FIFO behavior
    // Expected Result: First inserted element with same priority dequeued first
    public void TestPriorityQueue_FIFOSamePriority()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("X", 5);
        priorityQueue.Enqueue("Y", 5);
        priorityQueue.Enqueue("Z", 5);

        Assert.AreEqual("X", priorityQueue.Dequeue()); // FIFO for same priority
        Assert.AreEqual("Y", priorityQueue.Dequeue()); // Y is the next with 5
        Assert.AreEqual("Z", priorityQueue.Dequeue()); // Z has the lowest priority
    }

    [TestMethod]
    // Scenario: Dequeue from empty queue
    // Expected Result: Exception thrown
    public void TestPriorityQueue_EmptyDequeue()
    {
        var priorityQueue = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
    }
}