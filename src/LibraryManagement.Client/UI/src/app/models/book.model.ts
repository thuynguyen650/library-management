import Author from "./author.model";

export default class Book {
    title: string = '';
    bookCategory: string = '';
    authors: Author[] = [];
}