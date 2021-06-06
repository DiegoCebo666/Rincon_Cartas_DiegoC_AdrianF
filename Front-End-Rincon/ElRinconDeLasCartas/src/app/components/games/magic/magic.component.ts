import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router'
import { CardService } from 'src/app/service/card.service';

@Component({
  selector: 'app-magic',
  templateUrl: './magic.component.html',
  styleUrls: ['./magic.component.css']
})
export class MagicComponent implements OnInit {

  constructor(public cardService: CardService,
    private router: ActivatedRoute) { }

  images = [944, 1011, 984].map((n) => `https://picsum.photos/id/${n}/1500/400`);

  ngOnInit(): void {
    this.cardService.ObtenerListadoCardNombre(" ", 3);
  }

}
