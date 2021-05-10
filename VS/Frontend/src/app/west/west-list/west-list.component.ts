import { Component, OnInit } from '@angular/core';
import { West } from '../west.class';
import { WestService } from '../west.service';

@Component({
  selector: 'app-west-list',
  templateUrl: './west-list.component.html',
  styleUrls: ['./west-list.component.css']
})
export class WestListComponent implements OnInit {

  wests: West[] = [];
  searchCriteria: string ='';

  constructor(
    private wstsvc: WestService
  ) { }

  ngOnInit(): void {
    this.wstsvc.list().subscribe(
      res=>{
        console.log("West Events:", res);
        this.wests = res as West[];
      },
      err => {
        console.error(err);
      }
    );
  }

}