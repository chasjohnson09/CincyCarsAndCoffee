import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { South } from '../south.class';
import { SouthService } from '../south.service';

@Component({
  selector: 'app-south-detail',
  templateUrl: './south-detail.component.html',
  styleUrls: ['./south-detail.component.css']
})
export class SouthDetailComponent implements OnInit {
  
  south: South = null;
  id: number = 0;

  constructor(
    private sthsvc: SouthService,
    private route: ActivatedRoute,
    private router: Router
  ) { }

  ngOnInit(): void {
    this.id = this.route.snapshot.params.id;
    this.sthsvc.get(+this.id).subscribe(
      res => {
        console.log("South Event:", res);
        this.south = res;
      },
      err => {
        console.error(err);
      }
    );
  }

}
