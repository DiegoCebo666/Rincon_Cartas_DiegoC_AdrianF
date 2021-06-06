import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { userDto } from '../model/userDto';

import { Observable } from 'rxjs';
import { userDto2 } from '../model/userDto2';
import { cartaCarrito, cartaCarritoAllData } from '../model/cartaCarrito';
import { RegisterComponent } from '../components/session/register/register.component';

@Injectable({
  providedIn: 'root'
})
export class UserServiceService {
  apiUrl = 'https://localhost:44377/';
  listUrl = 'Usuarios/'
  loginUrl = 'Usuarios/login';
  getCartasCarritoUrl = 'Carritos/CartasCarrito/'  
  addUserUrl = "Usuarios";
  eliminarUrl = 'Carritos/deleteCardCarrito/'
  listOfUsers: userDto[];
  userActiveId: number;
  isLogin: boolean = false;
  idUserLoged: number;
  carritoProducts: cartaCarrito[];
  cartasCarritoFullData : cartaCarritoAllData[];
  cartasBeforeFullData : cartaCarritoAllData[];


  constructor(private http: HttpClient,
            
    ) { }

  obtenerAllUsers(){ 
    this.http.get(this.apiUrl + this.listUrl).toPromise()
      .then(data => {
        this.listOfUsers = data as userDto[];
    });
  }

  login(username: String, password: String){
    this.http.get(this.apiUrl + this.loginUrl + "/" + username + "/" + password).toPromise()
      .then(data => {
       this.isLogin = data as boolean;
      });
      

      this.http.get(this.apiUrl + this.listUrl).toPromise()
      .then(data => {
        this.listOfUsers = data as userDto[];

        for(let i = 0; i < this.listOfUsers.length; i++){
          if(username == data[i].userName && password == data[i].password){
            this.idUserLoged = data[i].usuarioId
            console.log(this.idUserLoged)
          }
          //console.log(data[i].userId)
        }

    });

  }

  addUser(userToAdd: userDto2): Observable<userDto2>{
    console.log(userToAdd)
    
    return this.http.post<userDto2>(this.apiUrl + this.addUserUrl, userToAdd);
    
  }

  getCarritoProducts(idUser: number){
    this.http.get(this.apiUrl + this.getCartasCarritoUrl + idUser).toPromise()
    .then(data => {
      this.carritoProducts = data as cartaCarrito[];
      console.log(data)
      for(let i = 0; i < this.carritoProducts.length; i++){
        this.cartasBeforeFullData = [
          {
            cartaCarritoId: 1,
            carritoFId: 1,
            cartaVendedorFId: [{
                CartaFName: "String",
                Precio: 2
            }],
            fCantidad: 1
          }
        ]
      }
  });
  }

  eliminarCarta(idCarrito: number, idCartaVendedor: number, idUser: number){
    this.http.delete(this.apiUrl + this.eliminarUrl + idCarrito + "/" + idCartaVendedor).subscribe()
    this.getCarritoProducts(idUser)
  }

  
}
