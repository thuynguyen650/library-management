import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable()
export default class BookService
{
    constructor(private httpClient: HttpClient)
    {
    }

    getAllBookCopies() {
        return this.httpClient.get("https://localhost:7141/api/books");
    }
}