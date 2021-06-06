import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';


import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { PokemonComponent } from './components/games/pokemon/pokemon.component';
import { CardDetailComponent } from './components/card/card-detail/card-detail.component';
import { MagicComponent } from './components/games/magic/magic.component';
import { YugiohComponent } from './components/games/yugioh/yugioh.component';
import { UserProfileComponent } from './components/user/user-profile/user-profile.component';
import { CarritoComponent } from './components/compra/carrito/carrito.component';
import { LoginComponent } from './components/session/login/login.component';
import { RegisterComponent } from './components/session/register/register.component';
import { CompraFinalizadaComponent } from './components/compra/compra-finalizada/compra-finalizada.component';
import { UserCardsComponent } from './components/user/user-cards/user-cards.component';

import { RouterModule, Routes } from '@angular/router';
import { MainpageComponent } from './components/mainPage/mainpage/mainpage.component';

import { AppRoutingModule } from './app-routing.module';
import { CardListNameComponent } from './components/card/card-list-name/card-list-name.component';
import { DragonballComponent } from './components/games/dragonball/dragonball.component';
import { UserCarritoComponent } from './components/user/user-carrito/user-carrito.component';




@NgModule({
  declarations: [
    AppComponent,
    PokemonComponent,
    CardDetailComponent,
    MagicComponent,
    YugiohComponent,
    UserProfileComponent,
    CarritoComponent,
    LoginComponent,
    RegisterComponent,
    CompraFinalizadaComponent,
    UserCardsComponent,
    MainpageComponent,
    CardListNameComponent,
    DragonballComponent,
    UserCarritoComponent
  ],
  imports: [
    BrowserModule,
    NgbModule,
    AppRoutingModule,
    ReactiveFormsModule,
    HttpClientModule,
    BrowserAnimationsModule,
    ToastrModule.forRoot()
  ],
  exports: [RouterModule],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
