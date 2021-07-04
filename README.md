# Books.API

## Seed data database for testing:
# Also found in file structure obj/books.json

`[
	{
		"id": "B01",
		"author": "Kutner, Joe",
		"title": "Deploying with JRuby",
		"genre": "Computer",
		"price": "33.00",
		"publish_date": "2012-08-15",
		"description": "Deploying with JRuby is the missing link between enjoying JRuby and using it in the real world to build high-performance, scalable applications."
	},
	{
		"id": "B02",
		"author": "Ralls, Kim",
		"title": "Midnight Rain",
		"genre": "Fantasy",
		"price": "5.95",
		"publish_date": "2000-12-16",
		"description": "A former architect battles corporate zombies, an evil sorceress, and her own childhood to become queen of the world."
	},
	{
		"id": "B03",
		"author": "Corets, Eva",
		"title": "Maeve Ascendant",
		"genre": "Fantasy",
		"price": "5.95",
		"publish_date": "2000-11-17",
		"description": "After the collapse of a nanotechnology society in England, the young survivors lay the foundation for a new society."
	},
	{
		"id": "B04",
		"author": "Corets, Eva",
		"title": "Oberon's Legacy",
		"genre": "Fantasy",
		"price": "5.95",
		"publish_date": "2001-03-10",
		"description": "In post-apocalypse England, the mysterious agent known only as Oberon helps to create a new life for the inhabitants of London. Sequel to Maeve Ascendant."
	},
	{
		"id": "B05",
		"author": "Tolkien, JRR",
		"title": "The Hobbit",
		"genre": "Fantasy",
		"price": "11.95",
		"publish_date": "1985-09-10",
		"description": "If you care for journeys there and back, out of the comfortable Western world, over the edge of the Wild, and home again, and can take an interest in a humble hero blessed with a little wisdom and a little courage and considerable good luck, here is a record of such a journey and such a traveler."
	},
	{
		"id": "B06",
		"author": "Randall, Cynthia",
		"title": "Lover Birds",
		"genre": "Romance",
		"price": "4.95",
		"publish_date": "2000-09-02",
		"description": "When Carla meets Paul at an ornithology conference, tempers fly as feathers get ruffled."
	},
	{
		"id": "B07",
		"author": "Thurman, Paula",
		"title": "Splish Splash",
		"genre": "Romance",
		"price": "4.95",
		"publish_date": "2000-11-02",
		"description": "A deep sea diver finds true love twenty thousand leagues beneath the sea."
	},
	{
		"id": "B08",
		"author": "Knorr, Stefan",
		"title": "Creepy Crawlies",
		"genre": "Horror",
		"price": "4.95",
		"publish_date": "2000-12-06",
		"description": "An anthology of horror stories about roaches, centipedes, scorpions  and other insects."
	},
	{
		"id": "B09",
		"author": "Kress, Peter",
		"title": "Paradox Lost",
		"genre": "Science Fiction",
		"price": "6.95",
		"publish_date": "2000-11-02",
		"description": "After an inadvertant trip through a Heisenberg Uncertainty Device, James Salway discovers the problems of being quantum."
	},
	{
		"id": "B10",
		"author": "O'Brien, Tim",
		"title": "Microsoft .NET: The Programming Bible",
		"genre": "Computer",
		"price": "36.95",
		"publish_date": "2000-12-09",
		"description": "Microsoft's .NET initiative is explored in detail in this deep programmer's reference."
	},
	{
		"id": "B11",
		"author": "Sydik, Jeremy J",
		"title": "Design Accessible Web Sites",
		"genre": "Computer",
		"price": "34.95",
		"publish_date": "2007-12-01",
		"description": "Accessibility has a reputation of being dull, dry, and unfriendly toward graphic design. But there is a better way: well-styled semantic markup that lets you provide the best possible results for all of your users. This book will help you provide images, video, Flash and PDF in an accessible way that looks great to your sighted users, but is still accessible to all users."
	},
	{
		"id": "B12",
		"author": "Russell, Alex",
		"title": "Mastering Dojo",
		"genre": "Computer",
		"price": "38.95",
		"publish_date": "2008-06-01",
		"description": "The last couple of years have seen big changes in server-side web programming. Now it’s the client’s turn; Dojo is the toolkit to make it happen and Mastering Dojo shows you how."
	},
	{
		"id": "B13",
		"author": "Copeland, David Bryant",
		"title": "Build Awesome Command-Line Applications in Ruby",
		"genre": "Computer",
		"price": "20.00",
		"publish_date": "2012-03-01",
		"description": "Speak directly to your system. With its simple commands, flags, and parameters, a well-formed command-line application is the quickest way to automate a backup, a build, or a deployment and simplify your life."
	}
]
`

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
