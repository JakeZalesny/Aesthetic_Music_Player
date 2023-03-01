# Sets

When you think about a set of data what do you think about? I think about any form of datum stored somewhere secure with no duplicates! Lucky me, because that's what a set is all about: no duplicates. When I think of Sets I also think of a group of people, not in any particular order, just sort of standing there.

![Group of People](/IMGS/group_of_people.jpg)

Sets have several built in methods and functions in C#, in this tutorial we're hoping to take advantage of that by creating a DJ's playlist.

# I. Creating a Set

The best way to start a set, is by creating one. Duh! That's going to look something like this:

```csharp
void createSet() {
    HashSet<string> set = new HashSet<string>();
}

//You can also initialize a set with a list

void createInitializedSet(List<string> listToSet) {
    HashSet<string> set = new HashSet<string>(listToSet);
}
```

The awesome thing about sets is that order doesn't matter at all. However, the size of the object that will be inserted does! Which leads us to the next part.

# II. Hashing

Inserting a single digit number into a HashSet is not going to be a problem at all! What will be is inserting bigger numbers into a set. To do this we're going to need a Hashing algorithm. We'll also need a HashCode. For this example we're going to use the [n % 10] algorithm. Here's an example:

```csharp
int Hash(int hashCode) {
    int n = hashCode % 10
    return n;
}
```

If we wanted to convert something we'd use the built in C# method to do so. Here's an example of that. (T being a place holder for any data type.)

```csharp
int getHashCode(T object) {
    int hashCode = object.GetHashCode();
    return hashCode;
}
```

# III Efficiency

|  Operation  |                    Efficiency                     |
| :---------: | :-----------------------------------------------: |
|   .Add()    | O(1) (Assuming good Hashing Algorithm is in play) |
|  .Remove()  | O(1) (Assuming good Hashing Algorithm is in play) |
| .Contains() | O(1) (Assuming good Hashing Algorithm is in play) |
|  .Count()   | O(1) (Assuming good Hashing Algorithm is in play) |

# VI. Try it yourself!

Using the .Intersection() and .Union() methods, play around with the following code and see if you can come up with some interesting combinations!

```csharp
void testHashSets() {
    var set1 = new HashSet<int>(){1, 2, 3, 4, 5, 6, 7, 8};
    var set2 = new HashSet<int>(){5, 7, 9, 10, 11, 12, 13, 14};
    // TODO: test it out here:

}
```

If you have an comments or concerns please feel free to contact your professor or myself and I'd be happy to help!
