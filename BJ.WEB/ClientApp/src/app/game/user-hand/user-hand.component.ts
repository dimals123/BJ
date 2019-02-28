import { User } from './../../shared/models/table.model';
import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-user-hand',
  templateUrl: './user-hand.component.html',
  styleUrls: ['./user-hand.component.scss']
})
export class UserHandComponent implements OnInit {

  constructor() { }

  @Input() user: User = new User();

  ngOnInit() {
  }

}
