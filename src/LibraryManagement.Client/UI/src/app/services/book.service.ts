import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable()
export default class BookService
{
    constructor(private httpClient: HttpClient)
    {
    }

    getAllBookCopies() {
        return this.httpClient.get(environment.apiURL);
    }
}