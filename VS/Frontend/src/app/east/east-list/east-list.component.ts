import { Component, OnInit } from '@angular/core';
import { East } from '../east.class';
import { EastService } from '../east.service';

@Component({
  selector: 'app-east-list',
  templateUrl: './east-list.component.html',
  styleUrls: ['./east-list.component.css']
})
export class EastListComponent implements OnInit {

  easts: East[] = [];
  searchCriteria: string ='';

  constructor(
    private estsvc: EastService
  ) { }

  ngOnInit(): void {
    this.estsvc.list().subscribe(
      res=>{
        console.log("East Events:", res);
        this.easts = res as East[];
      },
      err => {
        console.error(err);
      }
    );
  }

}
