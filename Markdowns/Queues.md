# Queues

When we think about queues what do we think about? Lines, playlists, waitlists for class etc.. Queues are in almost everything we do, in some form or another. Ponder the following question: What are some of the ways that you've used a queue without even realizing it?

![Line of people](/IMGS/People-in-line.jpg)

Queues have several functions in C#. In this tutorial we are aiming to explore those and figure out just how we can use queues to our advantage.

# I. Creating a Queue

To start out with a Queue in C# you're going to need to create it first! duh... That should look something like this:

```csharp
void createQueue() {
    Queue newQueue = new Queue<string>();
}
```

You can also insert a collection into a queue upon initialization, that would look something like:

```csharp
void createQueueFromList(List<string> newList) {
    //CAUTION: Make sure that the collections contain
    // the same data type or you'll be in trouble

    Queue newQueue = new Queue<string>(newList);
}

```

# II. Adding and Removing from the Queue

Queues are a FIFO (First In First Out) collection. Which means Adding and Removing from the queue is going to be really funky. But don't worry I'm here to help! When you add something to a playlist in Spotify or Apple Music, where does it go? That's right the bottom! In our case it's the back of the list. We'll do this using the Enqueue built in method

```csharp
void addToQueue(Queue<string> q, string song) {
    q.Enqueue(song);
    Console.WriteLine("Song: " + song + " has been added");
}
```

When we remove something from the queue we'll always remove the first item in the queue. It's like the first person in a line at a restaurant placing their order and leaving the line. To do that we'll use the Dequeue method.

```csharp

void removeFromQueue(Queue<string> q) {
    var currentSong = q.Dequeue();
    Console.WriteLine("Now Playing: " + currentSong);
}
```

Does this make sense? If it doesn't go back and review and feel free to use outside sources for help!

# II. Checking the Size and Emptying the Queue

Every once in a while we're going to want to see how big our Queue is. Whether this is to check how much it's taking in memory or just for GUI purposes entirely. To do this we'll use the Size method.

```csharp

int checkSize(Queue<string> q) {
    int size = q.Count();
    return size;
}
```

And sometimes we need a fresh start. If we really want to empty out our queue we'll use the Empty method. Here's an example.

```csharp

void emptyQueue(Queue<string> q) {
    q.Clear();
}
```
# III Efficiency
| Operation | Efficiency |
| :---:        |    :----:   |
| .Enqueue() | O(1) |
| .Dequeue() | O(1) |
| .Count() | O(1) |
| .Clear() | O(1) |



# IV. Try it yourself!

Now here's the real test. From what you've learned implement the following function, you may do this anyway that you can, but please make it as efficient as possible:

```csharp
void addToIndex( Queue<string> q,string songTitle, int slot) {
    //TODO: Problem 1
}
```

If any of this doesn't make sense go back and review. Please feel free to use outside sources as well!
