import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { MovieCard } from 'src/app/shared/models/movieCard';
import { Movie } from 'src/app/shared/models/movieDetails';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  // should have all the methods that deals with Movies, getById, getTopRevenue, GetTopRated
  // HttpClient to make AJAX request
  // XMLHttpRequest => 
  // private readonly, inject
  constructor(private http: HttpClient) { }

  getTopRevenueMovies(): Observable<MovieCard[]> {
    // https://localhost:44301/api/Movies/toprated
    // model based on JSON data
    // Observables are Lazy, only when u subscribe to an observable u will get the data...
    // Youtube => channels
    // Xbox => videos
    // notification when Xbox posts a new video
    // subscribe to it
    // newspaper,
    // HttpClient in Angular => Observables
    // localhost:4200(browser) => AJAX call to https://localhost:44301/api/Movies/toprated
    // yahoo.com => google.com

    return this.http.get(`${environment.apiUrl}` + 'movies/toprated').pipe(
      map(resp => resp as MovieCard[])
    )
    // movies.where(m=>m.budget > 10000).select(m=> new MovieCard {id = m.id, title => m.title}).ToList()
  }

  getMovieDetails(id: number): Observable<Movie> {
    return this.http.get(`${environment.apiUrl}` + 'movies/' + id)
      .pipe(map(resp => resp as Movie));
  }
}
