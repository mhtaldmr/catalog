import { HttpClientModule } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import 'rxjs/add/operator/map';
import 'rxjs/Rx';
import { Config } from 'protractor';


@Injectable({
  providedIn: 'root'
})

export class VehicleService {

  constructor(private http: HttpClient) { }

  getMakes() {
    //return this.http.get('/api/makes')
    //  .map(res => res);

    return this.http.get<Config>('/api/makes');
  }

  getFeatures() {

    return this.http.get<Config>('/api/features');
  }



}
