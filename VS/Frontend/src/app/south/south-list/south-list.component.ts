import { Component, OnInit } from '@angular/core';
import { South } from '../south.class';
import { SouthService } from '../south.service';

@Component({
  selector: 'app-south-list',
  templateUrl: './south-list.component.html',
  styleUrls: ['./south-list.component.css']
})
export class SouthListComponent implements OnInit {

  souths: South[] = [];

  constructor(
    private sthsvc: SouthService
  ) { }

  ngOnInit(): void {
    this.sthsvc.list().subscribe(
      res => {
        console.log("South Events:", res);
        this.souths = res as South[];
      },
      err => {
        console.error(err);
      }
    );
  }

}
