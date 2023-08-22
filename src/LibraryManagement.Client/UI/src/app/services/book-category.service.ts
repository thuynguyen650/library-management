import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { environment } from "src/environments/environment";

@Injectable()
export default class BookCategoryService
{
    constructor(private httpClient: HttpClient) {
    }

    getAllBookCategories()
    {
        return this.httpClient.get(`${environment.apiURL}BookCategories`);
    }
}