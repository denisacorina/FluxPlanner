import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  userUrl = "https://localhost:7197/api/Users"
  constructor(private http: HttpClient) { }

  getUsers() {
    return this.http.get(this.userUrl);
  }
}
