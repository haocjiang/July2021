import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { MovieCard } from 'src/app/shared/models/movieCard';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent implements OnInit {

  favorites! : MovieCard[];
  id! : number;
  constructor(private userService:UserService, private router:ActivatedRoute) { }

  ngOnInit(): void {
    this.router.paramMap.subscribe(
      r=>{
        this.id = +r.get('id')!;
        this.userService.getUserFavorites(this.id).subscribe(
          f =>{
            this.favorites = f;
            console.table(this.favorites);
          });
  });
   
  }

}
