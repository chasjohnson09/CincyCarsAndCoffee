import { Component, OnInit } from '@angular/core';
import { North } from '../north.class';
import { NorthService } from '../north.service';

@Component({
  selector: 'app-north-list',
  templateUrl: './north-list.component.html',
  styleUrls: ['./north-list.component.css']
})
export class NorthListComponent implements OnInit {

  norths: North[] = [];
  searchCriteria: string ='';

  constructor(
    private nrthsvc: NorthService
  ) { }

  ngOnInit(): void {
    this.nrthsvc.list().subscribe(
      res=>{
        console.log("Norths:", res);
        this.norths = res as North[];
      },
      err => {
        console.error(err);
      }
    );
  }

}
