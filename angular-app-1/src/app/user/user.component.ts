import { Component, Output, Input, EventEmitter } from '@angular/core';

import { User } from './user.model';
import { CardComponent } from "../shared/card/card.component";

@Component({
  selector: 'app-user',
  standalone: true,
  templateUrl: './user.component.html',
  styleUrl: './user.component.css',
  imports: [CardComponent]
})
export class UserComponent {
  
  @Input({required:true}) user !: User;
  @Input({required:true}) selected !: boolean;
  @Output() select = new EventEmitter();


  get ImagePath() {
    return "/assets/users/" + this.user.avatar;
  }
  

  onSelectUser() {
    this.select.emit(this.user.id);
  }

}
