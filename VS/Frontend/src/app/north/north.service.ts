import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { North } from "./north.class";
import { HttpClient } from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})
export class NorthService {
    baseurl: string = 'http://localhost:17445/api/Norths'

    constructor(
        private http: HttpClient,

    ) { }

    list(): Observable<North[]> {
        return this.http.get(this.baseurl) as Observable<North[]>
    }
    get(id: number): Observable<North> {
        return this.http.get(`${this.baseurl}/${id}`) as Observable<North>
    }
}