import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router'
import { AppComponent } from 'src/app/app.component';
import { CarritoService } from 'src/app/service/carrito.service';
import { UserServiceService } from 'src/app/service/user-service.service';
import { getTypeParameterOwner } from 'typescript';
import { RegisterComponent } from '../../session/register/register.component';

@Component({
  selector: 'app-user-carrito',
  templateUrl: './user-carrito.component.html',
  styleUrls: ['./user-carrito.component.css']
})
export class UserCarritoComponent implements OnInit {

  idUser: number;
  constructor(private router: ActivatedRoute,
    private router2: Router,
    public userService: UserServiceService,
    public appComponent: AppComponent,
    public carritoService: CarritoService
  ) { }

  ngOnInit(): void {
    this.idUser = this.router.snapshot.params.idUser
    console.log(this.idUser)
    this.userService.getCarritoProducts(this.idUser)
  }

  deleteCard(idCarrito: number, idCartaVendedor: number) {
    this.idUser = this.router.snapshot.params.idUser
    this.userService.eliminarCarta(idCarrito, idCartaVendedor, this.idUser)
    this.reloadComponent()

  }

  reloadComponent() {
    let currentUrl = this.router2.url;
    this.router2.navigateByUrl('/', {skipLocationChange: true}).then(() => {
        this.router2.navigate([currentUrl]);
        console.log(currentUrl);
    });
  }

  finalizarCompra(){
    this.idUser = this.router.snapshot.params.idUser
    this.carritoService.confirmarPedido(this.idUser).subscribe(userA =>
      console.log()  
    );

    window.alert("Se ha realizado la compra correctamente.")

    this.router2.navigate(['mainPage']);
  }
}
