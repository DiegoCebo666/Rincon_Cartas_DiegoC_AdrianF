import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validator } from '@angular/forms';
import { ToastrModule, ToastrService } from 'ngx-toastr';
import { CardVendedorService } from 'src/app/service/card-vendedor.service';
import { ActivatedRoute } from '@angular/router'
import { CardService } from 'src/app/service/card.service';
import { AppComponent } from 'src/app/app.component';
import { PedidosService } from 'src/app/service/pedidos.service';
import { cartaCarrito2 } from 'src/app/model/cartaCarrito';
import { UserServiceService } from 'src/app/service/user-service.service';

@Component({
  selector: 'app-card-detail',
  templateUrl: './card-detail.component.html',
  styleUrls: ['./card-detail.component.css'],
})
export class CardDetailComponent implements OnInit {
  idCard = 0;
  idGame = 0;
  nameCard = "";
  mediaPrecio = 0;
  loged: boolean = this.appCompo.loged;
  constructor(public cardVendedorService: CardVendedorService,
              public cardService: CardService, 
              private router: ActivatedRoute,
              public appCompo: AppComponent,
              public pedidosService: PedidosService,
              public userService: UserServiceService) { }

  ngOnInit(): void {
    this.idCard=this.router.snapshot.params.id;
    //console.log(this.idCard);
    this.cardService.obtenerListadoCard(this.idCard);
    this.cardVendedorService.obtenerListado(this.idCard);
    //this.cardVendedorService.obtenerMedia();
    this.userService.obtenerAllUsers();
    //console.log(this.loged)
    
  }
  cardCarritoAdd: cartaCarrito2;
  addAlCarrito(idCartVendedor: number){
    const cant = (<HTMLInputElement>document.getElementById(idCartVendedor.toString())).value;
    this.cardCarritoAdd = {
      "carritoFId": this.userService.idUserLoged,
      "cartaVendedorFId": idCartVendedor,
      "fCantidad": parseInt(cant)
    }
    this.pedidosService.addCartaCarrito(this.cardCarritoAdd).subscribe();
  }

}
