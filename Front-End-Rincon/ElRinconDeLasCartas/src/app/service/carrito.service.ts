import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class CarritoService {
  apiUrl = 'https://localhost:44377/';
  confirmarPedidoUrl = "Pedidos/"


  constructor(private http: HttpClient) { }

  confirmarPedido(idCarrito: number): Observable<number>{
    console.log(idCarrito)
    return this.http.post<number>("https://localhost:44377/Pedidos/" + idCarrito, null)
  }
}
