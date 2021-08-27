import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { Login } from 'src/app/shared/models/login';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpClient) { }

  login(login: Login): Observable<boolean> {
    // call the API api/account/login
    // POST
    // JWT if its valid
    // save that token in local storage
    return this.http.post(`${environment.apiUrl}` + 'account/login', login).pipe(map((response:any) => {
      if (response) {
        // take the response and save that token in local storage
        localStorage.setItem('token', response.token);
        return true;
      }
      return false;
    }));

  }

  logout() {
    // delete the token from local storage
    localStorage.removeItem('token');
  }
}
