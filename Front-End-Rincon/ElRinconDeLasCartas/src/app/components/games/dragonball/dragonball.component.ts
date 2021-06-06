import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import { CardService } from 'src/app/service/card.service';


@Component({
  selector: 'app-dragonball',
  templateUrl: './dragonball.component.html',
  styleUrls: ['./dragonball.component.css']
})
export class DragonballComponent implements OnInit {

  constructor(public cardService: CardService,
    private router: ActivatedRoute) { }

  images = [944, 1011, 984].map((n) => `https://picsum.photos/id/${n}/1500/400`);

  ngOnInit(): void {
    this.cardService.ObtenerListadoCardNombre(" ", 4);
  }

}
