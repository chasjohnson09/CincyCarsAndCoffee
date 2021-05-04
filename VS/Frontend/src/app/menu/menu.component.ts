import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  menus: any[] = [
    {display: 'Home', route: '/home'},
    {display: 'East', route: '/users/list'},
    {display: 'West', route: '/vendors/list'},
    {display: 'North', route: '/products/list'},
    {display: 'South', route: '/requests/list'}
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
