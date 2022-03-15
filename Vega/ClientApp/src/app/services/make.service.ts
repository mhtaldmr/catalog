import { HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpModule } from '@angular/http';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/map';
import { map } from 'rxjs/operators';
import 'rxjs/Rx';
import { Observable, throwError } from 'rxjs';
import { catchError, retry } from 'rxjs/operators';
import { Config } from 'protractor';


@Injectable({
  providedIn: 'root'
})

export class MakeService {

  constructor(private http: HttpClient) { }

  getMakes() {
    //return this.http.get('/api/makes')
    //  .map(res => res);

    return this.http.get<Config>('/api/makes');
  }



}
