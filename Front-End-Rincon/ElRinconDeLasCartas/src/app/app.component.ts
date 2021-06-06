import { Component } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router'
import { Location } from '@angular/common';
import { collapseTextChangeRangesAcrossMultipleVersions } from 'typescript';
import { UserServiceService } from './service/user-service.service';
import { userDto } from './model/userDto';
import { userDto2 } from './model/userDto2';
import { Observable } from 'rxjs';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'ElRinconDeLasCartas';
  userActive = 0;
  idJuego = 0;
  number = 0;
  nameCard = "";
  bollean = true;
  loged: boolean = false;
  userName: String;
  userPass: String;

  constructor(private router: ActivatedRoute,
    private router2: Router,
    private location: Location,
    public userService: UserServiceService
    ) { }

  getUser(val){
    this.userName = val;
  }

  getPass(val){
    this.userPass = val;
  }
  
  login(){
    this.userService.login(this.userName, this.userPass)
    this.loged = this.userService.isLogin
    
  }

  desconectarse(){
    this.loged = false  
  }

  irAlCarrito(){
    this.router2.navigate(['Carrito/' + this.userService.idUserLoged])
  }

  getAndChangeIdJuego(event: any) {
    this.idJuego = event.target.value;
  }

  changeUrl(cardName: String) {
    if (cardName != "") {
      //this.router2.navigate(['CardList/' + cardName + '/' + this.idJuego]);
      //this.router2.navigate(['CardList/' + cardName + '/' + this.idJuego]);
      let currentUrl = this.router2.url;
      this.bollean = false

      //Sin esto al buscar cartas por nombre de manera seguida no listaria
      this.router2.navigateByUrl('/', {skipLocationChange: true}).then(() => {
        this.router2.navigate(['CardList/' + cardName + '/' + this.idJuego]);
        console.log(currentUrl);
    });
    }
  }

  reloadComponent() {
    let currentUrl = this.router2.url;
    this.router2.navigateByUrl('/', {skipLocationChange: true}).then(() => {
        this.router2.navigate([currentUrl]);
        console.log(currentUrl);
    });
  }
   
  testUser: userDto2 = {
    "userName": "UserTest2",
    "email": "UserTest2",
    "password": "UserTest2",
    "seller": true
  }

  addUser(){
    this.userService.addUser(this.testUser).subscribe(userA =>
      console.log(userA)  
    );
  }
  

  ngOnInit(): void {
    
  }

}

