import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { cardVendedorConNombreDto, cardVendedorDto } from '../model/cardVendedorDto';
import { userDto3 } from '../model/userDto';

@Injectable({
  providedIn: 'root'
})
export class CardVendedorService {
  apiUrl = 'https://localhost:44377/'
  cardVendedorUrl = 'Cartas/CardsDifferentSellers/';
  mediaPrecio = 0;
  listCardVendedor: cardVendedorDto[];
  public listCardVendedorName = [];
  usersList: userDto3[];


  cardVendedorProv: cardVendedorConNombreDto[];
  cardVendedorProv3 = [];
  //cardVendedorProv2: cardVendedorConNombreDto[];

  constructor(private http: HttpClient) { }

  obtenerListado(idCard: number) {
    this.http.get(this.apiUrl + this.cardVendedorUrl + idCard).toPromise()
      .then(data => {
        this.listCardVendedor = data as cardVendedorDto[];
        for (let i = 0; i < this.listCardVendedor.length; i++) {
          let num1 = data[i].precio
          this.mediaPrecio = this.mediaPrecio + num1;
        }
        this.mediaPrecio = parseInt((this.mediaPrecio / this.listCardVendedor.length).toFixed(2))

        this.http.get("https://localhost:44377/Usuarios").toPromise()
          .then(dataUser => {
            this.usersList = dataUser as userDto3[]
            this.listCardVendedorName = []
            for (let i = 0; i < this.listCardVendedor.length; i++) {
              for (let j = 0; j < this.usersList.length; j++) {
                if (dataUser[j].usuarioId == data[i].vendedorFId) {
                  const cardVendedorProv2 = {} as cardVendedorConNombreDto;
                  cardVendedorProv2.CartaVendedorId = data[i].cartaVendedorId
                  cardVendedorProv2.CartaFId = data[i].cartaFId
                  cardVendedorProv2.CartaFName = data[i].cartaFName
                  cardVendedorProv2.FImg = data[i].fImg
                  cardVendedorProv2.VendedorFId = data[i].vendedorFId
                  cardVendedorProv2.VendedorName = dataUser[j].userName
                  cardVendedorProv2.Idioma = data[i].idioma
                  cardVendedorProv2.Estado = data[i].estado
                  cardVendedorProv2.Cantidad = data[i].cantidad
                  cardVendedorProv2.Precio = data[i].precio
                  //this.cardVendedorProv3.push()
                  this.listCardVendedorName.push(cardVendedorProv2)
                }
              }
            }

          })
      });

  }


  obtenerMedia() {
    for (let i = 0; i < this.listCardVendedor.length; i++) {
      let num1 = this.listCardVendedor[i].Precio;
      //console.log(num1);
      this.mediaPrecio = this.mediaPrecio + num1;
    }
  }

}
