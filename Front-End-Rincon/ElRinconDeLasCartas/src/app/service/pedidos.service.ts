import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { cartaCarrito2 } from '../model/cartaCarrito'

@Injectable({
  providedIn: 'root'
})
export class PedidosService {
  apiUrl = 'https://localhost:44377/';
  addCardCarritoUrl = 'Carritos/addCardCarrito'
  url = 'https://localhost:44377/Carritos/addCardCarrito'

  


  constructor(private http: HttpClient) { }

  addCartaCarrito(cardCarritoAdd: cartaCarrito2): Observable<cartaCarrito2>{
    console.log(cardCarritoAdd)
    return this.http.post<cartaCarrito2>( this.url , cardCarritoAdd);
    //return this.http.post<userDto2>(this.apiUrl + this.addUserUrl, userToAdd);
  }
}
