import { Component, OnInit } from '@angular/core';
import { userDto2 } from 'src/app/model/userDto2';
import { ActivatedRoute, Router } from '@angular/router'
import { UserServiceService } from 'src/app/service/user-service.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  userName: String;
  userPass: String;
  userPass2: String;
  userEmail: String;
  constructor(private router: ActivatedRoute,
    private router2: Router,
    public userService: UserServiceService) { }

  ngOnInit(): void {
  }

  getUser(val){
    this.userName = val;
  }
  getEmail(val){
    this.userEmail = val;
  }
  getPass(val){
    this.userPass = val;
  }
  getPass2(val){
    this.userPass2 = val;
  }


  validarDatos(){
    if(this.userPass != this.userPass2 || this.userName == null  || this.userEmail == null  || this.userPass == null  || this.userPass2 == null ){
      window.alert("Estas introduciondo algun dato mal")
    }else{
      const userToAdd: userDto2 = {
        "userName": this.userName,
        "email": this.userEmail,
        "password": this.userPass,
        "seller": true
      }
      this.userService.addUser(userToAdd).subscribe(userA =>
        console.log()
      );
      this.router2.navigate(['mainPage']);
    }

  }
}
