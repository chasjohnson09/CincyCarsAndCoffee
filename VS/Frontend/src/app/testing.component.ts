import { Component, OnInit } from '@angular/core';
import { MaterialModule } from './MISC/materialsmod';

@Component({
  selector: 'testing',
  templateUrl: './testing.component.html',
  styleUrls: ['./testing.component.css']
})
export class TestingComponent implements OnInit {

  public googmaps = "https://www.google.com/maps/embed/v1/place?key=AIzaSyBzeDSTtYZMhn1A0TNus7nVBVYz0nLkAvo&q=";
  public address = "Big Sky Resort, Big Sky, MT"

  constructor(
    private matsvc: MaterialModule,
    
  ) { }

  ngOnInit(): void {
  }

}
