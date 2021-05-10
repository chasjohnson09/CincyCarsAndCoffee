import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { West } from "./west.class";
import {HttpClient} from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})
export class WestService {
    baseurl: string = 'http://localhost:17445/api/Wests'

    constructor (
        private http: HttpClient,

    ) {}

    list(): Observable<West[]>{
        return this.http.get(this.baseurl) as Observable<West[]>
    }
    get(id:number): Observable<West> {
        return this.http.get(`${this.baseurl}/${id}`) as Observable<West>
    }
}