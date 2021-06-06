import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { TestBed } from '@angular/core/testing';
import { cardDto } from '../model/cardDto';

@Injectable({
  providedIn: 'root'
})
export class CardService {
  apiUrl = 'https://localhost:44377/'
  cardUrlId = 'Cartas/CardById/';
  cardUrlListName = "Cartas/CardsByName/"
  cardUrlRandomCards = "Cartas/CardsRand/"
  listCard: cardDto[];
  listCardByName: cardDto[];
  gameId: number;
  cont: number;
  public arrayAllCardSize = 0;

        var1: Number = 0.1;
        var2: Number = 0.2;
        var3: Number = 0.3;
        var4: Number = 0.4;
        var5: Number = 0.5;
        var6: Number = 0.6;
        var7: Number = 0.7;
        var8: Number = 0.8;
        rd: number;
  listMasRecientesTop3: cardDto[];
  listMasRecientes4_8: cardDto[];
  listGangasTop3: cardDto[];
  listGangas4_8: cardDto[];
  testArry: cardDto[];
  constructor(private http: HttpClient) { }

  obtenerListadoCard(idCard: number) {
    this.http.get(this.apiUrl + this.cardUrlId + idCard).toPromise()
      .then(data => {
        this.listCard = data as cardDto[];

      });
  }

  ObtenerListadoCardNombre(nameCard: String, idGame: number) {
    this.http.get(this.apiUrl + this.cardUrlRandomCards + idGame).toPromise()
      .then(data => {

        this.listGangasTop3 = [
          {CartaId: data[0].cartaId, CartaName: data[0].cartaName, Img: data[0].img, JuegoFId: data[0].juegoFId},
          {CartaId: data[1].cartaId, CartaName: data[1].cartaName, Img: data[1].img, JuegoFId: data[1].juegoFId},
          {CartaId: data[2].cartaId, CartaName: data[2].cartaName, Img: data[2].img, JuegoFId: data[2].juegoFId} 
        ]

        this.listGangas4_8 = [
          {CartaId: data[3].cartaId, CartaName: data[3].cartaName, Img: data[3].img, JuegoFId: data[3].juegoFId},
          {CartaId: data[4].cartaId, CartaName: data[4].cartaName, Img: data[4].img, JuegoFId: data[4].juegoFId},
          {CartaId: data[5].cartaId, CartaName: data[5].cartaName, Img: data[5].img, JuegoFId: data[5].juegoFId},
          {CartaId: data[6].cartaId, CartaName: data[6].cartaName, Img: data[6].img, JuegoFId: data[6].juegoFId},
          {CartaId: data[7].cartaId, CartaName: data[7].cartaName, Img: data[7].img, JuegoFId: data[7].juegoFId}  
        
        ]

      });

      this.http.get(this.apiUrl + this.cardUrlListName + nameCard + "/" + idGame).toPromise()
      .then(data => {

        this.listCardByName = data as cardDto[];
        this.arrayAllCardSize = this.listCardByName.length
        this.cont = 0;
        //console.log(this.arrayAllCardSize)
        //console.log( data[22].cartaId)
        this.listMasRecientesTop3 = [
          {CartaId: data[this.arrayAllCardSize-1].cartaId, CartaName: data[this.arrayAllCardSize-1].cartaName, Img: data[this.arrayAllCardSize-1].img, JuegoFId: data[this.arrayAllCardSize-1].juegoFId},
          {CartaId: data[this.arrayAllCardSize-2].cartaId, CartaName: data[this.arrayAllCardSize-2].cartaName, Img: data[this.arrayAllCardSize-2].img, JuegoFId: data[this.arrayAllCardSize-2].juegoFId},
          {CartaId: data[this.arrayAllCardSize-3].cartaId, CartaName: data[this.arrayAllCardSize-3].cartaName, Img: data[this.arrayAllCardSize-3].img, JuegoFId: data[this.arrayAllCardSize-3].juegoFId} 
        ]

        this.listMasRecientes4_8 = [
          {CartaId: data[this.arrayAllCardSize-4].cartaId, CartaName: data[this.arrayAllCardSize-4].cartaName, Img: data[this.arrayAllCardSize-4].img, JuegoFId: data[this.arrayAllCardSize-4].juegoFId},
          {CartaId: data[this.arrayAllCardSize-5].cartaId, CartaName: data[this.arrayAllCardSize-5].cartaName, Img: data[this.arrayAllCardSize-5].img, JuegoFId: data[this.arrayAllCardSize-5].juegoFId},
          {CartaId: data[this.arrayAllCardSize-6].cartaId, CartaName: data[this.arrayAllCardSize-6].cartaName, Img: data[this.arrayAllCardSize-6].img, JuegoFId: data[this.arrayAllCardSize-6].juegoFId},
          {CartaId: data[this.arrayAllCardSize-7].cartaId, CartaName: data[this.arrayAllCardSize-7].cartaName, Img: data[this.arrayAllCardSize-7].img, JuegoFId: data[this.arrayAllCardSize-7].juegoFId},
          {CartaId: data[this.arrayAllCardSize-8].cartaId, CartaName: data[this.arrayAllCardSize-8].cartaName, Img: data[this.arrayAllCardSize-8].img, JuegoFId: data[this.arrayAllCardSize-8].juegoFId}  
        
        ]

      });
  }

}
