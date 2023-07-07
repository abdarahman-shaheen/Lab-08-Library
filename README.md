# Library

## The code consists of two classes, Library and Backpack<T>, which represent a library and a backpack:
- Library Class:
The Library class implements the ILibrary interface and represents a collection of books.
It uses a Dictionary<string, Book> called books to store the books, where the book title is the key and the Book object is the value.
The Count property returns the number of books in the library by returning the count of the books dictionary.
The constructor initializes the books dictionary.
The Add method adds a new book to the library. It takes the title, first name, last name, and number of pages as parameters, creates a Book object with the given information, and adds it to the books dictionary with the title as the key.
The Borrow method takes a book title as a parameter and returns the corresponding Book object if it exists in the books dictionary. It removes the book from the dictionary using the Remove method before returning it. If the book doesn't exist, it returns null.
The GetEnumerator methods allow iterating over the books in the library using a foreach loop by returning an enumerator that yields the Book objects.
The Return method takes a Book object as a parameter and adds it back to the books dictionary with the title as the key.

- Backpack<T> Class:

The Backpack<T> class implements the IBag<T> interface and represents a backpack that can store items of type T.
It uses a List<T> called lists to store the items in the backpack.
The constructor initializes the lists list.
The GetEnumerator methods allow iterating over the items in the backpack using a foreach loop by returning an enumerator that yields the items.
The Pack method takes an item of type T as a parameter and adds it to the lists list.
The Unpack method takes an index as a parameter, retrieves the item at that index from the lists list, removes it using the RemoveAt method, and returns the item.

[](https://github.com/abdarahman-shaheen/Lab-08-Library/blob/master/Library.png)
