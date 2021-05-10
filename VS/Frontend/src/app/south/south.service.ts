import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import {South} from "./south.class";

@Injectable({
    providedIn: 'root'
})
export class SouthService {
    baseurl: string = 'http://localhost:17445/api/Souths'

    constructor (
        private http: HttpClient,

    ) {}

    list(): Observable<South[]>{
        return this.http.get(this.baseurl) as Observable<South[]>
    }
    get(id:number): Observable<South> {
        return this.http.get(`${this.baseurl}/${id}`) as Observable<South>
    }
}