import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";

@Injectable()
export default class AuthorService
{
    constructor(private httpClient: HttpClient) {
    }

    getAllAuthors()
    {
        return this.httpClient.get(`${environment.apiURL}Authors`);
    }
}