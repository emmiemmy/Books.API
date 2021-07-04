# Books.API

# Seed data database for testing:
# found in file structure obj/books.json



priceRequirements Books API:
----------------------- 
The API should be written in NET Core > 2.2. 
The API doesn't have to be able to add or update the books.
The API should always return a collection of books in json format. 
By default it should return all books without any specific sorting. 
If a specific field is searched it should return the result sorted on that field. 
It should be possible to search on any field.
Field "published_date" should be a datetime. 
Field "price" should be a double. 
Rest of the fields could be plain strings. 

Use cases: 
---------- 
Whatever field I ask for, it should return the result sorted by that field. 
I should be able to ask for an author, a title, a genre or a description. It should perform the search "case insensitive" and with partial strings. So if I ask for "/api/books/author/kim" it should return only the book by "Ralls, Kim". 
I should be able to ask for a price range or a specific price. 
I should be able to ask for published_date or part of it, that means all books, books from a certain year, books from a certain year-month or books from a certain year-month-day. 

Use case examples:
https://host:port/api/books returns all unsorted (B1-B13)
https://host:port/api/books/id returns all sorted by id (B1-B13)
https://host:port/api/books/id/b returns all with id containing 'b' sorted by id (B1-B13)
https://host:port/api/books/id/1 returns all with id containing '1' sorted by id (B1, B10-13)

https://host:port/api/books/author returns all sorted by author (B1-B13)
https://host:port/api/books/author/joe returns all with author containing 'joe' sorted by author (B1)
https://host:port/api/books/author/kut returns all with author containing 'kut' sorted by author (B1)

https://host:port/api/books/title returns all sorted by title (B1-B13)
https://host:port/api/books/title/deploy returns all with title containing 'deploy' sorted by title (B1)
https://host:port/api/books/title/jruby returns all with title containing 'jruby' sorted by title (B1)

https://host:port/api/books/genre returns all sorted by genre (B1-B13)
https://host:port/api/books/genre/com returns all with genre containing 'com' sorted by genre (B1, B10-13)
https://host:port/api/books/genre/ter returns all with genre containing 'ter' sorted by genre (B1, B10-13)

https://host:port/api/books/description returns all sorted by description (B1-B13)
https://host:port/api/books/description/deploy returns all with description containing 'deploy' sorted by description (B1, B13)
https://host:port/api/books/description/applications returns all with description containing 'applications' sorted by description (B1)
