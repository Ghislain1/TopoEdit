import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';


import { DiagramModel } from '../api/backend.result';

import { catchError, map, tap } from 'rxjs/operators';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})


export class GojsService {
  private dynamicportsUrl = 'api/dynamicports';  // URL to web api


  constructor(private httpClient: HttpClient) {
  }

  /** GET heroes from the server */
  getDynamicPorts(): Observable<DiagramModel[]> {
    return this.httpClient.get<DiagramModel[]>(this.dynamicportsUrl)
      .pipe(
        tap(_ => this.log('fetched dynamicports')),
        catchError(this.handleError<DiagramModel[]>('getHeroes', []))
      );
  }


  private log(message: string) {
    console.log(`GojsService: ${message}`);
  }
  /**
  * Handle Http operation that failed.
  * Let the app continue.
  * @param operation - name of the operation that failed
  * @param result - optional value to return as the observable result
  **/
  private handleError<T>(operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}
