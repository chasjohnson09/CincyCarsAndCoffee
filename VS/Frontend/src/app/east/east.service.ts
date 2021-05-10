import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { East } from "./east.class";
import {HttpClient} from "@angular/common/http";

@Injectable({
    providedIn: 'root'
})
export class EastService {
    baseurl: string = 'http://localhost:17445/api/Easts'

    constructor (
        private http: HttpClient,

    ) {}

    list(): Observable<East[]>{
        return this.http.get(this.baseurl) as Observable<East[]>
    }
    get(id:number): Observable<East> {
        return this.http.get(`${this.baseurl}/${id}`) as Observable<East>
    }
}