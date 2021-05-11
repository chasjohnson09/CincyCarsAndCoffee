import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'main-menu',
  templateUrl: './menu.component.html',
  styleUrls: ['./menu.component.css']
})
export class MenuComponent implements OnInit {

  menus: any[] = [
    { display: 'Home', route: '/home' },
    { display: 'East', route: '/east/list' },
    { display: 'West', route: '/west/list' },
    { display: 'North', route: '/north/list' },
    { display: 'South', route: '/south/list' }
  ];
  constructor() { }

  ngOnInit(): void {
  }

}
