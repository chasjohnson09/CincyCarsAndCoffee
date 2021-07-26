import { Component, OnInit } from '@angular/core';
import { MaterialModule } from './MISC/materialsmod';

@Component({
  selector: 'testing',
  templateUrl: './testing.component.html',
  styleUrls: ['./testing.component.css']
})
export class TestingComponent implements OnInit {

  constructor(
    private matsvc: MaterialModule
  ) { }

  ngOnInit(): void {
  }

}
