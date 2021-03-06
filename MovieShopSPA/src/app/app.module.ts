import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './account/login/login.component';
import { RegisterComponent } from './account/register/register.component';
import { ProfileComponent } from './user/profile/profile.component';
import { FavoritesComponent } from './user/favorites/favorites.component';
import { PurchasesComponent } from './user/purchases/purchases.component';
import { EditprofileComponent } from './user/editprofile/editprofile.component';
import { TopratedComponent } from './movies/toprated/toprated.component';
import { CreateMovieComponent } from './admin/create-movie/create-movie.component';
import { CreateCastComponent } from './admin/create-cast/create-cast.component';
import { MovieDetailsComponent } from './movies/movie-details/movie-details.component';
import { HeaderComponent } from './core/layout/header/header.component';
import { MovieCardComponent } from './shared/components/movie-card/movie-card.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    LoginComponent,
    RegisterComponent,
    ProfileComponent,
    FavoritesComponent,
    PurchasesComponent,
    EditprofileComponent,
    TopratedComponent,
    CreateMovieComponent,
    CreateCastComponent,
    MovieDetailsComponent,
    HeaderComponent,
    MovieCardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
