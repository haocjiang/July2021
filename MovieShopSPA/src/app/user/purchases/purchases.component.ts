import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { UserService } from 'src/app/core/services/user.service';
import { MovieCard } from 'src/app/shared/models/movieCard';


@Component({
  selector: 'app-purchases',
  templateUrl: './purchases.component.html',
  styleUrls: ['./purchases.component.css']
})
export class PurchasesComponent implements OnInit {

  purchases!: MovieCard[];
  id!: number;
  constructor(private userService:UserService, private router:ActivatedRoute) { }

  ngOnInit(): void {
    this.router.paramMap.subscribe(
      r=>{
        this.id = +r.get('id')!;
        this.userService.getUserPurchases(this.id).subscribe(
          p =>{
            this.purchases =p;
            console.table(this.purchases); 
          });
  });
} 
  
}
