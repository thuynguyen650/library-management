import Book from "./book.model";

export class BookCopy
{
    yearPublished?: number;
    publisher: string = "";
    imageUrl: string = "";
    book: Book = new Book;
}