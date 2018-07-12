import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { Configuration } from '../../app.constants';

export class ApiService {
    
    private actionUrl: string;

    constructor(private http: HttpClient, private _configuration: Configuration) {
        this.actionUrl = _configuration.ServerWithApiUrl;
    }

    public getAll<T>(): Observable<T[]> {
        return this.http.get<T[]>(this.actionUrl);
    }

    public getById<T>(id: number): Observable<T> {
        return this.http.get<T>(this.actionUrl+id);
    }

    public post<T>(model: T): Observable<T> {
        const toAdd = JSON.stringify({ ItemName: model});

        return this.http.post<T>(this.actionUrl, toAdd);
    }

    public put<T>(itemToUpdate: any): Observable<T> {
        return this.http.put<T>(this.actionUrl, itemToUpdate);
    }

    public delete<T>(id: number): Observable<T> {
        return this.http.delete<T>(this.actionUrl + id);
    }

}