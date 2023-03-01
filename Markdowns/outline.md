# Data Structures Tutorial

## I. Welcome

- Introduction
  - In this tutorial for Data Structures we will be using several data structures to build a playlist that will actually play music.
  - We will be using the following data types:
    - Queues
    - Sets
    - Binary Search Trees
- Contact Information
  - Jake Zalesny
  - Phone: (619)-881-7691
  - Email: zal18001@byui.edu
  - Linkedin: Jake Zalesny

## II. Queue

- Introduction
  - In this project we will be building a makeshift music player.
  - We will be using a queue to handle the playlist aspect of the portion.
  - The user will be able to manipulate which song is playing in the queue which one will no longer be in the queue and which one to add onto the queue.
- Efficiency of common operations
  - Enqueue & Dequeue: O(1)
  - Size & Empty: O(1)
- Example

```csharp
void addToQueue(string songTitle) {
    if(playlist.Contains(songTitle)) {
        Console.WriteLine("Song is already in queue!")
    }

    else {
        playlist.Enqueue(songTitle);
    }
}
```

- Problem to Solve
  // Add a song to a certain spot in the Queue

```csharp
void addToIndex(string songTitle, int slot) {
    //TODO: Problem 1
}
```

## III. Set

- Introduction
  - I would still like to continue working with a music playlist for this example.
  - This time we're going to create a DJ playlist, and as we all know DJs can't have repeats in their playlists. So before the DJ adds a new song we're going to implement a failsaife.
- Efficiency of common operations
  - Add & Remove: O(1)
  - Contains & Count: O(1)
- Example

```csharp
void checkValidity(string songTitle) {

    if(!validList.Contains(songTitle)) {
        addToQueue(songTitle);
    }

    else {
        validList.Add(songTitle);
    }
}
```

- Problem to Solve

```csharp
void removeSong(string songTitle) {
    //TODO remove the song from the playlist
}
```

## IV. Tree

- Introduction
  - This time we're going to insert the amount of plays each song has into a tree. This way we'll be able to track the history of the user.
  - Other option find a song in a list that is the same length as a user need, same or less than. 
- Efficiency of common operations
  - Insert, Remove, Contains: O(log n)
  - traverse_forward, traverse_backward, height: O(n)
  - Size, Empty: O(1)

* Example

```csharp
void addHistory(int historyOfPlays) {
    bst.add(historyOfPlays)
}
```

- Problem to Solve

```csharp
void checkHistory() {
    //TODO Check and see the greatest number on the list.
}
```
