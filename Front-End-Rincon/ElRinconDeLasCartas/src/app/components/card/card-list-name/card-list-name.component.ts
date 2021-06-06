import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import { CardService } from 'src/app/service/card.service';

@Component({
  selector: 'app-card-list-name',
  templateUrl: './card-list-name.component.html',
  styleUrls: ['./card-list-name.component.css']
})
export class CardListNameComponent implements OnInit {
  idGame = 0;
  nameCard = "";

  constructor(public cardService: CardService,
    private router: ActivatedRoute) { }

  ngOnInit(): void {
    this.idGame = this.router.snapshot.params.idGame;
    this.nameCard = this.router.snapshot.params.name;
    this.cardService.ObtenerListadoCardNombre(this.nameCard, this.idGame);
  }

}
