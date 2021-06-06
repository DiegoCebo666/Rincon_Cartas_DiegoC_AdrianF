import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

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

import { MainpageComponent } from './components/mainPage/mainpage/mainpage.component';
import { CardListNameComponent } from './components/card/card-list-name/card-list-name.component';
import { DragonballComponent } from './components/games/dragonball/dragonball.component';
import { UserCarritoComponent } from './components/user/user-carrito/user-carrito.component';

const misRutas: Routes = [
  { path: '' , component: MainpageComponent},
  {
    path: 'mainPage', component: MainpageComponent,
    children: [
      { path: 'PokemonMainPage', component: PokemonComponent },
      { path: 'CardDetail/:id/:idJuego', component: CardDetailComponent },
      { path: 'MagicMainPage', component: MagicComponent },
      { path: 'YuGiOhMainPage', component: YugiohComponent },
      { path: 'CardList/:name/:idGame', component: CardListNameComponent },
      { path: 'DragonBallMainPage', component: DragonballComponent },
      
    ]
  },
  { path: 'PokemonMainPage', component: PokemonComponent },
  { path: 'MagicMainPage', component: MagicComponent },
  { path: 'YuGiOhMainPage', component: YugiohComponent },
  { path: 'CardDetail', component: CardDetailComponent },
  { path: 'CardDetail/:id', component: CardDetailComponent },
  { path: 'Registerpage', component: RegisterComponent },
  { path: 'DragonBallMainPage', component: DragonballComponent },
  {
    path: 'CardList/:name/:idGame', component: CardListNameComponent,
    children: [
      { path: 'PokemonMainPage', component: PokemonComponent },
      { path: 'CardList/:name/:idGame', component: CardListNameComponent },
      { path: 'CardList2/:name/:idGame', component: CardListNameComponent },
      { path: 'CardDetail/:id/:idJuego', component: CardDetailComponent },
      { path: 'MagicMainPage', component: MagicComponent },
      { path: 'YuGiOhMainPage', component: YugiohComponent },
    ]
  },
  { path: 'CardList2/:name/:idGame', component: CardListNameComponent },
  { path: 'Carrito/:idUser', component: UserCarritoComponent }
]

@NgModule({
  imports: [RouterModule.forRoot(misRutas, { enableTracing: true }),
  ],
  exports: [RouterModule]
})

export class AppRoutingModule { }